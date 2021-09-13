using System;
using System.Collections.Generic;
using System.Text;

namespace RSys.Domain.Models
{
    public class PersonalInfo
    {
        public Title Title { set; get; }
        public string Name { set; get; }
        public string Lastname { set; get; }
        public DateTime DOB { set; get; }
        public Country Country { set; get; }
    }
}
