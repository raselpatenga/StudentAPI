using Microsoft.EntityFrameworkCore;
using StudentAPIV2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAPIV2.Data
{
    public class StudentContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        public StudentContext(DbContextOptions options) : base(options)
        {
        }
    }
}
