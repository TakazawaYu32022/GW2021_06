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
                    string[] xValues = new string[] { };

            }
            else
            {

            }
        }
    }
}
