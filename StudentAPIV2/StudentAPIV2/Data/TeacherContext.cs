using Microsoft.EntityFrameworkCore;
using StudentAPIV2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAPIV2.Data
{
    public class TeacherContext : DbContext
    {
        public DbSet<Teacher> tblTeachers { get; set; }

        public TeacherContext(DbContextOptions options): base(options)
        {
        }
    }
}
