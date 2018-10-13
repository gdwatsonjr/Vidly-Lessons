namespace Glenn_Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCustomers : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Customers (Name, IsSubscribedToNewsLetter, MembershipTypeId, Birthdate) Values ('John Smith', 0, 1, '12/15/1982')");
            Sql("INSERT INTO Customers (Name, IsSubscribedToNewsLetter, MembershipTypeId, Birthdate) Values ('Mary Smith', 1, 2, NULL)");
        }
        
        public override void Down()
        {
        }
    }
}
