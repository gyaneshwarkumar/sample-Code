using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using OA.Repo;

namespace Repositories.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20171018111333_MyMigration11")]
    partial class MyMigration11
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OA.Data.Cours", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("App_Status");

                    b.Property<string>("Course_Name");

                    b.Property<string>("Del_Status");

                    b.Property<string>("Description");

                    b.HasKey("Id");

                    b.ToTable("Courss");
                });

            modelBuilder.Entity("OA.Data.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("OA.Data.UserProfile", b =>
                {
                    b.Property<long>("Id");

                    b.Property<string>("Address");

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("UserProfiles");
                });

            modelBuilder.Entity("OA.Data.UserProfile", b =>
                {
                    b.HasOne("OA.Data.User", "User")
                        .WithOne("UserProfile")
                        .HasForeignKey("OA.Data.UserProfile", "Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
