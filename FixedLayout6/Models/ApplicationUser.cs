using Microsoft.AspNetCore.Identity;
using System.Diagnostics.CodeAnalysis;

namespace FixedLayout6.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int UsernameChangeLimit { get; set; } = 10;
        [AllowNull]
        public byte[] ProfilePicture { get; set; }
    }
}
