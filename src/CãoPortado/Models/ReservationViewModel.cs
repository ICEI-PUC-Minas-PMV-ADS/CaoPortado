using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace PetHotel.Models
{
    public class ReservationViewModel
    {
        public int Id { get; set; }
        [StringLength(100)]

        public string Name { get; set; }
        [StringLength(100)]

        public string Email { get; set; }
        [StringLength(50)]

        public string Serviços { get; set; }

        public int QuantidadeDePets { get; set; }
        [Required]

        public string DataDeChegada { get; set; }
        [Required]

        public string HoraDeChegada { get; set; }
        [Required]

        public string DataDePartida { get; set; }
        [Required]

        public string HoraDePartidar { get; set; }

        public DateTime DataDeChegadaHora => DateTime.ParseExact($"{DataDeChegada} {HoraDeChegada}", "dd/MM/yyyy h : mm tt", CultureInfo.InvariantCulture);

        public DateTime DataDePartidaHora => DateTime.ParseExact($"{DataDePartida} {HoraDePartidar}", "dd/MM/yyyy h : mm tt", CultureInfo.InvariantCulture);

    }
}
