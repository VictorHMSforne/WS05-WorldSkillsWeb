using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace WS.Models
{
    [Table("ExameClinico")]
    public class ExameClinico
    {
        [Key]
        public int Id { get; set; }
        [NotNull]
        public string Ocupacao { get; set; }
        [NotNull]
        public string Nome { get; set; }
        [NotNull]
        public string Idade { get; set; }
        [NotNull]
        public string RG { get; set; }
        [NotNull]
        public string Funcao { get; set; }
        [NotNull]
        public string Empresa { get; set; }
    }
}
