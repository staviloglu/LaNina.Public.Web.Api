﻿// <auto-generated />
using Lanina.Public.Web.Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Lanina.Public.Web.Api.Migrations.FlagMigrations
{
    [DbContext(typeof(LaNinaFlagDbContext))]
    [Migration("20190831070914_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity("Lanina.Public.Web.Api.Models.Flag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Value");

                    b.HasKey("Id");

                    b.ToTable("Flags");
                });
#pragma warning restore 612, 618
        }
    }
}
