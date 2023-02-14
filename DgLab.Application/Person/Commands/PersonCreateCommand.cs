using System.ComponentModel.DataAnnotations;
using MediatR;

namespace DgLab.Application.Person.Commands
{
    public record PersonCreateCommand(
        [Required] string FirstName,
        [Required] string LastName,
        [Required] string Email,
        [Required] DateTime? DateOfBirth 
    ) : IRequest;

} 
