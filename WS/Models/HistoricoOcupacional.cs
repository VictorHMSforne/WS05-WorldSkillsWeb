using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace WS.Models
{
    [Table("HistoricoOcupacional")]
    public class HistoricoOcupacional
    {
        [Key]
        public int Id { get; set; }
        [NotNull]
        public string FuncoesAnteriores { get; set; }
        [NotNull]
        public string AcidentesTrabalho { get; set; }
    }
}
