using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace advProj_BusinessObjects
{
    [Table("AdvProj_ComResponse")]
    public partial class AdvProjComResponse
    {
        public AdvProjComResponse()
        {
            AdvProjComments = new HashSet<AdvProjComment>();
        }

        [Key]
        [Column("responseID")]
        public int ResponseId { get; set; }
        [Column("responseName")]
        [StringLength(10)]
        public string ResponseName { get; set; } = null!;
        [Column("responseDescription")]
        [StringLength(30)]
        public string ResponseDescription { get; set; } = null!;

        [InverseProperty("Response")]
        public virtual ICollection<AdvProjComment> AdvProjComments { get; set; }
    }
}
