using System.Web;
using System.Web.Optimization;

namespace WorkersIndia
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Content/js/jquery-3.2.1.min.js",
                        "~/Content/js/popper.min.js",
                        "~/Content/js/bootstrap.min.js",
                        "~/Content/js/jquery.magnific-popup.js",
                        "~/Content/js/swiper.min.js"                        
                        ));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                       "~/Scripts/bootstrap.js",
                       "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(                    
                      "~/Content/css/bootstrap.min.css",
                      "~/Content/css/simple-line-icons.css",
                      "~/Content/css/themify-icons.css",
                      "~/Content/css/set1.css",
                      "~/Content/css/style.css",
                      "~/Content/css/swiper.min.css",
                      "~/Content/css/magnific - popup.css"));

        }
    }
}
