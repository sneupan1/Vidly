namespace Vidly.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'4bc8fa89-8563-45d6-a1d4-ab42853c5a56', N'sneupan1@go.olemiss.edu', 0, N'AKgvmIsz/A9NfRNzYq9gphHQKja5VaWr2gb0vh8KvGZcr5DocLXPJuP41yTcjDoATw==', N'7e70295f-f3a9-4f0f-9ad5-dda7cb098852', NULL, 0, 0, NULL, 1, 0, N'sneupan1@go.olemiss.edu')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'6578e2a6-4e77-433f-8923-30c5f654f3f7', N'admin@vidly.com', 0, N'APcFx0L67brYzeMA0x+yaVI2AKZqmnz8z7BceLOJD81aO5XCMmxTzn+djRT1DShPig==', N'7bfb8aea-fce0-491a-8171-b1da44510b68', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'3ce8835e-595a-483c-85d8-bb4c3eda4ca1', N'CanManageMovies')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'6578e2a6-4e77-433f-8923-30c5f654f3f7', N'3ce8835e-595a-483c-85d8-bb4c3eda4ca1')
");

        }

        public override void Down()
        {
        }
    }
}