using OnkoSoft.Data.Attributes;

namespace OnkoSoft.Data.Domain.Enumerations
{
    public enum HealthInsuranceKind
    {
        [EnumDisplayText("")]
        Empty,

        [EnumDisplayText("Kasse")]
        Public,

        [EnumDisplayText("Privat")]
        Private,

        [EnumDisplayText("Kasse mit privater Zusatzversicherung")]
        PublicWithAdditionalInsurance,

    }
}