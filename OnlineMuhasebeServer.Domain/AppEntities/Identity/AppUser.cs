﻿using Microsoft.AspNetCore.Identity;

namespace OnlineMuhasebeServer.Domain.AppEntities.Identity
{
    public class AppUser : IdentityUser<string>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NameLastName { get; set; }
        public string RefreshToken { get; set; }
        public DateTime RefreshTokenExpires { get; set; }
    }
    
}
