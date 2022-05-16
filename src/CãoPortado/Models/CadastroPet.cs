using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetHotel.Models
{
    [Table("CadastroPet")]

    public class CadastroPet
    {
        [Key]

        [Required(ErrorMessage = ("Obrigatório informar o nome CPF do usuário!"))]

        public int CPF_Usuario { get; set; }

        [Required(ErrorMessage = ("Obrigatório informar o nome do Pet!"))]
        public string Nome { get; set; }

        [Required(ErrorMessage = ("Obrigatório informar o porte!"))]
        public string Porte { get; set; }

        [Required(ErrorMessage = ("Obrigatório informar a idade!"))]
        public int Idade { get; set; }

        [Required(ErrorMessage = ("Obrigatório informar a raça!"))]
        public string Raca { get; set; }

        [Required(ErrorMessage = ("Obrigatório selecionar as vacinas já tomadas!"))]
        public string Vacina { get; set; }

    }

}