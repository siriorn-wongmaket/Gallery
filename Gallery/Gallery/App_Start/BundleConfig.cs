using System.Web;
using System.Web.Optimization;

namespace Gallery
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jqueryJs").Include(
                       "~/Scripts/Gallery/jquery.js"));

            bundles.Add(new ScriptBundle("~/bundles/galleryJs").Include(
                        "~/Scripts/Gallery/Gallery/jquery.blueimp-gallery.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/mobileJs").Include(
                       "~/Scripts/Gallery/mobile/touchSwipe.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/respondJs").Include(
                      "~/Scripts/Gallery/respond/respond.js"));


            bundles.Add(new ScriptBundle("~/bundles/wowJs").Include(
                      "~/Scripts/Gallery/wow/wow.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/boostrapJs").Include(
                      "~/Scripts/Gallery/boostrap/bootstrap.js"));

            bundles.Add(new ScriptBundle("~/bundles/main").Include(
                 "~/Scripts/Gallery/script.js"));


            //bundles.Add(new StyleBundle("~/bundles/bootstrapCss").Include(
            //        "~/Content/Gallery/bootstrap/css/bootstrap.min.css"));
          
            bundles.Add(new StyleBundle("~/Content/gallery").Include(
                      "~/Content/Gallery/bootstrap/css/bootstrap.min.css",
                      "~/Content/Gallery/animate/animate.css",
                      "~/Content/Gallery/animate/set.css",
                      "~/Content/Gallery/Gallery/blueimp-gallery.min.css",
                      "~/Content/Gallery/style.css"));

            //bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
            //            "~/Scripts/jquery-{version}.js"));

            //bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
            //            "~/Scripts/jquery.validate*"));

            //// Use the development version of Modernizr to develop with and learn from. Then, when you're
            //// ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            //bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
            //            "~/Scripts/modernizr-*"));

            //bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
            //          "~/Scripts/bootstrap.js",
            //          "~/Scripts/respond.js"));

            //bundles.Add(new StyleBundle("~/Content/css").Include(
            //          "~/Content/bootstrap.css",
            //          "~/Content/site.css"));
        }
    }
}
