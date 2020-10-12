using StudentAPIV2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAPIV2.Injector
{
    public interface IStudent
    {
        List<Student> GetStudentList();
        Student GetStudentInfo(int Id);
    }
}
