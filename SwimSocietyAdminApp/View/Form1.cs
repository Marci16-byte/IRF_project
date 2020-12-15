using System;
using System.Windows.Forms;
using SwimSocietyAdminApp.View;

namespace SwimSocietyAdminApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuSwimmersButton_Click(object sender, EventArgs e)
        {
            Form swimmersForm = new SwimmersForm();
            swimmersForm.ShowDialog();
        }

        private void menuClubsButton_Click(object sender, EventArgs e)
        {
            Form clubsForm = new ClubsForm();
            clubsForm.ShowDialog();
        }

        private void menuStatsButton_Click(object sender, EventArgs e)
        {
            Form statsForm = new StatsForm();
            statsForm.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void swimmersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuSwimmersButton_Click(this, EventArgs.Empty);
        }

        private void clubsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuClubsButton_Click(this, EventArgs.Empty);
        }

        private void statsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuStatsButton_Click(this, EventArgs.Empty);
        }

        private void menuExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
