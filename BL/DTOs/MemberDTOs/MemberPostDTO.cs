using FluentValidation;
using Microsoft.AspNetCore.Http;

namespace BL.DTOs.MemberDTOs
{
	public  class MemberPostDTO
    {

        public IFormFile Image { get; set; }
        public string Name { get; set; }
        public string Profession { get; set; }

        public int ServiceId {  get; set; }
    }

    public class MemberPostDTOValidation : AbstractValidator<MemberPostDTO>
    {
        public MemberPostDTOValidation()
        {
            RuleFor(x => x.Image).NotEmpty().WithMessage("Not be empty");
            RuleFor(x => x.Name).NotEmpty().WithMessage("Not be empty");
            RuleFor(x => x.Profession).NotEmpty().WithMessage("Not be empty");
        }
    }
}
