﻿using Microsoft.AspNetCore.Identity;

namespace WebApplication3.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
