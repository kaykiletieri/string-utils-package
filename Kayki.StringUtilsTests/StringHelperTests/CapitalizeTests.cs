using Kayki.StringUtils;

namespace Kayki.StringUtilsTests.StringHelperTests;
public class CapitalizeTests
{
    [Fact]
    public void Capitalize_WhenInputIsEmpty_ReturnsEmptyString()
    {
        // Arrange
        string input = string.Empty;

        // Act
        string result = StringHelper.Capitalize(input);

        // Assert
        Assert.Equal(string.Empty, result);
    }

    [Fact]
    public void Capitalize_WhenInputIsLowerCase_ReturnsCapitalizedString()
    {
        // Arrange
        string input = "hello world";

        // Act
        string result = StringHelper.Capitalize(input);

        // Assert
        Assert.Equal("Hello World", result);
    }

    [Fact]
    public void Capitalize_WhenInputIsUpperCase_ReturnsCapitalizedString()
    {
        // Arrange
        string input = "HELLO WORLD";

        // Act
        string result = StringHelper.Capitalize(input);

        // Assert
        Assert.Equal("Hello World", result);
    }

    [Fact]
    public void Capitalize_WhenInputIsMixedCase_ReturnsCapitalizedString()
    {
        // Arrange
        string input = "hELLO wORLD";

        // Act
        string result = StringHelper.Capitalize(input);

        // Assert
        Assert.Equal("Hello World", result);
    }
}
