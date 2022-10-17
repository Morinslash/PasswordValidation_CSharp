using PasswordValidatorImplementation.Policies;

namespace PasswordValidatorImplementation;

public class Validator
{
    private readonly List<IPasswordPolicy> _passwordPolicies;

    public Validator(List<IPasswordPolicy> passwordPolicies)
    {
        _passwordPolicies = passwordPolicies;
    }

    public bool Check(string password)
    {
        return _passwordPolicies
            .Select(policy => policy.Validate(password))
            .All(c => c);
    }
}