using OnkoSoft.Data.Attributes;

namespace OnkoSoft.Data.Domain.Enumerations
{
    public enum DonationUnit
    {
        [EnumDisplayText("")]
        Empty,

        [EnumDisplayText("µg", "Mikrogramm")]
        Microgram,

        [EnumDisplayText("mg", "Milligramm")]
        Milligram,

        [EnumDisplayText("g", "Gramm")]
        Gram,

        [EnumDisplayText("ml", "Milliliter")]
        Milliliter,

        [EnumDisplayText("Amp.", "Ampulle")]
        Ampule,

        [EnumDisplayText("Tr.", "Tropfen")]
        Drops,

        [EnumDisplayText("Pckg.", "Packung")]
        Package,

        [EnumDisplayText("Units")]
        Units,

        [EnumDisplayText("Mio. Units")]
        MillionUnits,

        [EnumDisplayText("IE", "Internationale Einheit")]
        InternationalUnit,

        [EnumDisplayText("Teelöffel")]
        Teaspoon,

        [EnumDisplayText("Esslöffel")]
        Tablespoon,

        [EnumDisplayText("mval", "Millival")]
        Milliequivalent,

        [EnumDisplayText("mval/l", "Millival pro Liter")]
        MilliequivalentPerLiter
    }
}