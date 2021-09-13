using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RSys.Sqlite.DTO
{
    [Table("Address")]
    public class AddressDTO
    {
        [Key]
        public string InfoId { set; get; }
        public string House { set; get; }
        public string Work { set; get; }
    }
}
