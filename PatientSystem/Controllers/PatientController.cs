using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PatientSystem.Controllers
{
    public class PatientController : Controller
    {
        public ViewResult Registration()
        {
            return View();
        }
    }
}
