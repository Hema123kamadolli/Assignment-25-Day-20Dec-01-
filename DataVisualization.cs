using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApp_Assignment_25
{
    public class DataVisualization
    {
        private readonly MysharedLibrary.DataVlidator datavalidator;
        private readonly MysharedLibrary.Logger logger;

        public DataVisualization(MysharedLibrary.DataVlidator dataValidator, MysharedLibrary.Logger logger)
        {
            this.datavalidator = dataValidator;
            this.logger = logger;
        }
        public void ProcessUserInput(string userInput)
        {
            if (datavalidator.ValidateUserData(userInput))
            {
                logger.LogMessage($"User input '{userInput}' is valid.");
            }
            else
            {
                logger.LogMessage($"Invalid user input: '{userInput}'.");
            }
        }
    }
}
