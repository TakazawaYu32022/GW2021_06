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
            int TotalCost = rent + utilitycost + cellphonebill + foodcost + medicalcost + mexpense
                            + travelcost + tuition + specialcost + saving;
            ChPieChart.Series[0].Points.Add(rent);
            ChPieChart.Series[0].Points.Add(utilitycost);
            ChPieChart.Series[0].Points.Add(cellphonebill);
            ChPieChart.Series[0].Points.Add(foodcost);
            ChPieChart.Series[0].Points.Add(medicalcost);
            ChPieChart.Series[0].Points.Add(mexpense);
            ChPieChart.Series[0].Points.Add(travelcost);
            ChPieChart.Series[0].Points.Add(tuition);
            ChPieChart.Series[0].Points.Add(specialcost);
            ChPieChart.Series[0].Points.Add(saving);

            ChPieChart.Series[0].Points[0].Label = "家賃(ローン)" + rent + "円";
            ChPieChart.Series[0].Points[1].Label = "光熱費" + utilitycost + "円";
            ChPieChart.Series[0].Points[2].Label = "通信費" + cellphonebill + "円";
            ChPieChart.Series[0].Points[3].Label = "食費" + foodcost + "円";
            ChPieChart.Series[0].Points[4].Label = "医療費" + medicalcost + "円";
            ChPieChart.Series[0].Points[5].Label = "雑費" + mexpense + "円";
            ChPieChart.Series[0].Points[6].Label = "旅費" + travelcost + "円";
            ChPieChart.Series[0].Points[7].Label = "教育費" + tuition + "円";
            ChPieChart.Series[0].Points[8].Label = "特別費" + specialcost + "円";
            ChPieChart.Series[0].Points[9].Label = "貯金" + saving + "円";

            lbBudget.Text += budget.ToString() + "円";
            lbTotalCost.Text += TotalCost.ToString() + "円";
            lbTotal.Text += total.ToString() + "円";
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
