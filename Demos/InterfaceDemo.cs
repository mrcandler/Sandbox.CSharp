using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox_Console_App.DemoFiles
{
    //Display Result
    public class InterfaceDemo  
    {
        public static void DisplayInfo()
        {

            //polymorphism in action: we can treat different types of animals as the same type (IAnimal)
            List<IAnimal> animals = new List<IAnimal>();

            Dog dog = new Dog();
            Cat cat = new Cat();

            animals.Add(dog);
            animals.Add(cat);

            //enable this code to see the polymorphic behavior of the animals
            foreach (IAnimal animal in animals)
            {
                animal.MakeSound();
            }

            List<IDatabaseConnection> dbList = new List<IDatabaseConnection>();

            SQLDataBaseConnection tsqldb = new SQLDataBaseConnection();
            MySQLDataBaseConnection mysqldb = new MySQLDataBaseConnection();
            PostgresDataBaseConnection postgressqldb = new PostgresDataBaseConnection();

            dbList.Add(tsqldb);
            dbList.Add(mysqldb);
            dbList.Add(postgressqldb);

            foreach(IDatabaseConnection db in dbList)
            {
                db.Connect();
            }
        }
    }

    #region InterfaceDemo #1
    //Interface #1: Animals
    public interface IAnimal
    {
        int legCount { get; set; }
        //just a sample interface
        void MakeSound();
    }

    public class Dog : IAnimal
    {
        public int legCount { get; set; }

        public Dog()
        {
            legCount = 4;
        }

        public void MakeSound()
        {
            Console.WriteLine("Woof!");
        }
    }

    public class Cat : IAnimal
    {
        public int legCount { get; set; }

        public Cat()
        {
            legCount = 4;
        }

        public void MakeSound()
        {
            Console.WriteLine("Meow!");
        }
        
    }
    #endregion

    #region InterfaceDemo #2
    //Interface #2: Database Connection
    public interface IDatabaseConnection
    {
        void Connect();
        void Disconnect();
    }

    public class SQLDataBaseConnection : IDatabaseConnection
    {
        public void Connect()
        {
            Console.WriteLine("Connecting to the Microsoft SQL Server Database...");
        }
    
          public void Disconnect()
          {
                Console.WriteLine("Disconnecting from the Microsoft SQL Server Database...");
        }

    }

    public class MySQLDataBaseConnection : IDatabaseConnection
    {
        public void Connect()
        {
            Console.WriteLine("Connecting to the MySQL database...");
        }

        public void Disconnect()
        {
            Console.WriteLine("Disconnecting from the MySQL database...");
        }

    }

    public class PostgresDataBaseConnection : IDatabaseConnection
    {
        public void Connect()
        {
            Console.WriteLine("Connecting to the PostgresSQL database...");
        }

        public void Disconnect()
        {
            Console.WriteLine("Disconnecting from the PostgresSQL database...");
        }

    }

    public class MongoDataBaseConnection : IDatabaseConnection
    {
        public void Connect()
        {
            Console.WriteLine("Connecting to the Mongo database...");
        }

        public void Disconnect()
        {
            Console.WriteLine("Disconnecting from the Mongo database...");
        }

    }


    #endregion


}
