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
            //相対パスに変更する
            if (File.Exists(@"C:\Users\infosys\Desktop\test\" + lbDay.Text + ".csv"))
            {
                var reader = new StreamReader(@"C:\Users\infosys\Desktop\test\" + lbDay.Text + ".csv");
                //CSVから文字を読み取り、文字列として返す

                for (int i = 0; i < 12; i++)
                {
                    sLine = reader.ReadLine();
                    sFields[i] = sLine;
                }

                tbBudgets.Text = sFields[0];
                tbRent.Text = sFields[1];
                tbUtilityCosts.Text = sFields[2];
                tbCellPhoneBill.Text = sFields[3];
                tbFoodCosts.Text = sFields[4];
                tbMedicalcosts.Text = sFields[5];
                tbMExpense.Text = sFields[6];
                tbTravelCosts.Text = sFields[7];
                tbTuition.Text = sFields[8];
                tbSpecialCosts.Text = sFields[9];
                tbSavings.Text = sFields[10];
                tbTotal.Text = sFields[11];
                tbMemo.Text = sFields[12];
                reader.Dispose();//データの解放。ファイルをよみこんだら必ず入れる。
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
            tbTotal.Text = String.Format("{0:#,##0}", result);
        }

        private void btSave_Click(object sender, EventArgs e)
        {

            //相対パスに変更する
            if (File.Exists(@"C:\Users\infosys\Desktop\test\" + lbDay.Text + ".csv"))
            {
                //データの更新
                //FileStream fs = new FileStream(@"C:\Users\infosys\Desktop\test\" + lbDay.Text + ".csv", FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                //var writer = new StreamWriter(fs);
                File.WriteAllText(@"C:\Users\infosys\Desktop\test\" + lbDay.Text + ".csv",
                          tbBudgets.Text + "\r\n" + tbRent.Text + "\r\n" + tbUtilityCosts.Text + "\r\n"
                        + tbCellPhoneBill.Text + "\r\n" + tbFoodCosts.Text + "\r\n" + tbMedicalcosts.Text + "\r\n"
                        + tbMExpense.Text + "\r\n" + tbTravelCosts.Text + "\r\n" + tbTuition.Text + "\r\n"
                        + tbSpecialCosts.Text + "\r\n" + tbSavings.Text + "\r\n" + tbTotal.Text + "\r\n"
                        + tbMemo.Text + "\r\n", Encoding.UTF8);


            }
            else
            {
                //データの新規追加
                String now = DateTime.Now.ToString(lbDay.Text/*"yyyy" + "年" + "MM" + "月"*/);
                //相対パスに変更する
                StreamWriter sw = new StreamWriter(@"C:\Users\infosys\Desktop\test\" + now + ".csv", true);
                sw.Write(tbBudgets.Text + "\r\n" + tbRent.Text + "\r\n" + tbUtilityCosts.Text + "\r\n"
                            + tbCellPhoneBill.Text + "\r\n" + tbFoodCosts.Text + "\r\n" + tbMedicalcosts.Text + "\r\n"
                            + tbMExpense.Text + "\r\n" + tbTravelCosts.Text + "\r\n" + tbTuition.Text + "\r\n"
                            + tbSpecialCosts.Text + "\r\n" + tbSavings.Text + "\r\n" + tbTotal.Text + "\r\n"
                            + tbMemo.Text + "\r\n");
                sw.Close();
            }
            
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
            if (File.Exists(@"C:\Users\infosys\Desktop\test\" + lbDay.Text + ".csv"))
            {
                //相対パスに変更する
                var reader = new StreamReader(@"C:\Users\infosys\Desktop\test\" + lbDay.Text + ".csv");
                //CSVから文字を読み取り、文字列として返す
                
                for (int i = 0; i < 13; i++)
                {
                    sLine = reader.ReadLine();
                    sFields[i] = sLine;
                }
                
                tbBudgets.Text = sFields[0];
                tbRent.Text = sFields[1];
                tbUtilityCosts.Text = sFields[2];
                tbCellPhoneBill.Text = sFields[3];
                tbFoodCosts.Text = sFields[4];
                tbMedicalcosts.Text = sFields[5];
                tbMExpense.Text = sFields[6];
                tbTravelCosts.Text = sFields[7];
                tbTuition.Text = sFields[8];
                tbSpecialCosts.Text = sFields[9];
                tbSavings.Text = sFields[10];
                tbTotal.Text = sFields[11];
                tbMemo.Text = sFields[12];
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
            if (File.Exists(@"C:\Users\infosys\Desktop\test\" + lbDay.Text + ".csv"))
            {
                //相対パスに変更する
                var reader = new StreamReader(@"C:\Users\infosys\Desktop\test\" + lbDay.Text + ".csv");
                //CSVから文字を読み取り、文字列として返す

                for (int i = 0; i < 12; i++)
                {
                    sLine = reader.ReadLine();
                    sFields[i] = sLine;
                }
                
                tbBudgets.Text = sFields[0];
                tbRent.Text = sFields[1];
                tbUtilityCosts.Text = sFields[2];
                tbCellPhoneBill.Text = sFields[3];
                tbFoodCosts.Text = sFields[4];
                tbMedicalcosts.Text = sFields[5];
                tbMExpense.Text = sFields[6];
                tbTravelCosts.Text = sFields[7];
                tbTuition.Text = sFields[8];
                tbSpecialCosts.Text = sFields[9];
                tbSavings.Text = sFields[10];
                tbTotal.Text = sFields[11];
                tbMemo.Text = sFields[12];
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
