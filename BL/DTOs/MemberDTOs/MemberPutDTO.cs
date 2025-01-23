using FluentValidation;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.DTOs.MemberDTOs
{
    public  class MemberPutDTO
    {
        public int Id {  get; set; }
        public IFormFile Image { get; set; }
        public string Name { get; set; }
        public string Profession { get; set; }

        public int ServiceId { get; set; }
    }

    public class MemberPutDTOValidation : AbstractValidator<MemberPutDTO>
    {
        public MemberPutDTOValidation()
        {
            RuleFor(x => x.Image).NotEmpty().WithMessage("Not be empty");
            RuleFor(x => x.Name).NotEmpty().WithMessage("Not be empty");
            RuleFor(x => x.Profession).NotEmpty().WithMessage("Not be empty");
        }
    }
}
