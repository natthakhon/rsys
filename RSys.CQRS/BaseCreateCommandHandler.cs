using FluentValidation;
using FluentValidation.Results;
using MediatR;
using RSys.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RSys.CQRS
{
    public abstract class BaseCreateCommandHandler<TResponse> : IRequestHandler<IRequestor<TResponse>, TResponse>
        where TResponse : class
    {
        private IValidator<TResponse> validator;
        protected IGenericUpsert<TResponse> repository;
        protected BaseCreateCommandHandler(IValidator<TResponse> validator
            , IGenericUpsert<TResponse> repository)
        {
            this.validator = validator;
            this.repository = repository;
        }

        public async Task<TResponse> Handle(IRequestor<TResponse> request, CancellationToken cancellationToken)
        {
            ValidationResult result = await this.validator.ValidateAsync(request.Item); ;

            if (result.IsValid)
            {
                return await this.handle(request, cancellationToken);
            }
            throw new ArgumentException(String.Join(",", result.Errors));
        }

        protected abstract Task<TResponse> handle(IRequestor<TResponse> request, CancellationToken cancellationToken);
    }
}
