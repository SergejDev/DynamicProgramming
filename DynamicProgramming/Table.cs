using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProgramming
{
    class Table
    {
        private int bCurrent;

        private List<int> xState;

        private List<Record> records;

        public Table(int bCurrent, List<int> xState)
        {
            this.bCurrent = bCurrent;
            this.xState = xState;
            FillRecords();
        }

        private void FillRecords()
        {

        }
    }
}
