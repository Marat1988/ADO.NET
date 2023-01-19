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
    public partial class FormBigCity : Form
    {
        private DataClasses1DataContext db = new DataClasses1DataContext();
        private int idBigCity;
        public FormBigCity()
        {
            InitializeComponent();
            ShowInfoBigCity();
        }
        private void tabControlBigCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlBigCity.SelectedIndex == 0)
            {
                ShowInfoBigCity();
            }
        }

        private void ShowInfoBigCity()
        {
            var queryResult = from c1 in db.BigCity
                              join c2 in db.City on c1.CityId equals c2.CityId
                              join c3 in db.Country on c2.CountryId equals c3.CountryId
                              select new
                              {
                                  Id = c1.CityId,
                                  Budget = c1.Budget,
                                  City_Name = c2.Name,
                                  Count_People = c2.CountPeople,
                                  Country = c3.Name
                              };
            var cityResult = from c1 in db.City
                             where !(from o in db.BigCity
                                     select o.CityId).Contains(c1.CityId)
                             select new
                             {
                                 Name_City = c1.Name
                             };
            comboBoxChooseCity.Items.Clear();
            comboBoxChooseCity.Items.AddRange(cityResult.Select(i => i.Name_City).ToArray());
            dataGridViewShowBigCity.DataSource = queryResult;
            dataGridViewEditBigCity.DataSource = queryResult;
            dataGridViewDeleteBigCity.DataSource = queryResult;
        }

        private void buttonInputBigCity_Click(object sender, EventArgs e)
        {
            try
            {
                int idCity = db.City.FirstOrDefault(i => i.Name == comboBoxChooseCity.Text).CityId;
                BigCity bigCity = new BigCity();
                bigCity.CityId = idCity;
                bigCity.Budget = Convert.ToDecimal(textBoxBigCityBudgetAdd.Text);
                db.BigCity.InsertOnSubmit(bigCity);
                db.SubmitChanges();
                ShowInfoBigCity();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonEditBigCity_Click(object sender, EventArgs e)
        {
            try
            {
                BigCity bigCity = db.BigCity.Single(x => x.CityId == idBigCity);
                bigCity.Budget = Convert.ToDecimal(textBoxBigCityBudgetEdit.Text);
                db.SubmitChanges();
                ShowInfoBigCity();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonDeleteBigCity_Click(object sender, EventArgs e)
        {
            try
            {
                BigCity bigCity = db.BigCity.Single(x => x.CityId == idBigCity);
                db.BigCity.DeleteOnSubmit(bigCity);
                db.SubmitChanges();
                ShowInfoBigCity();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewShowBigCity_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewShowBigCity.SelectedRows)
            {
                textBoxBigCityBudgetEdit.Text = row.Cells[1].Value.ToString();
                idBigCity = int.Parse(row.Cells[0].Value.ToString());
            }
        }

    }
}
