using OnkoSoft.Data.Attributes;

namespace OnkoSoft.Data.Domain.Enumerations
{
    //TODO: IntMM - Richtige Stati ergänzen oder entfallen lassen
    public enum AppointmentStatus
    {
        [EnumDisplayText("10")]
        Status_10,

        [EnumDisplayText("20")]
        Status_20,

        [EnumDisplayText("30")]
        Status_30,

        [EnumDisplayText("40")]
        Status_40,

        [EnumDisplayText("50")]
        Status_50
    }
}