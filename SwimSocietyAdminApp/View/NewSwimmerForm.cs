using System;
using System.Windows.Forms;
using SwimSocietyAdminApp.Model;
using SwimSocietyAdminApp.Persistence;

namespace SwimSocietyAdminApp.View
{
    public partial class NewSwimmerForm : Form
    {
        public NewSwimmerForm()
        {
            InitializeComponent();
        }

        private void buttonAddSwimmer_Click(object sender, EventArgs e)
        {
            var model = new SwimmersModel();
            try
            {
                model.AddNewSwimmer(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text);
                MessageBox.Show("Sikeres mentés!");
            }
            catch (SwimSocietyDataException)
            {
                MessageBox.Show("Sikertelen művelet!", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
