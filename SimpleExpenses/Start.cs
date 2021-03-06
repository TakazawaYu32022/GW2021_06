using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleExpenses
{
    public partial class Start : Form
    {
        List<ExpensesData> edata = new List<ExpensesData>();


        string  fullPath = Path.GetFullPath(@"..\家計簿記録.csv");
        
        private DateTime _Now;

        public Start()
        {
            InitializeComponent();
            //起動時の年と月を保存
            _Now = DateTime.Now;
        }

        private void Start_Load(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            lbDay.Text = dt.Year.ToString() + "年" + dt.Month.ToString() + "月";
            
            



            //起動したときの月のデータがあれば表示する
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

                int listNumber = edata.FindIndex(s => s.Day == lbDay.Text);

                tbBudgets.Text = edata[listNumber].Budgets.ToString();
                tbRent.Text = edata[listNumber].Rent.ToString();
                tbUtilityCosts.Text = edata[listNumber].UtilityCosts.ToString();
                tbCellPhoneBill.Text = edata[listNumber].CellPhoneBill.ToString();
                tbFoodCosts.Text = edata[listNumber].FoodCosts.ToString();
                tbMedicalcosts.Text = edata[listNumber].Medicalcosts.ToString();
                tbMExpense.Text = edata[listNumber].MExpense.ToString();
                tbTravelCosts.Text = edata[listNumber].TravelCosts.ToString();
                tbTuition.Text = edata[listNumber].Tuition.ToString();
                tbSpecialCosts.Text = edata[listNumber].SpecialCosts.ToString();
                tbSavings.Text = edata[listNumber].Savings.ToString();
                tbTotal.Text = edata[listNumber].Total.ToString();
                tbMemo.Text = edata[listNumber].Memo.ToString();

                
            }
            //今月のデータがなかった場合
            else
            {
                tbBudgets.Text = "0";
                tbRent.Text = "0";
                tbUtilityCosts.Text = "0";
                tbCellPhoneBill.Text = "0";
                tbFoodCosts.Text = "0";
                tbMedicalcosts.Text = "0";
                tbMExpense.Text = "0";
                tbTravelCosts.Text = "0";
                tbTuition.Text = "0";
                tbSpecialCosts.Text = "0";
                tbSavings.Text = "0";
                tbTotal.Text = "0";
                tbMemo.Text = "";

            }
            
        }

        private void btCalculation_Click(object sender, EventArgs e)
        {
            int budget = 0;
            int cost = 0;
            int result = 0;
            var value = new int[12];
            try
            {
                budget = int.Parse(tbBudgets.Text);
                cost = int.Parse(tbRent.Text) + int.Parse(tbUtilityCosts.Text) + int.Parse(tbCellPhoneBill.Text)
                        + int.Parse(tbFoodCosts.Text) + int.Parse(tbMedicalcosts.Text) + int.Parse(tbMExpense.Text)
                        + int.Parse(tbTravelCosts.Text) + int.Parse(tbTuition.Text) + int.Parse(tbSpecialCosts.Text)
                        + int.Parse(tbSavings.Text);
                result = budget - cost;

            }
            catch (Exception)
            {
                MessageBox.Show("数字のみ入力してください。");
            }
            
            tbTotal.Text = String.Format(result.ToString());
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            //改行するとCSV内で別データとして扱われるので改行を削除する。
            tbMemo.Text = tbMemo.Text.Replace("\r", "").Replace("\n","");
            //「,」を使うとCSV内で別データとして扱われるので「,」を削除する。
            tbBudgets.Text = tbBudgets.Text.Replace(",", "");
            tbRent.Text = tbRent.Text.Replace(",", "");
            tbUtilityCosts.Text = tbUtilityCosts.Text.Replace(",", "");
            tbCellPhoneBill.Text = tbCellPhoneBill.Text.Replace(",", "");
            tbFoodCosts.Text = tbFoodCosts.Text.Replace(",", "");
            tbMedicalcosts.Text = tbMedicalcosts.Text.Replace(",", "");
            tbMExpense.Text = tbMExpense.Text.Replace(",", "");
            tbTravelCosts.Text = tbTravelCosts.Text.Replace(",", "");
            tbTuition.Text = tbTuition.Text.Replace(",", "");
            tbSpecialCosts.Text = tbSpecialCosts.Text.Replace(",", "");
            tbSavings.Text = tbSavings.Text.Replace(",", "");
            tbTotal.Text = tbTotal.Text.Replace(",", "");
            tbMemo.Text = tbMemo.Text.Replace(",", "");

            string[] data = new string[] 
            {
                     lbDay.Text,tbBudgets.Text,tbRent.Text,tbUtilityCosts.Text
                    ,tbCellPhoneBill.Text,tbFoodCosts.Text,tbMedicalcosts.Text
                    ,tbMExpense.Text,tbTravelCosts.Text,tbTuition.Text
                    ,tbSpecialCosts.Text,tbSavings.Text,tbTotal.Text
                    ,tbMemo.Text,
            };
            ExpensesData expensesData = new ExpensesData
            {
                Day = lbDay.Text,
                Budgets = tbBudgets.Text,
                Rent = tbRent.Text,
                UtilityCosts = tbUtilityCosts.Text,
                CellPhoneBill = tbCellPhoneBill.Text,
                FoodCosts = tbFoodCosts.Text,
                Medicalcosts = tbMedicalcosts.Text,
                MExpense = tbMExpense.Text,
                TravelCosts = tbTravelCosts.Text,
                Tuition = tbTuition.Text,
                SpecialCosts = tbSpecialCosts.Text,
                Savings = tbSavings.Text,
                Total = tbTotal.Text,
                Memo = tbMemo.Text
            };
            StreamWriter sw = new StreamWriter(fullPath,true,Encoding.UTF8);
            string outData = "";
            for (int i = 0; i< data.Length; i++)
            {
                outData += data[i] + ",";
            }
            sw.WriteLine(outData);
            sw.Close();

            
        }

        private void btMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btNManth_Click(object sender, EventArgs e)
        {
            DateTime next = _Now.AddMonths(+1);
            _Now = next;
            lbDay.Text = next.Year.ToString() + "年"+ next.Month.ToString() + "月";
            //来月のデータがあるか探す
            if (edata.Exists(s=> s.Day == lbDay.Text))
            {


                int listNumber = edata.FindIndex(s => s.Day == lbDay.Text);

                tbBudgets.Text = edata[listNumber].Budgets.ToString();
                tbRent.Text = edata[listNumber].Rent.ToString();
                tbUtilityCosts.Text = edata[listNumber].UtilityCosts.ToString();
                tbCellPhoneBill.Text = edata[listNumber].CellPhoneBill.ToString();
                tbFoodCosts.Text = edata[listNumber].FoodCosts.ToString();
                tbMedicalcosts.Text = edata[listNumber].Medicalcosts.ToString();
                tbMExpense.Text = edata[listNumber].MExpense.ToString();
                tbTravelCosts.Text = edata[listNumber].TravelCosts.ToString();
                tbTuition.Text = edata[listNumber].Tuition.ToString();
                tbSpecialCosts.Text = edata[listNumber].SpecialCosts.ToString();
                tbSavings.Text = edata[listNumber].Savings.ToString();
                tbTotal.Text = edata[listNumber].Total.ToString();
                tbMemo.Text = edata[listNumber].Memo.ToString();
            }
            //来月のデータがなかった場合
            else
            {
                tbBudgets.Text = "0";
                tbRent.Text = "0";
                tbUtilityCosts.Text = "0";
                tbCellPhoneBill.Text = "0";
                tbFoodCosts.Text = "0";
                tbMedicalcosts.Text = "0";
                tbMExpense.Text = "0";
                tbTravelCosts.Text = "0";
                tbTuition.Text = "0";
                tbSpecialCosts.Text = "0";
                tbSavings.Text = "0";
                tbTotal.Text = "0";
                tbMemo.Text = "";

            }

        }

        private void btLManth_Click(object sender, EventArgs e)
        {
            DateTime prev = _Now.AddMonths(-1);//Nowを別のものに変えないとダメ
            _Now = prev;
            lbDay.Text = prev.Year.ToString() + "年" + prev.Month.ToString() + "月";
            //先月のデータがあるか探す
            if (edata.Exists(s => s.Day == lbDay.Text))
            {
                int listNumber = edata.FindIndex(s => s.Day == lbDay.Text);

                tbBudgets.Text = edata[listNumber].Budgets.ToString();
                tbRent.Text = edata[listNumber].Rent.ToString();
                tbUtilityCosts.Text = edata[listNumber].UtilityCosts.ToString();
                tbCellPhoneBill.Text = edata[listNumber].CellPhoneBill.ToString();
                tbFoodCosts.Text = edata[listNumber].FoodCosts.ToString();
                tbMedicalcosts.Text = edata[listNumber].Medicalcosts.ToString();
                tbMExpense.Text = edata[listNumber].MExpense.ToString();
                tbTravelCosts.Text = edata[listNumber].TravelCosts.ToString();
                tbTuition.Text = edata[listNumber].Tuition.ToString();
                tbSpecialCosts.Text = edata[listNumber].SpecialCosts.ToString();
                tbSavings.Text = edata[listNumber].Savings.ToString();
                tbTotal.Text = edata[listNumber].Total.ToString();
                tbMemo.Text = edata[listNumber].Memo.ToString();
            }
            //先月のデータがなかった場合
            else
            {
                tbBudgets.Text = "0";
                tbRent.Text = "0";
                tbUtilityCosts.Text = "0";
                tbCellPhoneBill.Text = "0";
                tbFoodCosts.Text = "0";
                tbMedicalcosts.Text = "0";
                tbMExpense.Text = "0";
                tbTravelCosts.Text = "0";
                tbTuition.Text = "0";
                tbSpecialCosts.Text = "0";
                tbSavings.Text = "0";
                tbTotal.Text = "0";
                tbMemo.Text = "";

            }
        }

        private void btNow_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            _Now = now;
            
            lbDay.Text = now.Year.ToString() + "年" + now.Month.ToString() + "月";
            //来月のデータがあるか探す
            if (edata.Exists(s => s.Day == lbDay.Text))
            {


                int listNumber = edata.FindIndex(s => s.Day == lbDay.Text);

                tbBudgets.Text = edata[listNumber].Budgets.ToString();
                tbRent.Text = edata[listNumber].Rent.ToString();
                tbUtilityCosts.Text = edata[listNumber].UtilityCosts.ToString();
                tbCellPhoneBill.Text = edata[listNumber].CellPhoneBill.ToString();
                tbFoodCosts.Text = edata[listNumber].FoodCosts.ToString();
                tbMedicalcosts.Text = edata[listNumber].Medicalcosts.ToString();
                tbMExpense.Text = edata[listNumber].MExpense.ToString();
                tbTravelCosts.Text = edata[listNumber].TravelCosts.ToString();
                tbTuition.Text = edata[listNumber].Tuition.ToString();
                tbSpecialCosts.Text = edata[listNumber].SpecialCosts.ToString();
                tbSavings.Text = edata[listNumber].Savings.ToString();
                tbTotal.Text = edata[listNumber].Total.ToString();
                tbMemo.Text = edata[listNumber].Memo.ToString();
            }
            else
            {
                tbBudgets.Text = "0";
                tbRent.Text = "0";
                tbUtilityCosts.Text = "0";
                tbCellPhoneBill.Text = "0";
                tbFoodCosts.Text = "0";
                tbMedicalcosts.Text = "0";
                tbMExpense.Text = "0";
                tbTravelCosts.Text = "0";
                tbTuition.Text = "0";
                tbSpecialCosts.Text = "0";
                tbSavings.Text = "0";
                tbTotal.Text = "0";
                tbMemo.Text = "";
            }
        }

        private void btPie_Click(object sender, EventArgs e)
        {
            PieChart pieChart = new PieChart();
            pieChart.day = lbDay.Text;
            pieChart.budget = int.Parse(tbBudgets.Text);
            pieChart.rent = int.Parse(tbRent.Text);
            pieChart.utilitycost = int.Parse(tbUtilityCosts.Text);
            pieChart.cellphonebill = int.Parse(tbCellPhoneBill.Text);
            pieChart.foodcost = int.Parse(tbFoodCosts.Text);
            pieChart.medicalcost = int.Parse(tbMedicalcosts.Text);
            pieChart.mexpense = int.Parse(tbMExpense.Text);
            pieChart.travelcost = int.Parse(tbTravelCosts.Text);
            pieChart.tuition = int.Parse(tbTuition.Text);
            pieChart.specialcost = int.Parse(tbSpecialCosts.Text);
            pieChart.saving = int.Parse(tbSavings.Text);
            pieChart.total = int.Parse(tbTotal.Text);
            pieChart.Show();


        }
    }
}
