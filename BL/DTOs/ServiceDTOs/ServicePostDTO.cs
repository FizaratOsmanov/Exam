using FluentValidation;

namespace BL.DTOs.ServiceDTOs
{
    public  class ServicePostDTO
    {
        public string Name { get; set; }

        public string Description { get; set; }
    }

    public class ServicePostDTOValidation : AbstractValidator<ServicePostDTO>
    {
        public ServicePostDTOValidation()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Not be empty");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Not be empty");
        }
    }
}
