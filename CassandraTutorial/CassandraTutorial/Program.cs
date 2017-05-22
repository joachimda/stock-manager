using System;
using System.Linq;
using Cassandra;

namespace CassandraTutorial
{
    // Sample code from:
    // https://academy.datastax.com/resources/getting-started-apache-cassandra-and-c-net

    class Program
    {
        static void Main(string[] args)
        {
            var cluster = Cluster.Builder().AddContactPoint("127.0.0.1").Build();
            var session = cluster.Connect("food_ks");
            
            session.Execute("INSERT INTO FOODS(id, type, weight) values (2, 'chicken',1000)");


            RowSet result = session.Execute("Select * from foods");
            
            foreach(Row row in result)
            {
                Console.WriteLine("{0} {1} {2} ",row["id"], row["type"], row["weight"]);
            }
        }
    }
}