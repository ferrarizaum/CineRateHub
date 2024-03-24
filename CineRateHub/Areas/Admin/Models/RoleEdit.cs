using CineRateHub.Models;
using Microsoft.AspNetCore.Identity;

namespace CineRateHub.Areas.Admin.Models
{
    //not used, just added so Areas.Admin.Models would be enabled
    public class RoleEdit
    {
        public IdentityRole? Role { get; set; }
        public IEnumerable<User>? Members { get; set; }
        public IEnumerable<User>? NonMembers { get; set; }
    }
}
