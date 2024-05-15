using Kayki.StringUtils;

namespace Kayki.StringUtilsTests.StringHelperTests;
public class SafeSubstringTests
{
    [Fact]
    public void SafeSubstring_ShouldReturnSubstring()
    {
        // Arrange
        string input = "Hello World";

        // Act
        string result = StringHelper.SafeSubstring(input, 6, 5);

        // Assert
        Assert.Equal("World", result);
    }

    [Fact]
    public void SafeSubstring_ShouldHandleNegativeStartIndex()
    {
        // Arrange
        string input = "Hello World";

        // Act
        string result = StringHelper.SafeSubstring(input, -5, 5);

        // Assert
        Assert.Equal("Hello", result);
    }

    [Fact]
    public void SafeSubstring_ShouldHandleLengthBeyondString()
    {
        // Arrange
        string input = "Hello World";

        // Act
        string result = StringHelper.SafeSubstring(input, 6, 20);

        // Assert
        Assert.Equal("World", result);
    }

    [Fact]
    public void SafeSubstring_ShouldReturnEmptyForStartIndexBeyondString()
    {
        // Arrange
        string input = "Hello World";

        // Act
        string result = StringHelper.SafeSubstring(input, 20, 5);

        // Assert
        Assert.Equal(string.Empty, result);
    }

    [Fact]
    public void SafeSubstring_ShouldReturnEmptyForNegativeLength()
    {
        // Arrange
        string input = "Hello World";

        // Act
        string result = StringHelper.SafeSubstring(input, 6, -5);

        // Assert
        Assert.Equal(string.Empty, result);
    }
}
