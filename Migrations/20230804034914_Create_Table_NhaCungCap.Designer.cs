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
    [Migration("20230804034914_Create_Table_NhaCungCap")]
    partial class Create_Table_NhaCungCap
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

            modelBuilder.Entity("NguyenVanSon_02.Models.NhaCungCap", b =>
                {
                    b.Property<string>("MaNCC")
                        .HasColumnType("TEXT");

                    b.Property<string>("TenNCC")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("MaNCC");

                    b.ToTable("NhaCungCap");
                });
#pragma warning restore 612, 618
        }
    }
}
