namespace PasswordValidatorImplementation;

public class NumberCasePolicy : IPasswordPolicy
{
    public bool Validate(string password) => password.Any(char.IsDigit);
}