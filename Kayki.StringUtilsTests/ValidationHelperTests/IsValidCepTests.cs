using Kayki.StringUtils;

namespace Kayki.StringUtilsTests.ValidationHelperTets;
public class IsValidCepTests
{
    [Fact]
    public void IsValidCep_ValidCep_ReturnsTrue()
    {
        // Arrange
        string cep = "12345-123";

        // Act
        bool result = ValidationHelper.IsValidCep(cep);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IsValidCep_InvalidCep_ReturnsFalse()
    {
        // Arrange
        string cep = "12345-12";

        // Act
        bool result = ValidationHelper.IsValidCep(cep);

        // Assert
        Assert.False(result);
    }
}
