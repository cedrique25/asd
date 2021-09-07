using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Diagnostics;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CrudAspCore.Controllers
{
    public class ErrorController : Controller
    {
        // GET: /<controller>/
        [Route("Error")]
        public IActionResult Error()
        {
            var exceptionHandler = HttpContext.Features.Get<IExceptionHandlerPathFeature>();
            ViewBag.expceptionpath = exceptionHandler.Path;
            ViewBag.ExceptionMessage = exceptionHandler.Error.Message;
            ViewBag.Stacktrace = exceptionHandler.Error.StackTrace;
            return View("Error");
        }
    }
}
