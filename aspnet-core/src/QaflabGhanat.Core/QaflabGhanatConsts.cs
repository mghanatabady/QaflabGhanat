using QaflabGhanat.Debugging;

namespace QaflabGhanat
{
    public class QaflabGhanatConsts
    {
        public const string LocalizationSourceName = "QaflabGhanat";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "1a064c803c05432889442f481598ec94";
    }
}
