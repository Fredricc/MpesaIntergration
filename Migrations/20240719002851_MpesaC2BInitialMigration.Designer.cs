﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MpesaIntergration.Data;

#nullable disable

namespace MpesaIntergration.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240719002851_MpesaC2BInitialMigration")]
    partial class MpesaC2BInitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0-preview.6.24327.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MpesaIntergration.Models.MpesaC2B", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("BillRefNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BusinessShortCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MSISDN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiddleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OrgAccountBalance")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ThirdPartyTransID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TransAmount")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TransID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TransTime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TransactionType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("created_at")
                        .HasColumnType("datetime2");

                    b.HasKey("id");

                    b.ToTable("MpesaC2Bs");
                });
#pragma warning restore 612, 618
        }
    }
}
