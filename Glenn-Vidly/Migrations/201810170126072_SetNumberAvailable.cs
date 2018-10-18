namespace Glenn_Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SetNumberAvailable : DbMigration
    {
        public override void Up()
        {
            Sql("Update Movies SET NumberAvailable = NumberInStock");
        }
        
        public override void Down()
        {
        }
    }
}
