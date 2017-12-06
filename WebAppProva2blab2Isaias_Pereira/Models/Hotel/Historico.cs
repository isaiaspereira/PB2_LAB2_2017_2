using System;
using System.Collections.Generic;

namespace WebAppProva2blab2Isaias_Pereira.Models.Hotel
{
    public class Historico
    {
        public int HistoricoId { get; set; }
        public string Detalhes { get; set; }
        public DateTime DataHora{ get; set; }

        public virtual ICollection<Reserva> Reservas{ get; set; }
    }
}