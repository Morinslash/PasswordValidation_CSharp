using Moq;
using PasswordValidatorImplementation;
using PasswordValidatorImplementation.Policies;

namespace PasswordValidatorTests;

public class PasswordValidatorShould
{
    private readonly List<IPasswordPolicy> _passwordPolicies;
    private readonly string _validPassword = "Any_Password";

    public PasswordValidatorShould()
    {
        _passwordPolicies = new List<IPasswordPolicy>();
    }
    [Fact]
    public void Throw_Exception_If_List_Of_Policies_Is_Empty()
    {
        Assert.Throws<ArgumentException>(
            () => new Validator(new List<IPasswordPolicy>()));
    }
    [Fact]
    public void Returns_True_If_One_Policy_Returns_True()
    {
        var mockPolicy = new Mock<IPasswordPolicy>();
        mockPolicy
            .Setup(policy => policy.Validate(_validPassword))
            .Returns(true);
        _passwordPolicies.Add(mockPolicy.Object);
        var validator = new Validator(_passwordPolicies);
        Assert.True(validator.Check(_validPassword));
    }

    [Fact]
    public void Return_True_If_All_Policies_Are_Passed()
    {
        var mockPolicy1 = new Mock<IPasswordPolicy>();
        mockPolicy1
            .Setup(policy => policy.Validate(_validPassword))
            .Returns(true);
        _passwordPolicies.Add(mockPolicy1.Object);
        
        var mockPolicy2 = new Mock<IPasswordPolicy>();
        mockPolicy2
            .Setup(policy => policy.Validate(_validPassword))
            .Returns(true);
        _passwordPolicies.Add(mockPolicy2.Object);
        
        var validator = new Validator(_passwordPolicies);
        Assert.True(validator.Check(_validPassword));
    }

    [Fact]
    public void Return_False_If_One_Policy_Does_Not_Pass()
    {
        var mockPolicy = new Mock<IPasswordPolicy>();
        mockPolicy
            .Setup(policy => policy.Validate(_validPassword))
            .Returns(false);
        _passwordPolicies.Add(mockPolicy.Object);
        var validator = new Validator(_passwordPolicies);
        Assert.False(validator.Check(_validPassword));
    }

    [Fact]
    public void Return_False_When_All_Policies_Do_Not_Pass()
    {
        var mockPolicy1 = new Mock<IPasswordPolicy>();
        mockPolicy1
            .Setup(policy => policy.Validate(_validPassword))
            .Returns(false);
        _passwordPolicies.Add(mockPolicy1.Object);
        
        var mockPolicy2 = new Mock<IPasswordPolicy>();
        mockPolicy2
            .Setup(policy => policy.Validate(_validPassword))
            .Returns(false);
        _passwordPolicies.Add(mockPolicy2.Object);
        
        var validator = new Validator(_passwordPolicies);
        Assert.False(validator.Check(_validPassword));
    }

    [Fact]
    public void Return_False_When_At_Least_One_Policy_Does_Not_Pass()
    {
        var mockPolicy1 = new Mock<IPasswordPolicy>();
        mockPolicy1
            .Setup(policy => policy.Validate(_validPassword))
            .Returns(true);
        _passwordPolicies.Add(mockPolicy1.Object);
        
        var mockPolicy2 = new Mock<IPasswordPolicy>();
        mockPolicy2
            .Setup(policy => policy.Validate(_validPassword))
            .Returns(false);
        _passwordPolicies.Add(mockPolicy2.Object);
        
        var validator = new Validator(_passwordPolicies);
        Assert.False(validator.Check(_validPassword));
    }
}