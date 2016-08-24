using OnkoSoft.Data.Attributes;

namespace OnkoSoft.Data.Domain.Enumerations
{
    public enum CalculationMethod
    {
        [EnumDisplayText("")]
        Empty,

        [EnumDisplayText("Körperoberfläche")]
        BodySurface,

        [EnumDisplayText("Gewicht")]
        Weight,

        [EnumDisplayText("Absolut")]
        Absolute,

        [EnumDisplayText("AUC")]
        Auc,

        [EnumDisplayText("Stufe")]
        Step
    }
}