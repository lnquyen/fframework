using System.Web;
using System.Web.Optimization;

namespace QuanLyDaoTao
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {

            //======================CSS============================
            
            bundles.Add(new StyleBundle("~/boostrap/css").Include(                        
                      "~/Content/bootstrap.css"));
            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/site.css"));
            //Custom for sb admin2 
            bundles.Add(new StyleBundle("~/sbAdmin2/css").Include(
                    "~/ThemeLibrary/bower_components/metisMenu/dist/metisMenu.min.css",
                    "~/ThemeLibrary/bower_components/font-awesome/css/font-awesome.min.css",
                    "~/ThemeLibrary/dist/css/sb-admin-2.css"));

            bundles.Add(new StyleBundle("~/easyui/css").Include(
                      "~/Content/themes/default/easyui.css",
                      "~/Content/themes/color.css",
                      "~/Content/themes/icon.css"

                      ));
            //-======================Jquery============================

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/jquery.unobtrusive-ajax.min.js"));
            
            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bootstrap/js").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/sbAdmin2/js").Include(
                        "~/ThemeLibrary/bower_components/metisMenu/dist/metisMenu.min.js",
                        "~/ThemeLibrary/dist/js/sb-admin-2.js"));

            bundles.Add(new ScriptBundle("~/easyui/js").Include(
                         "~/Scripts/jquery.easyui-1.4.5.min.js",
                         "~/Scripts/datagrid-filter.js"
                         ));

            
            //==================QLDT=================
            bundles.Add(new ScriptBundle("~/DonVi/js").Include(
                        "~/Scripts/QLDT/DonVi.js"));
        }
    }
}
