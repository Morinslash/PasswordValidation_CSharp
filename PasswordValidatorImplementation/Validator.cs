using PasswordValidatorImplementation.Policies;

namespace PasswordValidatorImplementation;

public class Validator
{
    private readonly List<IPasswordPolicy> _passwordPolicies;

    public Validator(List<IPasswordPolicy> passwordPolicies)
    {
        if (!passwordPolicies.Any())
        {
            throw new ArgumentException("Policies list cannot be empty");
        }
        _passwordPolicies = passwordPolicies;
    }

    public bool Check(string password) =>
        _passwordPolicies
            .All(p => p.Validate(password));
}