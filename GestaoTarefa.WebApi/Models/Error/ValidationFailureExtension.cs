using FluentValidation.Results;

namespace GestaoTarefa.WebApi.Models.Error
{
    public static class ValidationFailureExtension 
    {
        public static IList<CustomValidationError> ToCustomValidationFailure(this IEnumerable<ValidationFailure> failures)
        {
            return failures.Select(f => new CustomValidationError(f.PropertyName, f.ErrorMessage)).ToList();
        }
    }
}
