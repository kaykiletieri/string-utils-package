using Kayki.StringUtils;

namespace Kayki.StringUtilsTests.StringHelperTests;
public class IsPalindromeTests
{
    [Fact]
    public void IsPalindrome_EmptyInput_ReturnsFalse()
    {
        // Arrange
        string input = string.Empty;

        // Act
        bool result = StringHelper.IsPalindrome(input);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void IsPalindrome_ValidInput_ReturnsTrue()
    {
        // Arrange
        string input = "Ovo";

        // Act
        bool result = StringHelper.IsPalindrome(input);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IsPalindrome_ValidInput_ReturnsFalse()
    {
        // Arrange
        string input = "Hello";

        // Act
        bool result = StringHelper.IsPalindrome(input);

        // Assert
        Assert.False(result);
    }
}
