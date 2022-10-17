namespace PasswordValidatorImplementation;

public interface IPasswordPolicy
{
    bool Validate(string password);
}