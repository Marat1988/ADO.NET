using Dapper;
using MailingLists.Class;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace MailingLists.Forms
{
    public partial class FormCity : Form
    {
        private int CityId;
        public FormCity()
        {
            InitializeComponent();
            ShowInfo();
        }
        private void ShowInfo()
        {
            string sqlShowCity = "SELECT c1.CityId, c1.[Name], c.CountryId, c1.CountryId, c.Name FROM City c1 INNER JOIN Country c ON c1.CountryId = c.CountryId";
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnString"].ConnectionString))
            {
                var infoCity = connection.Query<City, Country, City>(sqlShowCity, (city, country) =>
                {
                    city.Country = country;
                    return city;
                }, splitOn: "CountryId").Select(p => new
                {
                    CityId = p.CityId,
                    City_Name = p.Name,
                    Country_Name = p.Country.Name
                }).ToList();
                dataGridViewShowCity.DataSource = infoCity;
                dataGridViewEditCity.DataSource = infoCity;
                dataGridViewDeleteCity.DataSource = infoCity;
            }
            string sqlShowCountry = "SELECT * FROM Country";
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnString"].ConnectionString))
            {
                var infoCountry = connection.Query<Country>(sqlShowCountry).Select(p => new
                {
                    p.CountryId,
                    p.Name,
                }).ToList();
                for (int i = 0; i < tabControlCity.Controls.Count; i++)
                {
                    for (int j = 0; j < tabControlCity.Controls[i].Controls.Count; j++)
                    {
                        if (tabControlCity.Controls[i].Controls[j] is ComboBox)
                        {
                            var dictionary = infoCountry.ToDictionary(x => x.CountryId, y => y.Name);
                            (tabControlCity.Controls[i].Controls[j] as ComboBox).DataSource = new BindingSource(dictionary, null);
                            (tabControlCity.Controls[i].Controls[j] as ComboBox).DisplayMember = "Value";
                            (tabControlCity.Controls[i].Controls[j] as ComboBox).ValueMember = "Key";
                        }
                    }
                }
            }
        }
        private void tabControlCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlCity.SelectedIndex == 0)
                ShowInfo();
        }
        private void ExecuteProcudure(int cityId, string name, int countryId)
        {
            try
            {
                using (var connecton = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnString"].ConnectionString))
                {
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@CityId", cityId);
                    parameters.Add("@Name", name);
                    parameters.Add("@CountryId", countryId);
                    parameters.Add("@LineAnswer", "", dbType: DbType.String, direction: ParameterDirection.Output);
                    connecton.Execute("up_CityAddEditDetele", parameters, commandType: CommandType.StoredProcedure);
                    if (parameters.Get<string>("@LineAnswer").Length > 0)
                    {
                        MessageBox.Show(parameters.Get<string>("@LineAnswer").ToString(), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    ShowInfo();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonInputCity_Click(object sender, EventArgs e)
        {
            ExecuteProcudure(0, textBoxCityNameAdd.Text, ((KeyValuePair<int, string>)comboBoxChooseCountry.SelectedItem).Key);
        }
        private void buttonEditCity_Click(object sender, EventArgs e)
        {
            ExecuteProcudure(CityId, textBoxCityNameEdit.Text, ((KeyValuePair<int, string>)comboBoxChooseEditCountry.SelectedItem).Key);
        }
        private void buttonDeleteCity_Click(object sender, EventArgs e)
        {
            ExecuteProcudure(-CityId, "", 0);
        }
        private void dataGridViewShowCity_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewShowCity.SelectedRows)
            {
                textBoxCityNameEdit.Text = row.Cells["City_Name"].Value.ToString();
                CityId = int.Parse(row.Cells["CityId"].Value.ToString());
                comboBoxChooseEditCountry.SelectedIndex = getSelectIndex(row.Cells["Country_Name"].Value.ToString());
            }
        }
        private int getSelectIndex(string country_Name)
        {
            for (int i = 0; i < comboBoxChooseEditCountry.Items.Count; i++)
            {
                if (((KeyValuePair<int, string>)comboBoxChooseEditCountry.Items[i]).Value == country_Name)
                    return i;
            }
            return -1;
        }
    }
}
