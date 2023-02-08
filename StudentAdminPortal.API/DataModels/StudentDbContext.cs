using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAdminPortal.API.DataModels
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options)
        {
            
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder options)
        //{
        //    options.UseSqlServer("StudentConnection");
        //}
        public DbSet<Student> Student { get; set; }
        public DbSet<Gender> Gender{ get; set; }
        public DbSet<Address> Address { get; set; }
    }
    
}
