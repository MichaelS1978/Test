using OnkoSoft.Data.Attributes;

namespace OnkoSoft.Data.Domain.Enumerations
{
    public enum TherapyStatus
    {
        [EnumDisplayText("angelegt")]
        Created,

        [EnumDisplayText("geplant")]
        Planned,

        [EnumDisplayText("freigegeben")]
        Approved,

        [EnumDisplayText("begonnen")]
        Started,

        [EnumDisplayText("abgebrochen")]
        Aborted,

        [EnumDisplayText("beendet")]
        Completed,
    }
}