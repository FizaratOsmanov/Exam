using AutoMapper;
using AutoMapper.Execution;
using BL.DTOs.MemberDTOs;
using BL.Services.Abstractions;
using DATA.Repositories.Abstractions;
using DATA.Repositories.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace BL.Services.Implementations
{
    public class MemberService : IMemberService
    {

        readonly IMemberRepository _memberRepository;
        readonly IMapper _mapper;
            
        public MemberService(IMemberRepository memberRepository,IMapper mapper)
        {
             _mapper = mapper;
            _memberRepository = memberRepository;
        }
        public async Task CreateMember(MemberPostDTO dto)
        {
            CORE.Models.Member member = _mapper.Map<CORE.Models.Member>(dto);
            await _memberRepository.GetByIdAsync(member.Id);
        }

        public async Task DeleteMember(int id)
        {
            CORE.Models.Member member=await _memberRepository.GetByIdAsync(id);
            _memberRepository.Delete(member);
        }
        public async Task<ICollection<MemberGetDTO>> GetAllMember()
        {
            ICollection<CORE.Models.Member> members = await _memberRepository.GetAllAsync();
            ICollection<MemberGetDTO> DTOs = _mapper.Map<ICollection<MemberGetDTO>>(members);
            return DTOs;
        }
        public async Task<MemberGetDTO> GetMemberById(int Id)
        {
            var dto = await _memberRepository.GetByIdAsync(Id);
            if (dto is null)
            {
                throw new Exception("Error");
            }
            return _mapper.Map<MemberGetDTO>(dto);
        }
    }
}
