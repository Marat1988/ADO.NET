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
    public partial class FormCountry : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public FormCountry()
        {
            InitializeComponent();
            ShowInfoCountry();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabControlCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlCountry.SelectedIndex == 0)
            {
                ShowInfoCountry();
            }
        }

        private  void ShowInfoCountry()
        {
            var queryResult = from c in db.Country
                              select new
                              {
                                  Id = c.CountryId,
                                  Name = c.Name,
                                  Area = c.Area
                              };
           dataGridViewShowCountry.DataSource = queryResult;
        }

        private void dataGridViewShowCountry_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonInputCountry_Click(object sender, EventArgs e)
        {
            try
            {
                Country country = new Country();
                country.Name = textBoxCountryName.Text;
                country.Area = int.Parse(textBoxCountryArea.Text);
                db.Country.InsertOnSubmit(country);
                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
