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
    public partial class FormGuideCountry : Form
    {
        public FormGuideCountry()
        {
            InitializeComponent();
        }

        private void buttonCountry_Click(object sender, EventArgs e)
        {
            FormCountry formCountry = new FormCountry();
            formCountry.Show();
        }

        private void buttonCity_Click(object sender, EventArgs e)
        {
            FormCity formCity = new FormCity();
            formCity.Show();
        }
    }
}
