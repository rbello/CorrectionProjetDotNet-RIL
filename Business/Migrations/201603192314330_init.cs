namespace Business.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Personnes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nom = c.String(),
                        Prenom = c.String(),
                        AdressePays = c.String(),
                        AdresseVille = c.String(),
                        AdresseCp = c.String(),
                        Adresse1 = c.String(),
                        Adresse2 = c.String(),
                        NumeroCarteFidelite = c.String(),
                        Login = c.String(),
                        Password = c.String(),
                        Permissions = c.Int(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Factures",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NumeroFacture = c.String(),
                        Client_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Personnes", t => t.Client_Id)
                .Index(t => t.Client_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Factures", "Client_Id", "dbo.Personnes");
            DropIndex("dbo.Factures", new[] { "Client_Id" });
            DropTable("dbo.Factures");
            DropTable("dbo.Personnes");
        }
    }
}
