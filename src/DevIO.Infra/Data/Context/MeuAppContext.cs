using DevIO.Business.Models.Fornecedores;
using DevIO.Business.Models.Produtos;
using DevIO.Infra.Data.Mappings;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace DevIO.Infra.Data.Context
{
    public class MeuAppContext : DbContext
    {
        public MeuAppContext() : base("DefaultConnection") 
        { 
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Fornecedor> Fornecedors { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar")
                .HasMaxLength(100));

            modelBuilder.Configurations.Add(new FornecedorMapping());
            modelBuilder.Configurations.Add(new EnderecoMapping());
            modelBuilder.Configurations.Add(new ProdutoMapping());
            
            base.OnModelCreating(modelBuilder);
        }
    }
}
