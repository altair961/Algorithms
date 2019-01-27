using AlgorithmsPlayer.ParallelSorter.Api.App_Start;
using System;
using System.Web.Http;

namespace AlgorithmsPlayer.ParallelSorter.Api
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            //     GlobalConfiguration.Configure(AutofacConfig.ConfigureContainer2);
        }
    }
}