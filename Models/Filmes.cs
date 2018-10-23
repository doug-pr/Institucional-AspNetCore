using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FilmesCRUDRazor.Models
{
    public class Filme
    {
        public int FilmeId { get; set; }

        [Display(Name = "Título")]
        [Required(ErrorMessage = "Este campo é obrigatório.")]       
        public string Titulo { get; set; }

        [Display(Name = "Data de Lançamento")]
        [DisplayFormat(DataFormatString = "{0: dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        //[RegularExpression(@"^(((0[1-9]|[12]\d|3[01])\/(0[13578]|1[02])\/((19|[2-9]\d)\d{2}))|((0[1-9]|[12]\d|30)\/(0[13456789]|1[012])\/((19|[2-9]\d)\d{2}))|((0[1-9]|1\d|2[0-8])\/02\/((19|[2-9]\d)\d{2}))|          (29\/02\/((1[6-9]|[2-9]\d)(0[48]|[2468][048]|[13579][26])|((16|[2468][048]|[3579][26])00))))$", ErrorMessage = "Data invalida")]
        [Required(ErrorMessage = "Este campo é obrigatório.")]
        [DataType(DataType.Date, ErrorMessage = "Uma data válida deve ser informada.")]
        public DateTime DataLancamento { get; set; }

        [Display(Name = "Gênero")]
        public string Genero { get; set; }

        [Display(Name = "Preço")]
        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:###,##0.00}")]
        public decimal Preco { get; set; }

    }
}