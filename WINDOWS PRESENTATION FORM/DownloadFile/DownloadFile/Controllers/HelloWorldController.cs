using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace DownloadFile.Controllers
{
    public class HelloWorldController : Controller
    {

        // GET: /krishna/
        public IActionResult Index()
        {
            return View();
        }

        // GET: /HelloWorld/Welcome/ 
        //Requires using System.Text.Encodings.Web;
        public IActionResult Welcome(string name,int ID=1)
        {
            ViewData["Message"] ="Hello "+name;
            ViewData["numTimes"] = ID;
            return View();
        }
    }
}
