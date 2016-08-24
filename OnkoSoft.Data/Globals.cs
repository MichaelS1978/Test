using System;

namespace OnkoSoft.Data
{
    public static class Globals
    {
        public static readonly DateTime MinimumDate = new DateTime(1900, 1, 1);
        public static readonly DateTime MaximumDate = new DateTime(2999, 12, 31);

        public const string CURRENT_DATABASE_VERSION = "2.0.0.0";
    }
}