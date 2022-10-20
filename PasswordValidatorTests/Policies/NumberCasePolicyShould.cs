using PasswordValidatorImplementation.Policies;

namespace PasswordValidatorTests.Policies;

public class NumberCasePolicyShould
{
    [Fact]
    public void Return_True_If_Password_Contains_At_Least_One_Digit()
    {
        var numberCasePolicy = new NumberCasePolicy();
        Assert.True(numberCasePolicy.Validate("1"));
    }
    [Fact]
    public void Return_False_If_Password_Does_Not_Contain_At_Least_One_Digit()
    {
        var numberCasePolicy = new NumberCasePolicy();
        Assert.False(numberCasePolicy.Validate("a"));
    }
}