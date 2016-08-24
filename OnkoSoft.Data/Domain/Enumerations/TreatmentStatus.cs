using OnkoSoft.Data.Attributes;

namespace OnkoSoft.Data.Domain.Enumerations
{

    //TODO: IntMM - Richtige Stati ergänzen oder entfallen lassen
    public enum TreatmentStatus
    {
        [EnumDisplayText("0 - offen")]
        Status_0,

        [EnumDisplayText("1 - vorbereitet")]
        Status_1,

        [EnumDisplayText("15 - Freigabe")]
        Status_15,

        [EnumDisplayText("19 - ausgelassen")]
        Status_19,

        [EnumDisplayText("2 - behandelt")]
        Status_2
    }
}