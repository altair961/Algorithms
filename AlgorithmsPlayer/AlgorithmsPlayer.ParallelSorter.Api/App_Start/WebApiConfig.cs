using System.Web.Http;

namespace AlgorithmsPlayer.ParallelSorter.Api.App_Start
{
    public class WebApiConfig
    {
        internal static void Register(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();
        }
    }
}