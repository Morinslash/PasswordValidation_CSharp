using PasswordValidatorImplementation;

namespace PasswordValidatorTests;

public class PasswordValidatorShould
{
    [Fact]
    public void ReturnsTrueIfPasswordsMeetsAllBasicRequirements()
    {
        var validPassword = "Valid_Password_1";
        var validator = new Validator();
        Assert.True(validator.Check(validPassword));
    }
}