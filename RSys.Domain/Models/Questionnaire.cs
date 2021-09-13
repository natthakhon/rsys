using System;
using System.Collections.Generic;
using System.Text;

namespace RSys.Domain.Models
{
    public class Questionnaire
    {
        public string InfoId { set; get; }
        public PersonalInfo PersonalInfo { set; get; }
        public Address Address { set; get; }
        public Occupation Occupation { set; get; }
        public DateTime CreateDate { set; get; }
    }
}
