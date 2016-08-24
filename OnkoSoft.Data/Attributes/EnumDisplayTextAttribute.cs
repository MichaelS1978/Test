using System;

namespace OnkoSoft.Data.Attributes
{
    [AttributeUsage(AttributeTargets.Field)]
    public class EnumDisplayTextAttribute : Attribute
    {
        public EnumDisplayTextAttribute(string displayText)
        {
            DisplayText = displayText;
        }

        public EnumDisplayTextAttribute(string displayText, string displayTextLong)
            : this(displayText)
        {
            DisplayTextLong = displayTextLong;
        }

        public string DisplayText { get; private set; }
        public string DisplayTextLong { get; private set; }
    }
}