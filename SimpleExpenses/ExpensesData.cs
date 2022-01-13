using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleExpenses
{
    class ExpensesData
    {
        public string Day { get; set; }//年月
        public int Budgets { get; set; }//予算
        public int Rent { get; set; }//家賃・ローン
        public int UtilityCosts { get; set; }//光熱費
        public int CellPhoneBill { get; set; }//通信費
        public int FoodCosts { get; set; }//食費


    }
}
