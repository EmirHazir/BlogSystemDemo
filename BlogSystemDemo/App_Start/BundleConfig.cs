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

            bundles.Add(new StyleBundle("~/Content/AdminCSS").Include(
                     "~/Areas/AdminArea/Materials/AdminLTE-2.3.7/bootstrap/css/bootstrap.min.css",
                     "~/Areas/AdminArea/Materials/AdminLTE-2.3.7/dist/css/AdminLTE.min.css",
                     "~/Areas/AdminArea/Materials/AdminLTE-2.3.7/dist/css/skins/_all-skins.min.css"
                     ));

            bundles.Add(new ScriptBundle("~/bundles/AdminJS").Include(
                        "~/Areas/AdminArea/Materials/AdminLTE-2.3.7/plugins/jQuery/jquery-2.2.3.min.js",
                        "~/Areas/AdminArea/Materials/AdminLTE-2.3.7/bootstrap/js/bootstrap.min.js",
                        "~/Areas/AdminArea/Materials/AdminLTE-2.3.7/plugins/slimScroll/jquery.slimscroll.min.js",
                        "~/Areas/AdminArea/Materials/AdminLTE-2.3.7/plugins/fastclick/fastclick.js",
                        "~/Areas/AdminArea/Materials/AdminLTE-2.3.7/dist/js/app.min.js",
                        "~/Areas/AdminArea/Materials/AdminLTE-2.3.7/dist/js/demo.js"
                        ));


        }
    }
}
