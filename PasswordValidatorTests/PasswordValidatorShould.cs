using PasswordValidatorImplementation;

namespace PasswordValidatorTests;

public class PasswordValidatorShould
{
    [Fact]
    public void ReturnTrueIfPasswordHasMoreThan8Characters()
    {
        var validPassword = "123456789";
        var validator = new Validator();
        Assert.True(validator.Check(validPassword));
    }
}