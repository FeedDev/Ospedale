namespace Ospedale.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrazioneInvioProgettoAlDB : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Medico", "IdReparto", c => c.Int(nullable: false));
            CreateIndex("dbo.Medico", "IdReparto");
            AddForeignKey("dbo.Medico", "IdReparto", "dbo.Reparto", "IdReparto", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Medico", "IdReparto", "dbo.Reparto");
            DropIndex("dbo.Medico", new[] { "IdReparto" });
            DropColumn("dbo.Medico", "IdReparto");
        }
    }
}
