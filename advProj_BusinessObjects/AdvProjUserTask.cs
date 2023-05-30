using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace advProj_BusinessObjects
{
    [Table("advProj_UserTask")]
    public partial class AdvProjUserTask
    {
        [Key]
        [Column("userTaskID")]
        public int UserTaskId { get; set; }
        [Column("objective")]
        [StringLength(50)]
        public string Objective { get; set; } = null!;
        [Column("startDate", TypeName = "date")]
        public DateTime? StartDate { get; set; }
        [Column("endDate", TypeName = "date")]
        public DateTime? EndDate { get; set; }
        [Column("statusID")]
        public int? StatusId { get; set; }
        [Column("userID")]
        public int? UserId { get; set; }
        [Column("taskID")]
        public int? TaskId { get; set; }

        [ForeignKey("StatusId")]
        [InverseProperty("AdvProjUserTasks")]
        public virtual AdvProjPStatus? Status { get; set; }
        [ForeignKey("TaskId")]
        [InverseProperty("AdvProjUserTasks")]
        public virtual AdvProjTask? Task { get; set; }
        [ForeignKey("UserId")]
        [InverseProperty("AdvProjUserTasks")]
        public virtual AdvProjUser? User { get; set; }
    }
}
