using Kayki.StringUtils;

namespace Kayki.StringUtilsTests.ValidationHelperTets;
public class IsValidCpf
{
    [Fact]
    public void IsValidCpf_ShouldReturnTrue_ForValidCpf()
    {
        // Arrange
        string cpf = "529.982.247-25";

        // Act
        bool result = ValidationHelper.IsValidCpf(cpf);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IsValidCpf_ShouldReturnFalse_ForInvalidCpf()
    {
        // Arrange
        string cpf = "529.982.247-26";

        // Act
        bool result = ValidationHelper.IsValidCpf(cpf);

        // Assert
        Assert.False(result);
    }
}
