using PasswordValidatorImplementation.Policies;

namespace PasswordValidatorTests.Policies;

public class UpperCasePolicyShould
{
    [Fact]
    public void Return_True_If_Password_Contains_Upper_Case()
    {
        var upperCasePolicy = new UpperCasePolicy();
        Assert.True(upperCasePolicy.Validate("A"));
    }

    [Fact]
    public void Return_False_If_Password_Does_Not_Contain_Upper_Case()
    {
        var upperCasePolicy = new UpperCasePolicy();
        Assert.False(upperCasePolicy.Validate("a"));
    }
}