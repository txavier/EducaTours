using System.Web;
using System.Web.Optimization;

namespace EducaTours
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/wwwroot/lib/jquery/dist/jquery.min.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/wwwroot/lib/modernizr/modernizr.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/angular").Include(
                      "~/wwwroot/lib/angular/angular.min.js",
                      "~/wwwroot/lib/angular-route/angular-route.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/angular-third-party").Include(
                      "~/wwwroot/lib/angular-loading-bar/build/loading-bar.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/angular-app").Include(
                      "~/app/app.module.js",
                      "~/app/app.config.js",
                      "~/app/home/home.controller.js"));

            bundles.Add(new ScriptBundle("~/bundles/theme-scripts").Include(
                      "~/Scripts/owl.carousel.min.js",
                      "~/Scripts/custom.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/imports.css",
                      "~/Content/owl-carousel.css",
                      "~/Content/site.css"));

            // Set EnableOptimizations to false for debugging. For more information,
            // visit http://go.microsoft.com/fwlink/?LinkId=301862
            BundleTable.EnableOptimizations = false;
        }
    }
}
