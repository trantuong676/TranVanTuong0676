﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace tranvantuong0676.Migrations
{
    [DbContext(typeof(BAITHI))]
    [Migration("20230623013943_create_table_TVTstudent")]
    partial class create_table_TVTstudent
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.5");

            modelBuilder.Entity("TRANVANTUONG0676.Models.TVTstudent", b =>
                {
                    b.Property<string>("TVTstudentID")
                        .HasColumnType("TEXT");

                    b.Property<string>("TVTStudentSex")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("TVTstudentName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("TVTstudentID");

                    b.ToTable("TVTstudent");
                });
#pragma warning restore 612, 618
        }
    }
}
