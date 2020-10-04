using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;


namespace IRCalculator
{
    public partial class ResultsForm : Form
    {
        public ResultsForm(float loan, float interestRate, float years)
        {

            InitializeComponent(loan, interestRate, years);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
