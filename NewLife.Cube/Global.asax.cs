﻿using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;
using NewLife.Log;

namespace NewLife.Cube
{
    /// <summary>
    /// 注意: 有关启用 IIS6 或 IIS7 经典模式的说明，
    /// 请访问 http://go.microsoft.com/?LinkId=9394801
    /// </summary>

    public class MvcApplication : System.Web.HttpApplication
    {
        /// <summary>应用程序启动</summary>
        protected void Application_Start()
        {
            XTrace.WriteLine("系统启动");

            // 必须位于其它路由配置之前，否则无法生效
            //GlobalConfiguration.Configure(ODataConfig.Register);
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            //BundleConfig.RegisterBundles(BundleTable.Bundles);
            //XCode.Cache.CacheBase.Debug = true;
            

            XTrace.WriteLine("系统启动完成");
        }
    }
}