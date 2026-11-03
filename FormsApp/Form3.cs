using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FormsApp
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e) { }

        private void textBox2_TextChanged(object sender, EventArgs e) { }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtStart.Text, out int start) || start < 0 || start > 23)
            {
                MessageBox.Show("Starting hour must be a number between 0 and 23.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtEnd.Text, out int end) || end < 1 || end > 24 || end <= start)
            {
                MessageBox.Show("Ending hour must be between 1 and 24, and greater than starting hour.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int total = 0;
            for (int hour = start; hour < end; hour++)
            {
                if (hour < 7 || hour >= 21)
                    total += 500;
                else if (hour < 14 || hour >= 19)
                    total += 1000;
                else
                    total += 1500;
            }

            lblResult.Text = $"Total rent: {total} RWF";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Close();
        }
    }
}
