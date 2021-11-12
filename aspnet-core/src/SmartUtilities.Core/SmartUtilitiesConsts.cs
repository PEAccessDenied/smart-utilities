using SmartUtilities.Debugging;

namespace SmartUtilities
{
    public class SmartUtilitiesConsts
    {
        public const string LocalizationSourceName = "SmartUtilities";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "5ff3d2f1df3a4e84806d59ebb6a8ab29";
    }
}
