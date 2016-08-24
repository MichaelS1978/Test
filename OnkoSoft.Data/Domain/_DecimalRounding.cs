using OnkoSoft.Data.Attributes;

namespace OnkoSoft.Data.Domain
{
    public enum DecimalRounding
    {
        [EnumDisplayText("")]
        Empty,

        [EnumDisplayText("1")]
        UnitPosition,

        [EnumDisplayText("2")]
        DecadePosition,

        [EnumDisplayText("3")]
        HundredPosition
    }
}