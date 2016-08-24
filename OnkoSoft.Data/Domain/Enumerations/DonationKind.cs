using OnkoSoft.Data.Attributes;

namespace OnkoSoft.Data.Domain.Enumerations
{
    public enum DonationKind
    {
        [EnumDisplayText("")]
        Empty,

        [EnumDisplayText("i.v.", "intravenös")]
        Intravenous,

        [EnumDisplayText("p.o.", "per os")]
        Oral,

        [EnumDisplayText("i.v.Port")]
        IntravenousPort,

        [EnumDisplayText("i.a.hept", "intrahepatal")]
        Intrahepatic,

        [EnumDisplayText("s.c.", "subkutan")]
        Subcutaneous,

        [EnumDisplayText("supp.", "Suppositorium")]
        Suppository,

        [EnumDisplayText("i.m.", "intramuskulär")]
        Intramuscular,

        [EnumDisplayText("i.pleur.", "intrapleural")]
        Intrapleural,

        [EnumDisplayText("i.vesi.", "intraversical")]
        Intravesical,

        [EnumDisplayText("i.thek.", "intrahektal")]
        Intrathecal,

        [EnumDisplayText("l.i.v.")]
        Liv,

        [EnumDisplayText("i.p.", "intraperitoneal")]
        Intraperitoneal
    }
}