using System.ComponentModel.DataAnnotations;

namespace Tasks
{
    public class TipoUsuario
    {
        [ScaffoldColumn(false)]
        public int IDTipoUsuario { get; set; }

        [Required, StringLength(15), Display(Name = "Tipo")]
        public string TpUsuario { get; set; }
    }
}