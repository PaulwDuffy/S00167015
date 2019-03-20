using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ValStarter.Models
{
    public class Student
    {
        [Required (ErrorMessage ="Please Enter a Valid Student ID")]
        [Display(Name = "Student ID")]
        [RegularExpression(@"(s\S)\d{7}")]

        public string StudentID { get; set; } = "";

        [Required]
        [Display(Name = "FirstName")]
        [RegularExpression(@"\w{2,50}")]
        public string FirstName { get; set; } = "";

        [Required]
        [Display(Name = "SurName")]
        [RegularExpression(@"[\w'-]\w{2,50}")]
        
        public string SurName { get; set; } = "";

        [Required]
        [DataType(DataType.Date)]

        public DateTime DOB { get; set; }

        [Required]
        [Display(Name = "Number of Modules")]

        public int NoOfModules { get; set; }

        [Required]
        [Display(Name = "Height")]

        public decimal Height { get; set; }

        [EmailAddress]
        [Required]
        [RegularExpression(@"\b[A-Z0-9._%+-]+@[A-Z0-9._%+-]+\.[A-Z]{2,}\b")]

        public string Email { get; set; }
        [EmailAddress]
        [Required]
        [RegularExpression(@"\b[A-Z0-9._%+-]+@[A-Z0-9._%+-]+\.[A-Z]{2,}\b")]

        public string ConfirmEmail { get; set; }
    }
}
