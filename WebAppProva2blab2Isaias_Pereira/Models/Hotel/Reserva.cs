using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppProva2blab2Isaias_Pereira.Models.Hotel
{
    public class Reserva
    {
        public int ReservaId { get; set; }
        public int NumeroQuarto { get; set; }
        public DateTime DataEntrada { get; set; }
        public DateTime DataSaida { get; set; }
        public decimal Valor { get; set; }

        public virtual ICollection<Historico> Historicos { get; set; }
    }
}