﻿// <auto-generated />
using System;
using DotnetMinimalApiStarter.WebApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DotnetMinimalApiStarter.WebApi.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.0");

            modelBuilder.Entity("DotnetMinimalApiStarter.WebApi.Modules.Tags.Core.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("DotnetMinimalApiStarter.WebApi.Modules.Trainings.Core.Training", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<int?>("Distance")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Duration")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int?>("TagId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("TagId");

                    b.ToTable("Trainings");
                });

            modelBuilder.Entity("DotnetMinimalApiStarter.WebApi.Modules.Trainings.Core.Training", b =>
                {
                    b.HasOne("DotnetMinimalApiStarter.WebApi.Modules.Tags.Core.Tag", "Tag")
                        .WithMany("Trainings")
                        .HasForeignKey("TagId");

                    b.Navigation("Tag");
                });

            modelBuilder.Entity("DotnetMinimalApiStarter.WebApi.Modules.Tags.Core.Tag", b =>
                {
                    b.Navigation("Trainings");
                });
#pragma warning restore 612, 618
        }
    }
}
