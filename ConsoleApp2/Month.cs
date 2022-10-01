using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    
    class Month
    {
        static int maxDailyProduction = 200;        //Max production per day for each month
        string monthName;
        int monthDays;
        int maxProduction;      //Maximum production per month = nr of days * 200
        int totalProduction;


        public Month(string name, int days)
        {
            monthName = name;
            monthDays = days;
            maxProduction = monthDays * maxDailyProduction;    //calculate the maximum to be produced this month based on days
        }
            
        public override String ToString()
        {
            return String.Format("Month: {0}\tMonth days: {1}\tProduction: {2}", monthName, monthDays, totalProduction);
        }

        public void setTotalProduction(int production)
        {
            totalProduction = production;
        }
        public int getMaxProduction()
        {
            return maxProduction;
        }
    }
}
