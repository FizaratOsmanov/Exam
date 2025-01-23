using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.DTOs.ServiceDTOs
{
    public  class ServiceGetDTO
    {

        public int Id { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }
    }

    public class ServiceGetDTOValidation : AbstractValidator<ServiceGetDTO>
    {
        public ServiceGetDTOValidation()
        {
            RuleFor(x => x.Id).NotEmpty().WithMessage("Not be empty");
            RuleFor(x => x.Name).NotEmpty().WithMessage("Not be empty");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Not be empty");
        }
    }
}
