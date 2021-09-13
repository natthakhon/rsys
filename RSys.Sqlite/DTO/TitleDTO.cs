using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RSys.Sqlite.DTO
{
    [Table("Title")]
    public class TitleDTO
    {
        [Key]
        public int TitleId { set; get; }
        public string TitleDescription { set; get; }
    }
}
