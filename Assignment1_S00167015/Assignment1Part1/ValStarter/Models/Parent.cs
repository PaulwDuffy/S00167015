using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ValStarter.Models
{
    public class Parent
    {

        [Required (ErrorMessage = "Please enter a first name, minimum length is 2 characters")]
        [Display(Name = "FirstName")]
        [RegularExpression(@"\w{2,50}")]
        public string FirstName { get; set; } = "";

        [Required (ErrorMessage = "Please enter a surname, minimum length is 2 characters")]
        [Display(Name = "Surname")]
        [RegularExpression(@"[\w'-]\w{2,50}")]

        public string LastName { get; set; } = "";


        [Required(ErrorMessage = "Please enter Mother/Father/Guardian")]
        [Display(Name = "Relationship to Child")]
        [RegularExpression("mother|father|gaurdian|Mother|Father|Gaurdian")]

        public string Relation { get; set; } = "";


        [Required (ErrorMessage = "Please enter Address")]
        [Display(Name = "Address Line 1")]
        [RegularExpression(@"[\w'-]\w{1,50}")]

        public string Address1 { get; set; } = "";

        [Required (ErrorMessage = "Please enter Address")]
        [Display(Name = "Address Line 2")]
        [RegularExpression(@"[\w'-]\w{2,50}")]

        public string Address2 { get; set; } = "";

       // [Required]
        [Display(Name = "Address Line 3")]
        [RegularExpression(@"[\w'-]\w{2,50}")]

        public string Address3 { get; set; } = "";

        [Required (ErrorMessage = "Please enter Mobile Number")]
        [Display(Name = "Mobile Phone")]
        [RegularExpression(@"[\w'-]\w{2,50}")]

        public string Mobile { get; set; }

        [Display(Name = "Second Mobile Phone")]
        [RegularExpression(@"[\w'-]\w{2,50}")]

        public string Mobile2 { get; set; }

        [Display(Name = "Alternate Number")]
        [RegularExpression(@"[\w'-]\w{2,50}")]

        public string AltNumber { get; set; }

        [Required (ErrorMessage = "Please enter valid email address")]
        [Display(Name = "Email")]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*")]

        public string Email { get; set; } = "";

        [Display(Name = "Second Email")]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*")]

        public string Email2 { get; set; } = "";

        [Required(ErrorMessage = "Please select a start date")]
        [DataType(DataType.Date)]

        public DateTime StartDate { get; set; }




        //[Required(ErrorMessage = "Please select days required")]
        //[Display(Name = "Days")]
        // [RegularExpression("Monday|Tuesday|Wednesday|Thursday|Friday")]









    }
}