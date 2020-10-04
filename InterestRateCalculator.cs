using System.Collections.Generic;


namespace IRCalculator
{
    public class InterestRateCalculator
    {
        public float Loan { get; set; }
        public float Years{ get; set; }
        public float InterestRate { get; set; }
                
        public InterestRateCalculator(float loan, float interestRate)
        {
            this.Loan = loan;
            this.InterestRate = interestRate;
            this.Years = 1;
        }
        public InterestRateCalculator(float loan, float interestRate, float time)
            : this(loan, interestRate)
        {
            this.Years = time;
        }

        public List<List<float>> Calculate()
        {
            var months = Years * 12;
            var currentDebt = Loan;
            var monthlyInterestRate = InterestRate / months;
            var monthlyPayment = Loan / months;
            var List2D = new List<List<float>>();


            for (int i = 1; i <= months; i++)
            {
                var currentPayment = monthlyPayment + (monthlyInterestRate * currentDebt);
                currentDebt = currentDebt - monthlyPayment;
                if (currentDebt < 0)
                    currentDebt = 0;

                List2D.Add(new List<float>() { i, currentPayment, currentDebt });
                
            }
            return List2D;
        }
    }
}