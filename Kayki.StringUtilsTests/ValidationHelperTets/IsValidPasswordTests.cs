using Kayki.StringUtils;

namespace Kayki.StringUtilsTests.ValidationHelperTets;
public class IsValidPasswordTests
{
    [Theory]
    [InlineData("Password1!", true)] // Valid password with all requirements
    [InlineData("password1!", false)] // Missing uppercase
    [InlineData("PASSWORD1!", false)] // Missing lowercase
    [InlineData("Password!", false)] // Missing digit
    [InlineData("Password1", false)] // Missing special character
    [InlineData("Pass1!", false)] // Too short
    [InlineData("Password1!", false, 12)] // Valid but below custom minLength
    [InlineData("Password1", true, 8, true, true, true, false)] // Valid without special character requirement
    [InlineData("password", true, 8, false, true, false, false)] // Valid with only lowercase requirement
    [InlineData("", false)] // Empty password
    public void IsValidPassword_TestCases(string password, bool expectedResult, int minLength = 8, bool requireUppercase = true, bool requireLowercase = true, bool requireDigit = true, bool requireSpecialCharacter = true)
    {
        bool result = ValidationHelper.IsValidPassword(password, minLength, requireUppercase, requireLowercase, requireDigit, requireSpecialCharacter);
        Assert.Equal(expectedResult, result);
    }
}

