using Moq;
using PasswordValidatorImplementation;
using PasswordValidatorImplementation.Policies;

namespace PasswordValidatorTests;

public class PasswordValidatorShould
{
    private List<IPasswordPolicy> _passwordPolicies;
    private readonly string _validPassword = "Any_Password";

    public PasswordValidatorShould()
    {
        _passwordPolicies = new List<IPasswordPolicy>();
    }
    [Fact]
    public void ThrowExceptionIfListOfPoliciesIsEmpty()
    {
        Assert.Throws<ArgumentException>(
            () => new Validator(new List<IPasswordPolicy>()));
    }
    [Fact]
    public void ReturnsTrueIfOnePolicyReturnsTrue()
    {
        var mockPolicy = new Mock<IPasswordPolicy>();
        mockPolicy
            .Setup(policy => policy.Validate(_validPassword))
            .Returns(true);
        _passwordPolicies.Add(mockPolicy.Object);
        var validator = new Validator(_passwordPolicies);
        Assert.True(validator.Check(_validPassword));
    }
}