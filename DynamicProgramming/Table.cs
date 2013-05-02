using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProgramming
{
    class Table
    {

        private List<int> xState;

        private List<Record> records;

        private Dictionary<int, int> newFPreview;

        private Dictionary<int, int> lastFPreview;


        public Table(List<int> xState, Dictionary<int, int> lastFPreview)
        {
            records = new List<Record>();
            this.lastFPreview = lastFPreview;
            newFPreview = new Dictionary<int, int>();
            this.xState = xState;
            FillRecords();
        }

        private void FillRecords()
        {
            foreach (var x in xState)
            {
                Record record = new Record(x, lastFPreview);
                newFPreview.Add(x, record.OptimumF);
                records.Add(record);
            }
        }

        public List<Record> Records
        {
            get { return records; }
        } 

        public Dictionary<int,int> NewFPreview
        {
            get { return newFPreview; }
        } 
    }
}
