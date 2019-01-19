using System;

namespace Intermediete_Exercises
{
    //Design a class called DbCommand for executing an instruction against the database.A
    //DbCommand cannot be in a valid state without having a connection.So in the constructor of
    //this class, pass a DbConnection.Don’t forget to cater for the null.
    //Each DbCommand should also have the instruction to be sent to the database.In case of SQL
    //Server, this instruction is expressed in T-SQL language. Use a string to represent this instruction.
    //Again, a command cannot be in a valid state without this instruction.So make sure to receive it
    //in the constructor and cater for the null reference or an empty string.
    //Each command should be executable.So we need to create a method called Execute(). In this
    //method, we need a simple implementation as follows:
    //Open the connection
    //Run the instruction
    //Close the connection
    //Note that here, inside the DbCommand, we have a reference to DbConnection. Depending on
    //the type of DbConnection sent at runtime, opening and closing a connection will be different.
    //For example, if we initialize this DbCommand with a SqlConnection, we will open and close a
    //connection to a Sql Server database. This is polymorphism.Interestingly, DbCommand doesn’t
    //care about how a connection is opened or closed.It’s not the responsibility of the DbCommand.
    //All it cares about is to send an instruction to a database.
    //In the main method, initialize a DbCommand with some string as the instruction and a
    //SqlConnection. Execute the command and see the result on the console.
    public class DbCommand
    {
        private string Instruction { get; set; }
        private DbConnection Connection { get; set; }

        public DbCommand(DbConnection connection, string instruction)
        {
            if (connection == null || String.IsNullOrWhiteSpace(instruction))
                throw new InvalidOperationException("Cant call null connection");
            else
            {
                Connection = connection;
                Instruction = instruction;
            }
        }

        public void Execute()
        {
            Connection.Open();
            Console.WriteLine(Instruction);
            Connection.Close();
        }
    }
}
