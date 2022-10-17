namespace PasswordValidatorImplementation;

public class UnderscorePolicy : IPasswordPolicy
{
    public bool Validate(string password) => password.Any(c => c.Equals('_'));
}