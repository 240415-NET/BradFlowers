﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjectOneApi.DataAccessLayer;

#nullable disable

namespace ProjectOneApi.Migrations
{
    [DbContext(typeof(ProjectOneApiContext))]
    [Migration("20240626184828_BloodPressureTrackerEfAsp")]
    partial class BloodPressureTrackerEfAsp
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseCollation("SQL_Latin1_General_CP1_CS_AS")
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ProjectOneApi.Models.BloodPressureRecord", b =>
                {
                    b.Property<Guid>("ReadingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("Diastolic")
                        .HasColumnType("int");

                    b.Property<int>("Pulse")
                        .HasColumnType("int");

                    b.Property<int>("Systolic")
                        .HasColumnType("int");

                    b.Property<Guid>("UserProfileUserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ReadingId");

                    b.HasIndex("UserProfileUserId");

                    b.ToTable("BloodPressureRecords", (string)null);

                    b.UseTpcMappingStrategy();
                });

            modelBuilder.Entity("ProjectOneApi.Models.UserProfile", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("UserProfiles", (string)null);
                });

            modelBuilder.Entity("ProjectOneApi.Models.BloodPressureRecord", b =>
                {
                    b.HasOne("ProjectOneApi.Models.UserProfile", "UserProfile")
                        .WithMany()
                        .HasForeignKey("UserProfileUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserProfile");
                });
#pragma warning restore 612, 618
        }
    }
}
