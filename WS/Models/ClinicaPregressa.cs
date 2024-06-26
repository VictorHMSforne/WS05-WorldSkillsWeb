using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace WS.Models
{
    [Table("ClinicaPregressa")]
    public class ClinicaPregressa
    {
        [Key]
        public int MyProperty { get; set; }
        [NotNull]
        public string DoencasInfecciosas { get; set; }
        [NotNull]
        public string Alergias { get; set; }
        [NotNull]
        public string Cirurgias { get; set; }
        [NotNull]
        public string TransfusaoSangue { get; set; }
        [NotNull]
        public string MedicamentosContinuo { get; set; }
        
        public string Outros { get; set; }

        [NotMapped]
        public string Dados { get; set; }
    }
}
