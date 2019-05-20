using System.Web;
using System.Web.Optimization;

namespace Bussiness_Agent
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
                      "~/Scripts/bootstrap.js",
                      "~/Assets/bower_components/jquery/dist/jquery.min.js",
                      "~/Assets/bower_components/bootstrap/dist/js/bootstrap.min.js",
                      "~/Assets/bower_components/bootstrap-datepicker/dist/js/bootstrap-datepicker.min.js",
                      "~/Assets/plugins/timepicker/bootstrap-timepicker.min.js",
                      "~/Assets/dist/js/adminlte.min.js"
                      ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Assets/bower_components/bootstrap/dist/css/bootstrap.min.css",
                      "~/Assets/bower_components/font-awesome/css/font-awesome.min.css",
                      "~/Assets/bower_components/Ionicons/css/ionicons.min.css",
                      "~/Assets/bower_components/bootstrap-datepicker/dist/css/bootstrap-datepicker.min.css",
                      "~/Assets/plugins/timepicker/bootstrap-timepicker.min.css",
                      "~/Assets/dist/css/AdminLTE.min.css",
                      "~/Assets/dist/css/skins/skin-blue.css",
                      "~/Content/site.css"));
        }
    }
}
