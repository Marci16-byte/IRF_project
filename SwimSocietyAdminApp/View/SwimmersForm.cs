using System;
using System.Windows.Forms;
using SwimSocietyAdminApp.Model;
using SwimSocietyAdminApp.Persistence;

namespace SwimSocietyAdminApp.View
{
    public partial class SwimmersForm : Form
    {
        private SwimmersModel model;
        Swimmer selected;

        private void InitDataControls()
        {
            dataGridView1.DataSource = model.GetSwimmers();
            dataGridView1.Columns["Agegroup"].Visible = false;
            dataGridView1.Columns["Club"].Visible = false;
            dataGridView1.Columns[0].HeaderText = "Azonosító";
            dataGridView1.Columns[1].HeaderText = "Név";
            dataGridView1.Columns[2].HeaderText = "Szül. hely";
            dataGridView1.Columns[3].HeaderText = "Szül. idő";
            dataGridView1.Columns[4].HeaderText = "Nem";
            dataGridView1.Columns[5].HeaderText = "Korcsoport";
            dataGridView1.Columns[6].HeaderText = "Egyesület";

            selected = dataGridView1.Rows[0].DataBoundItem as Swimmer;
            textBoxAge.Text = model.GetAgeGroupFromNum(selected.AgeGroup_FK).ToString();
            textBoxBirthPlace.Text = selected.Birthplace;
            textBoxBirthTime.Text = selected.Birthdate.ToString();
            textBoxClub.Text = model.GetSwimmerClub(selected.Club_FK);
            textBoxName.Text = selected.Name;
            textBoxSex.Text = selected.Sex;
        }

        public SwimmersForm()
        {
            InitializeComponent();

            model = new SwimmersModel();
            InitDataControls();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                selected = dataGridView1.SelectedRows[0].DataBoundItem as Swimmer;
                textBoxAge.Text = model.GetAgeGroupFromNum(selected.AgeGroup_FK).ToString();
                textBoxBirthPlace.Text = selected.Birthplace;
                textBoxBirthTime.Text = selected.Birthdate.ToString();
                textBoxClub.Text = model.GetSwimmerClub(selected.Club_FK);
                textBoxName.Text = selected.Name;
                textBoxSex.Text = selected.Sex;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Valami hiba történt!");
            }
        }

        private void buttonModifySwimmer_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Biztosan módosítja a kijelölt versenyző adatait?", "Versenyző módosítása", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    model.ModifySwimmer(selected.Id, textBoxAge.Text, textBoxBirthPlace.Text, textBoxBirthTime.Text, textBoxClub.Text,
                                        textBoxName.Text, textBoxSex.Text);
                    dataGridView1.Update();
                    dataGridView1.Refresh();
                }
                catch (SwimSocietyDataException)
                {
                    MessageBox.Show("Módosítás sikertelen!" + Environment.NewLine + "Korcsoport megnevezése, és az Egyesület neve nem lehetnek üresek!" +
                                    Environment.NewLine + "Esetleg nem létező Korcsoportot, vagy Egyesületet ad meg!",
                                    "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void buttonNewSwimmer_Click(object sender, EventArgs e)
        {
            using (NewSwimmerForm newSwimmerForm = new NewSwimmerForm())
            {
                newSwimmerForm.ShowDialog();
            }

            InitDataControls();
        }

        private void buttonDeleteSwimmer_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Biztosan törli a kijelölt versenyzőt?", "Versenyző törlése", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    model.DeleteSwimmer(selected.Id);
                    InitDataControls();
                }
                catch (SwimSocietyDataException)
                {
                    MessageBox.Show("Törlés sikertelen!", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void buttonDeleteBy_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Biztosan törli a megadott tulajdonságú versenyzőket?", "Versenyzők törlése tulajdonságok szerint",
                                                        MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    model.DeleteSwimmersBy(textBoxBP.Text, textBoxS.Text, textBoxA.Text, textBoxC.Text);
                    InitDataControls();
                }
                catch (SwimSocietyDataException)
                {
                    MessageBox.Show("Törlés sikertelen!", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
