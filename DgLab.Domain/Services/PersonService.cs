using DgLab.Domain.Entities;
using DgLab.Domain.Exception;
using DgLab.Domain.Ports;

namespace DgLab.Domain.Services
{
    [DomainService]
    public class PersonService
    {
        readonly IGenericRepository<Person> _repository;
        public PersonService(IGenericRepository<Person> repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository), "No repo available");
        }

        public async Task<Person> RegisterPersonAsync(Person person)
        {
            if (!person.IsUnderAge)
            {             
                return await _repository.AddAsync(person);
            }
            throw new UnderAgeException("The person you're trying to register is not of 18 year or older");
        }

    }
}
