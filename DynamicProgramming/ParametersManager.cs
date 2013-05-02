using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProgramming
{
    public static class ParametersManager
    {
        public static int? CarRentPrice { set; get; }

        public static int? CarDealPrice { set; get; }

        static ParametersManager()
        {
            CarRentPrice = null;
            CarDealPrice = null;
        }

        public static bool IsParametersSetted()
        {
            return (CarDealPrice != null && CarRentPrice != null);
        }
    }
}
