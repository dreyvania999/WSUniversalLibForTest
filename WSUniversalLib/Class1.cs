using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSUniversalLib
{
    public class Calculation
    {
        public static int GetQuantityForProduct(int productType, int materialType, int count, float width, float length)
        {
            double sqvear = width * length;

            if (sqvear < 0 || count < 0)
            {
                return -1;
            }

            double result = sqvear * count;
            switch (productType)
            {
                case 1:
                    result *= 1.1;
                    break;
                case 2:
                    result *= 2.5;
                    break;
                case 3:
                    result *= 8.43;
                    break;
                default:
                    return -1;

            }
            switch (materialType)
            {
                case 1:
                    result += (result / 100) * 0.3;
                    break;
                case 2:
                    result += (result / 100) * 0.12;
                    break;

                default:
                    return -1;

            }


            return (int)Math.Round(result);
        }
    }
}
