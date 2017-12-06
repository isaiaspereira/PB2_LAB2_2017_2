
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using WebAppProva2blab2Isaias_Pereira.Models.Hotel;

namespace WebAppProva2blab2Isaias_Pereira.Models.Configurations
{
    public class ReservaConfigurations:EntityTypeConfiguration<Reserva>
    {
        public ReservaConfigurations()
        {
            HasKey(c => c.ReservaId);
            
        }
    }
}