using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace IRCalculator
{
    public partial class InterestRateCalculator2 : Form
    {
        public float Loan { get; set; }
        public float Time { get; set; }
        public float InterestRate { get; set; }

        public InterestRateCalculator2()
        {
            
        }

        public InterestRateCalculator2(float loan, float interestRate)
        {
            this.Loan = loan;
            this.InterestRate = interestRate;
            this.Time = 1;
        }
        public InterestRateCalculator2(float loan, float interestRate, float time)
            : this(loan, interestRate)
        {
            this.Time = time;
        }

        public void Calculate()
        {
            var months = Time * 12;
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
                
                MessageBox.Show("Current Month\t\tCurrent Payment\t\tCurrent Debt\t\n" + string.Format("\t    {0}\t\t\t      {1}\t\t   {2}", i.ToString("F0"), currentPayment.ToString("F2"), currentDebt.ToString("F2")));
            }


            for (int i = 0; i < List2D.Count; i++)
            {
                Console.WriteLine(List2D[i][0] + " " + List2D[i][1] + " " + List2D[i][2]);
            }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // InterestRateCalculator
            // 
            this.ClientSize = new System.Drawing.Size(477, 243);
            this.Name = "InterestRateCalculator";
            this.ResumeLayout(false);

        }
    }
}