using System;
using Microsoft.AspNetCore.Mvc;
using StudentAPIV2.Survises;
using StudentAPIV2.Data;
using StudentAPIV2.Models;
using StudentAPIV2.Injector;

namespace StudentAPIV2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : Controller
    {
        private IStudent _studentRepository;

        public StudentController(IStudent studentRepository)
        {
            _studentRepository = studentRepository;
        }

        // GET api/student
        [HttpGet]
        public ActionResult<Student> Get()
        {
            var list = _studentRepository.GetStudentList();
            return Ok(list);
        }

        // GET api/student/5
        [HttpGet("{id}")]
        public ActionResult<Student> Get(int id)
        {
            try
            {
                var data = _studentRepository.GetStudentInfo(id);
                if (data == null)
                    return NotFound("Data Not Found !!");
                else
                    return Ok(data);
            }
            catch (Exception ex)
            {
                return BadRequest($"Student Get Error !!! with this warning {ex.Message} ");
            }
        }

        //// POST api/student
        //[HttpPost]
        //public ActionResult Post([FromBody] Student model)
        //{
        //    try
        //    {
        //        var massege = studentSurvice.SaveStudent(model);
        //        return Ok(massege);
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest($"Student Save Unsuccess!!! Error this warning {ex.Message} ");
        //    }
        //}

        //// PUT api/student/5
        //[HttpPut("{id}")]
        //public ActionResult Put(int id, [FromBody] Student model)
        //{
        //    try
        //    {
        //        var massege = studentSurvice.UpdateStudent(id, model);
        //        return Ok(massege);
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest($"Student Update Unsuccessfully !!! Error this Warning {ex.Message}");
        //    }
        //}

        //// DELETE api/student/5
        //[HttpDelete("{id}")]
        //public ActionResult Delete(int id)
        //{
        //    try
        //    {
        //        var data = studentSurvice.DaleteStudent(id);
        //        return Ok();
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest($"Unsuccessfully Delete !!! { ex.Message }");
        //    }
        //}
    }
}
