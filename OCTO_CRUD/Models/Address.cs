using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;


namespace OCTO_CRUD.Models
{
    public class Address 
    {
        [Key]
        public int IdAddress { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        [DisplayName("Endereço")]
        public string HomeLocation { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        [DisplayName("Cidade")]
        public string City { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        [DisplayName("Estado")]
        public string State { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        [DisplayName("CEP")]
        public string ZipCode { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        [DisplayName("Forma de Cobrança")]
        public string ChargingMethod { get; set; }
    }
}
