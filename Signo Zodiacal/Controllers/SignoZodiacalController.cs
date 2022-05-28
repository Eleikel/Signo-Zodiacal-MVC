using Application;
using Microsoft.AspNetCore.Mvc;
using Signo_Zodiacal.Models;

namespace Signos_Zodiacales.Controllers
{
    public class SignoZodiacalController : Controller
    {

        private readonly SignoZodiacalService signoZodiacalService;

        public SignoZodiacalController()
        {
            signoZodiacalService = new();
        }

        public IActionResult Index()
        {
            return View(new SignosViewModel());
        }

        ///ESTA LA QUE VA

        [HttpPost]
        public IActionResult Index(SignosViewModel svm)
        {

            signoZodiacalService.Consultar(svm);

            return View(svm);
        }

    }
}
