﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NguyenVanSon_02.Data;

#nullable disable

namespace NguyenVanSon_02.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230804034236_Create_Table_NguyenVanSonDb")]
    partial class Create_Table_NguyenVanSonDb
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.9");

            modelBuilder.Entity("NguyenVanSon_02.Models.NguyenVanSonDb", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("NguyenVanSonDb");
                });
#pragma warning restore 612, 618
        }
    }
}