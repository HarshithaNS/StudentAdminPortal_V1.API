using Microsoft.EntityFrameworkCore;
using StudentAdminPortal.API.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAdminPortal.API.Repository
{
    public class StudentRepository : IStudentRepo
    {
        private readonly StudentDbContext context;

        public StudentRepository(StudentDbContext context)
        {
            this.context = context;
        }
        public async Task<List<Student>> GetStudents()
        {
            return await context.Student.Include("Gender").ToListAsync();
        }
    }
}
