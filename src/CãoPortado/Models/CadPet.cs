using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetHotel.Models
{
    [Table("CadPet")]
    public class CadPet
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = ("Obrigatório informar o nome CPF do usuário!"))]
        public string CPF_Usuario { get; set; }

        [Required(ErrorMessage = ("Obrigatório informar o nome do Pet!"))]
        public string Nome { get; set; }
        
        [Required(ErrorMessage = ("Obrigatório informar a idade!"))]
        public int AnoNascimento { get; set; }

        [Required(ErrorMessage = ("Obrigatório informar o porte!"))]
        public string Porte { get; set; }

        [Required(ErrorMessage = ("Informe a raça!"))]
        public string Raca { get; set; }

        [Required(ErrorMessage = ("Obrigatório selecionar as vacinas tomadas!"))]
        public bool Raiva { get; set; }

        [Required(ErrorMessage = ("Obrigatório selecionar as vacinas tomadas!"))]
        public bool Giárdia { get; set; }

        [Required(ErrorMessage = ("Obrigatório selecionar as vacinas tomadas!"))]
        public bool PolivalenteV8ouV10 { get; set; }
    }
    

    public enum Porte
    {
        Pequeno,
        Medio, 
        Grande

    }
    
    
}
