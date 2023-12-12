﻿using Microsoft.AspNetCore.Identity;

namespace PassbokningsDemo.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ICollection<ApplicationUserGymClass> AttendedMembers { get; set; }

    }
}
