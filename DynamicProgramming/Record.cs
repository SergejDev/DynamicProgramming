using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProgramming
{
    class Record
    {
        private int c1 = 220; // HARDCODE!!!!!!!!!!!!!!!!!!!!
        private int c2 = 500;

        private int xState;

       // private List<int> xControl;

        private List<int> fList;

        private int optimumF;

        private int optimumXControl;

        private Dictionary<int, int> fPreview;
      
        public Record(int xState, Dictionary<int, int> fPreview)
        {
            fList = new List<int>();
            this.xState = xState;
           // this.xControl = xControl;
            this.fPreview = fPreview;
            InitializeF();
        }

        void InitializeF()
        {
            foreach (var fp in fPreview)
            {
                if (xState < fp.Key)
                {
                    int tempF = c2 + c1 * fp.Key + fp.Value;

                    SetOptimumValues(fp.Key, tempF);

                    fList.Add(tempF);
                }
                else
                {
                    int tempF = c1 * fp.Key + fp.Value;

                    SetOptimumValues(fp.Key, tempF); 
                    
                    fList.Add(tempF);
                }
            }       
        }

        public int OptimumF
        {
            get { return optimumF; }
        }

        public int OptimumXControl
        {
            get { return optimumXControl; }
        }

        private void SetOptimumValues(int tempXControl, int tempF)
        {
            if (fList.Any())
            {
                if (fList.Min() > tempF)
                {
                    optimumXControl = tempXControl;
                    optimumF = tempF;
                }
            }
            else
            {
                optimumXControl = tempXControl;
                optimumF = tempF;
            }
        }
        
    }
}
