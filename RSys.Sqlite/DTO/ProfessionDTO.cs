using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RSys.Sqlite.DTO
{
    [Table("Profession")]
    public class ProfessionDTO
    {
        [Key]
        public int Id { set; get; }
        public string ProfessionDescription { set; get; }
    }
}
