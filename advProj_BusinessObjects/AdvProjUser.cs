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
        public AdvProjUser()
        {
            AdvProjAudits = new HashSet<AdvProjAudit>();
            AdvProjComments = new HashSet<AdvProjComment>();
            AdvProjDocuments = new HashSet<AdvProjDocument>();
            AdvProjLogs = new HashSet<AdvProjLog>();
            AdvProjNotifications = new HashSet<AdvProjNotification>();
            AdvProjProjects = new HashSet<AdvProjProject>();
            AdvProjUserTasks = new HashSet<AdvProjUserTask>();
        }

        [Key]
        [Column("userID")]
        public int UserId { get; set; }
        [Column("aspUserID")]
        [StringLength(450)]
        public string? AspUserId { get; set; }
        [Column("roleID")]
        [StringLength(450)]
        public string? RoleId { get; set; }

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
    }
}
