using System.ComponentModel.DataAnnotations;

namespace Tasks
{
    public class Situacao
    {
        [ScaffoldColumn(false)]
        public int IDSituacao { get; set; }

        [Required, StringLength(15), Display(Name = "Situacao")]
        public string NomeSituacao { get; set; }
    }
}