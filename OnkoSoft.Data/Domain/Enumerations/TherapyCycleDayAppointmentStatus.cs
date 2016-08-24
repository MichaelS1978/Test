using OnkoSoft.Data.Attributes;

namespace OnkoSoft.Data.Domain.Enumerations
{
    //TODO: IntMM - Richtige Stati ergänzen oder entfallen lassen
    public enum TherapyCycleDayAppointmentStatus
    {
        [EnumDisplayText("0")]
        Status_0,

        [EnumDisplayText("1")]
        Status_1,

        [EnumDisplayText("2")]
        Status_2,

        [EnumDisplayText("3")]
        Status_3
    }
}