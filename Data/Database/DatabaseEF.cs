using Data.Entities;
using System.Collections.Generic;

namespace Data.Database
{
    public class DatabaseEF : IDatabase
    {
        private int sal = 0;

        public DatabaseEF(int salmali)
        {
            sal = salmali;
        }

        public OrderData getOrder()
        {
            return new OrderData()
            {
                ID = 1,
                Name = "SALam" + sal,
                DetailDatas = new List<DetailData>()
                {
                    new DetailData(){Id = 1,Tedad = 5},
                    new DetailData(){Id = 2,Tedad = 40},
                    new DetailData(){Id = 3,Tedad = 10}
                }
            };
        }
    }
}