using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace advProj_BusinessObjects
{
    [Table("advProj_Audit")]
    public partial class AdvProjAudit
    {
        [Key]
        [Column("auditID")]
        public int AuditId { get; set; }
        [Column("auditSource")]
        [StringLength(10)]
        public string AuditSource { get; set; } = null!;
        [Column("chnageType")]
        [StringLength(10)]
        public string ChnageType { get; set; } = null!;
        [Column("entityName")]
        [StringLength(20)]
        public string EntityName { get; set; } = null!;
        [Column("oldValue")]
        [StringLength(1100)]
        public string? OldValue { get; set; }
        [Column("newValue")]
        [StringLength(1100)]
        public string? NewValue { get; set; }
        [Column("recordID")]
        public int? RecordId { get; set; }
        [Column("userID")]
        public int? UserId { get; set; }

        [ForeignKey("UserId")]
        [InverseProperty("AdvProjAudits")]
        public virtual AdvProjUser? User { get; set; }
    }
}
