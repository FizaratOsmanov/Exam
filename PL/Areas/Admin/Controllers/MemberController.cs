using AutoMapper;
using BL.DTOs.MemberDTOs;
using BL.FileManager;
using BL.Services.Abstractions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace PL.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class MemberController : Controller
    {
        readonly IMemberService _memberService;
        readonly IOurSeviceService _service;
        readonly IMapper _mapper;
        public MemberController(IMemberService memberService, IMapper mapper, IOurSeviceService service)
        {
            _memberService = memberService;
            _mapper = mapper;
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            ICollection<MemberGetDTO> dto = await _memberService.GetAllMember();
            return View(dto);
        }
        public IActionResult Create()
        {
            ViewBag.Service = _service.GetAllService();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(MemberPostDTO dto)
        {
            await  dto.Image.SaveAsync("members");
            await _memberService.CreateMember(dto);
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Delete(int id)
        {
            await _memberService.DeleteMember(id);
            return RedirectToAction("Index");
        }
    }
}