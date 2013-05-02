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

        public Form1()
        {
            InitializeComponent();
           
            PlaningCore core = new PlaningCore(new List<int>(){7, 4, 7, 8});
        }


    }
}
