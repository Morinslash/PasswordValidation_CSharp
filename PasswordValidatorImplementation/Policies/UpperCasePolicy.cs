namespace PasswordValidatorImplementation.Policies;

public class UpperCasePolicy : IPasswordPolicy
{
    public bool Validate(string password)
        => password.Any(char.IsUpper);
}