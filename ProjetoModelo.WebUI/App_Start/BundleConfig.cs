using System.Web.Optimization;

namespace ProjetoModelo.WebUI
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/js/materialize").Include(
                "~/Scripts/js/materialize.js"));

            bundles.Add(new ScriptBundle("~/bundles/custom").Include(
                "~/Scripts/custom.js"));

            bundles.Add(new StyleBundle("~/bundles/site").Include(
                "~/Content/site.css",
                new CssRewriteUrlTransform()));

            bundles.Add(new StyleBundle("~/bundles/css/materialize").Include(
                "~/Content/css/materialize.css",
                new CssRewriteUrlTransform()));
        }
    }
}