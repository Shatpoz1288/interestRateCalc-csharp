using System;


namespace IRCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n\n*****************************************************\nDo you want to exit?\n*****************************************************");
                string exit = Console.ReadLine().ToLower().Trim();

                if (exit == "yes" || exit == "y")
                    break;
                    
                try
                {
                    
                    float interestRate, loan, years;


                    Console.Write("Enter loan amount: ");
                    loan = float.Parse(Console.ReadLine());

                    Console.Write("Enter time in years: ");
                    years = float.Parse(Console.ReadLine());

                    Console.Write("Enter interest rate: ");
                    interestRate = float.Parse(Console.ReadLine());


                    var calculate = new InterestRateCalculator(loan, interestRate, years);
                    calculate.Calculate();


                }
                catch(Exception ex)
                {
                    Console.WriteLine("\nError: " + ex + "\n\nMake sure inputs are numeric characters.\n".ToUpper());
                }
            }
        }
    }
}