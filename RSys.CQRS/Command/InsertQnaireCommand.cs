using RSys.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RSys.CQRS.Command
{
    public class InsertQnaireCommand : IRequestor<Questionnaire>
    {
        public Questionnaire Item { get; set; }
    }
}
