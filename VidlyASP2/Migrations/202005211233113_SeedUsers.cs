namespace VidlyASP2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'b8325711-469a-41d9-9f03-36d295543762', N'guest@vidly.com', 0, N'AMmyV/mGjCjiNirBVrGrhNlwDMZf47hUMP0xiGePqTCAs5a64SxPlubm25VjEhTP5w==', N'b30d7ab9-93fc-4626-9517-855936b11582', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'c3a1941e-8bab-4c11-9849-7f11aa1335ea', N'admin@vidly.com', 0, N'AI5KQdy5R3VyM/vkPodWMJG2YXGztJT/fRTvpjEsPQP1RI7Rx6kmafeoUAnCOEgIMg==', N'd7b80541-24fc-4bd6-96ea-acce5b1b3019', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
            INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'dc4a9071-61bf-4243-9e50-9c5520b0f5f2', N'CanManageMovies')
            INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'c3a1941e-8bab-4c11-9849-7f11aa1335ea', N'dc4a9071-61bf-4243-9e50-9c5520b0f5f2')
            ");
        }
        
        public override void Down()
        {
        }
    }
}
