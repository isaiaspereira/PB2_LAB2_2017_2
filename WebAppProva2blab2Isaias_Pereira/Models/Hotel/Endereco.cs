using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppProva2blab2Isaias_Pereira.Models.Hotel
{
    
    public class Endereco
    {
        [ForeignKey("HospedeId")]
        public int EnderecoId { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string CEP { get; set; }
        public string Numero { get; set; }

        public virtual Hospede hospede { get; set; }

    }
}