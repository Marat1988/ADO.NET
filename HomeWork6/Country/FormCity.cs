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
    public partial class FormCity : Form
    {
        private DataClasses1DataContext db = new DataClasses1DataContext();
        private int idCity;
        public FormCity()
        {
            InitializeComponent();
            ShowInfoCity();
        }

        private void tabControlCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlCity.SelectedIndex == 0)
            {
                ShowInfoCity();
            }
        }

        private void ShowInfoCity()
        {
            var queryResult = from c1 in db.Country
                              join c2 in db.City on c1.CountryId equals c2.CountryId
                              select new
                              {
                                  Id = c2.CityId,
                                  Name = c2.Name,
                                  Count_people = c2.CountPeople,
                                  Name_Country = c1.Name
                              };
            var countryResult = from c1 in db.Country
                                orderby c1.Name
                                select new
                                {
                                    Name_City = c1.Name
                                };
            comboBoxChooseCountry.Items.Clear();
            comboBoxChooseCountry.Items.AddRange(countryResult.Select(i => i.Name_City).ToArray());
            comboBoxChooseEditCountry.Items.Clear();
            comboBoxChooseEditCountry.Items.AddRange(countryResult.Select(i => i.Name_City).ToArray());
            dataGridViewShowCity.DataSource = queryResult;
            dataGridViewEditCity.DataSource = queryResult;
            dataGridViewDeleteCity.DataSource = queryResult;
        }

        private void buttonInputCountry_Click(object sender, EventArgs e)
        {
            try
            {
                City city = new City();
                city.Name = textBoxCityNameAdd.Text;
                city.CountPeople = int.Parse(textBoxCityCountPeopleAdd.Text);
                city.CountryId = db.Country.FirstOrDefault(i => i.Name == comboBoxChooseCountry.Text).CountryId;
                db.City.InsertOnSubmit(city);
                db.SubmitChanges();
                ShowInfoCity();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonEditCity_Click(object sender, EventArgs e)
        {
            try
            {
                City city = db.City.Single(x => x.CityId == idCity);
                city.Name = textBoxCityNameEdit.Text;
                city.CountPeople = int.Parse(textBoxCityCountPeopleEdit.Text);
                city.CountryId = db.Country.FirstOrDefault(i => i.Name == comboBoxChooseEditCountry.Text).CountryId;
                db.SubmitChanges();
                ShowInfoCity();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDeleteCountry_Click(object sender, EventArgs e)
        {
            try
            {
                City city = db.City.Single(x => x.CityId == idCity);
                db.City.DeleteOnSubmit(city);
                db.SubmitChanges();
                ShowInfoCity();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewShowCity_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewShowCity.SelectedRows)
            {
                textBoxCityNameEdit.Text = row.Cells[1].Value.ToString();
                textBoxCityCountPeopleEdit.Text = row.Cells[2].Value.ToString();
                comboBoxChooseEditCountry.SelectedIndex=comboBoxChooseEditCountry.Items.IndexOf(row.Cells[3].Value.ToString());
                idCity = int.Parse(row.Cells[0].Value.ToString());
            }
        }
    }
}
