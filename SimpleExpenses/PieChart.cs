using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleExpenses
{
    public partial class PieChart : Form
    {
       
        public PieChart()
        {
            InitializeComponent();
        }
        public string day { get; set; }
        public int budget { get; set; }
        public int rent { get; set; }
        public int utilitycost { get; set; }
        public int cellphonebill { get; set; }
        public int foodcost { get; set; }
        public int medicalcost { get; set; }
        public int mexpense { get; set; }
        public int travelcost { get; set; }
        public int tuition { get; set; }
        public int specialcost { get; set; }
        public int saving { get; set; }
        public int total { get; set; }

        private void PieChart_Load(object sender, EventArgs e)
        {
            lbPieDay.Text = day;
            ChPieChart.Series[0].Points[0]
            
            ChPieChart.Series[0].Points[1].XValue=utilitycost;
            ChPieChart.Series[0].Points[2].XValue=cellphonebill;
            ChPieChart.Series[0].Points[3].XValue=foodcost;
            ChPieChart.Series[0].Points[4].XValue=medicalcost;
            ChPieChart.Series[0].Points[5].XValue=mexpense;
            ChPieChart.Series[0].Points[6].XValue=travelcost;
            ChPieChart.Series[0].Points[7].XValue=tuition;
            ChPieChart.Series[0].Points[8].XValue=specialcost;
            ChPieChart.Series[0].Points[9].XValue=saving;

        }
    }
}
