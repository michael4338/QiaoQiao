using System.Web;
using System.Web.Optimization;

namespace QiaoQiao
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new ScriptBundle("~/bundles/elate").Include(
                      "~/Scripts/modernizr-2.6.2.min.js",
                      "~/Scripts/jquery.min.js",
                      "~/Scripts/jquery.easing.1.3.js",
                      "~/Scripts/bootstrap.min.js",
                      "~/Scripts/jquery.waypoints.min.js",
                      "~/Scripts/jquery.stellar.min.js",
                      "~/Scripts/jquery.countTo.js",
                      "~/Scripts/jquery.magnific-popup.min.js",
                      "~/Scripts/magnific-popup-options.js",
                      "~/Scripts/google_map.js",
                      "~/Scripts/main.js"));

                     bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/style.css",
                      "~/Content/bootstrap-elate.css",
                      "~/Content/simple-line-icons.css",
                      "~/Content/magnific-popup.css",
                      "~/Content/icomoon.css",
                      "~/Content/animate.css"));
        }
    }
}
