using Poster.Domain.ValueObjects.Common.Abstractions;

namespace Poster.Domain.ValueObjects.Users
{
    public sealed class Address : BaseValueObject
    {
        public Address() 
        { 
        }

        public Address(string city, string country)
        { 
            City = city;
            Country = country;
        }

        public string City { get; set; }
        public string Country { get; set; }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return City;
            yield return Country;
        }
    }
}
