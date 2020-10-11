using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAPIV2.Injector
{
    public interface IStudent
    {
        string GetStudentInfo(int Id);
    }
}
