using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SimpleExpenses
{
    public partial class Statistics : Form
    {
        List<ExpensesData> edata = new List<ExpensesData>();
        string fullPath = Path.GetFullPath(@"..\家計簿記録.csv");
        
        public Statistics()
        {
            InitializeComponent();
        }

        private void Statistics_Load(object sender, EventArgs e)
        {
            if (File.Exists(fullPath))
            {
                var csvreaders = File.ReadAllLines(fullPath);
                foreach (var csvreader in csvreaders)
                {
                    var items = csvreader.Split(',');
                    ExpensesData expensesData = new ExpensesData
                    {
                        Day = items[0],
                        Budgets = items[1],
                        Rent = items[2],
                        UtilityCosts = items[3],
                        CellPhoneBill = items[4],
                        FoodCosts = items[5],
                        Medicalcosts = items[6],
                        MExpense = items[7],
                        TravelCosts = items[8],
                        Tuition = items[9],
                        SpecialCosts = items[10],
                        Savings = items[11],
                        Total = items[12],
                        Memo = items[13]
                    };
                    edata.Add(expensesData);
                }

                int sum = 0;
                for (int i = 0; i < File.ReadAllLines(fullPath).Length; i++)
                {
                    sum = int.Parse(edata[i].Rent) + int.Parse(edata[i].UtilityCosts) + int.Parse(edata[i].CellPhoneBill)
                                   + int.Parse(edata[i].FoodCosts) + int.Parse(edata[i].Medicalcosts) + int.Parse(edata[i].MExpense)
                                   + int.Parse(edata[i].TravelCosts) + int.Parse(edata[i].Tuition) + int.Parse(edata[i].SpecialCosts)
                                   + int.Parse(edata[i].Savings);
                    ExpensesChart.Series[0].Points.AddXY(edata[i].Day, sum);
                    ExpensesChart.Series[1].Points.Add(int.Parse(edata[i].Budgets));
                }

            }
            else
            {
                MessageBox.Show("まだデータを記録していません。");
                this.Close();
            }
        }

        private void btMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
