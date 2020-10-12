using StudentAPIV2.Data;
using StudentAPIV2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAPIV2.Services
{
    public class TeacherService
    {
        private TeacherContext _context;

        public TeacherService(TeacherContext context)
        {
            _context = context;
        }

        public List<Teacher> GetTeacherList()
        {
            try
            {
                var list = _context.tblTeachers.ToList();
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public string SaveTeacher(Teacher model)
        {
            try
            {
                _context.tblTeachers.Add(model);
                _context.SaveChanges();
                return "Save Successfully";
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public string UpdateTeache(int Id,Teacher model)
        {
            try
            {
                var OldTeacher = _context.tblTeachers.Find(Id);
                OldTeacher.TeacherName = model.TeacherName;
                OldTeacher.Mobile = model.Mobile;
                OldTeacher.Address = model.Address;
                OldTeacher.Gender = model.Gender;
                OldTeacher.Subject = model.Subject;
                OldTeacher.isMarried = model.isMarried;
                _context.SaveChanges();
                return "Update Succesfully";
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public Teacher GetTeacherInfo(int id)
        {
            try
            {
                var Teacher = _context.tblTeachers.Where(x => x.TeacherId == id).SingleOrDefault();
                return Teacher;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public string DeleteTeacher(int Id)
        {
            try
            {
                var isExistTeacher = _context.tblTeachers.Find(Id);
                if (isExistTeacher == null)
                    throw new SystemException("Teacher not found !! Please check Teacher list");
                _context.tblTeachers.Remove(isExistTeacher);
                _context.SaveChanges();
                return "Delete data Successfully.";
            }
            catch(Exception ex)
            {
                throw ex;
            }




        }
    }
}
