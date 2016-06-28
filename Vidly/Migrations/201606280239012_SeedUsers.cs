namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'1ce7e126-70a6-4d61-84e9-9a7f5ecb567c', N'guest@vidly.com', 0, N'ALnHB+u+CZHzhwf69Dycx0HGnlEM6mso8h/W/6LDEBnD7GvRF8GTg7ZM79waPBqwuw==', N'50f2384a-2cdc-4c71-b21f-88b065d4b721', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'97a815fb-85aa-4ece-9474-e1205c53e4fd', N'admin@vidly.com', 0, N'AIpXRg+Czg5SBV80e6nJ9zbmYC+i1B8tKhaiMp8HlbCDyZjTnbS+1iQ0F5HDAnYFAA==', N'68ec3de8-3823-4ca3-b8a1-62b21ba627d5', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'e8b4fe38-9fab-40a4-a47c-48b3f70d2860', N'CanManageMovies')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'97a815fb-85aa-4ece-9474-e1205c53e4fd', N'e8b4fe38-9fab-40a4-a47c-48b3f70d2860')");
        }
        
        public override void Down()
        {
        }
    }
}
