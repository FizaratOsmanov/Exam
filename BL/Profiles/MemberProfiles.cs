using AutoMapper;
using BL.DTOs.MemberDTOs;
using BL.DTOs.ServiceDTOs;
using CORE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Profiles
{
    public class MemberProfiles : Profile
    {
        public MemberProfiles()
        {
            CreateMap<MemberGetDTO, Member>().ReverseMap();
            CreateMap<MemberPutDTO, Member>().ReverseMap();
            CreateMap<MemberPostDTO, Member>().ReverseMap();
        }
    }
}