using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;


namespace advProj_BusinessObjects
{
    [Table("advProj_Project")]
    public partial class AdvProjProject
    {
        public AdvProjProject()
        {
            AdvProjTasks = new HashSet<AdvProjTask>();
        }

        [Key]
        [Column("projectID")]
        public int ProjectId { get; set; }
        [Column("projectName")]
        [StringLength(30)]
        public string ProjectName { get; set; } = null!;
        [Column("projectDescription")]
        [StringLength(200)]
        public string ProjectDescription { get; set; } = null!;
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
        [Column("managerID")]
        public int? ManagerId { get; set; }

        [ForeignKey("ManagerId")]
        [InverseProperty("AdvProjProjects")]
        public virtual AdvProjUser? Manager { get; set; }
        [ForeignKey("StatusId")]
        [InverseProperty("AdvProjProjects")]
        public virtual AdvProjPStatus? Status { get; set; }
        [InverseProperty("Project")]
        public virtual ICollection<AdvProjTask> AdvProjTasks { get; set; }


        // custome tostring method to serilize object to show in audits
        public override string? ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
