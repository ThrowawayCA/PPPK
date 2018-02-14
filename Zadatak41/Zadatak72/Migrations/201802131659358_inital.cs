namespace Zadatak72.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inital : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Kolegiji",
                c => new
                    {
                        IDkolegij = c.Int(nullable: false, identity: true),
                        Naziv = c.String(nullable: false, maxLength: 120),
                        SkraceniNaziv = c.String(maxLength: 10),
                        ECTSbodova = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IDkolegij);
            
            CreateTable(
                "dbo.Studenti",
                c => new
                    {
                        IDStudent = c.Int(nullable: false, identity: true),
                        Ime = c.String(nullable: false, maxLength: 30),
                        Prezime = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.IDStudent);
            
            CreateTable(
                "dbo.UpisaniKolegiji",
                c => new
                    {
                        IDUpisaniKolegij = c.Int(nullable: false, identity: true),
                        StudentID = c.Int(nullable: false),
                        KolegijID = c.Int(nullable: false),
                        Kolegij_IDkolegij = c.Int(),
                    })
                .PrimaryKey(t => t.IDUpisaniKolegij)
                .ForeignKey("dbo.Kolegiji", t => t.Kolegij_IDkolegij)
                .ForeignKey("dbo.Studenti", t => t.StudentID, cascadeDelete: true)
                .Index(t => t.StudentID)
                .Index(t => t.Kolegij_IDkolegij);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UpisaniKolegiji", "StudentID", "dbo.Studenti");
            DropForeignKey("dbo.UpisaniKolegiji", "Kolegij_IDkolegij", "dbo.Kolegiji");
            DropIndex("dbo.UpisaniKolegiji", new[] { "Kolegij_IDkolegij" });
            DropIndex("dbo.UpisaniKolegiji", new[] { "StudentID" });
            DropTable("dbo.UpisaniKolegiji");
            DropTable("dbo.Studenti");
            DropTable("dbo.Kolegiji");
        }
    }
}
