using AcmeDemo.Debugging;

namespace AcmeDemo
{
    public class AcmeDemoConsts
    {
        public const string LocalizationSourceName = "AcmeDemo";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "824e9b979b1541d1b8f51a2577e358f8";
    }
}
