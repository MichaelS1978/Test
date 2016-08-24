using OnkoSoft.Data.Attributes;

namespace OnkoSoft.Data.Domain
{
    public enum UserRole
    {
        [EnumDisplayText("Administrator")]
        Administrator,

        [EnumDisplayText("Arzt")]
        Doctor,

        [EnumDisplayText("Assistent(-in)")]
        Assistant
    }
}