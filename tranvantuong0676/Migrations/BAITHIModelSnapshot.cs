﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace tranvantuong0676.Migrations
{
    [DbContext(typeof(BAITHI))]
    partial class BAITHIModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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