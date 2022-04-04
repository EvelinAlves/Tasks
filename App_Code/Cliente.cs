using System.ComponentModel.DataAnnotations;

namespace Tasks
{
    public class Cliente
    {
        [StringLength(10), ScaffoldColumn(false)]
        public string IDCliente { get; set; }

        [Required, StringLength(20), Display(Name = "Cliente")]
        public string NomeCliente { get; set; }

        [Required, Display(Name = "Sistema")]
        public int Sistema { get; set; }
    }
}