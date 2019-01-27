using System.Web.Http;

namespace AlgorithmsPlayer.ParallelSorter.Api
{
    public class OrdersController : ApiController
    {
        [Route("customers/{customerId}/orders")]
        [HttpGet]
        public int GetAmountOfOrders()
        {
            return 5;
        }
    }
}