using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using MasterWebApiCore;

namespace MasterWebApiCore.Migrations
{
    [DbContext(typeof(SecurityContext))]
    partial class SecurityContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MasterWebApiCore.Server.Models.Batch", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("Acedemic_Year");

                    b.Property<string>("App_Status");

                    b.Property<string>("Batch_Name");

                    b.Property<int?>("Course_Id");

                    b.Property<DateTime?>("Created_Date");

                    b.Property<string>("Del_Status");

                    b.Property<string>("Description");

                    b.Property<DateTime?>("EndDate");

                    b.Property<DateTime?>("StartDate");

                    b.HasKey("Id");

                    b.ToTable("Batchs");
                });

            modelBuilder.Entity("MasterWebApiCore.Server.Models.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("App_Status");

                    b.Property<string>("Course_Name");

                    b.Property<string>("Del_Status");

                    b.Property<string>("Description");

                    b.HasKey("Id");

                    b.ToTable("Courses");
                });
        }
    }
}
