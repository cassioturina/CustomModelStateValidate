using System.ComponentModel.DataAnnotations;

namespace CustomModelStateValidate.Models
{
    public class ClienteModel
    {
        [Required(ErrorMessage = "{0} é obrigatório")]
        [StringLength(120, ErrorMessage = "{0} deve ter entre {2} e {1} caracteres", MinimumLength = 3)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "{0} é obrigatória")]
        [Range(6,18 , ErrorMessage = "{0} deve ser entre {1} e {2} anos")]
        public int Idade { get; set; }
    }
}
