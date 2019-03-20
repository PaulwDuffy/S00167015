using System;
using System.Linq;
using System.Threading;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace multiselection.pages
{
    public class TimeModel : PageModel
    {

        public string[] DayNames { get; set; } = { "Mon", "Tues", "Wed", "Thurs", "Fri", "Sat", "Sun" };

        [BindProperty]
        public bool[] IsDayChosen { get; set; } = new bool[7];

        [BindProperty]
        public string[] MonthsChosen { get; set; } = { };

        public List<SelectListItem> MonthsSelectList { get; set; } =
            new List<SelectListItem>
            {new SelectListItem ("Jan", "Jan"),
            new SelectListItem ("Feb","Feb"),
            new SelectListItem ("March","March"),
            new SelectListItem ("April","April"),
            new SelectListItem ("May","May"),};
        

    public void OnGet()
    {

    }
}
}