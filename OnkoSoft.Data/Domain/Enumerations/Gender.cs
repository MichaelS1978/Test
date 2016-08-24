using OnkoSoft.Data.Attributes;

namespace OnkoSoft.Data.Domain.Enumerations
{
    public enum Gender
    {
        [EnumDisplayText("")]
        Empty,

        [EnumDisplayText("weiblich")]
        Female,

        [EnumDisplayText("männlich")]
        Male
    }
}