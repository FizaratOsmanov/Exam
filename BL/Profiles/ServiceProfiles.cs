using AutoMapper;
using BL.DTOs.ServiceDTOs;
using CORE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Profiles
{
    public  class ServiceProfiles : Profile
    {
        public ServiceProfiles()
        {
            CreateMap<ServiceGetDTO,Service>().ReverseMap();
            CreateMap<ServicePutDTO, Service>().ReverseMap();
            CreateMap<ServicePostDTO, Service>().ReverseMap();
        }
    }
}
