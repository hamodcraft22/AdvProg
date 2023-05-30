using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace advProj_BusinessObjects
{
    public class AdvProg_ApplicationUser : IdentityUser
    {
        [Required]
        public string? Name { get; set; }
        public string? Department { get; set; }
        public int? userID { get; set; }
    }
}
