namespace PasswordValidatorImplementation.Policies;

public interface IPasswordPolicy
{
    bool Validate(string password);
}