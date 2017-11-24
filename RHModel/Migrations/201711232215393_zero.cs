namespace RHModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class zero : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cargo",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SalarioBase = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Nome = c.String(nullable: false),
                        CargoPaiId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cargo", t => t.CargoPaiId)
                .Index(t => t.CargoPaiId);
            
            CreateTable(
                "dbo.Empregado",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false),
                        Cpf = c.String(nullable: false),
                        DataNascimento = c.DateTime(nullable: false),
                        DataContratacao = c.DateTime(nullable: false),
                        Salario = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CargoId = c.Int(nullable: false),
                        SuperiorId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cargo", t => t.CargoId, cascadeDelete: true)
                .ForeignKey("dbo.Empregado", t => t.SuperiorId)
                .Index(t => t.CargoId)
                .Index(t => t.SuperiorId);
            
            CreateTable(
                "dbo.HistoricoCargo",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmpregadoId = c.Int(nullable: false),
                        CargoId = c.Int(nullable: false),
                        DataInicio = c.DateTime(nullable: false),
                        DataFim = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cargo", t => t.CargoId, cascadeDelete: true)
                .ForeignKey("dbo.Empregado", t => t.EmpregadoId, cascadeDelete: true)
                .Index(t => t.EmpregadoId)
                .Index(t => t.CargoId);
            
            CreateTable(
                "dbo.HistoricoEmpregadoSetor",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SetorId = c.Int(nullable: false),
                        EmpregadoId = c.Int(nullable: false),
                        DataInicio = c.DateTime(nullable: false),
                        DataFim = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Empregado", t => t.EmpregadoId, cascadeDelete: true)
                .ForeignKey("dbo.Setor", t => t.SetorId, cascadeDelete: true)
                .Index(t => t.SetorId)
                .Index(t => t.EmpregadoId);
            
            CreateTable(
                "dbo.Setor",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        DataExtincao = c.DateTime(),
                        SetorPaiId = c.Int(nullable: false),
                        ResponsavelId = c.Int(nullable: false),
                        Atividades = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Empregado", t => t.ResponsavelId, cascadeDelete: true)
                .ForeignKey("dbo.Setor", t => t.SetorPaiId)
                .Index(t => t.SetorPaiId)
                .Index(t => t.ResponsavelId);
            
            CreateTable(
                "dbo.HistoricoSalarioCargo",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CargoId = c.Int(nullable: false),
                        Salario = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DataInicio = c.DateTime(nullable: false),
                        DataFim = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cargo", t => t.CargoId, cascadeDelete: true)
                .Index(t => t.CargoId);
            
            CreateTable(
                "dbo.HistoricoSalarioEmpregado",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmpregadoId = c.Int(nullable: false),
                        Salario = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DataInicio = c.DateTime(nullable: false),
                        DataFim = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Empregado", t => t.EmpregadoId, cascadeDelete: true)
                .Index(t => t.EmpregadoId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.HistoricoSalarioEmpregado", "EmpregadoId", "dbo.Empregado");
            DropForeignKey("dbo.HistoricoSalarioCargo", "CargoId", "dbo.Cargo");
            DropForeignKey("dbo.HistoricoEmpregadoSetor", "SetorId", "dbo.Setor");
            DropForeignKey("dbo.Setor", "SetorPaiId", "dbo.Setor");
            DropForeignKey("dbo.Setor", "ResponsavelId", "dbo.Empregado");
            DropForeignKey("dbo.HistoricoEmpregadoSetor", "EmpregadoId", "dbo.Empregado");
            DropForeignKey("dbo.HistoricoCargo", "EmpregadoId", "dbo.Empregado");
            DropForeignKey("dbo.HistoricoCargo", "CargoId", "dbo.Cargo");
            DropForeignKey("dbo.Empregado", "SuperiorId", "dbo.Empregado");
            DropForeignKey("dbo.Empregado", "CargoId", "dbo.Cargo");
            DropForeignKey("dbo.Cargo", "CargoPaiId", "dbo.Cargo");
            DropIndex("dbo.HistoricoSalarioEmpregado", new[] { "EmpregadoId" });
            DropIndex("dbo.HistoricoSalarioCargo", new[] { "CargoId" });
            DropIndex("dbo.Setor", new[] { "ResponsavelId" });
            DropIndex("dbo.Setor", new[] { "SetorPaiId" });
            DropIndex("dbo.HistoricoEmpregadoSetor", new[] { "EmpregadoId" });
            DropIndex("dbo.HistoricoEmpregadoSetor", new[] { "SetorId" });
            DropIndex("dbo.HistoricoCargo", new[] { "CargoId" });
            DropIndex("dbo.HistoricoCargo", new[] { "EmpregadoId" });
            DropIndex("dbo.Empregado", new[] { "SuperiorId" });
            DropIndex("dbo.Empregado", new[] { "CargoId" });
            DropIndex("dbo.Cargo", new[] { "CargoPaiId" });
            DropTable("dbo.HistoricoSalarioEmpregado");
            DropTable("dbo.HistoricoSalarioCargo");
            DropTable("dbo.Setor");
            DropTable("dbo.HistoricoEmpregadoSetor");
            DropTable("dbo.HistoricoCargo");
            DropTable("dbo.Empregado");
            DropTable("dbo.Cargo");
        }
    }
}
