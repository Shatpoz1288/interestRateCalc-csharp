using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;

namespace IRCalculator
{
    partial class ResultsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent(float loan, float interestRate, float time)
        {
            //Initialize the ListView control and add columns to it.
            this.listView1 = new ListView();
            // Set the initial sorting type for the ListView.
            this.listView1.Sorting = SortOrder.None;
            // Disable automatic sorting to enable manual sorting.
            this.listView1.View = View.Details;
            // Add columns and set their text.
            this.listView1.Columns.Add(new ColumnHeader());
            this.listView1.Columns[0].Text = "Month";
            this.listView1.Columns[0].Width = 150;
            listView1.Columns.Add(new ColumnHeader());
            listView1.Columns[1].Text = "Current Payment";
            this.listView1.Columns[1].Width = 150;
            listView1.Columns.Add(new ColumnHeader());
            listView1.Columns[2].Text = "Current Debt";
            this.listView1.Columns[2].Width = 150;

            // Suspend control logic until form is done configuring form.
            this.SuspendLayout();


            // Create ListView items to add to the control.
            // Add Items to the ListView control.
            var intCalc = new InterestRateCalculator(loan, interestRate, time);
            var my2DList = intCalc.Calculate();

            for (int i = 0; i < my2DList.Count; i++)
            {
                var listViewIt = new ListViewItem(new string[] { my2DList[i][0].ToString("F0"), my2DList[i][1].ToString("F2"), my2DList[i][2].ToString("F2") });
                this.listView1.Items.Add(listViewIt);
            }

            // Set the location and size of the ListView control.
            this.listView1.Location = new Point(10, 10);
            this.listView1.Name = "listView1";
            this.listView1.Size = new Size(455, 320);
            this.listView1.TabIndex = 0;
            // Enable editing of the items in the ListView.
            this.listView1.LabelEdit = true;
            // Connect the ListView.ColumnClick event to the ColumnClick event handler.
            this.listView1.ColumnClick += new ColumnClickEventHandler(ColumnClick);

            // Initialize the form.
            this.ClientSize = new Size(480, 335);
            this.Controls.AddRange(new Control[] { this.listView1 });
            this.Name = "ListViewSortForm";
            this.Text = "Sorted ListView Control";
            // Resume layout of the form.
            this.ResumeLayout(false);

        }
        private void ColumnClick(object o, ColumnClickEventArgs e)
        {
            // Set the ListViewItemSorter property to a new ListViewItemComparer 
            // object. Setting this property immediately sorts the 
            // ListView using the ListViewItemComparer object.
            this.listView1.ListViewItemSorter = new ListViewItemComparer(e.Column);
        }

        class ListViewItemComparer : IComparer
        {
            private int col;
            public ListViewItemComparer()
            {
                col = 0;
            }
            public ListViewItemComparer(int column)
            {
                col = column;
            }
            public int Compare(object x, object y)
            {
                return String.Compare(((ListViewItem)x).SubItems[col].Text, ((ListViewItem)y).SubItems[col].Text);
            }
        }

        #endregion

        private System.Windows.Forms.ListView listView1;


    }
}