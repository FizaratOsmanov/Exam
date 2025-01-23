using FluentValidation;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.DTOs.MemberDTOs
{
    public class MemberGetDTO
    {
        public int Id { get; set; }

        public string ImgPath { get; set; }
        public string Name { get; set; }
        public string Profession { get; set; }
        public int ServiceId { get; set; }
    }

    public class MemberGetDTOValidation : AbstractValidator<MemberGetDTO>
    {
        public MemberGetDTOValidation()
        {
            RuleFor(x => x.Id).NotEmpty().WithMessage("Not be empty");
            RuleFor(x => x.ImgPath).NotEmpty().WithMessage("Not be empty");
            RuleFor(x => x.Name).NotEmpty().WithMessage("Not be empty");
            RuleFor(x => x.Profession).NotEmpty().WithMessage("Not be empty");
        }
    }
}
