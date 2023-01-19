using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Country
{
    public partial class FormShowInfo : Form
    {
        private DataClasses1DataContext db = new DataClasses1DataContext();
        public FormShowInfo()
        {
            InitializeComponent();
        }

        private void buttonInfoTop3CountryCountPeople_Click(object sender, EventArgs e)
        {
            dataGridViewShowInfo.DataSource = null;
            dataGridViewShowInfo.DataSource = db.up_sel_InfoTop3CountryCountPeople();
        }

        private void buttonInfoCapitalTop3CountPeople_Click(object sender, EventArgs e)
        {
            dataGridViewShowInfo.DataSource = null;
            dataGridViewShowInfo.DataSource = db.up_sel_InfoCapitalTop3CountPeople();
        }

        private void buttonTopInfoCountryCountPeople_Click(object sender, EventArgs e)
        {
            dataGridViewShowInfo.DataSource = null;
            dataGridViewShowInfo.DataSource = db.up_sel_TopInfoCountryCountPeople();
        }

        private void buttonTopCityCountPeople_Click(object sender, EventArgs e)
        {
            dataGridViewShowInfo.DataSource = null;
            dataGridViewShowInfo.DataSource = db.up_sel_TopCityCountPeople();
        }
    }
}
