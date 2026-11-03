using Poster.Application.Helpers.Errors.Common;

namespace Poster.Application.Helpers.Results.Common
{
    public sealed class GenericResult<TValue> : Result
    {
        private readonly TValue _value;

        private GenericResult(TValue value) 
            : base(true, Error.None)
        {
            _value = value;
        }

        private GenericResult(Error error) 
            : base(false, error)
        {
            _value = default;
        }

        public TValue Value => IsSuccess
        ? _value!
        : throw new InvalidOperationException("Cannot access value of a failed result");

        public static GenericResult<TValue> Success(TValue value) => new(value);
        public new static GenericResult<TValue> Failure(Error error) => new(error);
        public static implicit operator GenericResult<TValue>(TValue value) => Success(value);
        public static implicit operator GenericResult<TValue>(Error error) => Failure(error);
    }
}

