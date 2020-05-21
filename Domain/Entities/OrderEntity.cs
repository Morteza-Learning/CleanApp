using System.Collections.Generic;

namespace Domain.Entities
{
    public class OrderEntity
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<DetailEntity> DetailEntitys { get; set; }
    }
}