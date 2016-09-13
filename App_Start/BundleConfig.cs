using System.Web.Optimization;

namespace Rafflesia
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            RegisterScriptBundles(bundles);
            RegisterStyleBundles(bundles);
        }

        private static void RegisterScriptBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/Scripts/jquery").Include(
                        "~/Content/scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/Scripts/jquery-ui").Include(
                        "~/Content/scripts/jquery-ui.js"));

            bundles.Add(new ScriptBundle("~/Scripts/bootstrap").Include(
                        "~/Content/scripts/bootstrap.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/Scripts/modernizr").Include(
                        "~/Content/scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/Scripts/site").Include(
                        "~/Content/scripts/site.js"));

            bundles.Add(new ScriptBundle("~/Scripts/Mobile/site").Include(
                        "~/Content/scripts/site.mobile.js"));
        }

        private static void RegisterStyleBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Styles/bootstrap").Include(
                        "~/Content/styles/bootstrap.css"));

            bundles.Add(new StyleBundle("~/Styles/fontawesome").Include(
                        "~/Content/styles/font-awesome.css",
                        "~/Content/styles/font-awesome.extensions.css"));

            bundles.Add(new StyleBundle("~/Styles/jquery-ui").Include(
                        "~/Content/styles/jquery-ui.css",
                        "~/Content/styles/jquery-ui.structure.css"));

            bundles.Add(new StyleBundle("~/Styles/site").Include(
                        "~/Content/styles/site.css"));

            bundles.Add(new StyleBundle("~/Styles/Mobile/site").Include(
                        "~/Content/styles/site.mobile.css"));
        }
    }
}