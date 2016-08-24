using OnkoSoft.Data.Attributes;

namespace OnkoSoft.Data.Domain.Enumerations
{
    public enum AppointmentSeriesType
    {
        [EnumDisplayText("Benutzerdefiniert")]
        Custom,

        [EnumDisplayText("Täglich")]
        Daily,

        [EnumDisplayText("Wöchentlich")]
        Weekly,

        [EnumDisplayText("Monatlich")]
        Monthly,

        [EnumDisplayText("Jährlich")]
        Yearly

    }
}