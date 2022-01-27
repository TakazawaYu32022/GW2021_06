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
            //起動時の月を保存しておく
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
            //データがなかった場合
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
            //「計」の値をカンマ区切りで表示する。（CSVファイルに保存するとき別のデータとして区切られてしまう）
            tbTotal.Text = String.Format(/*"{0:#,##0}",*/ result.ToString());
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            tbMemo.Text = tbMemo.Text.Replace("\r", "").Replace("\n","");//改行するとCSV内で別データとして扱われるので改行を削除する。
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
    }
}
