using AutoMapper.Execution;
using BL.DTOs.MemberDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Services.Abstractions
{
    public  interface  IMemberService
    {

        Task CreateMember(MemberPostDTO dto);
        Task DeleteMember(int id);
        Task<ICollection<MemberGetDTO>> GetAllMember();
        Task<MemberGetDTO> GetMemberById(int id);

    }
}
