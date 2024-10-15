﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Domain
{
    public class User
    {
        public int UserId { get; set; }
        public required string Username { get; set; }
        public required string Password { get; set; }
        public required string Name { get; set; }
        public required string Surname { get; set; }
        public string? Address { get; set; }
    }
}
