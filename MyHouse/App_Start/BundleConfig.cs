using System.Web;
using System.Web.Optimization;

namespace MyHouse
{
    public class BundleConfig
    {
        // Para obtener más información sobre Bundles, visite http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            BundleTable.Bundles.UseCdn = true;
            BundleTable.EnableOptimizations = true;
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Utilice la versión de desarrollo de Modernizr para desarrollar y obtener información. De este modo, estará
            // preparado para la producción y podrá utilizar la herramienta de compilación disponible en http://modernizr.com para seleccionar solo las pruebas que necesite.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            //Google analytics
            bundles.Add(new ScriptBundle("~/bundles/google-analytics", "http://www.google-analytics.com/analytics.js").Include(
                        "~/Scripts/analytics.js"));

            bundles.Add(new ScriptBundle("~/bundles/retina").Include(
                        "~/Scripts/plugins/retina/retina.min.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/font-awesome/css").Include(
                      "~/font-awesome/css/font-awesome.min.css"));

            bundles.Add(new StyleBundle("~/bundles/google-fonts-googleapis", "http://fonts.googleapis.com/css?family=Roboto:400,100,100italic,300,300italic,400italic,500,500italic,700,700italic,900,900italic").Include(
                        "~/Content/fonts.googleapis.com.css"));
        }
    }
}
