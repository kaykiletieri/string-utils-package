using Kayki.StringUtils;

namespace Kayki.StringUtilsTests.ValidationHelperTests;
public class IsValidVehiclePlateTests
{
    [Theory]
    [InlineData("ABC-1234", true)]
    [InlineData("abc-1234", true)]
    [InlineData("ABC1234", true)]
    [InlineData("A1B-1234", false)]
    [InlineData("ABCD-123", false)]
    public void IsValidVehiclePlate_ShouldValidateCorrectly(string plate, bool expected)
    {
        // Act
        bool result = ValidationHelper.IsValidVehiclePlate(plate);

        // Assert
        Assert.Equal(expected, result);
    }

}
