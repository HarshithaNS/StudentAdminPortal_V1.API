using AutoMapper;
using StudentAdminPortal.API.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAdminPortal.API.Profiles
{
    public class Automapper:Profile    
    {
        public Automapper()
        {
            CreateMap<Student, StudentAdminPortal.API.DomainModels.Student>().ReverseMap();

            CreateMap<Gender, StudentAdminPortal.API.DomainModels.Gender>().ReverseMap();

            CreateMap<Address, StudentAdminPortal.API.DomainModels.Address>().ReverseMap();
        }
    }
}
