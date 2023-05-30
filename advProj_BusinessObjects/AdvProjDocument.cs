using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace advProj_BusinessObjects
{
    [Table("advProj_Document")]
    public partial class AdvProjDocument
    {
        [Key]
        [Column("documentID")]
        public int DocumentId { get; set; }
        [Column("documentName")]
        [StringLength(20)]
        public string DocumentName { get; set; } = null!;
        [Column("documentType")]
        [StringLength(10)]
        public string DocumentType { get; set; } = null!;
        [Column("documentExt")]
        [StringLength(10)]
        public string DocumentExt { get; set; } = null!;
        [Column("documentPath")]
        [StringLength(100)]
        public string DocumentPath { get; set; } = null!;
        [Column("documentDescription")]
        [StringLength(100)]
        public string DocumentDescription { get; set; } = null!;
        [Column("uploadDate", TypeName = "datetime")]
        public DateTime UploadDate { get; set; }
        [Column("taskID")]
        public int? TaskId { get; set; }
        [Column("userID")]
        public int? UserId { get; set; }

        [ForeignKey("TaskId")]
        [InverseProperty("AdvProjDocuments")]
        public virtual AdvProjTask? Task { get; set; }
        [ForeignKey("UserId")]
        [InverseProperty("AdvProjDocuments")]
        public virtual AdvProjUser? User { get; set; }
    }
}
