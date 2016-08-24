using OnkoSoft.Data.Attributes;

namespace OnkoSoft.Data.Domain.Enumerations
{
    public enum RoundAccuracy
    {
        [EnumDisplayText("0")]
        Zero,

        [EnumDisplayText("1")]
        One,

        [EnumDisplayText("5")]
        Five,

        [EnumDisplayText("10")]
        Ten,

        [EnumDisplayText("50")]
        Fifty,

        [EnumDisplayText("100")]
        Hundred,

        [EnumDisplayText("1000")]
        Thousand,

    }
}