using Dapper;
using MailingLists.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MailingLists.Forms
{
    public partial class FormBuyers : Form
    {
        private int BuyerId;
        public FormBuyers()
        {
            InitializeComponent();
            ShowInfo();
        }
        private void ShowInfo()
        {
            string sqlShowBuyers = "SELECT b.BuyersId, b.[Name], b.DateBirthday, b.CityId, c.CityId, c.Name FROM Buyers b INNER JOIN City c ON b.CityId = c.CityId";
            using(var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnString"].ConnectionString))
            {
                var infoBuyers = connection.Query<Buyers, City, Buyers>(sqlShowBuyers, (buyers, city) =>
                {
                    buyers.City = city;
                    return buyers;
                }, splitOn: "CityId").Select(p => new
                {
                    BuyerId = p.BuyersId,
                    Buyers_Name = p.Name,
                    DateBirthday = p.DateBirthday,
                    City_name = p.City.Name
                }).ToList();
                dataGridViewShowBuyers.DataSource = infoBuyers;
                dataGridViewEditBuyers.DataSource = infoBuyers;
                dataGridViewDeleteBuyers.DataSource = infoBuyers;
            }
            string sqlShowCity = "SELECT * FROM City";
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnString"].ConnectionString))
            {
                var infoCity = connection.Query<City>(sqlShowCity).Select(p => new
                {
                    p.CityId,
                    p.Name
                }).ToList();
                for (int i = 0; i < tabControlBuyers.Controls.Count; i++)
                {
                    for (int j = 0; j < tabControlBuyers.Controls[i].Controls.Count; j++)
                    {
                        if (tabControlBuyers.Controls[i].Controls[j] is ComboBox)
                        {
                            var dictionary = infoCity.ToDictionary(x => x.CityId, y => y.Name);
                            (tabControlBuyers.Controls[i].Controls[j] as ComboBox).DataSource = new BindingSource(dictionary, null);
                            (tabControlBuyers.Controls[i].Controls[j] as ComboBox).DisplayMember = "Value";
                            (tabControlBuyers.Controls[i].Controls[j] as ComboBox).ValueMember = "Key";
                        }
                    }
                }
            }
        }
        private void tabControlBuyers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlBuyers.SelectedIndex == 0)
                ShowInfo();
        }
        private void ExecuteProcedure(int buyerId, string name, DateTime dateBirthDay, int cityId)
        {
            try
            {
                using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnString"].ConnectionString))
                {
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@BuyersId", buyerId);
                    parameters.Add("@Name", name);
                    parameters.Add("@DateBirthday", dateBirthDay);
                    parameters.Add("@CityId", cityId);
                    parameters.Add("@LineAnswer", "", dbType: DbType.String, direction: ParameterDirection.Output);
                    connection.Execute("up_BuyersAddEditDetele", parameters, commandType: CommandType.StoredProcedure);
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

        private void buttonInputBuyers_Click(object sender, EventArgs e)
        {
            ExecuteProcedure(0, textBoxBuyersNameAdd.Text, dateTimePickerBuyersDateBirthDayAdd.Value, ((KeyValuePair<int, string>)comboBoxChooseCityAdd.SelectedItem).Key);
        }

        private void buttonEditBuyers_Click(object sender, EventArgs e)
        {
            ExecuteProcedure(BuyerId, textBoxBuyersNameEdit.Text, dateTimePickerBuyersDateBirthDayEdit.Value, ((KeyValuePair<int, string>)comboBoxChooseCityEdit.SelectedItem).Key);
        }

        private void buttonDeleteBuyers_Click(object sender, EventArgs e)
        {
            ExecuteProcedure(-BuyerId, "", DateTime.Now, 0);
        }

        private void dataGridViewShowBuyers_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewShowBuyers.SelectedRows)
            {
                textBoxBuyersNameEdit.Text = row.Cells["Buyers_Name"].Value.ToString();
                BuyerId = int.Parse(row.Cells["BuyerId"].Value.ToString());
                comboBoxChooseCityEdit.SelectedIndex = getSelectIndex(row.Cells["City_name"].Value.ToString());
                dateTimePickerBuyersDateBirthDayEdit.Value = Convert.ToDateTime(row.Cells["DateBirthday"].Value.ToString());
            }
        }

        private int getSelectIndex(string city_Name)
        {
            for (int i = 0; i < comboBoxChooseCityEdit.Items.Count; i++)
            {
                if (((KeyValuePair<int, string>)comboBoxChooseCityEdit.Items[i]).Value == city_Name)
                    return i;
            }
            return -1;
        }
    }
}
