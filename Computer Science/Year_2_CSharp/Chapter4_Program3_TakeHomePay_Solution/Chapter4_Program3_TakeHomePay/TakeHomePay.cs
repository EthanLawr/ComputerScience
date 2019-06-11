using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4_Program3_TakeHomePay
{
    class TakeHomePay : TaskShortener
    {
        private static string employeeName;
        private static double sales;
        private const double TOTAL_SALES_FOR_EMPLOYEE = 0.07;
        public string Name
        {
            get
            {
                return employeeName;
            }
            set
            {
                employeeName = value;
            }
        }
        public double Sales
        {
            get
            {
                return sales;
            }
            set
            {
                sales =  value;
            }
        }
        public double SalesEarned
        {
            get
            {
                return sales* TOTAL_SALES_FOR_EMPLOYEE;
            }
            set
            {
                sales = value;
            }
        }
        
        public TakeHomePay()
        {
            employeeName = AskUserForString("the employee's name.");
            sales = AskUserForDouble("the total sales of this week (In american dollars).");
        }
    }
}
