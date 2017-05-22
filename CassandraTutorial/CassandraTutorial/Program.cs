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
            var session = cluster.Connect("demo");

            session.Execute("INSERT INTO FOODS(type, weight) values ('Beef','500')");


            Row result = session.Execute("Select * from foods").First();



            Console.WriteLine("Hello World!");
        }
    }
}