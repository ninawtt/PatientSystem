using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PatientSystem.Models;

namespace PatientSystem.Controllers
{
    public class PatientController : Controller
    {
        public ViewResult Registration()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Registration(Patient patient)
        {
            if (ModelState.IsValid)
            {
                PatientRepository.AddPatient(patient);
                return View("Thanks", patient);
            }
            else
            {
                return View(patient);
            }
        }

        public ViewResult ListPatients()
        {
            return View(PatientRepository.Patients
                .OrderBy(p => p.Name));
        }
       
    }
}
