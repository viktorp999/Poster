using Poster.Domain.Enums.Users;
using Poster.Domain.ValueObjects.Common.Abstractions;

namespace Poster.Domain.ValueObjects.Users
{
    public sealed class UserDetails : BaseValueObject
    {
        public UserDetails() 
        { 
        }

        public UserDetails(string firstName, string lastName, 
            string city, string country, Gender gender, DateOnly dateOfBirth)
        { 
            FirstName = firstName;
            LastName = lastName;
            City = city;
            Country = country;
            Gender = gender.ToString();
            DateOfBirth = dateOfBirth.ToString("dd-MMMM-yyyy");
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Gender { get; set; }
        public string DateOfBirth { get; set; }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return FirstName;
            yield return LastName;
            yield return City;
            yield return Country;
            yield return Gender;
            yield return DateOfBirth;
        }
    }
}
