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

        [Required]
        [Display(Name = "PPS Number")]
        [RegularExpression(@"\w{8}")]

        [Key]
        public string PPS { get; set; } = "";

        [Required]
        [Display(Name = "FirstName")]
        [RegularExpression(@"\w{2,50}")]
        public string FirstName { get; set; } = "";

        [Required]
        [Display(Name = "Surname")]
        [RegularExpression(@"[\w'-]\w{2,50}")]

        public string LastName { get; set; } = "";


        [Required]
        [DataType(DataType.Date)]

        public DateTime DOB { get; set; }


        [Required]
        [Display(Name = "Gender")]
        [RegularExpression ("m|f")]

        public string Gender { get; set; } = "";


    }
}
