using OnkoSoft.Data.Attributes;

namespace OnkoSoft.Data.Domain.Enumerations
{
    public enum IntentionPalliativeLine
    {
        [EnumDisplayText("1st Line")]
        First,

        [EnumDisplayText("2nd Line")]
        Second,

        [EnumDisplayText("3rd Line")]
        Third,

        [EnumDisplayText(">= 4th Line")]
        Fourth,

    }
}