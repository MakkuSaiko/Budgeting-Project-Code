using System;
using System.IO;

namespace ConsoleApp2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int annualProduction = 10000;           //Total annual production
            int limitProduction = 1000;             //limit the max production for the month to 1000
            
            Month[] months = new Month[12];         //lists of months
            populateMonthList(ref months);

            Random random = new Random();

            //get production for each month
            foreach(Month month in months)
            {
                int production = random.Next(0, month.getMaxProduction()+1);     //get a random production for the month
                if (production > limitProduction) { 
                    production = limitProduction;
                    production = random.Next(0, production);
                }
                if (annualProduction < production) production = annualProduction;
                   
                
                if (annualProduction > production) annualProduction -= production;
                month.setTotalProduction(production);
             
            }

            

            writeToFile(months);


            
        }

        static void populateMonthList(ref Month[] months)
        {
            int nrEl = 0;
            StreamReader sr = new StreamReader("Months.txt");
            while(!sr.EndOfStream)
            {
                String[] cur = sr.ReadLine().Split(",");
                String name = cur[0];
                int days = int.Parse(cur[1]);
                months[nrEl] = new Month(name, days);
                nrEl++;
            }
            sr.Close();

        }

        static void writeToFile(Month[] months)
        {
            StreamWriter sw = new StreamWriter("Output.txt");
            foreach(Month month in months)
            {
                sw.WriteLine(month.ToString());
            }
            sw.Close();
        }

        
    }
}
