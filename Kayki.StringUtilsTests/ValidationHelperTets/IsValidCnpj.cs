using Kayki.StringUtils;

namespace Kayki.StringUtilsTests.ValidationHelperTets;
public class IsValidCnpj
{
    [Fact]
    public void IsValidCnpj_ShouldReturnTrue_ForValidCnpj()
    {
        // Arrange
        string cnpj = "00.000.000/0001-91";

        // Act
        bool result = ValidationHelper.IsValidCnpj(cnpj);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IsValidCnpj_ShouldReturnFalse_ForInvalidCnpj()
    {
        // Arrange
        string cnpj = "00.000.000/0001-92";

        // Act
        bool result = ValidationHelper.IsValidCnpj(cnpj);

        // Assert
        Assert.False(result);
    }
}
