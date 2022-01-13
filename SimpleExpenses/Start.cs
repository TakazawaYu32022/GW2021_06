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
    public partial class Start : Form
    {
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
            String sLine = "";
            String[] sFields = new string[13];
            var fullPath = Path.GetFullPath(@"..\家計簿記録.csv");
            if (File.Exists(fullPath))
            {
                var reader = new StreamReader(fullPath);
                sLine = reader.ReadLine();
                sFields = sLine.Split(',');


                //CSVから文字を読み取り、文字列として返す

                /*for (int i = 0; i < 12; i++)
                {
                    
                    
                }*/

                tbBudgets.Text = sFields[1];
                tbRent.Text = sFields[2];
                tbUtilityCosts.Text = sFields[3];
                tbCellPhoneBill.Text = sFields[4];
                tbFoodCosts.Text = sFields[5];
                tbMedicalcosts.Text = sFields[6];
                tbMExpense.Text = sFields[7];
                tbTravelCosts.Text = sFields[8];
                tbTuition.Text = sFields[9];
                tbSpecialCosts.Text = sFields[10];
                tbSavings.Text = sFields[11];
                tbTotal.Text = sFields[12];
                tbMemo.Text = sFields[13];
                reader.Dispose();//データの解放。ファイルをよみこんだら必ず入れる。
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
            //データの更新
            //
            //var writer = new StreamWriter(fs);
            string[] data = new string[] 
            {
                     lbDay.Text,tbBudgets.Text,tbRent.Text,tbUtilityCosts.Text
                    ,tbCellPhoneBill.Text,tbFoodCosts.Text,tbMedicalcosts.Text
                    ,tbMExpense.Text,tbTravelCosts.Text,tbTuition.Text
                    ,tbSpecialCosts.Text,tbSavings.Text,tbTotal.Text
                    ,tbMemo.Text,
            };
            var fullPath = Path.GetFullPath(@"..\家計簿記録.csv");
            StreamWriter sw = new StreamWriter(fullPath,true,Encoding.UTF8);
            string outData = "";
            //string outData = string.Format("{0},{1},{2}", lbDay.Text, tbBudgets.Text, tbRent.Text);
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
            String sLine ="";
            String[] sFields = new string[13];
            DateTime next = _Now.AddMonths(+1);
            _Now = next;
            lbDay.Text = next.Year.ToString() + "年"+ next.Month.ToString() + "月";
            //相対パスに変更する
            var fullPath = Path.GetFullPath(@"..\家計簿記録.csv");
            if (File.Exists(fullPath))
            {
                var reader = new StreamReader(fullPath);
                //CSVから文字を読み取り、文字列として返す
                sLine = reader.ReadLine();
                sFields = sLine.Split(',');

                tbBudgets.Text = sFields[1];
                tbRent.Text = sFields[2];
                tbUtilityCosts.Text = sFields[3];
                tbCellPhoneBill.Text = sFields[4];
                tbFoodCosts.Text = sFields[5];
                tbMedicalcosts.Text = sFields[6];
                tbMExpense.Text = sFields[7];
                tbTravelCosts.Text = sFields[8];
                tbTuition.Text = sFields[9];
                tbSpecialCosts.Text = sFields[10];
                tbSavings.Text = sFields[11];
                tbTotal.Text = sFields[12];
                tbMemo.Text = sFields[13];
                reader.Dispose();
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
            String sLine = "";
            String[] sFields = new string[13];
            DateTime next = _Now.AddMonths(-1);//Nowを別のものに変えないとダメ
            _Now = next;
            lbDay.Text = next.Year.ToString() + "年" + next.Month.ToString() + "月";
            //相対パスに変更する
            var fullPath = Path.GetFullPath(@"..\家計簿記録.csv");
            if (File.Exists(fullPath))
            {
                //相対パスに変更する
                var reader = new StreamReader(fullPath);
                //CSVから文字を読み取り、文字列として返す
                sLine = reader.ReadLine();
                sFields = sLine.Split(',');

                tbBudgets.Text = sFields[1];
                tbRent.Text = sFields[2];
                tbUtilityCosts.Text = sFields[3];
                tbCellPhoneBill.Text = sFields[4];
                tbFoodCosts.Text = sFields[5];
                tbMedicalcosts.Text = sFields[6];
                tbMExpense.Text = sFields[7];
                tbTravelCosts.Text = sFields[8];
                tbTuition.Text = sFields[9];
                tbSpecialCosts.Text = sFields[10];
                tbSavings.Text = sFields[11];
                tbTotal.Text = sFields[12];
                tbMemo.Text = sFields[13];
                reader.Dispose();//データの解放。ファイルをよみこんだら必ず入れる。
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
