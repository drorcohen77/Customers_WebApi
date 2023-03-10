// <auto-generated />
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
    [Migration("20221229155203_fixingFactoriesToCustomer")]
    partial class fixingFactoriesToCustomer
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
                    b.Property<string>("CustomerId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("WebApi.Models.FactoriesToCustomer", b =>
                {
                    b.Property<string>("CustomerId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("FactoryCode")
                        .HasColumnType("int");

                    b.Property<int>("GroupCode")
                        .HasColumnType("int");

                    b.HasIndex("CustomerId");

                    b.HasIndex("FactoryCode");

                    b.HasIndex("GroupCode");

                    b.ToTable("FactoriesToCustomer");
                });

            modelBuilder.Entity("WebApi.Models.Factory", b =>
                {
                    b.Property<int>("FactoryCode")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FactoryCode"));

                    b.Property<string>("FactoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GroupCode")
                        .HasColumnType("int");

                    b.Property<int?>("GroupCode")
                        .HasColumnType("int");

                    b.HasKey("FactoryCode");

                    b.HasIndex("GroupCode");

                    b.ToTable("Factories");
                });

            modelBuilder.Entity("WebApi.Models.Group", b =>
                {
                    b.Property<int>("GroupCode")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GroupCode"));

                    b.Property<string>("GroupName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GroupCode");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("WebApi.Models.FactoriesToCustomer", b =>
                {
                    b.HasOne("WebApi.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApi.Models.Factory", "Factory")
                        .WithMany()
                        .HasForeignKey("FactoryCode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApi.Models.Group", "Group")
                        .WithMany()
                        .HasForeignKey("GroupCode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Factory");

                    b.Navigation("Group");
                });

            modelBuilder.Entity("WebApi.Models.Factory", b =>
                {
                    b.HasOne("WebApi.Models.Group", "Group")
                        .WithMany()
                        .HasForeignKey("GroupCode");

                    b.Navigation("Group");
                });
#pragma warning restore 612, 618
        }
    }
}
