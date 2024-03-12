namespace StudentRegisteration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class makingChangeToDatabase : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Students", new[] { "Email" });
        }
        
        public override void Down()
        {
            CreateIndex("dbo.Students", "Email", unique: true);
        }
    }
}
