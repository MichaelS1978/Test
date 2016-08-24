using OnkoSoft.Data.Attributes;

namespace OnkoSoft.Data.Domain.Enumerations
{
    public enum SolventUnit
    {
        [EnumDisplayText("")]
        Empty,

        [EnumDisplayText("ml", "Milliliter")]
        Milliliter,

        [EnumDisplayText("dl", "Deziliter")]
        Deciliter,

        [EnumDisplayText("l", "Liter")]
        Liter
    }
}