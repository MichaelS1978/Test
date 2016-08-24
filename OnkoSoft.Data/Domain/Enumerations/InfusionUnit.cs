using OnkoSoft.Data.Attributes;

namespace OnkoSoft.Data.Domain.Enumerations
{
    public enum InfusionDurationUnit
    {
        [EnumDisplayText("")]
        Empty,

        [EnumDisplayText("h")]
        Hour,

        [EnumDisplayText("min")]
        Minute,
    }
}