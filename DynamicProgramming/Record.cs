using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProgramming
{
    class Record
    {
        private int c1;
        private int c2;

        private int xState;

        private List<int> fList;

        private int optimumF;

        private int optimumXControl;

        private Dictionary<int, int> fPreview;
      
        public Record(int xState, Dictionary<int, int> fPreview)
        {
            this.xState = xState;
            this.fPreview = fPreview;
            InitializeParameters();
            InitializeF();
        }

        private void InitializeParameters()
        {
            if (!ParametersManager.IsParametersSetted())
            {
                throw new SystemException("Parameters do not setted.");
            }
            c1 = (int)ParametersManager.CarRentPrice;
            c2 = (int)ParametersManager.CarDealPrice;
            fList = new List<int>();
        }

        private void InitializeF()
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
