using Microsoft.AspNetCore.Mvc;
using paraApagar_2.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace paraApagar_2.Controllers
{
    public class HomeController : Controller /*A classe HomeController herda da classe Controller, todo o controller nosso vai ser uma subclasse de controller
                                              
                                              e este controlador vai ter varios metodos. Todos esses metodos retornam um objecto do tipo "IActionResult" que é um resultado de uma acção
                                              O proprio nome do metodo é mapeado para acção  */
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Salles web MVC App from C# Course";
            ViewData["Professor"] = "Ricardo David"; // Acrescentei outra view

            /*Quando metodo chama return View(), esse metodo é o que chamamos de methodBuilder, ele é um metodo auxiliar que vai retornar para nós 
             * um objecto do tipo IActionResult, no caso aqui uma View, e aqui o framework vai fazer o seguinte, está instanciando uma View e 
                está numa acção "About", o Framwork entao vai procurar na pasta Views , na subpasta Home que é o nome do Controlador, uma pagina chamada "About"*/

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
