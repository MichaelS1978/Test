using OnkoSoft.Data.Attributes;

namespace OnkoSoft.Data.Domain.Enumerations
{
    public enum Intention
    {
        [EnumDisplayText("adjuvant")]
        Adjuvant,

        [EnumDisplayText("diagnostisch")]
        Diagnostic,

        [EnumDisplayText("kurativ")]
        Curative,

        [EnumDisplayText("neoadjuvant")]
        Neoadjuvant,

        [EnumDisplayText("palliativ")]
        Palliative,

        [EnumDisplayText("symptomatisch")]
        Symptomatic

    }
}