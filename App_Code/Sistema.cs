using System.ComponentModel.DataAnnotations;

namespace Tasks
{
    public class Sistema
    {
        [ScaffoldColumn(false)]
        public int IDSistema { get; set; }

        [Required, StringLength(15), Display(Name = "Sistema")]
        public string NomeSistema { get; set; }

        [Required, Display(Name = "Gestor")]
        public int Gestor { get; set; }

        [Required, StringLength(50), Display(Name = "Email")]
        public string Email { get; set; }
    }
}