using System;
// using System.Collections.Generic;

namespace IRCalculator
{
    class InterestRateCalculator
    {
        public int Loan { get; set; }
        public int Time { get; set; }
        public float InterestRate { get; set; }

        public InterestRateCalculator(int loan, float interestRate)
        {
            this.Loan = loan;
            this.InterestRate = interestRate;
            this.Time = 1;
        }
        public InterestRateCalculator(int loan, float interestRate, int time)
            :this(loan, interestRate)
        {
            this.Time = time;
        }

        public void Calculate()
        {
            var months = Time * 12;
            var currentDebt = Loan;
            var monthlyInterestRate = InterestRate / months;
            var monthlyPayment = Loan / months;

            for(int i = 1; i <= months + 1; i++)
            {
                var currentPayment = monthlyPayment + (monthlyInterestRate*currentDebt);
                currentDebt = currentDebt - monthlyPayment;
                if (currentDebt < 0)
                    currentDebt = 0;

                Console.WriteLine("Current Month\t\tCurrent Payment\t\tCurrent Debt");
                Console.WriteLine(string.Format("\t    {0}\t\t\t      {1}\t\t   {2}",i,currentPayment.ToString("F2"),currentDebt));
                

            }
        }

    }
}
