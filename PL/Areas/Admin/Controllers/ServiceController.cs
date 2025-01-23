using AutoMapper;
using BL.DTOs.MemberDTOs;
using BL.DTOs.ServiceDTOs;
using BL.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace PL.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class ServiceController : Controller
	{
        readonly IOurSeviceService _service;
        readonly IMapper _mapper;
        public ServiceController(IMapper mapper, IOurSeviceService service)
        {
            _mapper = mapper;
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            try
            {
                ICollection<ServiceGetDTO> dto = await _service.GetAllService();
                return View(dto);
            }
            catch (Exception)
            {
                ModelState.AddModelError("CustomError", "Error");
                return View("Error");
            }
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(ServicePostDTO dto)
        {
            try
            {
                await _service.CreateService(dto);
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                ModelState.AddModelError("CustomError", "Error");
                return View("Error");
            }
        }
        public async Task<IActionResult> Delete(int id)
        {
            await _service.DeleteService(id);
            return RedirectToAction("Index");
        }
    }
}
