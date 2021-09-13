using System;
using System.Collections.Generic;
using System.Text;

namespace RSys.Domain.Models
{
    public class Country
    {
        public int ContryId { set; get; }
        public string CountryDescription { set; get; }
        public bool IsAllowed { set; get; }
    }
}
