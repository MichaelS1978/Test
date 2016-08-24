using OnkoSoft.Data.Attributes;

namespace OnkoSoft.Data.Domain.Enumerations
{
    public enum TherapyIntention
    {
        [EnumDisplayText("")]
        Empty,

        [EnumDisplayText("adjuvant")]
        Adjuvant,

        [EnumDisplayText("kurativ")]
        Curative,

        [EnumDisplayText("neoadjuvant")]
        Neoadjuvant,

        [EnumDisplayText("palliativ")]
        Palliative,

        [EnumDisplayText("primär")]
        Primary,
    }
}