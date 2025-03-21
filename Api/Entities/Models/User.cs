﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool UserConfirmed { get; set; }

        public UserRole Role { get; set; } // String yerine enum kullanıldı
    }
    public enum UserRole
    {
        User = 0,
        Admin = 1
    }


}
