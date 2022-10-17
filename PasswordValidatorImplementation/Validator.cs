namespace PasswordValidatorImplementation;

public class Validator
{
    public bool Check(string password)
    {
        return password.Length > 8;
    }
}