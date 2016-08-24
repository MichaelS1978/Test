using OnkoSoft.Data.Attributes;

namespace OnkoSoft.Data.Domain.Enumerations
{
    public enum AppointmentReminderPeriod
    {
        [EnumDisplayText("Ohne")]
        None,

        [EnumDisplayText("0 Minuten")]
        Minutes_0,

        [EnumDisplayText("5 Minuten")]
        Minutes_5,

        [EnumDisplayText("10 Minuten")]
        Minutes_10,

        [EnumDisplayText("15 Minuten")]
        Minutes_15,

        [EnumDisplayText("30 Minuten")]
        Minutes_30,

        [EnumDisplayText("1 Stunde")]
        Hours_1,

        [EnumDisplayText("2 Stunden")]
        Hours_2,

        [EnumDisplayText("3 Stunden")]
        Hours_3,

        [EnumDisplayText("4 Stunden")]
        Hours_4,

        [EnumDisplayText("5 Stunden")]
        Hours_5,

        [EnumDisplayText("6 Stunden")]
        Hours_6,

        [EnumDisplayText("7 Stunden")]
        Hours_7,

        [EnumDisplayText("8 Stunden")]
        Hours_8,

        [EnumDisplayText("9 Stunden")]
        Hours_9,

        [EnumDisplayText("10 Stunden")]
        Hours_10,

        [EnumDisplayText("11 Stunden")]
        Hours_11,

        [EnumDisplayText("12 Stunden")]
        Hours_12,

        [EnumDisplayText("18 Stunden")]
        Hours_18,

        [EnumDisplayText("1 Tag")]
        Days_1,

        [EnumDisplayText("2 Tage")]
        Days_2,

        [EnumDisplayText("3 Tage")]
        Days_3,

        [EnumDisplayText("4 Tage")]
        Days_4,

        [EnumDisplayText("1 Woche")]
        Week_1,

        [EnumDisplayText("2 Wochen")]
        Week_2,
    }
}