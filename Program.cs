using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fertilizer.BL;

namespace Fertilizer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program will help you calulate the number of pounds of fertilizer that should be purchased.\n");
            string buffer = "";

            while (!BusinessLogic.IsValid(buffer))
            {
                buffer = GetInput("Please enter the width of your area to be fertilized (ex. 14.25)");
            }

            //convert the string to a float
            float width = ConvertStringToFloat(buffer);

            // ensure that the buffer is clear before the next input
            buffer = "";

            while (!BusinessLogic.IsValid(buffer))
            {
                buffer = GetInput("Please enter the length of your area to be fertilized (ex. 26.75)");
            }

            //convert the string to a float
            float length = ConvertStringToFloat(buffer);

            // ensure that the buffer is clear before the next input
            buffer = "";

            while (!BusinessLogic.IsValid(buffer))
            {
                buffer = GetInput("Please enter the desired nitrogen content as a percentage. (ex. 20)");
            }

            float nitrogen = ConvertStringToFloat(buffer);

            BusinessLogic calc = new BusinessLogic(width, length, nitrogen);

            var pounds = calc.CalculateFertilizerPoundsRequired();

            Console.WriteLine($"Based on our calulations, you will require {pounds} pounds of fertilizer.");
            Console.ReadLine();
        }

        private static string GetInput(string promptText)
        {
            Console.WriteLine(promptText);
            return Console.ReadLine();
        }

        private static float ConvertStringToFloat(string input)
        {
            return (float)Convert.ToDouble(input);
        }
    }
}
