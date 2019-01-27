using System.Web.Http;

namespace AlgorithmsPlayer.ParallelSorter.Api
{
    public class PersonController : ApiController
    {
        public IHttpActionResult Get()
        {
            return Ok("Hello, Web API");
        }
    }
}