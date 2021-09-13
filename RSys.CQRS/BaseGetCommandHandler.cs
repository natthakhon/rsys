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
    public abstract class BaseGetCommandHandler<TRequest, TResponse> : IRequestHandler<TRequest, TResponse>
        where TResponse : class
        where TRequest : IRequest<TResponse>
    {
        private IValidator<TRequest> validator;
        protected IGetData<TResponse> getrepository;

        public BaseGetCommandHandler(IGetData<TResponse> repository)
        {
            this.getrepository = repository;
        }
        public BaseGetCommandHandler(IGetData<TResponse> repository, IValidator<TRequest> validator)
        {
            this.getrepository = repository;
            this.validator = validator;
        }

        public async Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken)
        {
            if (this.validator != null)
            {
                ValidationResult result = this.validator.Validate(request); ;

                if (result.IsValid)
                {
                    return await this.handle(request, cancellationToken);
                }
                throw new ArgumentException(String.Join(",", result.Errors));
            }
            else
            {
                return await this.handle(request, cancellationToken);
            }
        }

        protected abstract Task<TResponse> handle(TRequest request, CancellationToken cancellationToken);

    }
}
