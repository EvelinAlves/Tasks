using System.ComponentModel.DataAnnotations;

namespace Tasks
{
    public class Usuario
    {
        [ScaffoldColumn(false)]
        public int IDUsuario { get; set; }

        [Required, StringLength(15), Display(Name = "Usuario")]
        public string NomeUsuario { get; set; }

        [Required, Display(Name = "Tipo")]
        public int Tipo { get; set; }

        [Required, StringLength(50), Display(Name = "Email")]
        public string Email { get; set; }

        [Required, StringLength(10), Display(Name = "Senha")]
        public string Senha { get; set; }
    }
}