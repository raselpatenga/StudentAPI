using System;
using System.Collections.Generic;
using System.Linq;
using StudentAPIV2.Data;
using StudentAPIV2.Models;

namespace StudentAPIV2.Services
{
    public class StudentSurvice
    {
        private StudentContext _context;
        public StudentSurvice(StudentContext context)
        {
            _context = context;
        }
        public List<Student> GetStudentList()
        {
            try
            {
                var list  = _context.Students.ToList();
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public string SaveStudent(Student model)
        {
            try
            {
                _context.Students.Add(model);
                _context.SaveChanges();
                var result = "Save Successfully";
                return result;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Student GetStudentInfo(int id)
        {
            try
            {
                var student = _context.Students.Where(x => x.StudentId == id).SingleOrDefault();
                return student;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public string DaleteStudent(int id)
        {
            //throw new InvalidOperationException(" Manually Update failed !!");
            try
            {
                var student = _context.Students.Where(x => x.StudentId == id).SingleOrDefault();
                if (student == null)
                    throw new SystemException("Student not found !! Please check student list");
                _context.Students.Remove(student);
                _context.SaveChanges();
                return "Delete Successfully!!";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public string UpdateStudent(int id, Student model)
        {
            try
            {
                var oldstudent = _context.Students.Find(id);
                oldstudent.StudentName = model.StudentName;
                oldstudent.StudentRoll = model.StudentRoll;
                oldstudent.StudentClass = model.StudentClass;
                _context.SaveChanges();
                return "Data Update Successfully";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}