using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;
using Microsoft.EntityFrameworkCore;

namespace advProj_BusinessObjects
{
    [Table("advProj_Task")]
    public partial class AdvProjTask
    {
        public AdvProjTask()
        {
            AdvProjComments = new HashSet<AdvProjComment>();
            AdvProjDocuments = new HashSet<AdvProjDocument>();
            AdvProjNotifications = new HashSet<AdvProjNotification>();
            AdvProjUserTasks = new HashSet<AdvProjUserTask>();
        }

        [Key]
        [Column("taskID")]
        public int TaskId { get; set; }
        [Column("taskName")]
        [StringLength(30)]
        public string TaskName { get; set; } = null!;
        [Column("taskDescription")]
        [StringLength(100)]
        public string TaskDescription { get; set; } = null!;
        [Column("createDate", TypeName = "date")]
        public DateTime CreateDate { get; set; }
        [Column("startDate", TypeName = "date")]
        public DateTime? StartDate { get; set; }
        [Column("endDate", TypeName = "date")]
        public DateTime? EndDate { get; set; }
        [Column("finishDate", TypeName = "date")]
        public DateTime FinishDate { get; set; }
        [Column("statusID")]
        public int? StatusId { get; set; }
        [Column("projectID")]
        public int? ProjectId { get; set; }

        [ForeignKey("ProjectId")]
        [InverseProperty("AdvProjTasks")]
        public virtual AdvProjProject? Project { get; set; }
        [ForeignKey("StatusId")]
        [InverseProperty("AdvProjTasks")]
        public virtual AdvProjPStatus? Status { get; set; }
        [InverseProperty("Task")]
        public virtual ICollection<AdvProjComment> AdvProjComments { get; set; }
        [InverseProperty("Task")]
        public virtual ICollection<AdvProjDocument> AdvProjDocuments { get; set; }
        [InverseProperty("Task")]
        public virtual ICollection<AdvProjNotification> AdvProjNotifications { get; set; }
        [InverseProperty("Task")]
        public virtual ICollection<AdvProjUserTask> AdvProjUserTasks { get; set; }

        // custome tostring method to serilize object to show in audits
        public override string? ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
