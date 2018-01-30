namespace VidlyMy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SetNamesOfMembershipType : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes Set MembershipTypeName = 'Pay as you go' Where Id =1 ");
            Sql("UPDATE MembershipTypes Set MembershipTypeName = 'Mounthly' Where Id =2 ");
            Sql("UPDATE MembershipTypes Set MembershipTypeName = 'Quarterly' Where Id =3 ");
            Sql("UPDATE MembershipTypes Set MembershipTypeName = 'Annual' Where Id =4 ");
        }
        
        public override void Down()
        {
        }
    }
}
