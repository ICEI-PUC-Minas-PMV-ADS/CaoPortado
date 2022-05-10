using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace PetHotel.Models
{
     [Table("Clientes")]

    public class Clientes
    {
        [Key]
        public int Id{ get; set; }

        [Required(ErrorMessage = "Obrigatorio Informar o nome!")]
        public string Nome { get; set; }


        [Required(ErrorMessage = "Obrigatorio Informar a Senha!")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Obrigatorio Informar o Perfil!")]
        public Perfil Perfil { get; set; }
    }

    public enum Perfil
    {
        Admin,
        User
    }
}

