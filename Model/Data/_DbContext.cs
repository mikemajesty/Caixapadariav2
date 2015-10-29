using System.Data.Entity;
using Model.Entidades;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Model.Data
{
    public class _DbContext : DbContext
    {
        public DbSet<Datas> Datas { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Comanda> Comanda { get; set; }
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Produto> Produto { get; set; }
        public DbSet<TipoCadastro> TipoCadastro { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<TipoPagamento> TipoPagamento { get; set; }
        public DbSet<VendaComComandaAtiva> VendaComComandaAtiva { get; set; }
        public DbSet<Venda> Venda { get; set; }
        public DbSet<Caixa> Caixa { get; set; }
        public DbSet<Fiado> Fiado { get; set; }
        public DbSet<MovimentacaoCaixa> MovimentacaoCaixa { get; set; }
        public DbSet<MovimentacaoProduto> MovimentacaoProduto { get; set; }
        public DbSet<Anomalias> Anomalias { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {           
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Entity<Usuarios>().ToTable(nameof(Usuarios));
            modelBuilder.Entity<Comanda>().ToTable(nameof(Comanda));
            modelBuilder.Entity<Categoria>().ToTable(nameof(Categoria));
            modelBuilder.Entity<Produto>().ToTable(nameof(Produto));
            modelBuilder.Entity<TipoCadastro>().ToTable(nameof(TipoCadastro));
            modelBuilder.Entity<Cliente>().ToTable(nameof(Cliente));
            modelBuilder.Entity<TipoPagamento>().ToTable(nameof(TipoPagamento));
            modelBuilder.Entity<VendaComComandaAtiva>().ToTable(nameof(VendaComComandaAtiva));
            modelBuilder.Entity<Venda>().ToTable(nameof(Venda));
            modelBuilder.Entity<Caixa>().ToTable(nameof(Caixa));
            modelBuilder.Entity<Fiado>().ToTable(nameof(Fiado)); 
            modelBuilder.Entity<MovimentacaoCaixa>().ToTable(nameof(MovimentacaoCaixa));
            modelBuilder.Entity<MovimentacaoProduto>().ToTable(nameof(MovimentacaoProduto));
            modelBuilder.Entity<Datas>().ToTable(nameof(Datas));
            modelBuilder.Entity<Anomalias>().ToTable(nameof(Anomalias));
        }
    }
}
