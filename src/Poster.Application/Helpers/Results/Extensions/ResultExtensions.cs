using Poster.Application.Helpers.Errors.Common;
using Poster.Application.Helpers.Results.Common;

namespace Poster.Application.Helpers.Results.Extensions
{
    public static class ResultExtensions
    {
        public static GenericResult<TOut> Map<TIn, TOut>(
            this GenericResult<TIn> result,
            Func<TIn, TOut> mapper)
        {
            return result.IsSuccess
                ? GenericResult<TOut>.Success(mapper(result.Value))
                : GenericResult<TOut>.Failure(result.Error);
        }

        public static GenericResult<TOut> Bind<TIn, TOut>(
            this GenericResult<TIn> result,
            Func<TIn, GenericResult<TOut>> binder)
        {
            return result.IsSuccess
                ? binder(result.Value)
                : GenericResult<TOut>.Failure(result.Error);
        }

        public static TOut Match<TIn, TOut>(
            this GenericResult<TIn> result,
            Func<TIn, TOut> onSuccess,
            Func<Error, TOut> onFailure)
        {
            return result.IsSuccess
                ? onSuccess(result.Value)
                : onFailure(result.Error);
        }

        public static GenericResult<T> Tap<T>(
            this GenericResult<T> result,
            Action<T> action)
        {
            if (result.IsSuccess)
                action(result.Value);
            return result;
        }

        public static GenericResult<T> ToResult<T>(this Result result, T value)
        {
            return result.IsSuccess
                ? GenericResult<T>.Success(value)
                : GenericResult<T>.Failure(result.Error);
        }
    }
}
