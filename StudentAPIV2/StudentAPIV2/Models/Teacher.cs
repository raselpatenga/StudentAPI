using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAPIV2.Models
{
    public class Teacher
    {
        public int TeacherId { get; set; }
        public string TeacherName { get; set; }
        public int Mobile { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public string Subject { get; set; }
        public string isMarried { get; set; }
    }
}
