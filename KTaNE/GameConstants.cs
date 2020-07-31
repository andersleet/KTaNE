using KTaNE.Properties;

namespace KTaNE
{
    public class GameConstants //defines global constants since I cannot get the main view to recognize "Resources.[xxx]". I am probably just an idjit
    {
        public static int manualID = int.Parse(Resources.manual_code);
        public static string manualURL = Resources.manual_url;
    }
}