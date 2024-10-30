using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Application.Features.Mediator.Results.UserResuls
{
    public class GetUserQueryResult
    {
        public int UserId { get; set; }
        public required string Username { get; set; }
        public required string Password { get; set; }
        public required string Name { get; set; }
        public required string Surname { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Address { get; set; }
        public bool IsAdmin { get; set; }
    }
}
