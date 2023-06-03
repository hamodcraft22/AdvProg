using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace advProj_BusinessObjects
{
    [Table("advProj_User")]
    public partial class AdvProjUser
    {
        AdvProg_IdentityContext _identityContext;
        public AdvProjUser()
        {
            AdvProjAudits = new HashSet<AdvProjAudit>();
            AdvProjComments = new HashSet<AdvProjComment>();
            AdvProjDocuments = new HashSet<AdvProjDocument>();
            AdvProjLogs = new HashSet<AdvProjLog>();
            AdvProjNotifications = new HashSet<AdvProjNotification>();
            AdvProjProjects = new HashSet<AdvProjProject>();
            AdvProjUserTasks = new HashSet<AdvProjUserTask>();
            _identityContext = new AdvProg_IdentityContext();
        }

        [Key]
        [Column("userID")]
        public int UserId { get; set; }
        [Column("aspUserID")]
        [StringLength(450)]
        public string? AspUserId { get; set; }

        [InverseProperty("User")]
        public virtual ICollection<AdvProjAudit> AdvProjAudits { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<AdvProjComment> AdvProjComments { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<AdvProjDocument> AdvProjDocuments { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<AdvProjLog> AdvProjLogs { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<AdvProjNotification> AdvProjNotifications { get; set; }
        [InverseProperty("Manager")]
        public virtual ICollection<AdvProjProject> AdvProjProjects { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<AdvProjUserTask> AdvProjUserTasks { get; set; }

        public string FullName
        {
            get
            {
                var user = _identityContext.Users.Where(x => x.Id == this.AspUserId).FirstOrDefault();
                if (user != null)
                {
                    return (user.fName + " " + user.lName);
                }
                else
                {
                    return string.Empty;
                }
            }
        }
    }
}
