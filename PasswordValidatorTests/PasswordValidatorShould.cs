using PasswordValidatorImplementation;
using PasswordValidatorImplementation.Policies;

namespace PasswordValidatorTests;

public class PasswordValidatorShould
{
    [Fact]
    public void ThrowExceptionIfListOfPoliciesIsEmpty()
    {
        Assert.Throws<ArgumentException>(
            () => new Validator(new List<IPasswordPolicy>()));
    }
    [Fact]
    public void ReturnsTrueIfPasswordsMeetsAllBasicRequirements()
    {
        var minimalLength = 8;
        var passwordPolicies = new List<IPasswordPolicy>()
        {
            new LengthPolicy(minimalLength),
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