namespace Business.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Chambres",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Numero = c.String(),
                        NbrLitsSimple = c.Int(nullable: false),
                        NbrLitsDouble = c.Int(nullable: false),
                        Disponible = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.OptionChambres",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nom = c.String(),
                        Chambre_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Chambres", t => t.Chambre_Id)
                .Index(t => t.Chambre_Id);
            
            CreateTable(
                "dbo.Reservations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateDebut = c.DateTime(nullable: false),
                        DateFin = c.DateTime(nullable: false),
                        NbrPersonnes = c.Int(nullable: false),
                        TypeRepas = c.Int(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                        Facture_Id = c.Int(),
                        Chambre_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Factures", t => t.Facture_Id)
                .ForeignKey("dbo.Chambres", t => t.Chambre_Id)
                .Index(t => t.Facture_Id)
                .Index(t => t.Chambre_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reservations", "Chambre_Id", "dbo.Chambres");
            DropForeignKey("dbo.Reservations", "Facture_Id", "dbo.Factures");
            DropForeignKey("dbo.OptionChambres", "Chambre_Id", "dbo.Chambres");
            DropIndex("dbo.Reservations", new[] { "Chambre_Id" });
            DropIndex("dbo.Reservations", new[] { "Facture_Id" });
            DropIndex("dbo.OptionChambres", new[] { "Chambre_Id" });
            DropTable("dbo.Reservations");
            DropTable("dbo.OptionChambres");
            DropTable("dbo.Chambres");
        }
    }
}
