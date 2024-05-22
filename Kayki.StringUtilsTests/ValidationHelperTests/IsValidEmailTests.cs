using Kayki.StringUtils;

namespace Kayki.StringUtilsTests.ValidationHelperTests;
public class IsValidEmailTests
{
    [Fact]
    public void IsValidEmail_ShouldReturnTrue_ForValidEmail()
    {
        // Arrange
        string email = "test@example.com";

        // Act
        bool result = ValidationHelper.IsValidEmail(email);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IsValidEmail_ShouldReturnFalse_ForInvalidEmail()
    {
        // Arrange
        string email = "invalid-email";

        // Act
        bool result = ValidationHelper.IsValidEmail(email);

        // Assert
        Assert.False(result);
    }
}
