using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace PetHotel.Models
{
     [Table("Clientes")]

    public class Clientes
    {
        [Key]
        public int Id{ get; set; }

        [Required(ErrorMessage = ("Obrigatório informar o nome completo"))]
        public string Nome { get; set; }

        [Required(ErrorMessage = ("Obrigatório informar o CPF"))]
        public string CPF { get; set; }

        [Required(ErrorMessage = ("Obrigatório informar a data de nascimento"))]
        public string DataDeNascimento { get; set; }

        [Required(ErrorMessage = ("Obrigatório informar o endereço"))]
        public string Endereco { get; set; }

        [Required(ErrorMessage = ("Obrigatório informar o telefone"))]
        public string Telefone { get; set; }

        [Required(ErrorMessage = ("Obrigatório informar o email"))]
        public string Email { get; set; }

        [Required(ErrorMessage = ("Obrigatório informar senha"))]
        public string Senha { get; set; }

        [Required(ErrorMessage = ("Obrigatório repetir a  senha"))]
        public string Senha2 { get; set; }


        public Perfil Perfil { get; set; }
    }

    public enum Perfil
    {
        User = 2,
        Admin = 1
        
    }
}

