using Microsoft.AspNetCore.Identity;

namespace Youtube.Services.AuthAPI.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
        public string? ProfilePicUrl { get; set; }
        public string? ProfilePicLocalPath { get; set; }
    }
}
