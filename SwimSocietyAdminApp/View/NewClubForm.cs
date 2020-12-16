using System;
using System.Windows.Forms;
using SwimSocietyAdminApp.Model;
using SwimSocietyAdminApp.Persistence;

namespace SwimSocietyAdminApp.View
{
    public partial class NewClubForm : Form
    {
        public NewClubForm()
        {
            InitializeComponent();
        }

        private void buttonAddClub_Click(object sender, EventArgs e)
        {
            var model = new ClubsModel();
            try
            {
                model.AddNewClub(textBoxName.Text, textBoxCity.Text, textBoxPrize.Text);
                MessageBox.Show("Sikeres mentés!");
            }
            catch (SwimSocietyDataException)
            {
                MessageBox.Show("Törléss sikertelen!", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
