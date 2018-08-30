using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RFQ.Areas.MyFeature.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RFQ.Areas.RFQPages.Controllers
{
    [Area("MyFeature")]
    [Route("[area]")]
    public class RFQController : Controller
    {
        private RFQModel dataModel = new RFQModel();
        public IActionResult Index()
        {
            return View();
        }

    }
}
