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
        public Start()
        {
            InitializeComponent();
        }

        private void Start_Load(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            lbDay.Text = dt.Year.ToString() + "年" + dt.Month.ToString() + "月";
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
            String now = DateTime.Now.ToString(lbDay.Text/*"yyyy" + "年" + "MM" + "月"*/);
            StreamWriter sw = new StreamWriter(@"C:\Users\infosys\Desktop\test\" + now + ".csv",true,
                System.Text.Encoding.GetEncoding("shift_jis"));
            sw.Write(tbBudgets.Text + "\r\n" + tbRent.Text + "\r\n" + tbUtilityCosts.Text + "\r\n"
                        + tbCellPhoneBill.Text + "\r\n" + tbFoodCosts.Text + "\r\n" + tbMedicalcosts.Text + "\r\n"
                        + tbMExpense.Text + "\r\n" + tbTravelCosts.Text + "\r\n" + tbTuition.Text + "\r\n"
                        + tbSpecialCosts.Text + "\r\n" + tbSavings.Text + "\r\n" + tbTotal.Text + "\r\n"
                        + tbMemo.Text + "\r\n");
            sw.Close();
        }

        private void btEnd_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
