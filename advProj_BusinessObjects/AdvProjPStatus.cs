using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace advProj_BusinessObjects
{
    [Table("advProj_pStatus")]
    public partial class AdvProjPStatus
    {
        public AdvProjPStatus()
        {
            AdvProjProjects = new HashSet<AdvProjProject>();
            AdvProjTasks = new HashSet<AdvProjTask>();
        }

        [Key]
        [Column("statusID")]
        public int StatusId { get; set; }
        [Column("statusName")]
        [StringLength(10)]
        public string StatusName { get; set; } = null!;
        [Column("statusDescription")]
        [StringLength(30)]
        public string StatusDescription { get; set; } = null!;

        [InverseProperty("Status")]
        public virtual ICollection<AdvProjProject> AdvProjProjects { get; set; }
        [InverseProperty("Status")]
        public virtual ICollection<AdvProjTask> AdvProjTasks { get; set; }
    }
}
