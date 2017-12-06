using System.Collections;
using System.Collections.Generic;

namespace WebAppProva2blab2Isaias_Pereira.Models.Hotel
{
    public class Categoria
    {
        public int CategoriaId { get; set; }
        public string Descricao { get; set; }

        public virtual ICollection<Reserva> Reservas{ get; set; }
    }
}