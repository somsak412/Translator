using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TranslateASPMVC.Models;

namespace TranslateASPMVC.Controllers
{
    public class TranslateController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Index(string inputText)
        {
            if (string.IsNullOrEmpty(inputText))
            {
                ViewBag.TranslatedText = "Please enter text to translate.";
                return View();
            }
            
            var translator = new Translator { OriginalText = inputText };
            translator.Translate();

            ViewBag.TranslatedText = translator.TranslatedText;
            return View();
        }
        
    }
}
