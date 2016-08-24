using OnkoSoft.Data.Attributes;

namespace OnkoSoft.Data.Domain.Enumerations
{
    public enum Solvent
    {
        [EnumDisplayText("")]
        Empty,

        [EnumDisplayText("NaCl 0,9%")]
        SodiumChloride,

        [EnumDisplayText("Glucose 5%")]
        Glucose,

        [EnumDisplayText("Ringerlösung")]
        Dilution,

        [EnumDisplayText("unverdünnt")]
        Undilated,
    }
}