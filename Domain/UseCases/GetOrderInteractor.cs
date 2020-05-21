using Domain.Entities;
using Domain.Repository;
using System;

namespace Domain.UseCases
{
    public class GetOrderInteractor : IRequestHandler<OrderEntity>
    {
        private readonly IOrderRepository _repository;

        public GetOrderInteractor(IOrderRepository repository)
        {
            if (repository != null)
            {
                _repository = repository;
            }
            else
                throw new ArgumentNullException(repository.ToString());
        }

        public OrderEntity Handle()
        {
            return _repository.GetOrderEntity();
        }
    }
}