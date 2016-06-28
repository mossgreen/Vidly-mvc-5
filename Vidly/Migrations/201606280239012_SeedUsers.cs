namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {

            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'795d59fb-54f2-497b-9b74-d8685c2abcd5', N'guest@vidly.com', 0, N'AJ7mcUPfyVaBTV81HwKDZ6tCnv2vxcaVc8Z9awD0AYf2ccyGkQ9nDAevBKPLe3UUFw==', N'80f1b773-452d-43ee-8d8b-f390fc29d464', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'a149264e-1a8d-4f52-b410-dc64ec781b29', N'admin@vidly.com', 0, N'ADU2byElA5R9DPg9vYB2jxyakbryidoghiq+vKlMXj02HKfgf4PgUSeST9ELt9vSDQ==', N'11a14b9c-d22f-4cfc-98e6-9961fce5a1f2', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'6cf97953-beb3-4845-8b7c-df2712099e32', N'CanManageMovies')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'a149264e-1a8d-4f52-b410-dc64ec781b29', N'6cf97953-beb3-4845-8b7c-df2712099e32')

");
        }
        
        public override void Down()
        {
        }
    }
}
