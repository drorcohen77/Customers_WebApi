﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApi.Data;

#nullable disable

namespace WebApi.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20221229140107_fixingGroupEntity3")]
    partial class fixingGroupEntity3
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebApi.Models.Customer", b =>
                {
                    b.Property<string>("customerId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("customerId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("WebApi.Models.FactoriesToCustomer", b =>
                {
                    b.Property<int>("groupCode")
                        .HasColumnType("int");

                    b.Property<string>("customerId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("factoryCode")
                        .HasColumnType("int");

                    b.HasKey("groupCode");

                    b.HasIndex("customerId");

                    b.HasIndex("factoryCode");

                    b.ToTable("FactoriesToCustomer");
                });

            modelBuilder.Entity("WebApi.Models.Factory", b =>
                {
                    b.Property<int>("factoryCode")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("factoryCode"));

                    b.Property<string>("factoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("groupCode")
                        .HasColumnType("int");

                    b.Property<int?>("groupCode1")
                        .HasColumnType("int");

                    b.HasKey("factoryCode");

                    b.HasIndex("groupCode1");

                    b.ToTable("Factories");
                });

            modelBuilder.Entity("WebApi.Models.Group", b =>
                {
                    b.Property<int>("groupCode")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("groupCode"));

                    b.Property<string>("groupName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("groupCode");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("WebApi.Models.FactoriesToCustomer", b =>
                {
                    b.HasOne("WebApi.Models.Customer", "customers")
                        .WithMany("FactoriesToCustomer")
                        .HasForeignKey("customerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApi.Models.Factory", "factories")
                        .WithMany("FactoriesToCustomer")
                        .HasForeignKey("factoryCode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApi.Models.Group", "groups")
                        .WithMany("FactoriesToCustomer")
                        .HasForeignKey("groupCode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("customers");

                    b.Navigation("factories");

                    b.Navigation("groups");
                });

            modelBuilder.Entity("WebApi.Models.Factory", b =>
                {
                    b.HasOne("WebApi.Models.Group", "group")
                        .WithMany()
                        .HasForeignKey("groupCode1");

                    b.Navigation("group");
                });

            modelBuilder.Entity("WebApi.Models.Customer", b =>
                {
                    b.Navigation("FactoriesToCustomer");
                });

            modelBuilder.Entity("WebApi.Models.Factory", b =>
                {
                    b.Navigation("FactoriesToCustomer");
                });

            modelBuilder.Entity("WebApi.Models.Group", b =>
                {
                    b.Navigation("FactoriesToCustomer");
                });
#pragma warning restore 612, 618
        }
    }
}
