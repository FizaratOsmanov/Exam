using AutoMapper;
using BL.DTOs.UserDTOs;
using BL.Services.Abstractions;
using CORE.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Services.Implementations
{
     public  class AccountService:IAccountService
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly IMapper _mapper;
        public AccountService(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager, IMapper mapper)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _mapper = mapper;
        }

        public async Task RegisterAsync(RegisterDTO dto)
        {
            if (await _userManager.FindByNameAsync(dto.UserName) is not null) throw new Exception();
            if (await _userManager.FindByEmailAsync(dto.Email) is not null) throw new Exception();

            IdentityUser user = _mapper.Map<IdentityUser>(dto);
            IdentityResult result = await _userManager.CreateAsync(user, dto.Password);

            if (!result.Succeeded)
            {
                throw new Exception();
            }

            result = await _userManager.AddToRoleAsync(user, RoleEnum.User.ToString());

            if (!result.Succeeded)
            {
                throw new Exception();
            }
        }

        public async Task LoginAsync(LoginDTO dto)
        {
            IdentityUser user = await _userManager.FindByNameAsync(dto.UserName) ?? throw new Exception("Error");
            SignInResult result = await _signInManager.PasswordSignInAsync(user, dto.Password, dto.RememberMe, true);
            if (!result.Succeeded)
            {
                throw new Exception();
            }
        }

        public async Task LogoutAsync()
        {
            await _signInManager.SignOutAsync();
        }

    }
}
