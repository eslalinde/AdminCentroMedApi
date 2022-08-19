using System.Globalization;
using System.Linq;
using System.Text;

namespace AdminCentroMed;

public static class StringExtensions
{
    public static string NormalizeString(this string value)
    {
        var text = value.Normalize(NormalizationForm.FormD).Replace(" ", string.Empty);
        var chars = text.Where(c => CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark).ToArray();
        return new string(chars).Normalize(NormalizationForm.FormC).ToUpper();
    }
}