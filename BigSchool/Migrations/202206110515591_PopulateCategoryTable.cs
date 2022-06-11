namespace BigSchool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCategoryTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO CATEGORIES (ID, NAME) VALUES (1,'KINH TE')");
            Sql("INSERT INTO CATEGORIES (ID, NAME) VALUES (2,'KINH DOANH')");
            Sql("INSERT INTO CATEGORIES (ID, NAME) VALUES (3,'CONG NGHE THONG TIN')");


        }

        public override void Down()
        {
        }
    }
}
