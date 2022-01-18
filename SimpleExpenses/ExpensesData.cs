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
        public string Budgets { get; set; }//予算
        public string Rent { get; set; }//家賃・ローン
        public string UtilityCosts { get; set; }//光熱費
        public string CellPhoneBill { get; set; }//通信費
        public string FoodCosts { get; set; }//食費
        public string Medicalcosts { get; set; }//医療費
        public string MExpense { get; set; }//雑費
        public string TravelCosts { get; set; }//交通費
        public string Tuition { get; set; }//教育費
        public string SpecialCosts { get; set; }//特別費
        public string Savings { get; set; }//貯金
        public string Total { get; set; }//計
        public string Memo { get; set; }//メモ

        public void UpDate(string day, string budgets, string rent, string utilitycosts,
                            string cellphonebill, string foodcosts, string medicalcosts, string mexpense, string travelcosts,
                            string tuition, string specialcosts, string saving, string total,string memo)
        {
            this.Day = day;
            this.Budgets = budgets;
            this.Rent = rent;
            this.UtilityCosts = utilitycosts;
            this.CellPhoneBill = cellphonebill;
            this.FoodCosts = foodcosts;
            this.Medicalcosts = medicalcosts;
            this.MExpense = mexpense;
            this.TravelCosts = travelcosts;
            this.Tuition = tuition;
            this.SpecialCosts = specialcosts;
            this.Savings = saving;
            this.Total = total;
            this.Memo = memo;
        }

    }
}
