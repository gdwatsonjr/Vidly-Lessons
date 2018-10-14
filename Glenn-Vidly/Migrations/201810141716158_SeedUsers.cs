namespace Glenn_Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'4dbab749-2a8b-429e-a915-955e7b6ca8cb', N'guest@vidly.com', 0, N'AJqzL6/q0VsfcuPihKXMe+r9UhTfV5YokXf3XaWHEVT0jzKdvSfLe1zUhnRsmu6fqQ==', N'f2ba84b1-f34f-43d4-9d59-b8dd0402f7f4', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'e2ad3a8f-f2da-4fcf-b192-fc1b1dbdea04', N'administrator@vidly.com', 0, N'AEA9/Ewr/SR8E/Big8uoPGtfUq+0lyO4PNjeF6Qn2y9570vhwO5QMSCBQ6+o4qi8Lg==', N'a21c8f89-b319-40c4-a9b3-16cb005c1ae1', NULL, 0, 0, NULL, 1, 0, N'administrator@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'cc3ec729-b6e7-4b91-af8d-d64db2146695', N'CanManageMovie')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'e2ad3a8f-f2da-4fcf-b192-fc1b1dbdea04', N'cc3ec729-b6e7-4b91-af8d-d64db2146695')

");
        }
        
        public override void Down()
        {
        }
    }
}
