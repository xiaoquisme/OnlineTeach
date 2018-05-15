﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using OnlineTeach.Web.Data;
using OnlineTeach.Web.Models.AdultViewModels;
using System;

namespace OnlineTeach.Web.Data.Migrations
{
    [DbContext(typeof(AdultDbContext))]
    [Migration("20180515082406_AdultMigration")]
    partial class AdultMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OnlineTeach.Web.Data.Adult.TeacherApply", b =>
                {
                    b.Property<long>("key")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ApplyCount");

                    b.Property<string>("ApplyReason");

                    b.Property<int>("ApplyStatus");

                    b.Property<DateTime>("ApplyTime");

                    b.Property<string>("Name");

                    b.Property<string>("RealName");

                    b.Property<string>("School");

                    b.HasKey("key");

                    b.ToTable("TeacherApplies");
                });

            modelBuilder.Entity("OnlineTeach.Web.Models.AdultViewModels.TeacherApplyViewModel", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ApplyCount");

                    b.Property<string>("ApplyReason");

                    b.Property<int>("ApplyStatus");

                    b.Property<DateTime>("ApplyTime");

                    b.Property<string>("Name");

                    b.Property<string>("RealName");

                    b.Property<string>("School");

                    b.HasKey("Id");

                    b.ToTable("TeacherApplyViewModel");
                });

            modelBuilder.Entity("OnlineTeach.Web.Models.ManageViewModels.ChangeToTeacherViewModel", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ApplyReason")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("RealName")
                        .IsRequired();

                    b.Property<string>("School")
                        .IsRequired();

                    b.Property<string>("StatusMessage");

                    b.HasKey("Id");

                    b.ToTable("ChangeToTeacherViewModel");
                });
#pragma warning restore 612, 618
        }
    }
}
