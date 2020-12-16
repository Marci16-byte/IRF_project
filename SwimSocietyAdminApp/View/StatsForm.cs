using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SwimSocietyAdminApp.Model;

namespace SwimSocietyAdminApp.View
{
    public partial class StatsForm : Form
    {
        StatsModel model;

        private void SetChartPrizes()
        {
            chartPrizes.ChartAreas[0].AxisX.Interval = 1;
            Dictionary<string, int?> dic = model.GetClubPrizes();
            foreach (var item in dic)
            {
                if(item.Value != null)
                {
                    chartPrizes.Series[0].Points.AddXY(item.Key, item.Value);
                }
            }
        }

        private void SetChartSwimmers()
        {
            chartSwimmers.ChartAreas[0].AxisX.Interval = 1;
            Dictionary<string, int> dic = model.GetClubSwimmers();
            foreach (var item in dic)
            {
                if (item.Value != 0) chartSwimmers.Series[0].Points.AddXY(item.Key, item.Value);
            }
        }

        public StatsForm()
        {
            InitializeComponent();
            model = new StatsModel();
            comboBoxCharts.Text = comboBoxCharts.Items[0].ToString();
            SetChartPrizes();
            SetChartSwimmers();
        }

        private void comboBoxCharts_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBoxCharts.SelectedIndex == 0)
            {
                chartSwimmers.Visible = false;
                chartPrizes.Visible = true;
            } else
            {
                chartPrizes.Visible = false;
                chartSwimmers.Visible = true;
            }
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
