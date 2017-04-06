using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace ChesFine.Octopus.Web.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            var commonscript = new ScriptBundle("~/commonscript");
            //commonscript.Include("~/Scripts/jquery-3.1.1.js");
            //commonscript.Include("~/Scripts/jquery.form.js");
            commonscript.Include("~/Content/jquery-easyui-1.5.1/jquery.min.js");
            commonscript.Include("~/Scripts/ajaxfileupload.js");
            bundles.Add(commonscript);

            //管理部分EasyUI 
            var easyUIJsBundler = new ScriptBundle("~/easyui-js");
            //easyUIJsBundler.Include("~/Content/jquery-easyui-1.5.1/jquery.min.js");
            //easyUIJsBundler.Include("~/Content/jquery-easyui-1.5.1/jquery-1.6.min.js");
            //scriptBundler.Include("~/Scripts/jquery-3.1.1.js"); 
          
            easyUIJsBundler.Include("~/Content/jquery-easyui-1.5.1/jquery.easyui.min.js");
            easyUIJsBundler.Include("~/Content/jquery-easyui-1.5.1/locale/easyui-lang-zh_CN.js");
            easyUIJsBundler.Include("~/Content/jquery-easyui-1.5.1/jquery.edatagrid.js");

            bundles.Add(easyUIJsBundler);

            var easyUiStyleBundler = new StyleBundle("~/easyui-css");
            easyUiStyleBundler.Include("~/Content/jquery-easyui-1.5.1/themes/default/easyui.css");
            easyUiStyleBundler.Include("~/Content/jquery-easyui-1.5.1/themes/icon.css");
            easyUiStyleBundler.Include("~/Content/jquery-easyui-1.5.1/themes/color.css");
          
            bundles.Add(easyUiStyleBundler);

            //前端部分
            var jqueryJsBundler = new ScriptBundle("~/jquery-js");
            jqueryJsBundler.Include("~/Scripts/jquery-3.1.1.js");
            bundles.Add(jqueryJsBundler);

            var customerStyleBundler = new StyleBundle("~/common-css");
            customerStyleBundler.Include("~/ Content/front/common.css");
            bundles.Add(customerStyleBundler);

        }
    }
}