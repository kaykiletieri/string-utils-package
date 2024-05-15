using Kayki.StringUtils;

namespace Kayki.StringUtilsTests.ValidationHelperTets;
public class IsValidUrl
{
    [Fact]
    public void IsValidUrl_ShouldReturnTrue_ForValidUrl()
    {
        // Arrange
        string url = "https://example.com";

        // Act
        bool result = ValidationHelper.IsValidUrl(url);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IsValidUrl_ShouldReturnFalse_ForInvalidUrl()
    {
        // Arrange
        string url = "invalid-url";

        // Act
        bool result = ValidationHelper.IsValidUrl(url);

        // Assert
        Assert.False(result);
    }
}
