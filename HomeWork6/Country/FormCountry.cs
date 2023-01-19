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
        private DataClasses1DataContext db = new DataClasses1DataContext();
        private int idCountry;
        public FormCountry()
        {
            InitializeComponent();
            ShowInfoCountry();
        }

        private void tabControlCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlCountry.SelectedIndex == 0)
            {
                ShowInfoCountry();
            }
        }

        private void ShowInfoCountry()
        {
            var queryResult = from c in db.Country
                              select new
                              {
                                  Id = c.CountryId,
                                  Name = c.Name,
                                  Area = c.Area
                              };
           dataGridViewShowCountry.DataSource = queryResult;
           dataGridViewEditCountry.DataSource = queryResult;
           dataGridViewDeleteCountry.DataSource = queryResult;
        }

        private void buttonInputCountry_Click(object sender, EventArgs e)
        {
            try
            {
                Country country = new Country();
                country.Name = textBoxCountryNameAdd.Text;
                country.Area = int.Parse(textBoxCountryAreaAdd.Text);
                db.Country.InsertOnSubmit(country);
                db.SubmitChanges();
                ShowInfoCountry();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonEditCountry_Click(object sender, EventArgs e)
        {
            try
            {
                Country country = db.Country.Single(x => x.CountryId == idCountry);
                country.Name = textBoxCountryNameEdit.Text;
                country.Area = int.Parse(textBoxCountryAreaEdit.Text);
                db.SubmitChanges();
                ShowInfoCountry();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewShowCountry_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewShowCountry.SelectedRows)
            {
                textBoxCountryNameEdit.Text = row.Cells[1].Value.ToString();
                textBoxCountryAreaEdit.Text = row.Cells[2].Value.ToString();
                idCountry = int.Parse(row.Cells[0].Value.ToString());
            }
        }

        private void buttonDeleteCountry_Click(object sender, EventArgs e)
        {
            try
            {
                Country country = db.Country.Single(x => x.CountryId == idCountry);
                db.Country.DeleteOnSubmit(country);
                db.SubmitChanges();
                ShowInfoCountry();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
