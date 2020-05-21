using Domain.Entities;

namespace Domain.Repository
{
    public interface IOrderRepository
    {
        OrderEntity GetOrderEntity();
    }
}