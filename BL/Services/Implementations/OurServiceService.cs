using AutoMapper;
using BL.DTOs.ServiceDTOs;
using BL.Services.Abstractions;
using CORE.Models;
using DATA.Repositories.Abstractions;


namespace BL.Services.Implementations
{
    public  class OurServiceService:IOurSeviceService
    {

        readonly IServiceRepository _serviceRepository;
        readonly IMapper _mapper;

        public OurServiceService(IServiceRepository serviceRepository, IMapper mapper)
        {
            _mapper = mapper;
            _serviceRepository = serviceRepository;
        }
        public async Task CreateService(ServicePostDTO dto)
        {
            Service service = _mapper.Map<Service>(dto);
            await _serviceRepository.GetByIdAsync(service.Id);
        }

        public async Task DeleteService(int id)
        {
            Service service = await _serviceRepository.GetByIdAsync(id);
            _serviceRepository.Delete(service);
        }

		public async Task<ICollection<ServiceGetDTO>> GetAllService()
        {
            ICollection<Service> services = await _serviceRepository.GetAllAsync();
            ICollection<ServiceGetDTO> DTOs = _mapper.Map<ICollection<ServiceGetDTO>>(services);
            return DTOs;
        }
        public async Task<ServiceGetDTO> GetServiceById(int Id)
        {
            var dto = await _serviceRepository.GetByIdAsync(Id);
            if (dto is null)
            {
                throw new Exception("Error");
            }
            return _mapper.Map<ServiceGetDTO>(dto);
        }
    }
}
