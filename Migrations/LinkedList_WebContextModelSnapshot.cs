﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LinkedList_Web.Migrations
{
    [DbContext(typeof(LinkedList_WebContext))]
    partial class LinkedList_WebContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("LinkedList_Web.Models.Text", b =>
                {
                    b.Property<int>("IdText")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Elementos")
                        .HasColumnType("int");

                    b.HasKey("IdText");

                    b.ToTable("Text");
                });
#pragma warning restore 612, 618
        }
    }
}