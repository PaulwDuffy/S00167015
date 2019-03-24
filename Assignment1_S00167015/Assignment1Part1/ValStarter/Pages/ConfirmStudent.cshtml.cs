using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ValStarter.Models;

namespace ValStarter.Pages
{
    public class ConfirmStudentModel : PageModel
    {
        
       

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PPS { get; set; }

        public string DOB { get; set; }

        public string Gender { get; set; }

        public void OnGet()
        {
           
            FirstName = HttpContext.Session.GetString("FirstName");
            LastName = HttpContext.Session.GetString("LastName");
            PPS = HttpContext.Session.GetString("PPS");
            DOB = HttpContext.Session.GetString("DOB");
            Gender = HttpContext.Session.GetString("Gender");
        }
    }
}