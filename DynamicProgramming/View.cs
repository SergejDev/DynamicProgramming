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
            Initialize();
        }

        private void Initialize()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView4.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            if (!IsInputInvalid())
            {
                SetParameters();
                try
                {
                    PlaningCore core = new PlaningCore(GetBValues());
                    var t = core.Tables;
                    SetTableData(core.Tables);
                }
                catch (SystemException exeption)
                {
                    MessageBox.Show(exeption.Message);
                }
            }
        }

        private void SetTableData(List<Table> tables)
        {
            InitializeGridView(dataGridView4, tables[0].Records);
            InitializeGridView(dataGridView3, tables[1].Records);
            InitializeGridView(dataGridView2, tables[2].Records);
            InitializeGridView(dataGridView1, tables[3].Records);
        }

        private void InitializeGridView(DataGridView gridView, List<Record> records)
        {
            InitializeGridViewColumns(gridView, records);
            InitializeGridViewRows(gridView, records);
        }

        private void InitializeGridViewColumns(DataGridView gridView, List<Record> records)
        {
            gridView.Columns.Add("X State", "X State");
            foreach (var xControl in records[0].FPreview)
            {
                String columnName = String.Format("X control = {0}", xControl.Key);
                gridView.Columns.Add(columnName, columnName);
            }
            gridView.Columns.Add("F optimum", "F optimum");
            gridView.Columns.Add("X optimum", "X optimum");
        }

        private void InitializeGridViewRows(DataGridView gridView, List<Record> records)
        {
            foreach (var record in records)
            {
                List<object> rowsParameters = new List<object>();
                rowsParameters.Add(record.XState);
                foreach (var xControl in record.FList)
                {
                    rowsParameters.Add(xControl);
                }
                rowsParameters.Add(record.OptimumF);
                rowsParameters.Add(record.OptimumXControl);
                gridView.Rows.Add(rowsParameters.ToArray());
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
