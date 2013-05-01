using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProgramming
{
    class Record
    {
        private int xState;

        private List<int> xControl;

        private List<int> f;

        private int optimumF;

        private int optimumXControl;
    }
}
