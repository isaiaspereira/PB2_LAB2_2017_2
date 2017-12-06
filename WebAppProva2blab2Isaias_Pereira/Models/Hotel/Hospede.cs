using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebAppProva2blab2Isaias_Pereira.Models.Hotel
{
    public class Hospede
    {
        [Key]
        public int HospedeId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public int ReservaId { get; set; }
        public int EnderecoId { get; set; }
        public virtual ICollection<Reserva> reserva { get; set; }
        public virtual Endereco endereco { get; set; }

    }
}