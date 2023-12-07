using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Lab5WebApp.Models;
using Lab5Classes;

namespace Lab5WebApp.Controllers
{
    [Authorize]
    public class Lab1Controller : Controller
    {
        public IActionResult Lab1()
        {
            var model = new LabDataModel();
            return View(model);
        }

        [Authorize]
        [HttpPost]
        public string Lab1(LabDataModel model)
        {
            try
            {
                string inputPath = model.Input;
                string outputPath = model.Output;
                string res = Lab5Classes.Lab1.Run(inputPath, outputPath);
                return res;
            }
            catch (Exception e)
            {
                return "Error to run Lab1 POST command...." + e;
            }
        }
    }
}
