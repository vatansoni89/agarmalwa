using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public string GetValue()
        {
            return "Hii";
        }

        [HttpGet("{id}")]
        public string GetValue(int id)
        {
            return "Hii " + id.ToString();
        }
    }
}