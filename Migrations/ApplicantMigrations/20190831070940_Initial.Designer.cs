﻿// <auto-generated />
using System;
using Lanina.Public.Web.Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Lanina.Public.Web.Api.Migrations.ApplicantMigrations
{
    [DbContext(typeof(LaNinaApplicantDbContext))]
    [Migration("20190831070940_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity("Lanina.Public.Web.Api.Models.Applicant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CoverLetter");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("EmailConfirmationKey");

                    b.Property<string>("Flag");

                    b.Property<string>("Github");

                    b.Property<bool>("IsEmailConfirmed");

                    b.Property<bool>("IsMobilePhoneConfirmed");

                    b.Property<bool>("IsReminderSent");

                    b.Property<string>("Key")
                        .IsRequired();

                    b.Property<string>("Linkedin");

                    b.Property<string>("MobilePhone")
                        .IsRequired();

                    b.Property<string>("MobilePhoneConfirmationKey");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("RejectReason");

                    b.Property<int>("Status");

                    b.Property<string>("Surname")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Applicants");
                });

            modelBuilder.Entity("Lanina.Public.Web.Api.Models.ApplyToken", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Value")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("ApplyTokens");
                });

            modelBuilder.Entity("Lanina.Public.Web.Api.Models.Interview", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ApplicantId");

                    b.Property<bool>("IsApprovedForToday");

                    b.Property<int?>("KoplanetReservationId");

                    b.Property<string>("MeetingRoomName");

                    b.HasKey("Id");

                    b.HasIndex("ApplicantId");

                    b.ToTable("Interviews");
                });

            modelBuilder.Entity("Lanina.Public.Web.Api.Models.InterviewDate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Date");

                    b.Property<int?>("InterviewId");

                    b.Property<string>("Key")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("InterviewId")
                        .IsUnique();

                    b.ToTable("InterviewDates");
                });

            modelBuilder.Entity("Lanina.Public.Web.Api.Models.Interview", b =>
                {
                    b.HasOne("Lanina.Public.Web.Api.Models.Applicant", "Applicant")
                        .WithMany("Interviews")
                        .HasForeignKey("ApplicantId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Lanina.Public.Web.Api.Models.InterviewDate", b =>
                {
                    b.HasOne("Lanina.Public.Web.Api.Models.Interview", "Interview")
                        .WithOne("InterviewDate")
                        .HasForeignKey("Lanina.Public.Web.Api.Models.InterviewDate", "InterviewId");
                });
#pragma warning restore 612, 618
        }
    }
}