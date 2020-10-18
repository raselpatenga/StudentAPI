using System;
using System.Collections.Generic;
using System.Linq;
using StudentAPIV2.Data;
using StudentAPIV2.Injector;
using StudentAPIV2.Models;

namespace StudentAPIV2.Survises
{
    public class StudentService : IStudent
    {
        private StudentContext _context;
        public StudentService(StudentContext context)
        {
            _context = context;
        }
        public Student GetStudentInfo(int Id)
        {
            return _context.Students.Where(x => x.StudentId == Id).SingleOrDefault();
        }
        public List<Student> GetStudentList()
        {
            return _context.Students.ToList();
        }
    }
}