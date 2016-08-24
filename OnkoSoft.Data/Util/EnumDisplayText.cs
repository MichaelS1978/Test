using System;
using System.Reflection;
using OnkoSoft.Data.Attributes;

namespace OnkoSoft.Data.Util
{
    public class EnumDisplayText
    {
        public EnumDisplayText(Enum enumValue)
        {
            EnumValue = enumValue;

            Type enumType = enumValue.GetType();
            MemberInfo[] memInfo = enumType.GetMember(enumValue.ToString());
            if (memInfo != null && memInfo.Length > 0)
            {
                Attribute attr = memInfo[0].GetCustomAttribute(typeof(EnumDisplayTextAttribute));
                if (attr != null)
                    DisplayText = ((EnumDisplayTextAttribute)attr).DisplayText;
            }
        }

        public Enum EnumValue { get; private set; }

        public string DisplayText { get; private set; }

        public override string ToString()
        {
            return DisplayText;
        }
    }
}