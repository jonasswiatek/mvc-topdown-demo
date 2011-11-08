using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using DR.Common.Web.Mvc.Util;
using DR.TopdownDemo.IHeartQuotesData;
using DR.TopdownDemo.IHeartQuotesData.Contract;
using DR.TopdownDemo.IHeartQuotesService;
using DR.TopdownDemo.MockServiceImpl;
using DR.TopdownDemo.ServiceModel.Contract;
using StructureMap;

namespace DR.TopdownDemo.Web
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "Default", // Route name
                "{controller}/{action}/{id}", // URL with parameters
                new { controller = "Home", action = "Index", id = UrlParameter.Optional } // Parameter defaults
            );

        }

        protected void BootstrapStructuremap()
        {
            ControllerBuilder.Current.SetControllerFactory(new StructureMapControllerFactory());

            ObjectFactory.Configure(a =>
                                        {
                                            a.For<IQuoteService>().Use<HeartQuotesQuoteService>();
                                            a.For<IQuoteRepository>().Use<HeartQuotesQuoteRepository>();
                                        });
        }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            BootstrapStructuremap();

            RegisterGlobalFilters(GlobalFilters.Filters);
            RegisterRoutes(RouteTable.Routes);
        }
    }
}