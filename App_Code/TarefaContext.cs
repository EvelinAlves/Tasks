using System.Data.Entity;

namespace Tasks
{
    public class TarefaContext : DbContext
    {
        /*public TarefaContext() : base("Tasks")
        {
        }*/
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Sistema> Sistemas { get; set; }
        public DbSet<Situacao> Situacoes { get; set; }
        public DbSet<Tarefa> Tarefas { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        /*public DbSet<TarefaCliente> TarefaClientes { get; set; }*/
        public DbSet<TipoUsuario> TipoUsuarios { get; set; }
    }
}