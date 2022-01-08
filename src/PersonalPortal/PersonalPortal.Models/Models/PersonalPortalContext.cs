using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PersonalPortal.Models.Models
{
    public partial class PersonalPortalContext : DbContext
    {
        public PersonalPortalContext()
        {
        }

        public PersonalPortalContext(DbContextOptions<PersonalPortalContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BulletPoint> BulletPoints { get; set; } = null!;
        public virtual DbSet<ContentCategory> ContentCategories { get; set; } = null!;
        public virtual DbSet<ContentIdea> ContentIdeas { get; set; } = null!;
        public virtual DbSet<ContentIdeaCategoryMedium> ContentIdeaCategoryMedia { get; set; } = null!;
        public virtual DbSet<ContentMedium> ContentMedia { get; set; } = null!;
        public virtual DbSet<EducationInfo> EducationInfos { get; set; } = null!;
        public virtual DbSet<Interest> Interests { get; set; } = null!;
        public virtual DbSet<Job> Jobs { get; set; } = null!;
        public virtual DbSet<Plan> Plans { get; set; } = null!;
        public virtual DbSet<Platform> Platforms { get; set; } = null!;
        public virtual DbSet<Project> Projects { get; set; } = null!;
        public virtual DbSet<ProjectCategory> ProjectCategories { get; set; } = null!;
        public virtual DbSet<ProjectType> ProjectTypes { get; set; } = null!;
        public virtual DbSet<Resource> Resources { get; set; } = null!;
        public virtual DbSet<ResourceCategory> ResourceCategories { get; set; } = null!;
        public virtual DbSet<ResourceType> ResourceTypes { get; set; } = null!;
        public virtual DbSet<Resume> Resumes { get; set; } = null!;
        public virtual DbSet<Skill> Skills { get; set; } = null!;
        public virtual DbSet<StaticResource> StaticResources { get; set; } = null!;
        public virtual DbSet<StaticResourceType> StaticResourceTypes { get; set; } = null!;
        public virtual DbSet<Step> Steps { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=localhost;Database=PersonalPortal;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BulletPoint>(entity =>
            {
                entity.HasKey(e => new { e.BulletPointId, e.JobId });

                entity.ToTable("BulletPoint");

                entity.Property(e => e.BulletPointDescription).IsUnicode(false);

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.BulletPoints)
                    .HasForeignKey(d => d.JobId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BulletPoint_Job");
            });

            modelBuilder.Entity<ContentCategory>(entity =>
            {
                entity.ToTable("ContentCategory");

                entity.Property(e => e.ContentCategoryId).ValueGeneratedNever();

                entity.Property(e => e.ContentCategoryDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ContentCategoryName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ContentIdea>(entity =>
            {
                entity.ToTable("ContentIdea");

                entity.Property(e => e.ContentIdeaId).ValueGeneratedNever();

                entity.Property(e => e.ContentIdeaDescription).IsUnicode(false);

                entity.Property(e => e.ContentIdeaName)
                    .HasMaxLength(70)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ContentIdeaCategoryMedium>(entity =>
            {
                entity.HasKey(e => new { e.ContentIdeaId, e.ContentCategoryId, e.ContentMediumId });

                entity.ToTable("ContentIdeaCategoryMedium");

                entity.HasOne(d => d.ContentCategory)
                    .WithMany(p => p.ContentIdeaCategoryMedia)
                    .HasForeignKey(d => d.ContentCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ContentIdeaCategoryMedium_ContentCategory");

                entity.HasOne(d => d.ContentIdea)
                    .WithMany(p => p.ContentIdeaCategoryMedia)
                    .HasForeignKey(d => d.ContentIdeaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ContentIdeaCategoryMedium_ContentIdea");

                entity.HasOne(d => d.ContentMedium)
                    .WithMany(p => p.ContentIdeaCategoryMedia)
                    .HasForeignKey(d => d.ContentMediumId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ContentIdeaCategoryMedium_ContentMedium");
            });

            modelBuilder.Entity<ContentMedium>(entity =>
            {
                entity.ToTable("ContentMedium");

                entity.Property(e => e.ContentMediumId).ValueGeneratedNever();

                entity.Property(e => e.ContentMediumDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ContentMediumName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EducationInfo>(entity =>
            {
                entity.ToTable("EducationInfo");

                entity.Property(e => e.EducationInfoId).ValueGeneratedNever();

                entity.Property(e => e.DegreeObtained)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.SchoolName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate).HasColumnType("date");
            });

            modelBuilder.Entity<Interest>(entity =>
            {
                entity.ToTable("Interest");

                entity.Property(e => e.InterestId).ValueGeneratedNever();

                entity.Property(e => e.InterestName)
                    .HasMaxLength(70)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Job>(entity =>
            {
                entity.ToTable("Job");

                entity.Property(e => e.JobId).ValueGeneratedNever();

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.JobEndDate).HasColumnType("datetime");

                entity.Property(e => e.JobStartDate).HasColumnType("datetime");

                entity.Property(e => e.JobTitle)
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.Location)
                    .HasMaxLength(70)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Plan>(entity =>
            {
                entity.ToTable("Plan");

                entity.Property(e => e.PlanId).ValueGeneratedNever();

                entity.Property(e => e.PlanDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.PlanName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PlanStartDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Platform>(entity =>
            {
                entity.ToTable("Platform");

                entity.Property(e => e.PlatformId).ValueGeneratedNever();

                entity.Property(e => e.PlatformBaseUrl)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PlatformDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.PlatformName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Project>(entity =>
            {
                entity.ToTable("Project");

                entity.Property(e => e.ProjectId).ValueGeneratedNever();

                entity.Property(e => e.ProjectDescription).IsUnicode(false);

                entity.Property(e => e.ProjectName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasMany(d => d.Projects)
                    .WithMany(p => p.Projects)
                    .UsingEntity<Dictionary<string, object>>(
                        "ProjectCategoryType",
                        l => l.HasOne<ProjectCategory>().WithMany().HasForeignKey("ProjectCategoryId", "ProjectTypeId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_ProjectCategoryType_ProjectCategory"),
                        r => r.HasOne<Project>().WithMany().HasForeignKey("ProjectId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_ProjectCategoryType_Project"),
                        j =>
                        {
                            j.HasKey("ProjectId", "ProjectCategoryId", "ProjectTypeId");

                            j.ToTable("ProjectCategoryType");
                        });
            });

            modelBuilder.Entity<ProjectCategory>(entity =>
            {
                entity.HasKey(e => new { e.ProjectCategoryId, e.ProjectTypeId });

                entity.ToTable("ProjectCategory");

                entity.Property(e => e.ProjectCategoryDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectCategoryName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.ProjectType)
                    .WithMany(p => p.ProjectCategories)
                    .HasForeignKey(d => d.ProjectTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectCategory_ProjectType");
            });

            modelBuilder.Entity<ProjectType>(entity =>
            {
                entity.ToTable("ProjectType");

                entity.Property(e => e.ProjectTypeId).ValueGeneratedNever();

                entity.Property(e => e.ProjectTypeDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectTypeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Resource>(entity =>
            {
                entity.ToTable("Resource");

                entity.Property(e => e.ResourceId).ValueGeneratedNever();

                entity.Property(e => e.ResouceAltText)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ResourceDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ResourceName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ResourceUrl)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.Platform)
                    .WithMany(p => p.Resources)
                    .HasForeignKey(d => d.PlatformId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Resource_Platform");
            });

            modelBuilder.Entity<ResourceCategory>(entity =>
            {
                entity.HasKey(e => new { e.ResourceCategoryId, e.ResourceTypeId });

                entity.ToTable("ResourceCategory");

                entity.Property(e => e.ResourceCategoryDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ResourceCategoryName)
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.HasOne(d => d.ResourceType)
                    .WithMany(p => p.ResourceCategories)
                    .HasForeignKey(d => d.ResourceTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ResourceCategory_ResourceType");

                entity.HasMany(d => d.Resources)
                    .WithMany(p => p.Resources)
                    .UsingEntity<Dictionary<string, object>>(
                        "ResourceCategoryType",
                        l => l.HasOne<Resource>().WithMany().HasForeignKey("ResourceId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_ResourceCategoryType_Resource"),
                        r => r.HasOne<ResourceCategory>().WithMany().HasForeignKey("ResourceCategoryId", "ResourceTypeId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_ResourceCategoryType_ResourceCategory"),
                        j =>
                        {
                            j.HasKey("ResourceTypeId", "ResourceCategoryId", "ResourceId");

                            j.ToTable("ResourceCategoryType");
                        });
            });

            modelBuilder.Entity<ResourceType>(entity =>
            {
                entity.ToTable("ResourceType");

                entity.Property(e => e.ResourceTypeId).ValueGeneratedNever();

                entity.Property(e => e.ResourceTypeDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ResourceTypeName)
                    .HasMaxLength(70)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Resume>(entity =>
            {
                entity.ToTable("Resume");

                entity.Property(e => e.ResumeId).ValueGeneratedNever();

                entity.Property(e => e.ResumeDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ResumeName)
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.HasMany(d => d.EducationInfos)
                    .WithMany(p => p.Resumes)
                    .UsingEntity<Dictionary<string, object>>(
                        "ResumeEducationInfo",
                        l => l.HasOne<EducationInfo>().WithMany().HasForeignKey("EducationInfoId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_ResumeEducationInfo_EducationInfo"),
                        r => r.HasOne<Resume>().WithMany().HasForeignKey("ResumeId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_ResumeEducationInfo_Resume"),
                        j =>
                        {
                            j.HasKey("ResumeId", "EducationInfoId");

                            j.ToTable("ResumeEducationInfo");
                        });

                entity.HasMany(d => d.Interests)
                    .WithMany(p => p.Resumes)
                    .UsingEntity<Dictionary<string, object>>(
                        "ResumeInterest",
                        l => l.HasOne<Interest>().WithMany().HasForeignKey("InterestId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_ResumeInterests_Interest"),
                        r => r.HasOne<Resume>().WithMany().HasForeignKey("ResumeId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_ResumeInterests_Resume"),
                        j =>
                        {
                            j.HasKey("ResumeId", "InterestId");

                            j.ToTable("ResumeInterests");
                        });

                entity.HasMany(d => d.Jobs)
                    .WithMany(p => p.Resumes)
                    .UsingEntity<Dictionary<string, object>>(
                        "ResumeJob",
                        l => l.HasOne<Job>().WithMany().HasForeignKey("JobId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_ResumeJobs_Job"),
                        r => r.HasOne<Resume>().WithMany().HasForeignKey("ResumeId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_ResumeJobs_Resume"),
                        j =>
                        {
                            j.HasKey("ResumeId", "JobId");

                            j.ToTable("ResumeJobs");
                        });

                entity.HasMany(d => d.Skills)
                    .WithMany(p => p.Resumes)
                    .UsingEntity<Dictionary<string, object>>(
                        "ResumeSkill",
                        l => l.HasOne<Skill>().WithMany().HasForeignKey("SkillId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_ResumeSkills_Skill"),
                        r => r.HasOne<Resume>().WithMany().HasForeignKey("ResumeId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_ResumeSkills_Resume"),
                        j =>
                        {
                            j.HasKey("ResumeId", "SkillId");

                            j.ToTable("ResumeSkills");

                            j.IndexerProperty<int>("SkillId").HasColumnName("SKillId");
                        });
            });

            modelBuilder.Entity<Skill>(entity =>
            {
                entity.ToTable("Skill");

                entity.Property(e => e.SkillId).ValueGeneratedNever();

                entity.Property(e => e.SkillName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StaticResource>(entity =>
            {
                entity.ToTable("StaticResource");

                entity.Property(e => e.StaticResourceId).ValueGeneratedNever();

                entity.Property(e => e.StaticResourceDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.StaticResourceName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StaticResourceUrl)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.StaticResourceType)
                    .WithMany(p => p.StaticResources)
                    .HasForeignKey(d => d.StaticResourceTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StaticResource_StaticResourceType");
            });

            modelBuilder.Entity<StaticResourceType>(entity =>
            {
                entity.ToTable("StaticResourceType");

                entity.Property(e => e.StaticResourceTypeId).ValueGeneratedNever();

                entity.Property(e => e.StaticResourceDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.StaticResourceName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Step>(entity =>
            {
                entity.ToTable("Step");

                entity.Property(e => e.StepId).ValueGeneratedNever();

                entity.Property(e => e.StepDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.StepEndDate).HasColumnType("datetime");

                entity.Property(e => e.StepName)
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.StepStartDate).HasColumnType("datetime");

                entity.HasOne(d => d.Plan)
                    .WithMany(p => p.Steps)
                    .HasForeignKey(d => d.PlanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Step_Plan");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
