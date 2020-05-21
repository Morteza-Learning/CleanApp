using System.Collections.Generic;

namespace Data.Entities
{
    public class OrderData
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<DetailData> DetailDatas { get; set; }
    }
}