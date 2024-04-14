namespace CapaDatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTablaReserva : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Reserva",
                c => new
                    {
                        ReservaId = c.Int(nullable: false, identity: true),
                        TeatroId = c.Int(nullable: false),
                        ClienteId = c.Int(nullable: false),
                        FechaReserva = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ReservaId)
                .ForeignKey("dbo.Clientes", t => t.ClienteId)
                .ForeignKey("dbo.Teatros", t => t.TeatroId)
                .Index(t => t.TeatroId)
                .Index(t => t.ClienteId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reserva", "TeatroId", "dbo.Teatros");
            DropForeignKey("dbo.Reserva", "ClienteId", "dbo.Clientes");
            DropIndex("dbo.Reserva", new[] { "ClienteId" });
            DropIndex("dbo.Reserva", new[] { "TeatroId" });
            DropTable("dbo.Reserva");
        }
    }
}
