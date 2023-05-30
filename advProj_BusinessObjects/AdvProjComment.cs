using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace advProj_BusinessObjects
{
    [Table("advProj_Comment")]
    public partial class AdvProjComment
    {
        [Key]
        [Column("commentID")]
        public int CommentId { get; set; }
        [Column("commentTitle")]
        [StringLength(30)]
        public string CommentTitle { get; set; } = null!;
        [Column("commentBody")]
        [StringLength(200)]
        public string CommentBody { get; set; } = null!;
        [Column("commentDate", TypeName = "datetime")]
        public DateTime CommentDate { get; set; }
        [Column("taskID")]
        public int? TaskId { get; set; }
        [Column("userID")]
        public int? UserId { get; set; }
        [Column("responseID")]
        public int? ResponseId { get; set; }

        [ForeignKey("ResponseId")]
        [InverseProperty("AdvProjComments")]
        public virtual AdvProjComResponse? Response { get; set; }
        [ForeignKey("TaskId")]
        [InverseProperty("AdvProjComments")]
        public virtual AdvProjTask? Task { get; set; }
        [ForeignKey("UserId")]
        [InverseProperty("AdvProjComments")]
        public virtual AdvProjUser? User { get; set; }
    }
}
