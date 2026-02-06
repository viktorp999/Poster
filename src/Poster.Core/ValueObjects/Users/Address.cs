using Poster.Core.ValueObjects.Common.Abstractions;

namespace Poster.Core.ValueObjects.Users
{
    public sealed class Address : BaseValueObject
    {
        public Address(string city, string country)
        {
            City = city;
            Country = country;
        }

        public string City { get; private set; }
        public string Country { get; private set; }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return City;
            yield return Country;
        }
    }
}
