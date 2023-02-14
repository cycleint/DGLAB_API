using System.Reflection;
using DgLab.Api.Filters;
using Elastic.Apm.NetCoreAll;
using Elastic.Apm.SerilogEnricher;
using DgLab.Infrastructure.Context;
using DgLab.Infrastructure.Extensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Prometheus;
using Serilog;
using Serilog.Sinks.Elasticsearch;

var builder = WebApplication.CreateBuilder(args);
var config = builder.Configuration;

builder.Services.AddControllers(opts =>
{
    opts.Filters.Add(typeof(AppExceptionFilterAttribute));
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddMediatR(Assembly.Load("DgLab.Application"), typeof(Program).Assembly);
builder.Services.AddAutoMapper(Assembly.Load("DgLab.Application"));

builder.Services.AddDbContext<PersistenceContext>(opt =>
{
    opt.UseSqlServer(config.GetConnectionString("database"), sqlopts =>
    {
        sqlopts.MigrationsHistoryTable("_MigrationHistory", config.GetValue<string>("SchemaName"));
    });
});

builder.Services.AddHealthChecks().AddSqlServer(config["ConnectionStrings:database"]);

builder.Services.AddLogging(loggingBuilder => loggingBuilder.AddSerilog(dispose: true));

builder.Services.AddPersistence(config).AddDomainServices().AddRabbitSupport(config);

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new() { Title = "DgLab Api", Version = "v1" });
});

Log.Logger = new LoggerConfiguration().Enrich.FromLogContext()    
    .WriteTo.Console()
   
    .CreateLogger();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "DgLab Api"));
}

app.UseRouting().UseHttpMetrics().UseEndpoints(endpoints =>
{  
    endpoints.MapMetrics();
    endpoints.MapHealthChecks("/health");
});

app.UseHttpLogging();
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
