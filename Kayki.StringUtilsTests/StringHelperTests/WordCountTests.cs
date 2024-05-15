using Kayki.StringUtils;

namespace Kayki.StringUtilsTests.StringHelperTests;
public class WordCountTests
{
    [Fact]
    public void WordCount_WhenInputIsValid_ShouldReturnWordCount()
    {
        // Arrange
        string input = "Hello, World!";
        int expected = 2;

        // Act
        int result = StringHelper.WordCount(input);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void WordCount_WhenInputIsEmpty_ShouldReturnZero()
    {
        // Arrange
        string input = string.Empty;

        // Act
        int result = StringHelper.WordCount(input);

        // Assert
        Assert.Equal(0, result);
    }

    [Fact]
    public void WordCount_WhenInputIsWhitespace_ShouldReturnZero()
    {
        // Arrange
        string input = " ";

        // Act
        int result = StringHelper.WordCount(input);

        // Assert
        Assert.Equal(0, result);
    }
}
