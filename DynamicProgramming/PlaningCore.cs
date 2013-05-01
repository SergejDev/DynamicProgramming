using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProgramming
{
    class PlaningCore
    {
        private List<int> b;

        //private int weeksCount;

        private List<Table> tables;

        public PlaningCore(List<int> b)
        {
            this.b = b;
          //  this.weeksCount = ConfigurationManager.GetWeeksCount();
            FillTables();
        }

        private List<int> FillXState()
        {
            //Anya's
        }

        private void FillTables()
        {
            foreach (var bCurrent in b)
            {
                tables.Add(new Table(bCurrent, FillXState()));
            }
        }


    }
}
