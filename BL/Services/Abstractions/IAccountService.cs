using BL.DTOs.UserDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Services.Abstractions
{
    public  interface IAccountService
    {
        Task RegisterAsync(RegisterDTO dto);
        Task LoginAsync(LoginDTO dto);
        Task LogoutAsync();
    }
}
