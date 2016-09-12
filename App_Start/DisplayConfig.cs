using System.Collections.Generic;
using System.Web.WebPages;
using Rafflesia.Web;

namespace Rafflesia
{
    public class DisplayConfig
    {
        public static void RegisterDisplayModes(IList<IDisplayMode> displayModes)
        {
            var mobileMode = new DefaultDisplayMode("mobile")
            {
                ContextCondition = (ctx => ctx.GetOverriddenBrowser().IsMobileDevice && !ctx.GetOverriddenBrowser().IsTabletDevice())
            };

            var tabletMode = new DefaultDisplayMode("tablet")
            {
                ContextCondition = (ctx => ctx.GetOverriddenBrowser().IsTabletDevice())
            };

            displayModes.Clear();
            displayModes.Add(tabletMode);
            displayModes.Add(mobileMode);
            displayModes.Add(new DefaultDisplayMode());
        }
    }
}