using System;

namespace Intermediete_Exercises
{ 
    //Your job is to represent these commonalities in a base class called DbConnection.This class
    //should have two properties:
    //ConnectionString : string
    //Timeout : TimeSpan
    //A DbConnection will not be in a valid state if it doesn’t have a connection string. So you need to
    //pass a connection string in the constructor of this class. Also, take into account the scenarios
    //where null or an empty string is sent as the connection string. Make sure to throw an exception
    //to guarantee that your class will always be in a valid state.
    //Our DbConnection should also have two methods for opening and closing a connection.We
    //don’t know how to open or close a connection in a DbConnection and this should be left to the
    //classes that derive from DbConnection. These classes (eg SqlConnection or OracleConnection)
    //will provide the actual implementation. So you need to declare these methods as abstract.
    //Derive two classes SqlConnection and OracleConnection from DbConnection and provide a
    //simple implementation of opening and closing connections using Console.WriteLine(). In the
    //real-world, SQL Server provides an API for opening or closing a connection to a database.But
    //for this exercise, we don’t need to worry about it.
    public abstract class DbConnection
    {
        private string ConnectionString { get; set; }
        private TimeSpan Timeout { get; set; }

        public DbConnection(string connection)
        {
            if (String.IsNullOrWhiteSpace(connection))
                throw new InvalidOperationException("Cant pass empty string");
            else
                ConnectionString = connection;
        }

        public abstract void Open();
        public abstract void Close();

    }

    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connection) 
            :base(connection)
        {
        }

        public override void Open()
        {
            Console.WriteLine("A SqlConnection is opened.");
        }

        public override void Close()
        {
            Console.WriteLine("A SqlConnection is closed.");
        }
    }

    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connection)
            : base(connection)
        {
        }

        public override void Open()
        {
            Console.WriteLine("An OracleConnection is opened.");
        }

        public override void Close()
        {
            Console.WriteLine("An OracleConnection is closed.");
        }
    }
}
