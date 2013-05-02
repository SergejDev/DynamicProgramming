using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DynamicProgramming
{
    public partial class Form1 : Form
    {
        private List<Table> tables;
        private PlaningCore core;
        public Form1()
        {
            InitializeComponent();
           
            core = new PlaningCore(new List<int>(){7, 4, 7, 8});
            var c = core.Tables;
            OutOptimumValues();
        }

        private void OutOptimumValues()
        {
            var optimumValues = core.GetListOptimumValues();
            string valueText = "X0 = 0 => ";

            for (int j =1, i = optimumValues.Count() - 1; i >= 0; i-- , j++)
            {
                string xS = "X" + j.ToString() + " = ";
                valueText += xS;
                valueText += optimumValues[i].Value.ToString();
                valueText += ("(" + optimumValues[i].Key.ToString() + ")");
                valueText += (i >0 ? " => ": "");
            }

            toolStripStatusLabel.Text = valueText;
        }

    }
}
