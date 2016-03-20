namespace Business.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Personnes", "Civilite", c => c.Int(nullable: false));
            AddColumn("dbo.Personnes", "Email", c => c.String());
            AddColumn("dbo.Personnes", "TelPortable", c => c.String());
            AddColumn("dbo.Personnes", "TelFixe", c => c.String());
            AddColumn("dbo.Personnes", "Entreprise", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Personnes", "Entreprise");
            DropColumn("dbo.Personnes", "TelFixe");
            DropColumn("dbo.Personnes", "TelPortable");
            DropColumn("dbo.Personnes", "Email");
            DropColumn("dbo.Personnes", "Civilite");
        }
    }
}
