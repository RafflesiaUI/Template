using System.Text.RegularExpressions;
using System.Web;

namespace Rafflesia.Web
{
    public static class RequestExtensions
    {
        public static bool IsTabletDevice(this HttpBrowserCapabilitiesBase browser)
        {
            var userAgent = HttpContext.Current.Request.UserAgent;
            if (Regex.IsMatch(userAgent, "iP(a|ro)d", RegexOptions.IgnoreCase) || 
                Regex.IsMatch(userAgent, "tablet", RegexOptions.IgnoreCase) &&
                !Regex.IsMatch(userAgent, "RX-34", RegexOptions.IgnoreCase) || 
                Regex.IsMatch(userAgent, "FOLIO", RegexOptions.IgnoreCase))
            {
                return true;
            }
            else if (Regex.IsMatch(userAgent, "Linux", RegexOptions.IgnoreCase) &&
                     Regex.IsMatch(userAgent, "Android", RegexOptions.IgnoreCase) &&
                     !Regex.IsMatch(userAgent, "Fennec|mobi|HTC.Magic|HTCX06HT|Nexus.One|SC-02B|fone.945", RegexOptions.IgnoreCase))
            {
                return true;
            }
            else if (Regex.IsMatch(userAgent, "Kindle", RegexOptions.IgnoreCase) ||
                     Regex.IsMatch(userAgent, "Mac.OS", RegexOptions.IgnoreCase) && 
                     Regex.IsMatch(userAgent, "Silk", RegexOptions.IgnoreCase))
            {
                return true;
            }
            else if (Regex.IsMatch(userAgent, @"GT-P10|SC-01C|SHW-M180S|SGH-T849|SCH-I800|SHW-M180L|SPH-P100|SGH-I987|zt180|HTC(.Flyer|\\_Flyer)|Sprint.ATP51|ViewPad7|pandigital(sprnova|nova)|Ideos.S7|Dell.Streak.7|Advent.Vega|A101IT|A70BHT|MID7015|Next2|nook", RegexOptions.IgnoreCase) || 
                     Regex.IsMatch(userAgent, "MB511", RegexOptions.IgnoreCase) && 
                     Regex.IsMatch(userAgent, "RUTEM", RegexOptions.IgnoreCase))
            {
                return true;
            }

            return false;
        }
    }
}