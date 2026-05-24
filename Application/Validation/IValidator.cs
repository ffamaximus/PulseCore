namespace PulseCore.Application.Validation;

public interface IValidator<in T>
{
    ValidationResult Validate(T instance);
}
