using System;
using System.ComponentModel.DataAnnotations;

namespace Tasks
{
    public class Tarefa
    {
        [ScaffoldColumn(false)]
        public int IDTarefa { get; set; }

        [Required, Display(Name = "Cadastrante")]
        public int Cadastrante { get; set; }

        [Required, Display(Name = "Sistema")]
        public int Sistema { get; set; }

        [Required, Display(Name = "Ordem")]
        public int Ordem { get; set; }

        [Required, StringLength(20), Display(Name = "Titulo")]
        public string Titulo { get; set; }

        [Required, StringLength(500), Display(Name = "Descricao")]
        public string Descricao { get; set; }

        [Required, StringLength(10), Display(Name = "Cliente")]
        public string Cliente { get; set; }

        [Required, Display(Name = "Situacao")]
        public int Situacao { get; set; }

        [DataType(DataType.Date), Display(Name = "DataPrevisao")]
        public DataType DataPrevisao { get; set; }

        [Required, DataType(DataType.DateTime), Display(Name = "DataCadastro")]
        public DataType DataCadastro { get; set; }

        [DataType(DataType.DateTime), Display(Name = "DataInicio")]
        public DataType DataInicio { get; set; }

        [DataType(DataType.DateTime), Display(Name = "DataFim")]
        public DataType DataFim { get; set; }

        [Display(Name = "Desenvolvedor")]
        public int Desenvolvedor { get; set; }

        [Display(Name = "App")]
        public bool app { get; set; }

    }
}