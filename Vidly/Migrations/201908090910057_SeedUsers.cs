namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'23288ccc-7ef8-45fe-b2eb-22af5d28fa17', N'admin@vidly.com', 0, N'AJ7Kfe4GSS7hh14arCv6bDmignFHMiCxrxNq9mtP+TVH3xDoKM2v/Euw385zUiUVzQ==', N'0b508388-b61f-427b-9d8c-6a8bd4e6998c', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'c087926f-bfa1-4d0e-8ac3-d8e6d4d7612e', N'guest@vidly.com', 0, N'AE8bGJm+Cm8YnSClnWmu9gWnTR8ejr3H27nZhLZy7OPMaY6MxnKc9c1/KjT3TGBcdg==', N'49fe61b6-c960-4702-879f-c40cd1ef6e45', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
            
            INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'08422e65-4cea-41ff-947c-7a1706084e42', N'CanManageMovies')

            INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'23288ccc-7ef8-45fe-b2eb-22af5d28fa17', N'08422e65-4cea-41ff-947c-7a1706084e42')

            ");

        }
        
        public override void Down()
        {
        }
    }
}
