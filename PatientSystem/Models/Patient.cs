using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PatientSystem.Models
{
    public class Patient
    {
        [Required(ErrorMessage = "Please enter your name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter your age")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Please enter your address")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Please enter your occupation")]
        public string Occupation { get; set; }
        
        public bool Insurance { get; set; }
        public bool Operation { get; set; }
        public string Marital { get; set; }
        public DateTime RegistrationTime { get; set; }
    }
}
