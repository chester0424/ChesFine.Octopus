using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace ChesFine.Octopus.Web.FrameWork
{
    public static class WebViewPageExtends
    {
        public static MvcHtmlString RenderScript(this WebViewPage webViewPage)
        {
            var virturalPath = webViewPage.VirtualPath;//形如："~/Views/Home/Index.cshtml"
            var pathSplites = virturalPath.Split(new char[] { '/', '.' });
            var targetpath = "/Content/front/js/" + pathSplites[2].ToLower() + "/" + pathSplites[3].ToLower() + ".js";
            if (File.Exists(webViewPage.Server.MapPath("~") + targetpath))
            {
                var script = string.Format("<script  src=\"{0}\"></script>", targetpath);
                return new MvcHtmlString(script);
            }
            else
            {
                return new MvcHtmlString("");
            }
        }

        public static MvcHtmlString RenderStyle(this WebViewPage webViewPage)
        {
            var virturalPath = webViewPage.VirtualPath;
            var pathSplites = virturalPath.Split(new char[] { '/', '.' });
            var targetpath = "/Content/front/css/" + pathSplites[2].ToLower() + "/" + pathSplites[3].ToLower() + ".css";
            if (File.Exists(webViewPage.Server.MapPath("~") + targetpath))
            {
                var script = string.Format(" <link href = \"{0}\" rel = \"stylesheet\" />", targetpath);
                return new MvcHtmlString(script);
            }
            else
            {
                return new MvcHtmlString("");
            }
        }
    }
}
