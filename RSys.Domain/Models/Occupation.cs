using System;
using System.Collections.Generic;
using System.Text;

namespace RSys.Domain.Models
{
    public class Occupation
    {
        public Profession Profession { set; get; }
        public string JobTitle { set; get; }
        public BusinessType BusinessType { set; get; }
        
    }
}
