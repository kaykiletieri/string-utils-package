using Kayki.StringUtils;
using System.Globalization;

namespace Kayki.StringUtilsTests.ValidationHelperTets;
public class IsValidDateTests
{
    [Fact]
    public void IsValidDate_ShouldReturnTrue_ForValidDate_DefaultFormat()
    {
        // Arrange
        string date = "14/05/2024";

        // Act
        bool result = ValidationHelper.IsValidDate(date);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IsValidDate_ShouldReturnFalse_ForInvalidDate_DefaultFormat()
    {
        // Arrange
        string date = "31/02/2024";

        // Act
        bool result = ValidationHelper.IsValidDate(date);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void IsValidDate_ShouldReturnTrue_ForValidDate_SpecifiedFormat()
    {
        // Arrange
        string date = "2024-05-14";
        string format = "yyyy-MM-dd";

        // Act
        bool result = ValidationHelper.IsValidDate(date, format);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IsValidDate_ShouldReturnFalse_ForInvalidDate_SpecifiedFormat()
    {
        // Arrange
        string date = "2024-02-31";
        string format = "yyyy-MM-dd";

        // Act
        bool result = ValidationHelper.IsValidDate(date, format);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void IsValidDate_ShouldReturnFalse_ForInvalidDate_SpecifiedFormatAndCulture()
    {
        // Arrange
        string date = "31 Fev 2024";
        string format = "dd MMM yyyy";
        CultureInfo cultureInfo = new("pt-BR");

        // Act
        bool result = ValidationHelper.IsValidDate(date, format, cultureInfo);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void IsValidDate_ShouldReturnFalse_ForEmptyString()
    {
        // Arrange
        string date = "";

        // Act
        bool result = ValidationHelper.IsValidDate(date);

        // Assert
        Assert.False(result);
    }
}
