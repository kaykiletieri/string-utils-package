using Kayki.StringUtils;

namespace Kayki.StringUtilsTests.StringHelperTests;
public class RemoveAccentsTests
{
    [Fact]
    public void RemoveAccents_WhenInputIsValid_ShouldReturnStringWithoutAccents()
    {
        // Arrange
        string input = "áéíóú";
        string expected = "aeiou";

        // Act
        string result = StringHelper.RemoveAccents(input);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void RemoveAccents_WhenInputIsEmpty_ShouldReturnEmptyString()
    {
        // Arrange
        string input = string.Empty;

        // Act
        string result = StringHelper.RemoveAccents(input);

        // Assert
        Assert.Equal(string.Empty, result);
    }

    [Fact]
    public void RemoveAccents_WhenInputIsWhitespace_ShouldReturnWhitespace()
    {
        // Arrange
        string input = " ";

        // Act
        string result = StringHelper.RemoveAccents(input);

        // Assert
        Assert.Equal(" ", result);
    }

    [Fact]
    public void RemoveAccents_WhenInputHasNoAccents_ShouldReturnSameString()
    {
        // Arrange
        string input = "aeiou";
        string expected = "aeiou";

        // Act
        string result = StringHelper.RemoveAccents(input);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void RemoveAccents_WhenInputHasMixedAccents_ShouldReturnStringWithoutAccents()
    {
        // Arrange
        string input = "áeíóu";
        string expected = "aeiou";

        // Act
        string result = StringHelper.RemoveAccents(input);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void RemoveAccents_WhenInputHasSpecialCharacters_ShouldReturnStringWithoutAccents()
    {
        // Arrange
        string input = "áéíóu!@#$%^&*()_+";
        string expected = "aeiou!@#$%^&*()_+";

        // Act
        string result = StringHelper.RemoveAccents(input);

        // Assert
        Assert.Equal(expected, result);
    }
}
