namespace NuvolaResume3.Models.Data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class NuvolaResumeContext : DbContext
    {
        public NuvolaResumeContext()
            : base("DefaultConnection")
        {
        }

        public virtual DbSet<Achievement> Achievements { get; set; }
        public virtual DbSet<Adertisement> Adertisements { get; set; }
        public virtual DbSet<Advertiser> Advertisers { get; set; }
        public virtual DbSet<APIKey> APIKeys { get; set; }
        public virtual DbSet<APITokenManager> APITokenManagers { get; set; }
        public virtual DbSet<AuthToken> AuthTokens { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<CategoryItem> CategoryItems { get; set; }
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<ConfirmationStatu> ConfirmationStatus { get; set; }
        public virtual DbSet<Connection> Connections { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Education> Educations { get; set; }
        public virtual DbSet<FeaturesList> FeaturesLists { get; set; }
        public virtual DbSet<Friend> Friends { get; set; }
        public virtual DbSet<HonorAward> HonorAwards { get; set; }
        public virtual DbSet<Industry> Industries { get; set; }
        public virtual DbSet<LanguageProficiency> LanguageProficiencies { get; set; }
        public virtual DbSet<Language> Languages { get; set; }
        public virtual DbSet<ManagedBy> ManagedBies { get; set; }
        public virtual DbSet<ManagerComment> ManagerComments { get; set; }
        public virtual DbSet<Organization> Organizations { get; set; }
        public virtual DbSet<PasswordReset> PasswordResets { get; set; }
        public virtual DbSet<ResumeAccess> ResumeAccesses { get; set; }
        public virtual DbSet<ResumeAchievement> ResumeAchievements { get; set; }
        public virtual DbSet<ResumeCategory> ResumeCategories { get; set; }
        public virtual DbSet<ResumeEducation> ResumeEducations { get; set; }
        public virtual DbSet<ResumeIndustry> ResumeIndustries { get; set; }
        public virtual DbSet<Resume> Resumes { get; set; }
        public virtual DbSet<ResumeSkill> ResumeSkills { get; set; }
        public virtual DbSet<ResumeSocialNetwork> ResumeSocialNetworks { get; set; }
        public virtual DbSet<ResumeVolunteerExperience> ResumeVolunteerExperiences { get; set; }
        public virtual DbSet<Skill> Skills { get; set; }
        public virtual DbSet<SkillsCategory> SkillsCategories { get; set; }
        public virtual DbSet<SocialNetwork> SocialNetworks { get; set; }
        public virtual DbSet<SupportRequest> SupportRequests { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<UserImage> UserImages { get; set; }
        public virtual DbSet<UserLanguage> UserLanguages { get; set; }
        public virtual DbSet<UserMail> UserMails { get; set; }
        public virtual DbSet<UserMedia> UserMedias { get; set; }
        public virtual DbSet<UserProfile> UserProfiles { get; set; }
        //public virtual DbSet<UserProfile1> UserProfiles1 { get; set; }
        public virtual DbSet<UserSocialNetwork> UserSocialNetworks { get; set; }
        public virtual DbSet<VolunteerExperience> VolunteerExperiences { get; set; }
        public virtual DbSet<webpages_Membership> webpages_Membership { get; set; }
        public virtual DbSet<webpages_OAuthMembership> webpages_OAuthMembership { get; set; }
        public virtual DbSet<webpages_Roles> webpages_Roles { get; set; }
        public virtual DbSet<webpages_UsersInRoles> webpages_UsersInRoles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Achievement>()
                .HasMany(e => e.ResumeAchievements)
                .WithRequired(e => e.Achievement)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Category>()
                .HasMany(e => e.CategoryItems)
                .WithRequired(e => e.Category)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CategoryItem>()
                .HasMany(e => e.ResumeCategories)
                .WithRequired(e => e.CategoryItem)
                .HasForeignKey(e => e.CategoriesItemID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Education>()
                .HasMany(e => e.ResumeEducations)
                .WithRequired(e => e.Education)
                .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Resume>()
            //    .HasMany(e => e.ResumeAccesses)
            //    .WithRequired(e => e.Resume)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Resume>()
            //    .HasMany(e => e.ResumeAchievements)
            //    .WithRequired(e => e.Resume)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Resume>()
            //    .HasMany(e => e.ResumeCategories)
            //    .WithRequired(e => e.Resume)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Resume>()
            //    .HasMany(e => e.ResumeEducations)
            //    .WithRequired(e => e.Resume)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Resume>()
            //    .HasMany(e => e.ResumeSkills)
            //    .WithRequired(e => e.Resume)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Resume>()
            //    .HasMany(e => e.ResumeSocialNetworks)
            //    .WithRequired(e => e.Resume)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Resume>()
            //    .HasMany(e => e.UserProfiles)
            //    .WithOptional(e => e.Resume)
            //    .HasForeignKey(e => e.PublicResumeID);

            modelBuilder.Entity<Skill>()
                .HasMany(e => e.ResumeSkills)
                .WithRequired(e => e.Skill)
                .WillCascadeOnDelete(false);

            //modelBuilder.Entity<SocialNetwork>()
            //    .HasMany(e => e.ResumeSocialNetworks)
            //    .WithRequired(e => e.UserSocialNetwork)
            //    .WillCascadeOnDelete(false);

            modelBuilder.Entity<webpages_Roles>()
                .HasMany(e => e.webpages_UsersInRoles)
                .WithRequired(e => e.webpages_Roles)
                .WillCascadeOnDelete(false);
        }
    }
}
