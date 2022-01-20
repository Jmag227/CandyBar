using System.Collections;
using System.Collections.Generic;

namespace CandyBarProject
{
    public interface ICandy
    {
        public IEnumerable<Candy> GetAllInfo();
        public Candy GetCandy(int id);
        public void UpdateCandy(Candy candy);
        public void InsertCandy(Candy candyToInsert);
        public void DeleteCandy(Candy candy);
        
        
    }
}
