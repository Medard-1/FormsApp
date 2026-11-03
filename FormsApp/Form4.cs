using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FormsApp
{
    public partial class MushroomForm : Form
    {
        private int step = 0;
        private bool inForest;

        private readonly string[] questions =
        {
            "Does your mushroom have gills?",
            "Does your mushroom grow in a forest?",
            "Does your mushroom have a ring?",
            "Does your mushroom have a convex cup?"
        };

        public MushroomForm()
        {
            InitializeComponent();
            lblQuestion.Text = questions[0];
        }

        private void lblQuestion_Click(object sender, EventArgs e) { }

        private void btnYes_Click(object sender, EventArgs e) => Answer(true);
        private void btnNo_Click(object sender, EventArgs e) => Answer(false);

        private void Answer(bool yes)
        {
            switch (step)
            {
                case 0:
                    if (!yes) { ShowResult("Cepe de Bordeaux"); return; }
                    step = 1;
                    lblQuestion.Text = questions[1];
                    break;

                case 1:
                    inForest = yes;
                    step = 2;
                    lblQuestion.Text = questions[2];
                    break;

                case 2:
                    if (!inForest)
                    {
                        ShowResult(yes ? "Coprin Chevelu" : "Agaric Jaunissant");
                    }
                    else
                    {
                        if (yes) { ShowResult("Amanite Tue-Mouche"); return; }
                        step = 3;
                        lblQuestion.Text = questions[3];
                    }
                    break;

                case 3:
                    ShowResult(yes ? "Pied Bleu" : "Girolle");
                    break;
            }
        }

        private void ShowResult(string mushroom)
        {
            lblQuestion.Text = $"Your mushroom is: {mushroom}";
            btnYes.Enabled = false;
            btnNo.Enabled = false;
            btnReset.Visible = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            step = 0;
            lblQuestion.Text = questions[0];
            btnYes.Enabled = true;
            btnNo.Enabled = true;
            btnReset.Visible = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Close();
        }
    }
}
