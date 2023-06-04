using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;
using Microsoft.EntityFrameworkCore;

namespace advProj_BusinessObjects
{
    [Table("advProj_UserTask")]
    public partial class AdvProjUserTask
    {
        [Key]
        [Column("userTaskID")]
        public int UserTaskId { get; set; }
        [Column("userID")]
        public int? UserId { get; set; }
        [Column("taskID")]
        public int? TaskId { get; set; }

        [ForeignKey("TaskId")]
        [InverseProperty("AdvProjUserTasks")]
        public virtual AdvProjTask? Task { get; set; }
        [ForeignKey("UserId")]
        [InverseProperty("AdvProjUserTasks")]
        public virtual AdvProjUser? User { get; set; }

        // custome tostring method to serilize object to show in audits
        public override string? ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
