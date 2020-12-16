using System;
using System.Windows.Forms;
using SwimSocietyAdminApp.Model;
using SwimSocietyAdminApp.Persistence;

namespace SwimSocietyAdminApp.View
{
    public partial class ClubsForm : Form
    {
        private ClubsModel model;
        Club selected;

        private void InitDataControls()
        {
            dataGridView1.DataSource = model.GetClubs();
            dataGridView1.Columns["Swimmers"].Visible = false;
            selected = dataGridView1.Rows[0].DataBoundItem as Club;
            textBoxCity.Text = selected.City;
            textBoxName.Text = selected.Name;
            textBoxPrize.Text = selected.Prize.ToString();
        }

        public ClubsForm()
        {
            InitializeComponent();

            model = new ClubsModel();
            InitDataControls();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                selected = dataGridView1.SelectedRows[0].DataBoundItem as Club;
                textBoxCity.Text = selected.City;
                textBoxName.Text = selected.Name;
                textBoxPrize.Text = selected.Prize.ToString();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Valami hiba történt!");
            }
        }

        private void buttonModClub_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Biztosan módosítja a kijelölt Egyesület adatait?", "Egyesület módosítása", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    model.ModifyClub(selected.Id, textBoxName.Text, textBoxCity.Text, textBoxPrize.Text);
                    dataGridView1.Update();
                    dataGridView1.Refresh();
                }
                catch (SwimSocietyDataException)
                {
                    MessageBox.Show("Módosítás sikertelen!" + Environment.NewLine + "Ellenőrizze az adatok formátumát!",
                                    "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void buttonDelClub_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Biztosan törli a kijelölt Egyesületet?", "Egyesület törlése", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    model.DeleteClub(selected.Id);
                    InitDataControls();
                }
                catch (SwimSocietyDataException)
                {
                    MessageBox.Show("Törléss sikertelen!", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void buttonNewClub_Click(object sender, EventArgs e)
        {
            using (NewClubForm newClubForm = new NewClubForm())
            {
                newClubForm.ShowDialog();
            }

            InitDataControls();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
