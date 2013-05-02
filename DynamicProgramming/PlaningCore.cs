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

        private List<Table> tables;

        public PlaningCore(List<int> b)
        {
            this.b = b;
            tables = new List<Table>();
            FillTables();
        }

        private List<int> GetXStateList(int index)
        {
            List<int> xStateList = new List<int>();
            if (index > 0)
            {
                var rangeB = b.GetRange(index - 1, b.Count - index + 1);
                var max = rangeB.Max();

                for (int i = b[index - 1]; i <= max; i++)
                {
                    xStateList.Add(i);
                }
            }

            if (index == 0)
            {
                xStateList.Add(0);
            }
                
            return xStateList;
        }
        
        private void FillTables()
        {
            Dictionary<int, int> FPreview = new Dictionary<int, int>(){ {b[b.Count()-1], 0} };

            for (int i = (b.Count()-1); i >= 0; i-- )
            {
                List<int> xState = GetXStateList(i);
                Table table = new Table(xState, FPreview);
                FPreview = table.NewFPreview;
                tables.Add(table);
            }

        }

        public List<Table> Tables
        {
            get { return tables; }
        } 


    }
}
