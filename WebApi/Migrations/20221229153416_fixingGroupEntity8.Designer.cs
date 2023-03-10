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
    [Migration("20221229153416_fixingGroupEntity8")]
    partial class fixingGroupEntity8
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
                    b.Property<int>("GroupCode")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GroupCode"));

                    b.Property<string>("CustomerId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("FactoryCode")
                        .HasColumnType("int");

                    b.Property<int?>("FactoryCode1")
                        .HasColumnType("int");

                    b.Property<int?>("GroupCode1")
                        .HasColumnType("int");

                    b.HasKey("GroupCode");

                    b.HasIndex("CustomerId");

                    b.HasIndex("FactoryCode1");

                    b.HasIndex("GroupCode1");

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

                    b.Property<int?>("GroupCode1")
                        .HasColumnType("int");

                    b.HasKey("FactoryCode");

                    b.HasIndex("GroupCode1");

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
                        .HasForeignKey("FactoryCode1");

                    b.HasOne("WebApi.Models.Group", "Group")
                        .WithMany()
                        .HasForeignKey("GroupCode1");

                    b.Navigation("Customer");

                    b.Navigation("Factory");

                    b.Navigation("Group");
                });

            modelBuilder.Entity("WebApi.Models.Factory", b =>
                {
                    b.HasOne("WebApi.Models.Group", "Group")
                        .WithMany()
                        .HasForeignKey("GroupCode1");

                    b.Navigation("Group");
                });
#pragma warning restore 612, 618
        }
    }
}
