using PasswordValidatorImplementation.Policies;

namespace PasswordValidatorTests.Policies;

public class LengthPolicyShould
{
    [Fact]
    public void Return_True_If_Password_Comply_With_Minimal_Length()
    {
        var minimalLength = 8;
        var lengthPolicy = new LengthPolicy(minimalLength);
        Assert.True(lengthPolicy.Validate("LongPassword"));
    }

    [Fact]
    public void Return_False_If_Password_Is_Too_Short()
    {
        var minimalLength = 8;
        var lengthPolicy = new LengthPolicy(minimalLength);
        Assert.False(lengthPolicy.Validate("ShortOne"));
    }
}