using System;
using System.ComponentModel.DataAnnotations;
using DgLab.Domain.Entities.Base;

namespace DgLab.Domain.Entities
{
    public class Person : EntityBase<Guid>
    {
        const int TOTAL_DAYS = 365;
        const int MINIMAL_AGE = 18;

        [MaxLength(20)]
        public string FirstName { get; set; } = default!;
        public string LastName { get; set; } = default!;
        public string Email { get; set; } = default!;
        public DateTime DateOfBirth { get; set; }

        public Person(string firstName, string lastName, string email, DateTime dateOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            DateOfBirth = dateOfBirth;
        }
        public Person()
        {

        }

        public bool IsUnderAge => (DateTime.Now.Subtract(DateOfBirth).TotalDays / TOTAL_DAYS) < MINIMAL_AGE;
    }
}
