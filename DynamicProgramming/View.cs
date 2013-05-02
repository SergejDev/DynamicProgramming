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
    public partial class View : Form
    {
        private List<Table> tables;

        public View()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            if (!IsInputInvalid())
            {
                //SetParameters();
                try
                {
                    PlaningCore core = new PlaningCore(GetBValues());
                    var t = core.Tables;
                }
                catch (SystemException exeption)
                {
                    MessageBox.Show(exeption.Message);
                }
            }
        }

        private List<int> GetBValues()
        {
            int b1 = Convert.ToInt32(textBoxB1.Text);
            int b2 = Convert.ToInt32(textBoxB2.Text);
            int b3 = Convert.ToInt32(textBoxB3.Text);
            int b4 = Convert.ToInt32(textBoxB4.Text);
            return new List<int>() { b1, b2, b3, b4 };
        }

        private void SetParameters()
        {
            ParametersManager.CarRentPrice = Convert.ToInt32(textBoxC1.Text);
            ParametersManager.CarDealPrice = Convert.ToInt32(textBoxC2.Text);
        }

        private bool IsInputInvalid()
        {
            return String.IsNullOrEmpty(textBoxB1.Text) || String.IsNullOrEmpty(textBoxB2.Text) ||
                String.IsNullOrEmpty(textBoxB3.Text) || String.IsNullOrEmpty(textBoxB4.Text) ||
                String.IsNullOrEmpty(textBoxC1.Text) || String.IsNullOrEmpty(textBoxC2.Text);
        }
    }
}
