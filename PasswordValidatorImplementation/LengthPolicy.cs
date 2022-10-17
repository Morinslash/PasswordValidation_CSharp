namespace PasswordValidatorImplementation;

public class LengthPolicy : IPasswordPolicy
{
    private readonly int _minimalLength;

    public LengthPolicy(int minimalLength)  
    {
        _minimalLength = minimalLength;
    }

    public bool Validate(string password) => password.Length > _minimalLength;
}