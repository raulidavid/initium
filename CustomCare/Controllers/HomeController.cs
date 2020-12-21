using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CustomCare.Services;
using System.Collections.Generic;
using System.Linq;

namespace CustomCare.Controllers
{
    public class HomeController : Controller
    {
        private IClient _client;

        public HomeController(IClient client)
        {
            _client = client;
        }

        [HttpGet("{name?}")]
        public IActionResult Index(string name)
        {
            _client.CreateCola1();

            if ((name != null))
            {
                _client.AddItemCola1(name);
            }
            var model = _client.getCola1();
            return View(model);
        }
    }
}
