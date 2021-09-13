using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RSys.Sqlite.DTO
{
    [Table("Country")]
    public class CountryDTO
    {
        [Key]
        public int ContryId { set; get; }
        public string CountryDescription { set; get; }
        public bool IsAllowed { set; get; }
    }
}
