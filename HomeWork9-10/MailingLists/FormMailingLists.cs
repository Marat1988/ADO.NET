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
        private void buttonBuyers_Click(object sender, EventArgs e)
        {
            FormBuyers formBuyers = new FormBuyers
            {
                Text = (sender as Button).Text
            };
            formBuyers.ShowDialog();
        }
        private void buttonGroupProduct_Click(object sender, EventArgs e)
        {
            FormGroupProduct formGroupProduct = new FormGroupProduct
            {
                Text = (sender as Button).Text
            };
            formGroupProduct.ShowDialog();
        }
        private void buttonStockProduct_Click(object sender, EventArgs e)
        {
            FormStockProduct formStockProduct = new FormStockProduct
            {
                Text = (sender as Button).Text
            };
            formStockProduct.ShowDialog();
        }
        private void buttonInfoHelp_Click(object sender, EventArgs e)
        {
            FormInfoHelp formInfoHelp = new FormInfoHelp
            {
                Text = (sender as Button).Text
            };
            formInfoHelp.ShowDialog();
        }

    }
}
