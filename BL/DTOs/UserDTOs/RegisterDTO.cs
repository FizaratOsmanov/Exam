﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.DTOs.UserDTOs
{
    public  class RegisterDTO
    {

        public string Email { get; set; }   

        public string UserName { get; set; }

        public string Password { get; set; }

        public string ConfirmPassword { get; set; }

    }
}
