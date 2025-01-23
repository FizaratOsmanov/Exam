using BL.DTOs.MemberDTOs;
using BL.DTOs.ServiceDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Services.Abstractions
{
    public  interface IOurSeviceService
    {
        Task CreateService(ServicePostDTO dto);
        Task DeleteService(int id);
        Task<ICollection<ServiceGetDTO>> GetAllService();

        Task<ServiceGetDTO> GetServiceById(int id);
    }
}
