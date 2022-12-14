using Microsoft.AspNetCore.Identity;

namespace StoragePeople.Models.Enterties
{
    public class AppUser:IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
