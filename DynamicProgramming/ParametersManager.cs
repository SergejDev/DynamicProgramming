using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProgramming
{
    public static class ParametersManager
    {
        private static int carRentPrice;

        private static int carDealPrice;

        public static int CarRentPrice { set; get; }

        public static int CarDealPrice { set; get; }
    }
}
