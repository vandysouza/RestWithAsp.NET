using RestWithASPNET.Model.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestWithASPNET.Model
{
    [Table("books")]
    public class Book : BaseEntity
    {
        [Column("author")]
        public string Autor { get; set; }

        [Column("launch_date")]
        public DateTime dataLançamento { get; set; }

        [Column("price")]
        public decimal Valor { get; set; }

        [Column("title")]
        public string Título { get; set; }
    }
}
