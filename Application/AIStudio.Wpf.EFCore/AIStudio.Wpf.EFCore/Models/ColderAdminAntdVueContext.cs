﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace AIStudio.Wpf.EFCore.Models
{
    public partial class ColderAdminAntdVueContext : DbContext
    {
        public ColderAdminAntdVueContext()
        {
        }

        public ColderAdminAntdVueContext(DbContextOptions<ColderAdminAntdVueContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Base_Action> Base_Action { get; set; }
        public virtual DbSet<Base_AppSecret> Base_AppSecret { get; set; }
        public virtual DbSet<Base_DbLink> Base_DbLink { get; set; }
        public virtual DbSet<Base_Department> Base_Department { get; set; }
        public virtual DbSet<Base_Role> Base_Role { get; set; }
        public virtual DbSet<Base_RoleAction> Base_RoleAction { get; set; }
        public virtual DbSet<Base_User> Base_User { get; set; }
        public virtual DbSet<Base_UserLog> Base_UserLog { get; set; }
        public virtual DbSet<Base_UserRole> Base_UserRole { get; set; }
        public virtual DbSet<D_UserGroup> D_UserGroup { get; set; }
        public virtual DbSet<D_UserMail> D_UserMail { get; set; }
        public virtual DbSet<D_UserMessage> D_UserMessage { get; set; }
        public virtual DbSet<D_UserMessage_202103> D_UserMessage_202103 { get; set; }
        public virtual DbSet<D_UserMessage_202104> D_UserMessage_202104 { get; set; }
        public virtual DbSet<Event> Event { get; set; }
        public virtual DbSet<ExecutionError> ExecutionError { get; set; }
        public virtual DbSet<ExecutionPointer> ExecutionPointer { get; set; }
        public virtual DbSet<ExtensionAttribute> ExtensionAttribute { get; set; }
        public virtual DbSet<OA_DefForm> OA_DefForm { get; set; }
        public virtual DbSet<OA_DefType> OA_DefType { get; set; }
        public virtual DbSet<OA_UserForm> OA_UserForm { get; set; }
        public virtual DbSet<OA_UserFormStep> OA_UserFormStep { get; set; }
        public virtual DbSet<Quartz_Task> Quartz_Task { get; set; }
        public virtual DbSet<Subscription> Subscription { get; set; }
        public virtual DbSet<Workflow> Workflow { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=121.36.12.76;Initial Catalog=Colder.Admin.AntdVue;uid=sa;pwd=aic3600!");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Base_Action>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .HasComment("自然主键");

                entity.Property(e => e.CreateTime).HasComment("创建时间");

                entity.Property(e => e.CreatorId)
                    .HasMaxLength(50)
                    .HasComment("创建人Id");

                entity.Property(e => e.CreatorName)
                    .HasMaxLength(255)
                    .HasComment("创建人");

                entity.Property(e => e.Deleted).HasComment("否已删除");

                entity.Property(e => e.Icon).HasComment("图标");

                entity.Property(e => e.ModifyId)
                    .HasMaxLength(50)
                    .HasComment("修改人Id");

                entity.Property(e => e.ModifyName)
                    .HasMaxLength(255)
                    .HasComment("修改人");

                entity.Property(e => e.ModifyTime).HasComment("修改时间");

                entity.Property(e => e.Name).HasComment("权限名/菜单名");

                entity.Property(e => e.NeedAction).HasComment("是否需要权限(仅页面有效)");

                entity.Property(e => e.ParentId).HasComment("父级Id");

                entity.Property(e => e.Sort).HasComment("排序");

                entity.Property(e => e.TenantId)
                    .HasMaxLength(50)
                    .HasComment("租户Id");

                entity.Property(e => e.Type).HasComment("类型,菜单=0,页面=1,权限=2");

                entity.Property(e => e.Url).HasComment("菜单地址");

                entity.Property(e => e.Value).HasComment("权限值");
            });

            modelBuilder.Entity<Base_AppSecret>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .HasComment("自然主键");

                entity.Property(e => e.AppId).HasComment("应用Id");

                entity.Property(e => e.AppName).HasComment("应用名");

                entity.Property(e => e.AppSecret).HasComment("应用密钥");

                entity.Property(e => e.CreateTime).HasComment("创建时间");

                entity.Property(e => e.CreatorId)
                    .HasMaxLength(50)
                    .HasComment("创建人Id");

                entity.Property(e => e.CreatorName)
                    .HasMaxLength(255)
                    .HasComment("创建人");

                entity.Property(e => e.Deleted).HasComment("否已删除");

                entity.Property(e => e.ModifyId)
                    .HasMaxLength(50)
                    .HasComment("修改人Id");

                entity.Property(e => e.ModifyName)
                    .HasMaxLength(255)
                    .HasComment("修改人");

                entity.Property(e => e.ModifyTime).HasComment("修改时间");

                entity.Property(e => e.TenantId)
                    .HasMaxLength(50)
                    .HasComment("租户Id");
            });

            modelBuilder.Entity<Base_DbLink>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .HasComment("自然主键");

                entity.Property(e => e.ConnectionStr).HasComment("连接字符串");

                entity.Property(e => e.CreateTime).HasComment("创建时间");

                entity.Property(e => e.CreatorId)
                    .HasMaxLength(50)
                    .HasComment("创建人Id");

                entity.Property(e => e.CreatorName)
                    .HasMaxLength(255)
                    .HasComment("创建人");

                entity.Property(e => e.DbType).HasComment("数据库类型");

                entity.Property(e => e.Deleted).HasComment("否已删除");

                entity.Property(e => e.LinkName).HasComment("连接名");

                entity.Property(e => e.ModifyId)
                    .HasMaxLength(50)
                    .HasComment("修改人Id");

                entity.Property(e => e.ModifyName)
                    .HasMaxLength(255)
                    .HasComment("修改人");

                entity.Property(e => e.ModifyTime).HasComment("修改时间");

                entity.Property(e => e.TenantId)
                    .HasMaxLength(50)
                    .HasComment("租户Id");
            });

            modelBuilder.Entity<Base_Department>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .HasComment("自然主键");

                entity.Property(e => e.CreateTime).HasComment("创建时间");

                entity.Property(e => e.CreatorId)
                    .HasMaxLength(50)
                    .HasComment("创建人Id");

                entity.Property(e => e.CreatorName)
                    .HasMaxLength(255)
                    .HasComment("创建人");

                entity.Property(e => e.Deleted).HasComment("否已删除");

                entity.Property(e => e.ModifyId)
                    .HasMaxLength(50)
                    .HasComment("修改人Id");

                entity.Property(e => e.ModifyName)
                    .HasMaxLength(255)
                    .HasComment("修改人");

                entity.Property(e => e.ModifyTime).HasComment("修改时间");

                entity.Property(e => e.Name).HasComment("部门名");

                entity.Property(e => e.ParentId).HasComment("上级部门Id");

                entity.Property(e => e.TenantId)
                    .HasMaxLength(50)
                    .HasComment("租户Id");
            });

            modelBuilder.Entity<Base_Role>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .HasComment("自然主键");

                entity.Property(e => e.CreateTime).HasComment("创建时间");

                entity.Property(e => e.CreatorId)
                    .HasMaxLength(50)
                    .HasComment("创建人Id");

                entity.Property(e => e.CreatorName)
                    .HasMaxLength(255)
                    .HasComment("创建人");

                entity.Property(e => e.Deleted).HasComment("否已删除");

                entity.Property(e => e.ModifyId)
                    .HasMaxLength(50)
                    .HasComment("修改人Id");

                entity.Property(e => e.ModifyName)
                    .HasMaxLength(255)
                    .HasComment("修改人");

                entity.Property(e => e.ModifyTime).HasComment("修改时间");

                entity.Property(e => e.RoleName).HasComment("角色名");

                entity.Property(e => e.TenantId)
                    .HasMaxLength(50)
                    .HasComment("租户Id");
            });

            modelBuilder.Entity<Base_RoleAction>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .HasComment("自然主键");

                entity.Property(e => e.ActionId).HasComment("权限Id");

                entity.Property(e => e.CreateTime).HasComment("创建时间");

                entity.Property(e => e.CreatorId)
                    .HasMaxLength(50)
                    .HasComment("创建人Id");

                entity.Property(e => e.CreatorName)
                    .HasMaxLength(255)
                    .HasComment("创建人");

                entity.Property(e => e.Deleted).HasComment("否已删除");

                entity.Property(e => e.ModifyId)
                    .HasMaxLength(50)
                    .HasComment("修改人Id");

                entity.Property(e => e.ModifyName)
                    .HasMaxLength(255)
                    .HasComment("修改人");

                entity.Property(e => e.ModifyTime).HasComment("修改时间");

                entity.Property(e => e.RoleId).HasComment("用户Id");

                entity.Property(e => e.TenantId)
                    .HasMaxLength(50)
                    .HasComment("租户Id");
            });

            modelBuilder.Entity<Base_User>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .HasComment("自然主键");

                entity.Property(e => e.Avatar).HasMaxLength(500);

                entity.Property(e => e.Birthday).HasComment("出生日期");

                entity.Property(e => e.CreateTime).HasComment("创建时间");

                entity.Property(e => e.CreatorId)
                    .HasMaxLength(50)
                    .HasComment("创建人Id");

                entity.Property(e => e.CreatorName)
                    .HasMaxLength(255)
                    .HasComment("创建人");

                entity.Property(e => e.Deleted).HasComment("否已删除");

                entity.Property(e => e.DepartmentId).HasComment("所属部门Id");

                entity.Property(e => e.ModifyId)
                    .HasMaxLength(50)
                    .HasComment("修改人Id");

                entity.Property(e => e.ModifyName)
                    .HasMaxLength(255)
                    .HasComment("修改人");

                entity.Property(e => e.ModifyTime).HasComment("修改时间");

                entity.Property(e => e.Password).HasComment("密码");

                entity.Property(e => e.PhoneNumber).HasMaxLength(255);

                entity.Property(e => e.RealName).HasComment("姓名");

                entity.Property(e => e.Sex).HasComment("性别");

                entity.Property(e => e.TenantId)
                    .HasMaxLength(50)
                    .HasComment("租户Id");

                entity.Property(e => e.UserName).HasComment("用户名");
            });

            modelBuilder.Entity<Base_UserLog>(entity =>
            {
                entity.Property(e => e.Id).HasComment("自然主键");

                entity.Property(e => e.CreateTime).HasComment("创建时间");

                entity.Property(e => e.CreatorId).HasComment("创建人Id");

                entity.Property(e => e.CreatorName).HasComment("创建人姓名");

                entity.Property(e => e.LogContent).HasComment("日志内容");

                entity.Property(e => e.LogType).HasComment("日志类型");
            });

            modelBuilder.Entity<Base_UserRole>(entity =>
            {
                entity.Property(e => e.Id).HasComment("主键");

                entity.Property(e => e.CreateTime).HasComment("创建时间");

                entity.Property(e => e.CreatorId).HasComment("创建人Id");

                entity.Property(e => e.Deleted).HasComment("否已删除");

                entity.Property(e => e.RoleId).HasComment("角色Id");

                entity.Property(e => e.UserId).HasComment("用户Id");
            });

            modelBuilder.Entity<D_UserGroup>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .HasComment("自然主键");

                entity.Property(e => e.Avatar).HasMaxLength(500);

                entity.Property(e => e.CreateTime).HasComment("创建时间");

                entity.Property(e => e.CreatorId)
                    .HasMaxLength(50)
                    .HasComment("创建人Id");

                entity.Property(e => e.CreatorName)
                    .HasMaxLength(255)
                    .HasComment("创建人");

                entity.Property(e => e.Deleted).HasComment("否已删除");

                entity.Property(e => e.ModifyId)
                    .HasMaxLength(50)
                    .HasComment("修改人Id");

                entity.Property(e => e.ModifyName)
                    .HasMaxLength(255)
                    .HasComment("修改人");

                entity.Property(e => e.ModifyTime).HasComment("修改时间");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.TenantId)
                    .HasMaxLength(50)
                    .HasComment("租户Id");

                entity.Property(e => e.Title).HasMaxLength(255);
            });

            modelBuilder.Entity<D_UserMail>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .HasComment("自然主键");

                entity.Property(e => e.CreateTime).HasComment("创建时间");

                entity.Property(e => e.CreatorId)
                    .HasMaxLength(50)
                    .HasComment("创建人Id");

                entity.Property(e => e.CreatorName)
                    .HasMaxLength(255)
                    .HasComment("创建人");

                entity.Property(e => e.Deleted).HasComment("否已删除");

                entity.Property(e => e.ModifyId)
                    .HasMaxLength(50)
                    .HasComment("修改人Id");

                entity.Property(e => e.ModifyName)
                    .HasMaxLength(255)
                    .HasComment("修改人");

                entity.Property(e => e.ModifyTime).HasComment("修改时间");

                entity.Property(e => e.TenantId)
                    .HasMaxLength(50)
                    .HasComment("租户Id");
            });

            modelBuilder.Entity<D_UserMessage>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .HasComment("自然主键");

                entity.Property(e => e.CreateTime).HasComment("创建时间");

                entity.Property(e => e.CreatorId)
                    .HasMaxLength(50)
                    .HasComment("创建人Id");

                entity.Property(e => e.CreatorName)
                    .HasMaxLength(255)
                    .HasComment("创建人");

                entity.Property(e => e.Deleted).HasComment("否已删除");

                entity.Property(e => e.ModifyId)
                    .HasMaxLength(50)
                    .HasComment("修改人Id");

                entity.Property(e => e.ModifyName)
                    .HasMaxLength(255)
                    .HasComment("修改人");

                entity.Property(e => e.ModifyTime).HasComment("修改时间");

                entity.Property(e => e.TenantId)
                    .HasMaxLength(50)
                    .HasComment("租户Id");
            });

            modelBuilder.Entity<D_UserMessage_202103>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .HasComment("自然主键");

                entity.Property(e => e.CreateTime).HasComment("创建时间");

                entity.Property(e => e.CreatorId)
                    .HasMaxLength(50)
                    .HasComment("创建人Id");

                entity.Property(e => e.CreatorName)
                    .HasMaxLength(255)
                    .HasComment("创建人");

                entity.Property(e => e.Deleted).HasComment("否已删除");

                entity.Property(e => e.ModifyId)
                    .HasMaxLength(50)
                    .HasComment("修改人Id");

                entity.Property(e => e.ModifyName)
                    .HasMaxLength(255)
                    .HasComment("修改人");

                entity.Property(e => e.ModifyTime).HasComment("修改时间");

                entity.Property(e => e.TenantId)
                    .HasMaxLength(50)
                    .HasComment("租户Id");
            });

            modelBuilder.Entity<D_UserMessage_202104>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .HasComment("自然主键");

                entity.Property(e => e.CreateTime).HasComment("创建时间");

                entity.Property(e => e.CreatorId)
                    .HasMaxLength(50)
                    .HasComment("创建人Id");

                entity.Property(e => e.CreatorName)
                    .HasMaxLength(255)
                    .HasComment("创建人");

                entity.Property(e => e.Deleted).HasComment("否已删除");

                entity.Property(e => e.ModifyId)
                    .HasMaxLength(50)
                    .HasComment("修改人Id");

                entity.Property(e => e.ModifyName)
                    .HasMaxLength(255)
                    .HasComment("修改人");

                entity.Property(e => e.ModifyTime).HasComment("修改时间");

                entity.Property(e => e.TenantId)
                    .HasMaxLength(50)
                    .HasComment("租户Id");
            });

            modelBuilder.Entity<Event>(entity =>
            {
                entity.HasKey(e => e.PersistenceId);

                entity.ToTable("Event", "wfc");

                entity.HasIndex(e => e.EventId)
                    .IsUnique()
                    .HasFilter("([EventId] IS NOT NULL)");

                entity.HasIndex(e => e.EventTime);

                entity.HasIndex(e => e.IsProcessed);

                entity.HasIndex(e => new { e.EventName, e.EventKey });

                entity.Property(e => e.EventKey).HasMaxLength(200);

                entity.Property(e => e.EventName).HasMaxLength(200);
            });

            modelBuilder.Entity<ExecutionError>(entity =>
            {
                entity.HasKey(e => e.PersistenceId);

                entity.ToTable("ExecutionError", "wfc");

                entity.Property(e => e.ExecutionPointerId).HasMaxLength(100);

                entity.Property(e => e.WorkflowId).HasMaxLength(100);
            });

            modelBuilder.Entity<ExecutionPointer>(entity =>
            {
                entity.HasKey(e => e.PersistenceId);

                entity.ToTable("ExecutionPointer", "wfc");

                entity.HasIndex(e => e.WorkflowId);

                entity.Property(e => e.EventKey).HasMaxLength(100);

                entity.Property(e => e.EventName).HasMaxLength(100);

                entity.Property(e => e.Id).HasMaxLength(50);

                entity.Property(e => e.PredecessorId).HasMaxLength(100);

                entity.Property(e => e.StepName).HasMaxLength(100);

                entity.HasOne(d => d.Workflow)
                    .WithMany(p => p.ExecutionPointer)
                    .HasForeignKey(d => d.WorkflowId);
            });

            modelBuilder.Entity<ExtensionAttribute>(entity =>
            {
                entity.HasKey(e => e.PersistenceId);

                entity.ToTable("ExtensionAttribute", "wfc");

                entity.HasIndex(e => e.ExecutionPointerId);

                entity.Property(e => e.AttributeKey).HasMaxLength(100);

                entity.HasOne(d => d.ExecutionPointer)
                    .WithMany(p => p.ExtensionAttribute)
                    .HasForeignKey(d => d.ExecutionPointerId);
            });

            modelBuilder.Entity<OA_DefForm>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .HasComment("自然主键");

                entity.Property(e => e.CreateTime).HasComment("创建时间");

                entity.Property(e => e.CreatorId)
                    .HasMaxLength(50)
                    .HasComment("创建人Id");

                entity.Property(e => e.CreatorName)
                    .HasMaxLength(255)
                    .HasComment("创建人");

                entity.Property(e => e.Deleted).HasComment("否已删除");

                entity.Property(e => e.JSONId).HasMaxLength(50);

                entity.Property(e => e.ModifyId)
                    .HasMaxLength(50)
                    .HasComment("修改人Id");

                entity.Property(e => e.ModifyName)
                    .HasMaxLength(255)
                    .HasComment("修改人");

                entity.Property(e => e.ModifyTime).HasComment("修改时间");

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.TenantId)
                    .HasMaxLength(50)
                    .HasComment("租户Id");

                entity.Property(e => e.Type).HasMaxLength(50);

                entity.Property(e => e.Value)
                    .HasMaxLength(500)
                    .HasComment("权限值");
            });

            modelBuilder.Entity<OA_DefType>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .HasComment("自然主键");

                entity.Property(e => e.CreateTime).HasComment("创建时间");

                entity.Property(e => e.CreatorId)
                    .HasMaxLength(50)
                    .HasComment("创建人Id");

                entity.Property(e => e.CreatorName)
                    .HasMaxLength(255)
                    .HasComment("创建人");

                entity.Property(e => e.Deleted).HasComment("否已删除");

                entity.Property(e => e.ModifyId)
                    .HasMaxLength(50)
                    .HasComment("修改人Id");

                entity.Property(e => e.ModifyName)
                    .HasMaxLength(255)
                    .HasComment("修改人");

                entity.Property(e => e.ModifyTime).HasComment("修改时间");

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.TenantId)
                    .HasMaxLength(50)
                    .HasComment("租户Id");

                entity.Property(e => e.Type).HasMaxLength(50);

                entity.Property(e => e.Unit).HasMaxLength(50);
            });

            modelBuilder.Entity<OA_UserForm>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .HasComment("自然主键");

                entity.Property(e => e.ApplicantDepartment).HasMaxLength(255);

                entity.Property(e => e.ApplicantDepartmentId).HasMaxLength(50);

                entity.Property(e => e.ApplicantRole).HasMaxLength(255);

                entity.Property(e => e.ApplicantRoleId).HasMaxLength(50);

                entity.Property(e => e.ApplicantUser).HasMaxLength(255);

                entity.Property(e => e.ApplicantUserId).HasMaxLength(50);

                entity.Property(e => e.CreateTime).HasComment("创建时间");

                entity.Property(e => e.CreatorId)
                    .HasMaxLength(50)
                    .HasComment("创建人Id");

                entity.Property(e => e.CreatorName)
                    .HasMaxLength(255)
                    .HasComment("创建人");

                entity.Property(e => e.CurrentNode).HasMaxLength(500);

                entity.Property(e => e.DefFormId).HasMaxLength(50);

                entity.Property(e => e.DefFormJsonId).HasMaxLength(50);

                entity.Property(e => e.DefFormName).HasMaxLength(255);

                entity.Property(e => e.Deleted).HasComment("否已删除");

                entity.Property(e => e.ModifyId)
                    .HasMaxLength(50)
                    .HasComment("修改人Id");

                entity.Property(e => e.ModifyName)
                    .HasMaxLength(255)
                    .HasComment("修改人");

                entity.Property(e => e.ModifyTime).HasComment("修改时间");

                entity.Property(e => e.SubType).HasMaxLength(50);

                entity.Property(e => e.TenantId)
                    .HasMaxLength(50)
                    .HasComment("租户Id");

                entity.Property(e => e.Type).HasMaxLength(50);

                entity.Property(e => e.Unit).HasMaxLength(50);
            });

            modelBuilder.Entity<OA_UserFormStep>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .HasComment("自然主键");

                entity.Property(e => e.CreateTime).HasComment("创建时间");

                entity.Property(e => e.CreatorId)
                    .HasMaxLength(50)
                    .HasComment("创建人Id");

                entity.Property(e => e.CreatorName)
                    .HasMaxLength(255)
                    .HasComment("创建人");

                entity.Property(e => e.Deleted).HasComment("否已删除");

                entity.Property(e => e.ModifyId)
                    .HasMaxLength(50)
                    .HasComment("修改人Id");

                entity.Property(e => e.ModifyName)
                    .HasMaxLength(255)
                    .HasComment("修改人");

                entity.Property(e => e.ModifyTime).HasComment("修改时间");

                entity.Property(e => e.TenantId)
                    .HasMaxLength(50)
                    .HasComment("租户Id");

                entity.Property(e => e.UserFormId).HasMaxLength(50);
            });

            modelBuilder.Entity<Quartz_Task>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .HasComment("自然主键");

                entity.Property(e => e.ApiUrl).HasMaxLength(500);

                entity.Property(e => e.AuthKey).HasMaxLength(50);

                entity.Property(e => e.AuthValue).HasMaxLength(500);

                entity.Property(e => e.CreateTime).HasComment("创建时间");

                entity.Property(e => e.CreatorId)
                    .HasMaxLength(50)
                    .HasComment("创建人Id");

                entity.Property(e => e.CreatorName)
                    .HasMaxLength(255)
                    .HasComment("创建人");

                entity.Property(e => e.Deleted).HasComment("否已删除");

                entity.Property(e => e.Describe).HasMaxLength(500);

                entity.Property(e => e.GroupName).HasMaxLength(255);

                entity.Property(e => e.Interval).HasMaxLength(50);

                entity.Property(e => e.ModifyId)
                    .HasMaxLength(50)
                    .HasComment("修改人Id");

                entity.Property(e => e.ModifyName)
                    .HasMaxLength(255)
                    .HasComment("修改人");

                entity.Property(e => e.ModifyTime).HasComment("修改时间");

                entity.Property(e => e.RequestType).HasMaxLength(50);

                entity.Property(e => e.TaskName).HasMaxLength(255);

                entity.Property(e => e.TenantId)
                    .HasMaxLength(50)
                    .HasComment("租户Id");
            });

            modelBuilder.Entity<Subscription>(entity =>
            {
                entity.HasKey(e => e.PersistenceId);

                entity.ToTable("Subscription", "wfc");

                entity.HasIndex(e => e.EventKey);

                entity.HasIndex(e => e.EventName);

                entity.HasIndex(e => e.SubscriptionId)
                    .IsUnique()
                    .HasFilter("([SubscriptionId] IS NOT NULL)");

                entity.Property(e => e.EventKey).HasMaxLength(200);

                entity.Property(e => e.EventName).HasMaxLength(200);

                entity.Property(e => e.ExecutionPointerId).HasMaxLength(200);

                entity.Property(e => e.ExternalToken).HasMaxLength(200);

                entity.Property(e => e.ExternalWorkerId).HasMaxLength(200);

                entity.Property(e => e.SubscribeAsOf).HasDefaultValueSql("('0001-01-01T00:00:00.0000000')");

                entity.Property(e => e.WorkflowId).HasMaxLength(200);
            });

            modelBuilder.Entity<Workflow>(entity =>
            {
                entity.HasKey(e => e.PersistenceId);

                entity.ToTable("Workflow", "wfc");

                entity.HasIndex(e => e.InstanceId)
                    .IsUnique()
                    .HasFilter("([InstanceId] IS NOT NULL)");

                entity.HasIndex(e => e.NextExecution);

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.Reference).HasMaxLength(200);

                entity.Property(e => e.WorkflowDefinitionId).HasMaxLength(200);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
