namespace BookApplicationAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChaingedDefaultTableNames : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.AspNetRoles", newName: "Roles");
            RenameTable(name: "dbo.AspNetUserRoles", newName: "UserRoles");
            RenameTable(name: "dbo.AspNetUsers", newName: "User");
            RenameTable(name: "dbo.AspNetUserClaims", newName: "UserClaim");
            RenameTable(name: "dbo.AspNetUserLogins", newName: "UserLogin");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.UserLogin", newName: "AspNetUserLogins");
            RenameTable(name: "dbo.UserClaim", newName: "AspNetUserClaims");
            RenameTable(name: "dbo.User", newName: "AspNetUsers");
            RenameTable(name: "dbo.UserRoles", newName: "AspNetUserRoles");
            RenameTable(name: "dbo.Roles", newName: "AspNetRoles");
        }
    }
}
