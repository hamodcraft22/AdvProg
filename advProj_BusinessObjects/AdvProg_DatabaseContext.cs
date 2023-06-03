using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace advProj_BusinessObjects
{
    public partial class AdvProg_DatabaseContext : DbContext
    {
        public AdvProg_DatabaseContext()
        {
        }

        public AdvProg_DatabaseContext(DbContextOptions<AdvProg_DatabaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AdvProjAudit> AdvProjAudits { get; set; } = null!;
        public virtual DbSet<AdvProjComResponse> AdvProjComResponses { get; set; } = null!;
        public virtual DbSet<AdvProjComment> AdvProjComments { get; set; } = null!;
        public virtual DbSet<AdvProjDocument> AdvProjDocuments { get; set; } = null!;
        public virtual DbSet<AdvProjLog> AdvProjLogs { get; set; } = null!;
        public virtual DbSet<AdvProjNStatus> AdvProjNStatuses { get; set; } = null!;
        public virtual DbSet<AdvProjNotification> AdvProjNotifications { get; set; } = null!;
        public virtual DbSet<AdvProjPStatus> AdvProjPStatuses { get; set; } = null!;
        public virtual DbSet<AdvProjProject> AdvProjProjects { get; set; } = null!;
        public virtual DbSet<AdvProjTask> AdvProjTasks { get; set; } = null!;
        public virtual DbSet<AdvProjUser> AdvProjUsers { get; set; } = null!;
        public virtual DbSet<AdvProjUserTask> AdvProjUserTasks { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=momacompany.asuscomm.com,62145;Database=AdvProg_Database;User Id=zift;Password=zift");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AdvProjAudit>(entity =>
            {
                entity.Property(e => e.AuditSource).IsFixedLength();

                entity.Property(e => e.ChnageType).IsFixedLength();

                entity.Property(e => e.EntityName).IsFixedLength();

                entity.Property(e => e.NewValue).IsFixedLength();

                entity.Property(e => e.OldValue).IsFixedLength();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AdvProjAudits)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_advProj_Audit_advProj_User");
            });

            modelBuilder.Entity<AdvProjComResponse>(entity =>
            {
                entity.Property(e => e.ResponseDescription).IsFixedLength();

                entity.Property(e => e.ResponseName).IsFixedLength();
            });

            modelBuilder.Entity<AdvProjComment>(entity =>
            {
                entity.Property(e => e.CommentBody).IsFixedLength();

                entity.Property(e => e.CommentTitle).IsFixedLength();

                entity.HasOne(d => d.Response)
                    .WithMany(p => p.AdvProjComments)
                    .HasForeignKey(d => d.ResponseId)
                    .HasConstraintName("FK_advProj_Comment_AdvProj_ComResponse");

                entity.HasOne(d => d.Task)
                    .WithMany(p => p.AdvProjComments)
                    .HasForeignKey(d => d.TaskId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_advProj_Comment_advProj_Task");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AdvProjComments)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_advProj_Comment_advProj_User");
            });

            modelBuilder.Entity<AdvProjDocument>(entity =>
            {
                entity.Property(e => e.DocumentDescription).IsFixedLength();

                entity.Property(e => e.DocumentExt).IsFixedLength();

                entity.Property(e => e.DocumentName).IsFixedLength();

                entity.Property(e => e.DocumentPath).IsFixedLength();

                entity.Property(e => e.DocumentType).IsFixedLength();

                entity.HasOne(d => d.Task)
                    .WithMany(p => p.AdvProjDocuments)
                    .HasForeignKey(d => d.TaskId)
                    .HasConstraintName("FK_advProj_Document_advProj_Task");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AdvProjDocuments)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_advProj_Document_advProj_User");
            });

            modelBuilder.Entity<AdvProjLog>(entity =>
            {
                entity.Property(e => e.ExceptionMsg).IsFixedLength();

                entity.Property(e => e.LogSource).IsFixedLength();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AdvProjLogs)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_advProj_Log_advProj_User");
            });

            modelBuilder.Entity<AdvProjNStatus>(entity =>
            {
                entity.HasKey(e => e.StatusId)
                    .HasName("PK_advProj_pStatus");

                entity.Property(e => e.StatusDescription).IsFixedLength();

                entity.Property(e => e.StatusName).IsFixedLength();
            });

            modelBuilder.Entity<AdvProjNotification>(entity =>
            {
                entity.Property(e => e.NotificationBody).IsFixedLength();

                entity.Property(e => e.NotificationTitle).IsFixedLength();

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.AdvProjNotifications)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_advProj_Notification_advProj_pStatus");

                entity.HasOne(d => d.Task)
                    .WithMany(p => p.AdvProjNotifications)
                    .HasForeignKey(d => d.TaskId)
                    .HasConstraintName("FK_advProj_Notification_advProj_Task");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AdvProjNotifications)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_advProj_Notification_advProj_User");
            });

            modelBuilder.Entity<AdvProjPStatus>(entity =>
            {
                entity.HasKey(e => e.StatusId)
                    .HasName("PK_advProj_Status");

                entity.Property(e => e.StatusDescription).IsFixedLength();

                entity.Property(e => e.StatusName).IsFixedLength();
            });

            modelBuilder.Entity<AdvProjProject>(entity =>
            {
                entity.Property(e => e.ProjectDescription).IsFixedLength();

                entity.Property(e => e.ProjectName).IsFixedLength();

                entity.HasOne(d => d.Manager)
                    .WithMany(p => p.AdvProjProjects)
                    .HasForeignKey(d => d.ManagerId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_advProj_Project_advProj_User");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.AdvProjProjects)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_advProj_Project_advProj_Status");
            });

            modelBuilder.Entity<AdvProjTask>(entity =>
            {
                entity.Property(e => e.TaskDescription).IsFixedLength();

                entity.Property(e => e.TaskName).IsFixedLength();

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.AdvProjTasks)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_advProj_Task_advProj_Project");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.AdvProjTasks)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_advProj_Task_advProj_Status");
            });

            modelBuilder.Entity<AdvProjUserTask>(entity =>
            {
                entity.HasOne(d => d.Task)
                    .WithMany(p => p.AdvProjUserTasks)
                    .HasForeignKey(d => d.TaskId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_advProj_UserTask_advProj_Task");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AdvProjUserTasks)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_advProj_UserTask_advProj_User");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
