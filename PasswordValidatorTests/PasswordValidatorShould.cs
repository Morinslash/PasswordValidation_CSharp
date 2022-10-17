using PasswordValidatorImplementation;

namespace PasswordValidatorTests;

public class PasswordValidatorShould
{
    [Fact]
    public void ReturnsTrueIfPasswordsMeetsAllBasicRequirements()
    {
        var passwordPolicies = new List<IPasswordPolicy>()
        {
            new LengthPolicy(8),
            new UpperCasePolicy(),
            new LowerCasePolicy(),
            new NumberCasePolicy(),
            new UnderscorePolicy()
        };
        var validPassword = "Valid_Password_1";
        var validator = new Validator(passwordPolicies);
        Assert.True(validator.Check(validPassword));
    }
}