using Data.Entities;

namespace Data.Database
{
    public interface IDatabase
    {
        OrderData getOrder();
    }
}