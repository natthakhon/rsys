using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RSys.Sqlite.DTO
{
    [Table("Occupation")]
    public class OccupationDTO
    {
        [Key]
        public string InfoId { set; get; }
        public ProfessionDTO Profession { set; get; }
        public string JobTitle { set; get; }
        public BusinessType BusinessType { set; get; }
    }
}
