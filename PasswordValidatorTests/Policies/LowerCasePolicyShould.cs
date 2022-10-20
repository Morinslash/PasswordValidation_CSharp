using PasswordValidatorImplementation.Policies;

namespace PasswordValidatorTests.Policies;

public class LowerCasePolicyShould
{
    [Fact]
    public void Return_True_If_Password_Has_At_Least_One_Lower_Case()
    {
        var lowerCasePolicy = new LowerCasePolicy();
        Assert.True(lowerCasePolicy.Validate("a"));
    }

    [Fact]
    public void Return_False_If_Password_Does_Not_Have_Lover_Case()
    {
        var lowerCasePolicy = new LowerCasePolicy();
        Assert.False(lowerCasePolicy.Validate("A"));
    }
}