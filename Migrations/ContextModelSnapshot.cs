﻿// <auto-generated />
using System;
using CoreDepartman.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CoreDepartman.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CoreDepartman.Models.departmanlar", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("departmanad");

                    b.HasKey("id");

                    b.ToTable("departmanlars");
                });

            modelBuilder.Entity("CoreDepartman.Models.personel", b =>
                {
                    b.Property<int>("perid")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ad");

                    b.Property<int?>("departid");

                    b.Property<string>("sehir");

                    b.Property<string>("soyad");

                    b.HasKey("perid");

                    b.HasIndex("departid");

                    b.ToTable("personels");
                });

            modelBuilder.Entity("CoreDepartman.Models.personel", b =>
                {
                    b.HasOne("CoreDepartman.Models.departmanlar", "depart")
                        .WithMany("personels")
                        .HasForeignKey("departid");
                });
#pragma warning restore 612, 618
        }
    }
}
