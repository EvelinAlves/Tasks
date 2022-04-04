using System.ComponentModel.DataAnnotations;

namespace Tasks
{
    public class TarefaCliente
    {
        [ScaffoldColumn(false)]
        public int IDTarefa { get; set; }

        [StringLength(10), Display(Name = "Cliente")]
        public string IDCliente { get; set; }
    }
}