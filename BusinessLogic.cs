using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fertilizer.BL
{
    class BusinessLogic
    {
        private readonly float length;
        private readonly float width;
        private readonly float nitro;

        /// <summary>
        /// Class that will help determine how much fertilizer you will need to buy/apply to your lawn
        /// </summary>
        /// <param name="lawnLength">Length of lawn in feet</param>
        /// <param name="lawnWidth">Width of lawn in feet</param>
        /// <param name="nitroContent">Percentage of nitrogen required</param>
        public BusinessLogic(float lawnLength, float lawnWidth, float nitroContent)
        {
            this.length = lawnLength;
            this.width = lawnWidth;
            this.nitro = nitroContent;

            Validate();
        }

        /// <summary>
        /// Using the values supplied when the object was created, calculates the number of pounds.
        /// </summary>
        /// <returns>Requirements in pounds</returns>
        public float CalculateFertilizerPoundsRequired()
        {
            var area = CalculateArea(this.length, this.width);
            var nitroReq = CalculateNitrogenRequired(area);
                        
            return nitroReq / (this.nitro / 100);
        }

        /// <summary>
        /// Takes a string input and determines whether it is numeric
        /// </summary>
        /// <param name="input"></param>
        /// <returns>true if numeric, false if non-numeric</returns>
        public static bool IsValid(string input)
        {
            float data = -1;
            if(float.TryParse(input.Trim(), out data))
            {
                return true;
            } else
            {
                return false;
            }
        }

        private float CalculateArea(float length, float width)
        {
            return length * width;
        }

        private float CalculateNitrogenRequired(float area)
        {
            return area / 1000;
        }

        private void Validate()
        {
            if(this.length <= 0 || this.width <= 0)
            {
                throw new Exception("Length and Width must be greater than 0");
            }

            if(this.nitro < 0)
            {
                throw new Exception("Nitrogen content should be specified as a number greater than 0.");
            }
        }
    }
}
