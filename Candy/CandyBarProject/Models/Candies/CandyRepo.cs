using System.Collections.Generic;
using System.Data;
using Dapper;
namespace CandyBarProject
{
    public class CandyRepo : ICandy
    {
        private readonly IDbConnection _connection;

        public CandyRepo(IDbConnection conn)
        {
            _connection = conn;
        }      

        public IEnumerable<Candy> GetAllInfo()
        {
            return _connection.Query<Candy>("Select * from candy;");
        }

        public Candy GetCandy(int id)
        {
            return _connection.QuerySingle<Candy>("Select * from candy where dbid = @id;", new { id });
        }

        public void InsertCandy(Candy candyToInsert)
        {
            _connection.Execute("insert into candy (Name,Manufacturer,WalmartPrice,Ingredients)" +
                "values (@Name, @Manufacturer, @WalmartPrice, @Ingredients);",
                new {
                    Name = candyToInsert.Name,
                    Manufacturer = candyToInsert.Manufacturer,
                    WalmartPrice = candyToInsert.WalmartPrice,
                    Ingredients = candyToInsert.Ingredients
                    });
        }

        public void UpdateCandy(Candy candy)
        {
            _connection.Execute("Update candy set Name = @Name, Manufacturer = @Manufacturer, WalmartPrice = @WalmartPrice, Ingredients = @Ingredients Where Dbid = @id;",
                new
                {
                    Name = candy.Name,
                    Manufacturer = candy.Manufacturer,
                    WalmartPrice = candy.WalmartPrice,
                    Ingredients = candy.Ingredients,
                    id = candy.Dbid
                });
        }
        public void DeleteCandy(Candy candy)
        {
            _connection.Execute("DELETE FROM candy WHERE dbid = @id;",
                                        new { id = candy.Dbid });           
        }        
    }
}
