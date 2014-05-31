namespace WcfService
{
    using System;
    using System.ServiceModel.Activation;
    using System.Web;
    using System.Web.Routing;

    public class Global : HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            var routes = RouteTable.Routes;

            routes.Add(new ServiceRoute(
                "Service",
                new WebServiceHostFactory(),
                typeof(Service1)));
        }
    }
}