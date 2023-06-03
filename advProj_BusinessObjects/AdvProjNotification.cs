using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;
using Microsoft.EntityFrameworkCore;

namespace advProj_BusinessObjects
{
    [Table("advProj_Notification")]
    public partial class AdvProjNotification
    {
        [Key]
        [Column("notificationID")]
        public int NotificationId { get; set; }
        [Column("notificationTitle")]
        [StringLength(60)]
        public string NotificationTitle { get; set; } = null!;
        [Column("notificationDate", TypeName = "datetime")]
        public DateTime NotificationDate { get; set; }
        [Column("notificationBody")]
        [StringLength(150)]
        public string NotificationBody { get; set; } = null!;
        [Column("statusID")]
        public int? StatusId { get; set; }
        [Column("userID")]
        public int? UserId { get; set; }
        [Column("taskID")]
        public int? TaskId { get; set; }

        [ForeignKey("StatusId")]
        [InverseProperty("AdvProjNotifications")]
        public virtual AdvProjNStatus? Status { get; set; }
        [ForeignKey("TaskId")]
        [InverseProperty("AdvProjNotifications")]
        public virtual AdvProjTask? Task { get; set; }
        [ForeignKey("UserId")]
        [InverseProperty("AdvProjNotifications")]
        public virtual AdvProjUser? User { get; set; }

        // custome tostring method to serilize object to show in audits
        public override string? ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
