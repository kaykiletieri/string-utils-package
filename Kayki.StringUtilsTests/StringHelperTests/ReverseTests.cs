using Kayki.StringUtils;

namespace Kayki.StringUtilsTests.StringHelperTests;
public class ReverseTests
{
    [Fact]
    public void Reverse_WhenInputIsValid_ShouldReturnReversedString()
    {
        // Arrange
        string input = "Hello, World!";
        string expected = "!dlroW ,olleH";

        // Act
        string result = StringHelper.Reverse(input);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Reverse_WhenInputIsEmpty_ShouldReturnEmptyString()
    {
        // Arrange
        string input = string.Empty;

        // Act
        string result = StringHelper.Reverse(input);

        // Assert
        Assert.Equal(string.Empty, result);
    }

    [Fact]
    public void Reverse_WhenInputIsWhitespace_ShouldReturnWhitespace()
    {
        // Arrange
        string input = " ";

        // Act
        string result = StringHelper.Reverse(input);

        // Assert
        Assert.Equal(" ", result);
    }
}
