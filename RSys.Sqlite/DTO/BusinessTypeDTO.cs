using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RSys.Sqlite.DTO
{
    [Table("BusinessType")]
    public class BusinessType
    {
        [Key]
        public int BusinessTypeId { set; get; }
        public string BusinessTypeDescription { set; get; }
    }
}
