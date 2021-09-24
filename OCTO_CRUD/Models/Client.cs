using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

[assembly: ComVisible(false)]

[assembly: Guid("09fc9855-aeef-4d1a-8f43-e6028930d844")]


namespace OCTO_CRUD.Models
{
    public class Client
    {
        [Key]
        public int IdClient { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        [Required(ErrorMessage = "Este campo é de preenchimento obrigatório")]
        [DisplayName("Nome")]
        public string FullName { get; set; }

        [Column(TypeName = "varchar(50)")]
        [Required(ErrorMessage = "Este campo é de preenchimento obrigatório")]
        [DisplayName("CPF")]
        public string ZipCode { get; set; }

        [Column(TypeName = "varchar(50)")]
        [Required(ErrorMessage = "Este campo é de preenchimento obrigatório")]
        [DisplayName("CNPJ")]
        public string Cnpj { get; set; }

        [Column(TypeName = "varchar(50)")]
        [DisplayName("Celular")]
        public string CellPhone { get; set; }

        [Column(TypeName = "varchar(50)")]
        [DisplayName("Residencial")]
        public string HomePhone { get; set; }

        [Column(TypeName = "varchar(50)")]
        [DisplayName("Comercial")]
        public string CommercialPhone { get; set; }

    }
}
