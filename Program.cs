using System;
using MysharedLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApp_Assignment_25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MysharedLibrary.DataVlidator dataValidator = new MysharedLibrary.DataVlidator();
            MysharedLibrary.Logger logger = new MysharedLibrary.Logger();

            UserManagement userManagement = new UserManagement(dataValidator, logger);
            FileProcessing fielprocessing = new FileProcessing(dataValidator, logger);
            DataVisualization dataVisualization = new DataVisualization(dataValidator, logger);


            Console.Write("Enter username for login: ");
            string userInput = Console.ReadLine();
            userManagement.ProcessUserInput(userInput);
            

             
            Console.ReadKey();
        }
    }
}
