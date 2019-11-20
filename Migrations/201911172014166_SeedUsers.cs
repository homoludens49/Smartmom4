namespace Smartmom4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'740b4ba5-e1cf-4b08-8787-30aeb9634545', N'admin@smartmom.com', 0, N'AAft0rxNdSD3cLPFNGWQWtNguZ+YbIwvZPA2PSpJqmjs6V9b8vx2lVMNmlXxfX7LSg==', N'ab057f30-4826-4ef1-a6af-346e920e4640', NULL, 0, 0, NULL, 1, 0, N'admin@smartmom.com')
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'8320c99b-6eb8-4437-a774-8cc2b1a691b6', N'test@smartmom.com', 0, N'AJ8IFxP5jOkdrkbZFoI8GV/vS76rLDSS+NxtwhBSSXgictcx12cJUat+jtoZsM1uiw==', N'9d8ed238-3e77-46c4-8dff-f5765b16ba82', NULL, 0, 0, NULL, 1, 0, N'test@smartmom.com')
            INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'8134b156-ecf4-45c9-9884-466a3b04a85c', N'CanManageMovies')
            INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'740b4ba5-e1cf-4b08-8787-30aeb9634545', N'8134b156-ecf4-45c9-9884-466a3b04a85c')



");
        }
        
        public override void Down()
        {
        }
    }
}
