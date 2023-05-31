using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace advProj_BusinessObjects
{
    public class AdvProg_ApplicationUser : IdentityUser
    {
        [Required]
        public string? fName { get; set; }

        [Required]
        public string? lName { get; set; }
        public string? Department { get; set; }
    }
}
