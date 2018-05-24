using VueWithTypescript.Models.Sample;
using Microsoft.AspNetCore.Mvc;

namespace VueWithTypescript.Controllers
{
    public class SampleController : Controller
    {
        [HttpGet]
        public JsonResult GetTest()
        {
            var request = new GetTestData("Send from server.");
            return Json(request);
        }

        [HttpPost]
        public JsonResult PostTest([FromBody]PostTestData request)
        {
            var response = new PostTestData(request.TestText);
            return Json(response);
        }
    }
}
