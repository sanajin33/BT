using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using VT.Data.Entities;
using TaskStatus = VT.Data.Entities.TaskStatus;

namespace VT.Data;


public class AppDbContext(DbContextOptions<AppDbContext> options) : IdentityDbContext<User, IdentityRole<int>, int>(options)
{
    public DbSet<DonationCategory> DonationCategories { get; set; }
    public DbSet<DonationItem> DonationItems { get; set; }
    public DbSet<DonationLog> DonationLogs { get; set; }
    public DbSet<Donation> Donations { get; set; }
    public DbSet<Feedback> Feedbacks { get; set; }
    public DbSet<Notification> Notifications { get; set; }
    public DbSet<Organization> Organizations { get; set; }
    public DbSet<Project> Projects { get; set; }
    public DbSet<ProjectUpdate> ProjectUpdates { get; set; }
    public DbSet<VolunteerApplication> VolunteerApplications { get; set; }
    public DbSet<VolunteerTask> VolunteerTasks { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<User>().ToTable("Users");
        builder.Entity<IdentityRole<int>>().ToTable("Roles");
        builder.Entity<IdentityUserRole<int>>().ToTable("UserRoles");
        builder.Entity<IdentityUserClaim<int>>().ToTable("UserClaims");
        builder.Entity<IdentityRoleClaim<int>>().ToTable("RoleClaims");
        builder.Entity<IdentityUserLogin<int>>().ToTable("UserLogins");
        builder.Entity<IdentityUserToken<int>>().ToTable("UserTokens");

        builder.Entity<User>().HasData(
            new User { Id = 1, Name = "Sena Cindioğlu", Email = "senacindioglu@gmail.com", NormalizedEmail = "SENACINDIOGLU@GMAIL.COM", PhoneNumber = "905539555123", Address = "BaşakŞehir/İstanbul", UserType = UserType.Admin, EmailConfirmed = true, CreatedAt = DateTime.Parse("2024-12-21 13:12:52.340946").ToUniversalTime(), UserName = "senacindioglu@gmail.com", NormalizedUserName = "SENACINDIOGLU@GMAIL.COM", ConcurrencyStamp = "43e6c8b7-c1b1-472a-8571-c38842d2c2a6" },
            new User { Id = 2, Name = "John Doe", Email = "john.doe@example.com", NormalizedEmail = "JOHN.DOE@EXAMPLE.COM", PhoneNumber = "555-1234", Address = "123 Elm Street", UserType = UserType.Donor, EmailConfirmed = true, CreatedAt = DateTime.Parse("2024-12-21 13:12:52.340946").ToUniversalTime(), UserName = "john.doe@example.com", NormalizedUserName = "JOHN.DOE@EXAMPLE.COM", ConcurrencyStamp = "040cbb41-c9fd-4cda-8e86-ceb533a31214" },
            new User { Id = 3, Name = "Jane Smith", Email = "jane.smith@example.com", NormalizedEmail = "JANE.SMITH@EXAMPLE.COM", PhoneNumber = "555-5678", Address = "456 Oak Avenue", UserType = UserType.Volunteer, EmailConfirmed = true, CreatedAt = DateTime.Parse("2024-12-21 13:12:52.340946").ToUniversalTime(), UserName = "jane.smith@example.com", NormalizedUserName = "JANE.SMITH@EXAMPLE.COM", ConcurrencyStamp = "4aba19c4-62f5-4bc1-a002-633e78671ced" },
            new User { Id = 4, Name = "Help Org", Email = "contact@helporg.org", NormalizedEmail = "CONTACT@HELPORG.ORG", PhoneNumber = null, Address = "789 Pine Road", UserType = UserType.Organization, EmailConfirmed = true, CreatedAt = DateTime.Parse("2024-12-21 13:12:52.340946").ToUniversalTime(), UserName = "contact@helporg.org", NormalizedUserName = "CONTACT@HELPORG.ORG", ConcurrencyStamp = "0812dbe6-4c5b-4c05-8271-4cfdefa6df9d" },
            new User { Id = 5, Name = "Alice Cooper", Email = "alice.cooper@example.com", NormalizedEmail = "ALICE.COOPER@EXAMPLE.COM", PhoneNumber = "555-7890", Address = "321 Birch Road", UserType = UserType.Donor, EmailConfirmed = true, CreatedAt = DateTime.Parse("2024-12-21 13:12:52.340946").ToUniversalTime(), UserName = "alice.cooper@example.com", NormalizedUserName = "ALICE.COOPER@EXAMPLE.COM", ConcurrencyStamp = "3ae8362b-0a14-4d20-b5e1-76bfd02ee79a" },
            new User { Id = 6, Name = "Bob Marley", Email = "bob.marley@example.com", NormalizedEmail = "BOB.MARLEY@EXAMPLE.COM", PhoneNumber = "555-6789", Address = "654 Spruce Street", UserType = UserType.Volunteer, EmailConfirmed = true, CreatedAt = DateTime.Parse("2024-12-21 13:12:52.340946").ToUniversalTime(), UserName = "bob.marley@example.com", NormalizedUserName = "BOB.MARLEY@EXAMPLE.COM", ConcurrencyStamp = "e08aa345-5ca5-417c-ba38-2c9a196de571" },
            new User { Id = 7, Name = "Charity Group", Email = "charity.group@example.com", NormalizedEmail = "CHARITY.GROUP@EXAMPLE.COM", PhoneNumber = null, Address = "987 Cedar Avenue", UserType = UserType.Organization, EmailConfirmed = true, CreatedAt = DateTime.Parse("2024-12-21 13:12:52.340946").ToUniversalTime(), UserName = "charity.group@example.com", NormalizedUserName = "CHARITY.GROUP@EXAMPLE.COM", ConcurrencyStamp = "b815559f-1ccd-4db8-952c-f33133618de2" },
            new User { Id = 8, Name = "Diana Ross", Email = "diana.ross@example.com", NormalizedEmail = "DIANA.ROSS@EXAMPLE.COM", PhoneNumber = "555-3456", Address = "789 Maple Lane", UserType = UserType.Donor, EmailConfirmed = true, CreatedAt = DateTime.Parse("2024-12-21 13:12:52.340946").ToUniversalTime(), UserName = "diana.ross@example.com", NormalizedUserName = "DIANA.ROSS@EXAMPLE.COM", ConcurrencyStamp = "cbc84531-edf8-49fa-ac1f-84b54698d33e" },
            new User { Id = 9, Name = "Edward Nigma", Email = "edward.nigma@example.com", NormalizedEmail = "EDWARD.NIGMA@EXAMPLE.COM", PhoneNumber = "555-4567", Address = "135 Willow Drive", UserType = UserType.Volunteer, EmailConfirmed = true, CreatedAt = DateTime.Parse("2024-12-21 13:12:52.340946").ToUniversalTime(), UserName = "edward.nigma@example.com", NormalizedUserName = "EDWARD.NIGMA@EXAMPLE.COM", ConcurrencyStamp = "0f888b96-b76b-4e3b-8847-8f6ba211f009" },
            new User { Id = 10, Name = "Bruce Wayne", Email = "bruce.wayne@example.com", NormalizedEmail = "BRUCE.WAYNE@EXAMPLE.COM", PhoneNumber = "555-7777", Address = "Wayne Manor", UserType = UserType.Donor, EmailConfirmed = true, CreatedAt = DateTime.Parse("2024-12-21 13:12:52.340946").ToUniversalTime(), UserName = "bruce.wayne@example.com", NormalizedUserName = "BRUCE.WAYNE@EXAMPLE.COM", ConcurrencyStamp = "3887fe1f-47c0-4d08-aa63-bdfd1585e507" },
            new User { Id = 11, Name = "Clark Kent", Email = "clark.kent@example.com", NormalizedEmail = "CLARK.KENT@EXAMPLE.COM", PhoneNumber = "555-8888", Address = "Metropolis", UserType = UserType.Volunteer, EmailConfirmed = true, CreatedAt = DateTime.Parse("2024-12-21 13:12:52.340946").ToUniversalTime(), UserName = "clark.kent@example.com", NormalizedUserName = "CLARK.KENT@EXAMPLE.COM", ConcurrencyStamp = "d49c47ac-6482-4e9a-93cc-e7ae5fbd73b4" }
        );

        builder.Entity<DonationCategory>().HasData(
            new DonationCategory { Id = 1, Name = "Food Supplies", Description = "Items such as canned goods, rice, etc." },
            new DonationCategory { Id = 2, Name = "Eco Materials", Description = "Sustainable materials for environmental projects" },
            new DonationCategory { Id = 3, Name = "Animal Supplies", Description = "Food, toys, and equipment for pets" },
            new DonationCategory { Id = 4, Name = "Education Materials", Description = "Books, stationery, and teaching aids" },
            new DonationCategory { Id = 5, Name = "Cleaning Supplies", Description = "Tools and materials for cleaning activities" },
            new DonationCategory { Id = 6, Name = "Medical Supplies", Description = "First aid kits, medicines, and equipment" },
            new DonationCategory { Id = 7, Name = "Building Materials", Description = "Items for renovation and construction" },
            new DonationCategory { Id = 8, Name = "Vocational Tools", Description = "Equipment for skill training." },
            new DonationCategory { Id = 9, Name = "Hygiene Kits", Description = "Soap, sanitizer, and personal care items." },
            new DonationCategory { Id = 10, Name = "Winter Supplies", Description = "Blankets, jackets, and other winter essentials." }
        );

        builder.Entity<Organization>().HasData(
            new Organization { Id = 1, Name = "Helping Hands", ContactEmail = "info@helpinghands.org", ContactPhone = "555-9876", Address = "101 Charity Lane", MissionStatement = "To support local communities.", CreatedAt = DateTime.Parse("2024-12-21 13:12:52.340946").ToUniversalTime() },
            new Organization { Id = 2, Name = "Green Earth", ContactEmail = "contact@greenearth.org", ContactPhone = "555-5432", Address = "202 Eco Way", MissionStatement = "Promoting sustainable living.", CreatedAt = DateTime.Parse("2024-12-21 13:12:52.340946").ToUniversalTime() },
            new Organization { Id = 3, Name = "Animal Rescue", ContactEmail = "contact@animalrescue.org", ContactPhone = "555-6543", Address = "303 Pet Street", MissionStatement = "Saving stray animals.", CreatedAt = DateTime.Parse("2024-12-21 13:12:52.340946").ToUniversalTime() },
            new Organization { Id = 4, Name = "Food Bank", ContactEmail = "info@foodbank.org", ContactPhone = "555-3210", Address = "404 Hunger Lane", MissionStatement = "Providing meals to the homeless.", CreatedAt = DateTime.Parse("2024-12-21 13:12:52.340946").ToUniversalTime() },
            new Organization { Id = 5, Name = "Eco Warriors", ContactEmail = "contact@ecowarriors.org", ContactPhone = "555-4321", Address = "505 Green Road", MissionStatement = "Fighting for a cleaner planet.", CreatedAt = DateTime.Parse("2024-12-21 13:12:52.340946").ToUniversalTime() },
            new Organization { Id = 6, Name = "Education First", ContactEmail = "info@educationfirst.org", ContactPhone = "555-8765", Address = "606 Knowledge Blvd", MissionStatement = "Promoting education for all.", CreatedAt = DateTime.Parse("2024-12-21 13:12:52.340946").ToUniversalTime() },
            new Organization { Id = 7, Name = "Health for All", ContactEmail = "contact@healthforall.org", ContactPhone = "555-7654", Address = "707 Wellness Way", MissionStatement = "Providing free healthcare services.", CreatedAt = DateTime.Parse("2024-12-21 13:12:52.340946").ToUniversalTime() },
            new Organization { Id = 8, Name = "Safe Shelter", ContactEmail = "info@safeshelter.org", ContactPhone = "555-6542", Address = "808 Haven Drive", MissionStatement = "Shelter for the homeless.", CreatedAt = DateTime.Parse("2024-12-21 13:12:52.340946").ToUniversalTime() },
            new Organization { Id = 9, Name = "Youth Empowerment", ContactEmail = "contact@youthempower.org", ContactPhone = "555-4444", Address = "909 Growth Street", MissionStatement = "Empowering young minds.", CreatedAt = DateTime.Parse("2024-12-21 13:12:52.340946").ToUniversalTime() },
            new Organization { Id = 10, Name = "Clean Future", ContactEmail = "info@cleanfuture.org", ContactPhone = "555-3333", Address = "1000 Bright Lane", MissionStatement = "Creating a cleaner tomorrow.", CreatedAt = DateTime.Parse("2024-12-21 13:12:52.340946").ToUniversalTime() }
        );

        builder.Entity<Project>().HasData(
             new Project { Id = 1, OrganizationId = 1, Title = "Food Drive", Description = "A project to distribute food to the needy.", StartDate = DateTime.Parse("2025-01-01").ToUniversalTime(), EndDate = DateTime.Parse("2025-01-15").ToUniversalTime(), Status = ProjectStatus.Ongoing },
             new Project { Id = 2, OrganizationId = 1, Title = "Tree Plantation", Description = "Planting trees in urban areas.", StartDate = DateTime.Parse("2025-02-01").ToUniversalTime(), EndDate = DateTime.Parse("2025-02-28").ToUniversalTime(), Status = ProjectStatus.Pending },
             new Project { Id = 3, OrganizationId = 1, Title = "Animal Adoption", Description = "Finding homes for stray animals.", StartDate = DateTime.Parse("2025-03-01").ToUniversalTime(), EndDate = DateTime.Parse("2025-03-15").ToUniversalTime(), Status = ProjectStatus.Ongoing },
             new Project { Id = 4, OrganizationId = 1, Title = "Education Fair", Description = "Promoting education opportunities.", StartDate = DateTime.Parse("2025-04-01").ToUniversalTime(), EndDate = DateTime.Parse("2025-04-15").ToUniversalTime(), Status = ProjectStatus.Pending },
             new Project { Id = 5, OrganizationId = 1, Title = "Clean Up Drive", Description = "Cleaning up local parks.", StartDate = DateTime.Parse("2025-05-01").ToUniversalTime(), EndDate = DateTime.Parse("2025-05-15").ToUniversalTime(), Status = ProjectStatus.Ongoing },
             new Project { Id = 6, OrganizationId = 1, Title = "Healthcare Camp", Description = "Providing free medical checkups.", StartDate = DateTime.Parse("2025-06-01").ToUniversalTime(), EndDate = DateTime.Parse("2025-06-15").ToUniversalTime(), Status = ProjectStatus.Pending },
             new Project { Id = 7, OrganizationId = 1, Title = "Shelter Renovation", Description = "Renovating shelters for the homeless.", StartDate = DateTime.Parse("2025-07-01").ToUniversalTime(), EndDate = DateTime.Parse("2025-07-15").ToUniversalTime(), Status = ProjectStatus.Ongoing },
             new Project { Id = 8, OrganizationId = 1, Title = "Skill Training", Description = "Providing vocational training to unemployed individuals.", StartDate = DateTime.Parse("2025-08-01").ToUniversalTime(), EndDate = DateTime.Parse("2025-08-15").ToUniversalTime(), Status = ProjectStatus.Pending },
             new Project { Id = 9, OrganizationId = 1, Title = "Plastic Recycling Initiative", Description = "Reducing plastic waste through recycling.", StartDate = DateTime.Parse("2025-09-01").ToUniversalTime(), EndDate = DateTime.Parse("2025-09-30").ToUniversalTime(), Status = ProjectStatus.Pending },
             new Project { Id = 10, OrganizationId = 1, Title = "Mental Health Workshop", Description = "Promoting mental wellness in the community.", StartDate = DateTime.Parse("2025-10-01").ToUniversalTime(), EndDate = DateTime.Parse("2025-10-20").ToUniversalTime(), Status = ProjectStatus.Ongoing }
         );

        builder.Entity<Donation>().HasData(
             new Donation { Id = 1, ProjectId = 1, Amount = 100.00m, DonationDate = new DateTime(2025, 1, 2).ToUniversalTime(), UserId = 1, Notes = "Donation for food supplies" },
             new Donation { Id = 2, ProjectId = 1, Amount = 50.00m, DonationDate = new DateTime(2025, 2, 1).ToUniversalTime(), UserId = 2, Notes = "For tree plantation materials" },
             new Donation { Id = 3, ProjectId = 4, Amount = 200.00m, DonationDate = new DateTime(2025, 3, 2).ToUniversalTime(), UserId = 3, Notes = "For animal adoption campaign" },
             new Donation { Id = 4, ProjectId = 5, Amount = 150.00m, DonationDate = new DateTime(2025, 4, 5).ToUniversalTime(), UserId = 4, Notes = "Support for education fair" },
             new Donation { Id = 5, ProjectId = 7, Amount = 75.00m, DonationDate = new DateTime(2025, 5, 6).ToUniversalTime(), UserId = 5, Notes = "Cleaning tools and supplies" },
             new Donation { Id = 6, ProjectId = 8, Amount = 300.00m, DonationDate = new DateTime(2025, 6, 7).ToUniversalTime(), UserId = 6, Notes = "Medical equipment for healthcare camp" },
             new Donation { Id = 7, ProjectId = 4, Amount = 100.00m, DonationDate = new DateTime(2025, 7, 8).ToUniversalTime(), UserId = 7, Notes = "Building materials for renovation" },
             new Donation { Id = 8, ProjectId = 5, Amount = 50.00m, DonationDate = new DateTime(2025, 8, 9).ToUniversalTime(), UserId = 8, Notes = "Training materials for skill training." },
             new Donation { Id = 9, ProjectId = 9, Amount = 250.00m, DonationDate = new DateTime(2025, 9, 15).ToUniversalTime(), UserId = 9, Notes = "Support for recycling initiative" },
             new Donation { Id = 10, ProjectId = 10, Amount = 180.00m, DonationDate = new DateTime(2025, 10, 12).ToUniversalTime(), UserId = 10, Notes = "Support for mental health workshop." }
         );

        builder.Entity<DonationItem>().HasData(
            new DonationItem { Id = 1, DonationId = 1, CategoryId = 1, ItemName = "Canned Beans", Quantity = 100, Notes = "For food distribution" },
            new DonationItem { Id = 2, DonationId = 2, CategoryId = 2, ItemName = "Tree Saplings", Quantity = 50, Notes = "For urban plantation project" },
            new DonationItem { Id = 3, DonationId = 3, CategoryId = 3, ItemName = "Dog Food", Quantity = 30, Notes = "For animal rescue efforts" },
            new DonationItem { Id = 4, DonationId = 4, CategoryId = 4, ItemName = "Notebooks", Quantity = 200, Notes = "For education fair distribution" },
            new DonationItem { Id = 5, DonationId = 5, CategoryId = 5, ItemName = "Trash Bags", Quantity = 500, Notes = "Used in park cleanup" },
            new DonationItem { Id = 6, DonationId = 6, CategoryId = 6, ItemName = "First Aid Kits", Quantity = 20, Notes = "For healthcare camp" },
            new DonationItem { Id = 7, DonationId = 7, CategoryId = 7, ItemName = "Cement Bags", Quantity = 40, Notes = "Used in shelter renovation" },
            new DonationItem { Id = 8, DonationId = 8, CategoryId = 8, ItemName = "Toolkits", Quantity = 15, Notes = "For skill training." },
            new DonationItem { Id = 9, DonationId = 9, CategoryId = 9, ItemName = "Plastic Bottles", Quantity = 100, Notes = "Collected for recycling." },
            new DonationItem { Id = 10, DonationId = 10, CategoryId = 10, ItemName = "Stress Balls", Quantity = 50, Notes = "For mental health workshop." }
        );
        builder.Entity<Feedback>().HasData(
            new Feedback { Id = 1, UserId = 1, OrganizationId = 1, Rating = 5, Comments = "Great initiative for the community!", FeedbackDate = DateTime.Parse("2024-12-21 13:12:52.340946").ToUniversalTime() },
            new Feedback { Id = 2, UserId = 2, OrganizationId = 2, Rating = 4, Comments = "Well-organized event but could use more volunteers.", FeedbackDate = DateTime.Parse("2024-12-21 13:12:52.340946").ToUniversalTime() },
            new Feedback { Id = 3, UserId = 4, OrganizationId = 3, Rating = 5, Comments = "Loved being part of the animal adoption campaign.", FeedbackDate = DateTime.Parse("2024-12-21 13:12:52.340946").ToUniversalTime() },
            new Feedback { Id = 4, UserId = 5, OrganizationId = 4, Rating = 4, Comments = "The education fair was very informative.", FeedbackDate = DateTime.Parse("2024-12-21 13:12:52.340946").ToUniversalTime() },
            new Feedback { Id = 5, UserId = 6, OrganizationId = 5, Rating = 5, Comments = "Parks look amazing after the cleanup drive.", FeedbackDate = DateTime.Parse("2024-12-21 13:12:52.340946").ToUniversalTime() },
            new Feedback { Id = 6, UserId = 7, OrganizationId = 6, Rating = 4, Comments = "Healthcare camp was very beneficial.", FeedbackDate = DateTime.Parse("2024-12-21 13:12:52.340946").ToUniversalTime() },
            new Feedback { Id = 7, UserId = 8, OrganizationId = 7, Rating = 5, Comments = "Shelters look much better now.", FeedbackDate = DateTime.Parse("2024-12-21 13:12:52.340946").ToUniversalTime() },
            new Feedback { Id = 8, UserId = 2, OrganizationId = 8, Rating = 4, Comments = "Skill training was very helpful but could use more resources.", FeedbackDate = DateTime.Parse("2024-12-21 13:12:52.340946").ToUniversalTime() },
            new Feedback { Id = 9, UserId = 9, OrganizationId = 9, Rating = 5, Comments = "Recycling workshop was insightful!", FeedbackDate = DateTime.Parse("2024-12-21 13:12:52.340946").ToUniversalTime() },
            new Feedback { Id = 10, UserId = 10, OrganizationId = 10, Rating = 5, Comments = "Mental health workshop was excellent.", FeedbackDate = DateTime.Parse("2024-12-21 13:12:52.340946").ToUniversalTime() }
        );

        builder.Entity<Notification>().HasData(
            new Notification { Id = 1, UserId = 1, Message = "Thank you for your donation!", IsRead = false, SentAt = DateTime.Parse("2024-12-21 13:12:52.340946").ToUniversalTime() },
            new Notification { Id = 2, UserId = 2, Message = "Your volunteer application is approved.", IsRead = false, SentAt = DateTime.Parse("2024-12-21 13:12:52.340946").ToUniversalTime() },
            new Notification { Id = 3, UserId = 4, Message = "Your donation was successfully processed.", IsRead = false, SentAt = DateTime.Parse("2024-12-21 13:12:52.340946").ToUniversalTime() },
            new Notification { Id = 4, UserId = 5, Message = "Your volunteer task has been updated.", IsRead = false, SentAt = DateTime.Parse("2024-12-21 13:12:52.340946").ToUniversalTime() },
            new Notification { Id = 5, UserId = 6, Message = "Thank you for participating in the healthcare camp.", IsRead = false, SentAt = DateTime.Parse("2024-12-21 13:12:52.340946").ToUniversalTime() },
            new Notification { Id = 6, UserId = 7, Message = "The shelter renovation project is completed.", IsRead = false, SentAt = DateTime.Parse("2024-12-21 13:12:52.340946").ToUniversalTime() },
            new Notification { Id = 7, UserId = 8, Message = "Training session schedule is now available.", IsRead = false, SentAt = DateTime.Parse("2024-12-21 13:12:52.340946").ToUniversalTime() },
            new Notification { Id = 8, UserId = 2, Message = "Your volunteer application status has been updated.", IsRead = false, SentAt = DateTime.Parse("2024-12-21 13:12:52.340946").ToUniversalTime() },
            new Notification { Id = 9, UserId = 9, Message = "Your recycling workshop slot is confirmed.", IsRead = false, SentAt = DateTime.Parse("2024-12-21 13:12:52.340946").ToUniversalTime() },
            new Notification { Id = 10, UserId = 10, Message = "Join us for the mental health workshop.", IsRead = false, SentAt = DateTime.Parse("2024-12-21 13:12:52.340946").ToUniversalTime() }
        );

        builder.Entity<ProjectUpdate>().HasData(
            new ProjectUpdate { Id = 1, ProjectId = 1, UpdateTitle = "Food Packages Delivered", UpdateBody = "We successfully delivered 500 food packages.", UpdateDate = DateTime.Parse("2024-12-21 13:12:52.340946").ToUniversalTime() },
            new ProjectUpdate { Id = 2, ProjectId = 2, UpdateTitle = "Trees Planted", UpdateBody = "100 trees were planted in the city park.", UpdateDate = DateTime.Parse("2024-12-21 13:12:52.340946").ToUniversalTime() },
            new ProjectUpdate { Id = 3, ProjectId = 3, UpdateTitle = "Animal Adoption Success", UpdateBody = "20 pets found loving homes.", UpdateDate = DateTime.Parse("2024-12-21 13:12:52.340946").ToUniversalTime() },
            new ProjectUpdate { Id = 4, ProjectId = 4, UpdateTitle = "Education Fair Scheduled", UpdateBody = "Dates and locations for the fair are finalized.", UpdateDate = DateTime.Parse("2024-12-21 13:12:52.340946").ToUniversalTime() },
            new ProjectUpdate { Id = 5, ProjectId = 5, UpdateTitle = "Cleanup Drive Completed", UpdateBody = "Local parks are now spotless and welcoming.", UpdateDate = DateTime.Parse("2024-12-21 13:12:52.340946").ToUniversalTime() },
            new ProjectUpdate { Id = 6, ProjectId = 6, UpdateTitle = "Healthcare Camp Report", UpdateBody = "Over 200 individuals benefited from the camp.", UpdateDate = DateTime.Parse("2024-12-21 13:12:52.340946").ToUniversalTime() },
            new ProjectUpdate { Id = 7, ProjectId = 7, UpdateTitle = "Shelter Renovation Done", UpdateBody = "Shelters are ready for use by the needy.", UpdateDate = DateTime.Parse("2024-12-21 13:12:52.340946").ToUniversalTime() },
            new ProjectUpdate { Id = 8, ProjectId = 8, UpdateTitle = "Skill Training Begun", UpdateBody = "Training sessions started successfully.", UpdateDate = DateTime.Parse("2024-12-21 13:12:52.340946").ToUniversalTime() },
            new ProjectUpdate { Id = 9, ProjectId = 9, UpdateTitle = "Plastic Recycling Workshop Held", UpdateBody = "50 participants learned about recycling.", UpdateDate = DateTime.Parse("2024-12-21 13:12:52.340946").ToUniversalTime() },
            new ProjectUpdate { Id = 10, ProjectId = 10, UpdateTitle = "Mental Health Workshop Success", UpdateBody = "Over 100 attendees benefited.", UpdateDate = DateTime.Parse("2024-12-21 13:12:52.340946").ToUniversalTime() }
        );

        builder.Entity<VolunteerTask>().HasData(
            new VolunteerTask { Id = 1, ProjectId = 2, UserId = 1, Description = "Distribute food packages", Date = new DateTime(2025, 1, 10).ToUniversalTime(), Status = TaskStatus.Pending },
            new VolunteerTask { Id = 2, ProjectId = 2, UserId = 2, Description = "Plant trees in designated areas", Date = new DateTime(2025, 2, 10).ToUniversalTime(), Status = TaskStatus.Pending },
            new VolunteerTask { Id = 3, ProjectId = 2, UserId = 3, Description = "Assist with animal adoption event", Date = new DateTime(2025, 3, 11).ToUniversalTime(), Status = TaskStatus.Pending },
            new VolunteerTask { Id = 4, ProjectId = 5, UserId = 4, Description = "Set up booths for education fair", Date = new DateTime(2025, 4, 12).ToUniversalTime(), Status = TaskStatus.Pending },
            new VolunteerTask { Id = 5, ProjectId = 6, UserId = 5, Description = "Organize volunteers for park cleanup", Date = new DateTime(2025, 5, 13).ToUniversalTime(), Status = TaskStatus.Pending },
            new VolunteerTask { Id = 6, ProjectId = 7, UserId = 6, Description = "Coordinate medical staff for camp", Date = new DateTime(2025, 6, 14).ToUniversalTime(), Status = TaskStatus.Pending },
            new VolunteerTask { Id = 7, ProjectId = 8, UserId = 7, Description = "Assist in shelter renovation", Date = new DateTime(2025, 7, 15).ToUniversalTime(), Status = TaskStatus.Pending },
            new VolunteerTask { Id = 8, ProjectId = 2, UserId = 8, Description = "Prepare training materials", Date = new DateTime(2025, 8, 16).ToUniversalTime(), Status = TaskStatus.Pending },
            new VolunteerTask { Id = 9, ProjectId = 9, UserId = 9, Description = "Assist in recycling workshop", Date = new DateTime(2025, 9, 5).ToUniversalTime(), Status = TaskStatus.Pending },
            new VolunteerTask { Id = 10, ProjectId = 10, UserId = 10, Description = "Coordinate mental health workshop logistics", Date = new DateTime(2025, 10, 10).ToUniversalTime(), Status = TaskStatus.Pending }
        );

        builder.Entity<VolunteerApplication>().HasData(
            new VolunteerApplication { Id = 1, UserId = 2, TaskId = 1, ApplicationDate = DateTime.Parse("2025-01-05").ToUniversalTime(), Status = ApplicationStatus.Approved },
            new VolunteerApplication { Id = 2, UserId = 2, TaskId = 2, ApplicationDate = DateTime.Parse("2025-01-20").ToUniversalTime(), Status = ApplicationStatus.Pending },
            new VolunteerApplication { Id = 3, UserId = 5, TaskId = 3, ApplicationDate = DateTime.Parse("2025-02-22").ToUniversalTime(), Status = ApplicationStatus.Approved },
            new VolunteerApplication { Id = 4, UserId = 6, TaskId = 4, ApplicationDate = DateTime.Parse("2025-03-12").ToUniversalTime(), Status = ApplicationStatus.Approved },
            new VolunteerApplication { Id = 5, UserId = 7, TaskId = 5, ApplicationDate = DateTime.Parse("2025-04-18").ToUniversalTime(), Status = ApplicationStatus.Pending },
            new VolunteerApplication { Id = 6, UserId = 8, TaskId = 6, ApplicationDate = DateTime.Parse("2025-05-20").ToUniversalTime(), Status = ApplicationStatus.Approved },
            new VolunteerApplication { Id = 7, UserId = 2, TaskId = 7, ApplicationDate = DateTime.Parse("2025-06-22").ToUniversalTime(), Status = ApplicationStatus.Pending },
            new VolunteerApplication { Id = 8, UserId = 4, TaskId = 8, ApplicationDate = DateTime.Parse("2025-07-24").ToUniversalTime(), Status = ApplicationStatus.Approved },
            new VolunteerApplication { Id = 9, UserId = 9, TaskId = 9, ApplicationDate = DateTime.Parse("2025-09-10").ToUniversalTime(), Status = ApplicationStatus.Approved },
            new VolunteerApplication { Id = 10, UserId = 10, TaskId = 10, ApplicationDate = DateTime.Parse("2025-10-15").ToUniversalTime(), Status = ApplicationStatus.Approved }
        );
    }
}
