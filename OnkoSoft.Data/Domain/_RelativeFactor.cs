using OnkoSoft.Data.Attributes;

namespace OnkoSoft.Data.Domain
{
    //TODO: IntMM - evtl. obsolet
    public enum RelativeFactor
    {
        [EnumDisplayText("")]
        Empty,

        [EnumDisplayText("Körperoberfläche")]
        BodySurface,

        [EnumDisplayText("Gewicht")]
        Weight,

        [EnumDisplayText("Absolut")]
        Absolute
    }
}