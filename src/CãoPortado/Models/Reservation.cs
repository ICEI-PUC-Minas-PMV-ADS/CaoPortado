using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetHotel.Models
{
    public class Reservation
    {

    public int Id { get; set; }
    [StringLength(100)]

    public string Name { get; set; }
    [StringLength(100)]

    public string Email { get; set; }

    public DateTime DataDeChegadaHora { get; set; }

    public DateTime DataDePartidaHora { get; set; }
    [StringLength(50)]

    public string Serviços { get; set; }

    public int QuantidadeDePets { get; set; }
    [NotMapped]

    public string DataDeChegada => DataDeChegadaHora.ToString("dd/MM/yyyy");
    [NotMapped]

    public string HoraDeChegada => DataDeChegadaHora.ToString("h : mm tt");
    [NotMapped]

    public string DataDePartida => DataDePartidaHora.ToString("dd/MM/yyyy");
    [NotMapped]

    public string HoraDePartidar => DataDePartidaHora.ToString("h : mm tt");



}
}