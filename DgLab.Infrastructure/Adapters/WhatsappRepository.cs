using DgLab.Domain.Ports;
using DgLab.Infrastructure.Context;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DgLab.Infrastructure.Adapters
{
    public class WhatsappRepository:IWhatsappRepository
    {
        private readonly IConfiguration _config;
        private readonly HttpClient _client;

        public WhatsappRepository(IConfiguration config, HttpClient client) 
        {
            _config = config ?? throw new ArgumentNullException(nameof(config));
            _client = client ?? throw new ArgumentNullException(nameof(client));
        }

        public async Task EnviarMensaje(object data) {
            string path = $"/{_config.GetSection("Whatsapp").GetSection("Version").Value}/{_config.GetSection("Whatsapp").GetSection("PhoneNumberId").Value}/messages";
            string token = _config.GetSection("Whatsapp").GetSection("Token").Value;         
           
            _client.DefaultRequestHeaders.Add("Bearer", token);
            var content = new StringContent(System.Text.Json.JsonSerializer.Serialize(data), System.Text.Encoding.UTF8, "text/json");
            await _client.PostAsync(path, content);

        }


    }
}
