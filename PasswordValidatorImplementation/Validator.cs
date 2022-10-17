namespace PasswordValidatorImplementation;

public class Validator
{
    private const int MinimalPasswordLength = 8;

    public bool Check(string password)
    {
        return password.Length > MinimalPasswordLength 
            || password.Any(char.IsUpper)
            || password.Any(char.IsLower)
            || password.Any(char.IsDigit)
            || password.Any(c => c.Equals('_'));
    }
}