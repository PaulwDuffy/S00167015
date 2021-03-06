using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ValStarter.Models;

namespace ValStarter.Pages
{
    public class EditStudentDetailsModel : PageModel
    {
        private readonly CollegeContext _db;

        public EditStudentDetailsModel(CollegeContext db)
        {
            _db = db;
        }

        [BindProperty]
        public Student Student { get; set; }

        [BindProperty]
        public Parent Parent { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            Student = await _db.Students.FindAsync(id);

            if (Student == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _db.Attach(Student).State = EntityState.Modified;

            try
            {
                await _db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw new Exception($"Student {Student.PPS} not found!");
            }

            return RedirectToPage("/ListStudents");
        }


    }
}