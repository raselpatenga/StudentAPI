using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StudentAPIV2.Data;
using StudentAPIV2.Models;
using StudentAPIV2.Services;

namespace StudentAPIV2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        private TeacherService teacherSurvise;

        public TeacherController(TeacherContext context)
        {
            teacherSurvise = new TeacherService(context);
        }

        //Get api/teacher
        [HttpGet]
        public ActionResult<Teacher> Get()
        {
            var list = teacherSurvise.GetTeacherList();
            return Ok(list);
        }

        //Post api/Teacher
        [HttpPost]
        public ActionResult Post([FromBody] Teacher model)
        {
            try
            {
                var massage = teacherSurvise.SaveTeacher(model);
                return Ok(massage);
            }
            catch (Exception ex)
            {
                return BadRequest($"Save Unsuccessfully!! Errore this warning {ex.Message}");
            }

        }

        //Put api/Teacher/5
        [HttpPut("{id}")]
        public ActionResult Put(int Id, [FromBody] Teacher model)
        {
            try
            {
                var massage = teacherSurvise.UpdateTeache(Id, model);
                return Ok(massage);
            }
            catch (Exception ex)
            {
                return BadRequest($"Update Unsuccessfully!! Errore this warning {ex.Message}");
            }
        }

        //Get api/Teacher/5
        [HttpGet("{id}")]
        public ActionResult<Teacher> Get(int Id)
        {
            try
            {
                var data = teacherSurvise.GetTeacherInfo(Id);
                if (data == null)
                    return NotFound("Data not found!!");
                else
                    return Ok(data);
            }
            catch (Exception ex)
            {
                return BadRequest($"Teacher Get Errore !! With this warning {ex.Message}");
            }
        }

        //Delete api/Teacher/5
        [HttpDelete("{id}")]
        public ActionResult DeleteTeacher(int Id)
        {
            try
            {
                var data = teacherSurvise.DeleteTeacher(Id);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return BadRequest($"Unsuccessfully Delete !!! { ex.Message }");
            }
        }
    }
}