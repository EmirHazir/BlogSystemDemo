using System.Web;
using System.Web.Optimization;

namespace BlogSystemDemo
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/ScriptlerBundle").Include(
                        "~/Scripts/jquery-3.1.1.min.js",
                        "~/Scripts/bootstrap.min.js",
                        "~/Scripts/main.js",
                        "~/Scripts/respond.js",
                        "~/Scripts/clean-blog.js",
                        "~/Scripts/jqBootstrapValidation.js"
                        ));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate.min.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-2.8.3.js"));


            bundles.Add(new StyleBundle("~/Content/cssLer").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/style.css",
                      "~/Content/responsive.css",
                      "~/Content/clean-blog.css"));
        }
    }
}
