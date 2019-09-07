using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fertilizer.BL
{
    class BusinessLogic
    {
        private float length;
        private float width;
        private float nitro;

        public BusinessLogic(float lawnLength, float lawnWidth, float nitroContent)
        {
            this.length = lawnLength;
            this.width = lawnWidth;
            this.nitro = nitroContent;
        }

        public float CalculateFertilizerPoundsRequired()
        {

            return 0;
        }

        private bool Validate()
        {
            if(this.length <= 0 || this.width <= 0)
            {
                throw new Exception("");
            }
        }
    }
}
