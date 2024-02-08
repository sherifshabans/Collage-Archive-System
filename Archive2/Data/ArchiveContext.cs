using System;
using System.Net.Mail;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using modeforview2.Models;

#nullable disable

namespace modelfor_archive.Models
{
    public partial class Archive2Context : DbContext
    {
        public Archive2Context()
        {
        }

        public Archive2Context(DbContextOptions<Archive2Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Attachment> Attachments { get; set; }
        public virtual DbSet<Message> Messages { get; set; }
        public virtual DbSet<UserAcc> UserAccs { get; set; }
        public virtual DbSet<ListUserMes> ListUserMes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"
                           Server=DESKTOP-8S0IFLS\SQL2022;
                           Database=Archive;
                           Trusted_Connection=True;");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ListUserMes>().HasKey(K => new { K.UserId, K.MessageId });

        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

        //    //    modelBuilder.Entity<Attachment>(entity =>
        //    //    {
        //    //        entity.ToTable("Attachment");

        //    //        entity.Property(e => e.AttachmentId).HasColumnName("attachmentID");

        //    //        entity.Property(e => e.AttDesc)
        //    //            .HasMaxLength(1)
        //    //            .IsUnicode(false)
        //    //            .HasColumnName("attDesc");

        //    //        entity.Property(e => e.AttFile)
        //    //            .HasMaxLength(1)
        //    //            .IsUnicode(false)
        //    //            .HasColumnName("attFile");

        //    //        entity.Property(e => e.MessageId).HasColumnName("messageID");

        //    //        entity.HasOne(d => d.Message)
        //    //            .WithMany(p => p.Attachments)
        //    //            .HasForeignKey(d => d.MessageId)
        //    //            .HasConstraintName("FK_MessageAttach");
        //    //    });

        //    //    modelBuilder.Entity<Message>(entity =>
        //    //    {
        //    //        entity.HasKey(e => e.MessageId)
        //    //            .HasName("PK___Message__E8406252C6534774");

        //    //        entity.ToTable("_Message");

        //    //        entity.Property(e => e.MessageText)
        //    //            .HasMaxLength(1)
        //    //            .IsUnicode(false);

        //    //        entity.Property(e => e.RcvTime).HasColumnType("datetime");

        //    //        entity.Property(e => e.SendDate).HasColumnType("datetime");

        //    //        entity.Property(e => e.Title)
        //    //            .HasMaxLength(30)
        //    //            .IsUnicode(false);

        //    //        entity.HasOne(d => d.User)
        //    //            .WithMany(p => p.Messages)
        //    //            .HasForeignKey(d => d.UserId)
        //    //            .HasConstraintName("FK_UserMessage");
        //    //    });

        //    //    modelBuilder.Entity<UserAcc>(entity =>
        //    //    {
        //    //        entity.HasKey(e => e.UserAccID)
        //    //            .HasName("PK__UserAcc__1788CC4CA71D9C63");

        //    //        entity.ToTable("UserAcc");

        //    //        entity.Property(e => e.AcadMail)
        //    //            .HasMaxLength(1)
        //    //            .IsUnicode(false);

        //    //        entity.Property(e => e.JobTitle)
        //    //            .HasMaxLength(1)
        //    //            .IsUnicode(false);

        //    //        entity.Property(e => e.Pass)
        //    //            .HasMaxLength(10)
        //    //            .IsUnicode(false);

        //    //        entity.Property(e => e.Phone)
        //    //            .HasMaxLength(11)
        //    //            .IsUnicode(false);

        //    //        entity.Property(e => e.UserName)
        //    //            .HasMaxLength(40)
        //    //            .IsUnicode(false);
        //    //    });

        //    //}

        //}
    }
}
