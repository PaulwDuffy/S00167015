using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment1.Models
{
    public class CollegeContext : DbContext
    {

        public CollegeContext(DbContextOptions<CollegeContext> options)
            : base(options)
        { }

        public DbSet<Student> Students { get; set; }

    }
}
