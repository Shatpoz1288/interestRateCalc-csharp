using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Drawing.Drawing2D;

namespace IRCalculator
{
    public partial class Program : Form
    {
        private Label label1;
        private Label label2;
        private TextBox textBoxLoan;
        private TextBox textBoxYears;
        private TextBox textBoxInterestRate;
        private Button buttonCalculate;
        private Label labelLoan;

        public Program()
        {
            InitializeComponent();
        }
        static void Main(string[] args)
        {
            Application.SetCompatibleTextRenderingDefault(false);
            Application.EnableVisualStyles();
            Application.Run(new Program());
        }


        private void InitializeComponent()
        {
            this.labelLoan = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxLoan = new System.Windows.Forms.TextBox();
            this.textBoxYears = new System.Windows.Forms.TextBox();
            this.textBoxInterestRate = new System.Windows.Forms.TextBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelLoan
            // 
            this.labelLoan.AutoSize = true;
            this.labelLoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoan.Location = new System.Drawing.Point(34, 19);
            this.labelLoan.Name = "labelLoan";
            this.labelLoan.Size = new System.Drawing.Size(66, 29);
            this.labelLoan.TabIndex = 0;
            this.labelLoan.Text = "Loan";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Years";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Interest Rate";
            // 
            // textBoxLoan
            // 
            this.textBoxLoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLoan.Location = new System.Drawing.Point(266, 16);
            this.textBoxLoan.Name = "textBoxLoan";
            this.textBoxLoan.Size = new System.Drawing.Size(180, 34);
            this.textBoxLoan.TabIndex = 3;
            // 
            // textBoxYears
            // 
            this.textBoxYears.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxYears.Location = new System.Drawing.Point(266, 71);
            this.textBoxYears.Name = "textBoxYears";
            this.textBoxYears.Size = new System.Drawing.Size(180, 34);
            this.textBoxYears.TabIndex = 4;
            // 
            // textBoxInterestRate
            // 
            this.textBoxInterestRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInterestRate.Location = new System.Drawing.Point(266, 126);
            this.textBoxInterestRate.Name = "textBoxInterestRate";
            this.textBoxInterestRate.Size = new System.Drawing.Size(180, 34);
            this.textBoxInterestRate.TabIndex = 5;
            this.textBoxInterestRate.TextChanged += new System.EventHandler(this.textBoxInterestRate_TextChanged);
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(39, 181);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(407, 36);
            this.buttonCalculate.TabIndex = 6;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // Program
            // 
            this.ClientSize = new System.Drawing.Size(474, 228);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.textBoxInterestRate);
            this.Controls.Add(this.textBoxYears);
            this.Controls.Add(this.textBoxLoan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelLoan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Program";
            this.Text = "Interest Rate Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxInterestRate_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            var loan = float.Parse(textBoxLoan.Text);
            var years = float.Parse(textBoxYears.Text);
            var interestRate = float.Parse(textBoxInterestRate.Text) / 100;

            var calculate = new InterestRateCalculator2(loan, interestRate, years);
            calculate.Calculate();
            
            //MessageBox.Show("HELLO WORLD");
        }
    }
}