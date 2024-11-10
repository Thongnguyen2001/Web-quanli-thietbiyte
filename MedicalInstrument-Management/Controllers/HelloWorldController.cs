using MedicalInstrument_Management.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
namespace MedicalInstrument_Management.Controllers
{ 
    public class HelloWorldController : Controller
    {
        //GET: /HelloWorld/
        public ActionResult Index()
        {
            var ultrasound = new Ultrasound();
            ultrasound.Crystal= 20000;
            return View(ultrasound);
        }
        //GET: /HelloWorld/Welcome
        public string Welcome(string name, int ID=1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name},ID: {ID}");

        }
        
    }
}
