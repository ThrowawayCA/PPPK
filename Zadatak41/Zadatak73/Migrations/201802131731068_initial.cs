namespace Zadatak73.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Kolegiji",
                c => new
                    {
                        IDKolegij = c.Int(nullable: false, identity: true),
                        Naziv = c.String(nullable: false, maxLength: 120),
                        SkraceniNaziv = c.String(maxLength: 10),
                        ECTSBodovi = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IDKolegij);
            
            CreateTable(
                "dbo.Studenti",
                c => new
                    {
                        IDStudent = c.Int(nullable: false, identity: true),
                        Ime = c.String(nullable: false, maxLength: 30),
                        Prezime = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.IDStudent);
            
            CreateTable(
                "dbo.UpisaniKolegiji",
                c => new
                    {
                        IDUpisaniKolegiji = c.Int(nullable: false, identity: true),
                        StudentID = c.Int(nullable: false),
                        KolegijID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IDUpisaniKolegiji)
                .ForeignKey("dbo.Kolegiji", t => t.KolegijID, cascadeDelete: true)
                .ForeignKey("dbo.Studenti", t => t.StudentID, cascadeDelete: true)
                .Index(t => t.StudentID)
                .Index(t => t.KolegijID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UpisaniKolegiji", "StudentID", "dbo.Studenti");
            DropForeignKey("dbo.UpisaniKolegiji", "KolegijID", "dbo.Kolegiji");
            DropIndex("dbo.UpisaniKolegiji", new[] { "KolegijID" });
            DropIndex("dbo.UpisaniKolegiji", new[] { "StudentID" });
            DropTable("dbo.UpisaniKolegiji");
            DropTable("dbo.Studenti");
            DropTable("dbo.Kolegiji");
        }
    }
}
