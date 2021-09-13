using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RSys.Sqlite.DTO
{
    [Table("Questionnaire")]
    public class QuestionnaireDTO
    {
        [Key]
        public string InfoId { set; get; }
        public PersonalInfoDTO PersonalInfo { set; get; }
        public AddressDTO Address { set; get; }
        public OccupationDTO Occupation { set; get; }
        public DateTime CreateDate { set; get; }
    }
}
