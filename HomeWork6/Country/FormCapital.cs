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
    public partial class FormCapital : Form
    {
        private DataClasses1DataContext db = new DataClasses1DataContext();
        private int idCapital;
        public FormCapital()
        {
            InitializeComponent();
            ShowInfoCapital();
        }

        private void tabControlCapital_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlCapital.SelectedIndex == 0)
            {
                ShowInfoCapital();
            }
        }
        private void ShowInfoCapital()
        {
            var queryRusult = from c1 in db.Capital
                              join c2 in db.City on c1.CityId equals c2.CityId
                              join c3 in db.Country on c2.CountryId equals c3.CountryId
                              select new
                              {
                                  Id = c1.CityId,
                                  City_Name = c2.Name,
                                  Mayor = c1.Mayor,
                                  Area = c1.Area,
                                  Country_Name = c3.Name
                              };
            var cityResult = from c1 in db.City
                             where !(from o in db.Capital
                                     select o.CityId).Contains(c1.CityId)
                             select new
                             {
                                 Name_City = c1.Name
                             };
            comboBoxChooseCity.Items.Clear();
            comboBoxChooseCity.Items.AddRange(cityResult.Select(i => i.Name_City).ToArray());
            dataGridViewShowCapital.DataSource = queryRusult;
            dataGridViewEditCapital.DataSource = queryRusult;
            dataGridViewDeleteCapital.DataSource = queryRusult;

        }

        private void buttonInputCapital_Click(object sender, EventArgs e)
        {
            try
            {
                db.Connection?.Close();
                db.Connection.Open();
                db.Transaction = db.Connection.BeginTransaction();
                int idCountry = db.City.FirstOrDefault(i => i.Name == comboBoxChooseCity.Text).CountryId; //Нахожу страну по городу
                if (idCountry != 0) //Одна страна одна столица. Сначала нахожу столицу в данной стране.
                {
                    IEnumerable<Capital> capitals = (from c1 in db.Capital
                                                     join c2 in db.City on c1.CityId equals c2.CityId
                                                     where c2.CountryId == idCountry
                                                     select c1).ToList();
                    if (capitals.Count() > 0)
                    {
                        db.Capital.DeleteAllOnSubmit(capitals); //Удаляю столицу у текущей страны
                    }

                    Capital capital = new Capital();
                    capital.CityId = db.City.FirstOrDefault(i => i.Name == comboBoxChooseCity.Text).CityId;
                    capital.Mayor = textBoxCapitalMayorAdd.Text;
                    capital.Area = int.Parse(textBoxCapitalAreaAdd.Text);
                    db.Capital.InsertOnSubmit(capital);
                    db.SubmitChanges();
                    db.Transaction.Commit();
                    ShowInfoCapital();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                db.Transaction.Rollback();
            }
            finally
            {
                db.Connection?.Close();
            }
        }

        private void buttonEditCapital_Click(object sender, EventArgs e)
        {
            try
            {
                Capital capital = db.Capital.Single(x => x.CityId == idCapital);
                capital.Mayor = textBoxCapitalMayorEdit.Text;
                capital.Area = int.Parse(textBoxCapitalAreaEdit.Text);
                db.SubmitChanges();
                ShowInfoCapital();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDeleteCapital_Click(object sender, EventArgs e)
        {
            try
            {
                Capital capital = db.Capital.Single(x => x.CityId == idCapital);
                db.Capital.DeleteOnSubmit(capital);
                db.SubmitChanges();
                ShowInfoCapital();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewShowCapital_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewShowCapital.SelectedRows)
            {
                textBoxCapitalMayorEdit.Text = row.Cells[2].Value.ToString();
                textBoxCapitalAreaEdit.Text = row.Cells[3].Value.ToString();
                idCapital = int.Parse(row.Cells[0].Value.ToString());
            }
        }
    }
}
