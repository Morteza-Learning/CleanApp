using Data.Database;
using Data.Entities;
using Domain.Entities;
using Domain.Mappers;
using Domain.Repository;

namespace Data.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly IDatabase _api;
        private readonly IMapper<OrderData, OrderEntity> _mapper;

        public OrderRepository(IDatabase api, IMapper<OrderData, OrderEntity> mapper)
        {
            _api = api; //?? throw new System.ArgumentNullException(nameof(api));
            _mapper = mapper; //?? throw new System.ArgumentNullException(nameof(mapper));
        }

        public OrderEntity GetOrderEntity()
        {
            return _mapper.MapFrom(_api.getOrder());
        }
    }
}