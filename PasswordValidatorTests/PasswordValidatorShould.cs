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

    [Fact]
    public void ReturnTrueIfPasswordContainsAtLeastOneCapitalLetter()
    {
        var validPassword = "A";
        var validator = new Validator();
        Assert.True(validator.Check(validPassword));
    }
    
    [Fact]
    public void ReturnTrueIfPasswordContainsAtLeastOneLowerCaseLetter()
    {
        var validPassword = "a";
        var validator = new Validator();
        Assert.True(validator.Check(validPassword));
    }    
    [Fact]
    public void ReturnTrueIfPasswordContainsAtLeastOneNumber()
    {
        var validPassword = "1";
        var validator = new Validator();
        Assert.True(validator.Check(validPassword));
    }
    
    [Fact]
    public void ReturnTrueIfPasswordContainsAtLeastOneUnderscore()
    {
        var validPassword = "_";
        var validator = new Validator();
        Assert.True(validator.Check(validPassword));
    }
}