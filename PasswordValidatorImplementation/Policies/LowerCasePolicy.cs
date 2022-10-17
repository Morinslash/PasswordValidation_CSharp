namespace PasswordValidatorImplementation.Policies;

public class LowerCasePolicy : IPasswordPolicy
{
    public bool Validate(string password)
        => password.Any(char.IsLower);
}