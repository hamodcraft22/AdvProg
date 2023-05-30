using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace advProj_BusinessObjects
{
    [Table("advProj_Log")]
    public partial class AdvProjLog
    {
        [Key]
        [Column("logID")]
        public int LogId { get; set; }
        [Column("logSource")]
        [StringLength(10)]
        public string LogSource { get; set; } = null!;
        [Column("exceptionMsg")]
        [StringLength(200)]
        public string ExceptionMsg { get; set; } = null!;
        [Column("date", TypeName = "datetime")]
        public DateTime Date { get; set; }
        [Column("userID")]
        public int? UserId { get; set; }

        [ForeignKey("UserId")]
        [InverseProperty("AdvProjLogs")]
        public virtual AdvProjUser? User { get; set; }
    }
}
