using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RSys.Sqlite.DTO
{
    [Table("PersonalInfo")]
    public class PersonalInfoDTO
    {
        [Key]
        public string InfoId { set; get; }
        public TitleDTO Title { set; get; }
        public string Name { set; get; }
        public string Lastname { set; get; }
        public DateTime DOB { set; get; }
        public CountryDTO Country { set; get; }
    }
}
