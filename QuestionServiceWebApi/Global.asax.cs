using AutoMapper;
using QuestionServiceWebApi.App_Start;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;

namespace QuestionServiceWebApi
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            Mapper.Initialize(c => c.AddProfile<MappingProfile>());
            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            GlobalConfiguration.Configuration.Formatters.XmlFormatter.SupportedMediaTypes.Clear();
        }
    }
}