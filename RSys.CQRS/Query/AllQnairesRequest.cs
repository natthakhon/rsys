using MediatR;
using RSys.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RSys.CQRS.Query
{
    public class AllQnairesRequest : IRequest<List<Questionnaire>>
    {
    }
}
