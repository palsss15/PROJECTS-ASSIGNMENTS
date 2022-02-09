﻿// <auto-generated />
using JobPortalCore.DAL.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace JobPortalCore.DAL.Migrations
{
    [DbContext(typeof(JobDbContext))]
    [Migration("20220208084851_candidate")]
    partial class candidate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("JobPortalCore.Entity.Models.CandidateLogin", b =>
                {
                    b.Property<string>("EmailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmailId");

                    b.ToTable("candidateLogin");
                });

            modelBuilder.Entity("JobPortalCore.Entity.Models.CandidateRegister", b =>
                {
                    b.Property<int>("CandidateId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ConfirmPassword")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmailId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Firstname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lastname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MobNumber")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QualificationDeg")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TechnicalSkills")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CandidateId");

                    b.ToTable("candidateRegister");
                });

            modelBuilder.Entity("JobPortalCore.Entity.Models.EmployeeDetails", b =>
                {
                    b.Property<int>("ContactId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConfirmPassword")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ContactNum")
                        .HasColumnType("int");

                    b.Property<string>("EmailId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmpName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ContactId");

                    b.ToTable("employeeDetails");
                });

            modelBuilder.Entity("JobPortalCoreApi.Entity.Models.JobDetails", b =>
                {
                    b.Property<int>("Jobid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Companyname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ContactId")
                        .HasColumnType("int");

                    b.Property<string>("Joblocation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Jobtitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Qualifications")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Technicalskills")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Jobid");

                    b.HasIndex("ContactId");

                    b.ToTable("jobs");
                });

            modelBuilder.Entity("JobPortalCoreApi.Entity.Models.JobDetails", b =>
                {
                    b.HasOne("JobPortalCore.Entity.Models.EmployeeDetails", "employeedetails")
                        .WithMany()
                        .HasForeignKey("ContactId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("employeedetails");
                });
#pragma warning restore 612, 618
        }
    }
}
