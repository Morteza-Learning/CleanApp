using Data.Entities;
using Domain.Entities;
using Domain.Mappers;

namespace Data.Mappers
{
    public class OrderMapper : IMapper<OrderData, OrderEntity>
    {
        public OrderEntity MapFrom(OrderData input)
        {
            if (input == null)
            {
                throw new System.ArgumentNullException(input.ToString());
            }

            return new OrderEntity
            {
                ID = input.ID,
                Name = input.Name,
                DetailEntitys = input.DetailDatas.ConvertAll<DetailEntity>(p => new DetailEntity()
                {
                    Id = p.Id,
                    Tedad = p.Tedad
                })
            };
        }
    }
}