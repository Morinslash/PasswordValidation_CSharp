using PasswordValidatorImplementation.Policies;

namespace PasswordValidatorTests.Policies;

public class UnderscorePolicyShould
{
    [Fact]
    public void Return_True_If_Password_Contains_At_Least_One_Underscore()
    {
        var underscorePolicy = new UnderscorePolicy();
        Assert.True(underscorePolicy.Validate("_"));
    }

    [Fact]
    public void Return_False_If_Password_Does_Not_Contain_At_Least_One_Underscore()
    {
        var underscorePolicy = new UnderscorePolicy();
        Assert.False(underscorePolicy.Validate("A"));
    }
}