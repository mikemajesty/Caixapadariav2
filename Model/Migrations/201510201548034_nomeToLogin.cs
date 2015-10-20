namespace Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nomeToLogin : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Caixa",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        IDUsuario = c.Int(nullable: false),
                        Valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Categoria",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Cliente",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        CPF = c.String(),
                        Celular = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Comanda",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Codigo = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Datas",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Data = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Fiado",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        IDCliente = c.Int(nullable: false),
                        Valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                        IDFuncionario = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.MovimentacaoCaixa",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Data = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.MovimentacaoProduto",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Codigo = c.String(),
                        Data = c.DateTime(nullable: false),
                        Quantidade = c.Int(),
                        Valor = c.Decimal(precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Produto",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Codigo = c.String(),
                        Nome = c.String(),
                        Categoria = c.Int(nullable: false),
                        PrecoCompra = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PrecoVenda = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Descricao = c.String(),
                        Porcentagem = c.Int(),
                        TipoCadastro = c.Int(nullable: false),
                        GerenciarEstoque = c.Boolean(nullable: false),
                        Quantidade = c.Int(),
                        QuantidadeMinima = c.Int(),
                        QuantidadeMaxima = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.TipoCadastro",
                c => new
                    {
                        TipoCadastroID = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                    })
                .PrimaryKey(t => t.TipoCadastroID);
            
            CreateTable(
                "dbo.TipoPagamento",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Tipo = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Login = c.String(),
                        Senha = c.String(),
                        Permicao = c.String(),
                        NomeCompleto = c.String(),
                        UltimoAcesso = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Venda",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        VendaTotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        LucroTotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Data = c.DateTime(nullable: false),
                        IdUsuario = c.Int(nullable: false),
                        IDTIPOPAGAMENTO = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.VendaComComandaAtiva",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        IDProduto = c.Int(nullable: false),
                        IDComanda = c.Int(nullable: false),
                        Quantidade = c.Int(nullable: false),
                        PrecoTotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.VendaComComandaAtiva");
            DropTable("dbo.Venda");
            DropTable("dbo.Usuarios");
            DropTable("dbo.TipoPagamento");
            DropTable("dbo.TipoCadastro");
            DropTable("dbo.Produto");
            DropTable("dbo.MovimentacaoProduto");
            DropTable("dbo.MovimentacaoCaixa");
            DropTable("dbo.Fiado");
            DropTable("dbo.Datas");
            DropTable("dbo.Comanda");
            DropTable("dbo.Cliente");
            DropTable("dbo.Categoria");
            DropTable("dbo.Caixa");
        }
    }
}
