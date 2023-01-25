using MailingLists.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MailingLists
{
    public partial class FormMailingLists : Form
    {
        public FormMailingLists()
        {
            InitializeComponent();
        }

        private void FormMailingLists_Load(object sender, EventArgs e)
        {

        }

        private void buttonCountry_Click(object sender, EventArgs e)
        {
            FormCountry formCountry = new FormCountry
            {
                Text = (sender as Button).Text
            };
            formCountry.ShowDialog();
        }

        private void buttonCity_Click(object sender, EventArgs e)
        {
            FormCity formCity = new FormCity
            {
                Text = (sender as Button).Text
            };
            formCity.ShowDialog();
        }
    }
}
