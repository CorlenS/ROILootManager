
namespace ROILootManager {
    public class Constants {
        public const string PROGRAM_VERSION = "0.6.1";

        public static string CLIENT_ID = "387553138581.apps.googleusercontent.com";

        // This is the OAuth 2.0 Client Secret retrieved
        // above.  Be sure to store this value securely.  Leaking this
        // value would enable others to act on behalf of your application!
        public static string CLIENT_SECRET = "VBQq95L9ImAI-xcfp9xzKvMT";

        // Space separated list of scopes for which to request access.
        public static string SCOPE = "https://spreadsheets.google.com/feeds https://docs.google.com/feeds";

        // This is the Redirect URI for installed applications.
        // If you are building a web application, you have to set your
        // Redirect URI at https://code.google.com/apis/console.
        public static string REDIRECT_URI = "urn:ietf:wg:oauth:2.0:oob";

        // Application name
        public static string APPLICATION_NAME = "ROI LOOT";

        public static string ROSTER_URI = "https://spreadsheets.google.com/feeds/spreadsheets/private/full/tsCBcxMYW3TG_KM1cvgi41Q";

        public static string ITEM_LISTING_URI = "https://spreadsheets.google.com/feeds/spreadsheets/private/full/tZLRaKnZNJnUJl8-Omjz-Bg";

        public static string SPELL_LISTING_URI = "https://spreadsheets.google.com/feeds/spreadsheets/private/full/tnDMUXD9Hr47lGznmPe4Xpw";

        // Test sheet
        public const string ROI_LOOT_TEST_URI = "https://spreadsheets.google.com/feeds/spreadsheets/private/full/tD8bUaGtIBX7dZ9xwDmcabQ";

        // Real loot sheet
        public const string ROI_ROF_LOOT_URI = "https://spreadsheets.google.com/feeds/spreadsheets/private/full/trtkBWhxlyTB-Sozi9hNr5g";

        public const string RAID_ATTENDANCE_URL = "http://roiguild.org/dkp/viewmembers.php";

    }
}
