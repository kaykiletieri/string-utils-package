using System.Globalization;
using System.Text.RegularExpressions;

namespace Kayki.StringUtils;
public partial class ValidationHelper
{
    [GeneratedRegex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", RegexOptions.IgnoreCase, "pt-BR")]
    private static partial Regex EmailRegex();

    [GeneratedRegex(@"^(http|https)://[^\s/$.?#].[^\s]*$", RegexOptions.IgnoreCase, "pt-BR")]
    private static partial Regex UrlRegex();

    [GeneratedRegex(@"^\d{5}-\d{3}$")]
    private static partial Regex CepRegex();

    public static bool IsValidEmail(string email)
    {
        if (string.IsNullOrWhiteSpace(email))
            return false;

        try
        {
            Regex emailRegex = EmailRegex();
            return emailRegex.IsMatch(email);
        }
        catch
        {
            return false;
        }
    }

    public static bool IsValidUrl(string url)
    {
        if (string.IsNullOrWhiteSpace(url))
            return false;

        Regex urlRegex = UrlRegex();
        return urlRegex.IsMatch(url);
    }

    public static bool IsValidCpf(string cpf)
    {
        int[] multiplier1 = [10, 9, 8, 7, 6, 5, 4, 3, 2];
        int[] multiplier2 = [11, 10, 9, 8, 7, 6, 5, 4, 3, 2];

        cpf = cpf.Trim().Replace(".", "").Replace("-", "");
        if (cpf.Length != 11)
            return false;

        for (int j = 0; j < 10; j++)
            if (j.ToString().PadLeft(11, char.Parse(j.ToString())) == cpf)
                return false;

        string tempCpf = cpf[..9];
        int sum = 0;

        for (int i = 0; i < 9; i++)
            sum += int.Parse(tempCpf[i].ToString()) * multiplier1[i];

        int remainder = sum % 11;
        if (remainder < 2)
            remainder = 0;
        else
            remainder = 11 - remainder;

        string digit = remainder.ToString();
        tempCpf += digit;
        sum = 0;
        for (int i = 0; i < 10; i++)
            sum += int.Parse(tempCpf[i].ToString()) * multiplier2[i];

        remainder = sum % 11;
        if (remainder < 2)
            remainder = 0;
        else
            remainder = 11 - remainder;

        digit += remainder.ToString();

        return cpf.EndsWith(digit);
    }

    public static bool IsValidCnpj(string cnpj)
    {
        int[] multiplier1 = [5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2];
        int[] multiplier2 = [6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2];

        cnpj = cnpj.Trim().Replace(".", "").Replace("-", "").Replace("/", "");
        if (cnpj.Length != 14)
            return false;

        string tempCnpj = cnpj[..12];
        int sum = 0;

        for (int i = 0; i < 12; i++)
            sum += int.Parse(tempCnpj[i].ToString()) * multiplier1[i];

        int remainder = sum % 11;
        if (remainder < 2)
            remainder = 0;
        else
            remainder = 11 - remainder;

        string digit = remainder.ToString();
        tempCnpj += digit;
        sum = 0;
        for (int i = 0; i < 13; i++)
            sum += int.Parse(tempCnpj[i].ToString()) * multiplier2[i];

        remainder = sum % 11;
        if (remainder < 2)
            remainder = 0;
        else
            remainder = 11 - remainder;

        digit += remainder.ToString();

        return cnpj.EndsWith(digit);
    }

    public static bool IsValidCep(string cep)
    {
        if (string.IsNullOrWhiteSpace(cep))
            return false;

        Regex cepRegex = CepRegex();
        return cepRegex.IsMatch(cep);
    }

    public static bool IsValidDate(string date, string format = "dd/MM/yyyy", CultureInfo? cultureInfo = null)
    {
        if (string.IsNullOrWhiteSpace(date))
            return false;

        cultureInfo ??= CultureInfo.InvariantCulture;
        return DateTime.TryParseExact(date, format, cultureInfo, DateTimeStyles.None, out _);
    }

    public static bool IsValidPassword(string password, int minLength = 8, bool requireUppercase = true, bool requireLowercase = true, bool requireDigit = true, bool requireSpecialCharacter = true)
    {
        if (string.IsNullOrWhiteSpace(password) || password.Length < minLength)
            return false;

        bool hasUppercase = !requireUppercase || password.Any(char.IsUpper);
        bool hasLowercase = !requireLowercase || password.Any(char.IsLower);
        bool hasDigit = !requireDigit || password.Any(char.IsDigit);
        bool hasSpecialChar = !requireSpecialCharacter || password.Any(ch => !char.IsLetterOrDigit(ch));

        return hasUppercase && hasLowercase && hasDigit && hasSpecialChar;
    }
}
