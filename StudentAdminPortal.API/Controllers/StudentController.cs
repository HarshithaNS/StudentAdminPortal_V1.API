using Microsoft.AspNetCore.Mvc;
using StudentAdminPortal.API.DomainModels;
using StudentAdminPortal.API.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StudentAdminPortal.API.Profiles;
using AutoMapper;

namespace StudentAdminPortal.API.Controllers
{
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentRepo repo;
        private readonly IMapper mapper;

        public StudentController(IStudentRepo repo,IMapper mapper)
        {
            this.repo = repo;
            this.mapper = mapper;
        }

        [HttpGet]
      [Route("api/[controller]")]
        public async Task<IActionResult> GetAllStudents ()
        {
            var std = await repo.GetStudents();
            var domainStudent = new List<Student>();
            domainStudent = mapper.Map<List<DomainModels.Student>>(std);

            //foreach (var student in std)
            //{
            //    domainStudent.Add(new Student()
            //    {
            //        Id = student.Id,
            //        FirstName=student.FirstName,
            //        LastName=student.LastName,
            //        DateOfBirth=student.DateOfBirth,
            //        Mobile=student.Mobile,
            //        ProfileImageUrl=student.ProfileImageUrl,
            //        GenderId=student.GenderId,
            //        Gender=new Gender()
            //        {
            //            Id=student.Gender.Id,
            //            Description=student.Gender.Description
            //        }

            //    });
            //}

            return Ok(domainStudent);
        }
    }
}
