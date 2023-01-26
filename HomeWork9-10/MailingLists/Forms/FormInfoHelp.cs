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
    public partial class FormInfoHelp : Form
    {
        public FormInfoHelp()
        {
            InitializeComponent();
            LoadInfo();
        }
        private void LoadInfo()
        {
            LoadInfoToComboBox(comboBoxChooseCountry, "SELECT CountryId AS Id, Name FROM Country");
            LoadInfoToComboBox(comboBoxChooseBuyers, "SELECT BuyersId AS Id, Name FROM Buyers");
            LoadInfoToComboBox(comboBoxChooseGroupProduct, "SELECT GroupProductId AS Id, Name FROM GroupProduct");

        }
        private void LoadInfoToComboBox(ComboBox comboBox, string sql)
        {
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnString"].ConnectionString))
            {
                var info = connection.Query<TempClass>(sql).Select(p => new
                {
                    p.Id,
                    p.Name
                }).ToList();
                var dictionary = info.ToDictionary(x => x.Id, y => y.Name);
                comboBox.DataSource = new BindingSource(dictionary, null);
                comboBox.DisplayMember = "Value";
                comboBox.ValueMember = "Key";
            }
        }
        private void buttonInfoShowCity_Click(object sender, EventArgs e)
        {
            string sql = @"SELECT Name FROM City WHERE CountryId = @Id";
            RunSql(sql, comboBoxChooseCountry);
        }
        private void buttonInfoShowGroup_Click(object sender, EventArgs e)
        {
            string sql = "SELECT DISTINCT gp.Name " +
                "FROM Buyers b " +
                "INNER JOIN Mailing m ON b.BuyersId = m.BuyersId " +
                "INNER JOIN Stock s ON m.StockId = s.StockId " +
                "INNER JOIN GroupProduct gp ON s.GroupProductId = gp.GroupProductId " +
                "WHERE b.BuyersId = @Id";
            RunSql(sql, comboBoxChooseBuyers);
        }
        private void buttonInfoStockProduct_Click(object sender, EventArgs e)
        {
            string sql = "SELECT DISTINCT p.Name " +
                "FROM LineStock ls " +
                "INNER JOIN Stock s ON ls.StockId = s.StockId " +
                "INNER JOIN Product p ON ls.ProductId = p.ProductId " +
                "INNER JOIN GroupProduct gp ON p.GroupProductId = gp.GroupProductId " +
                "WHERE gp.GroupProductId = @Id AND s.DateEnd > CAST(GETDATE() AS DATE)";
            RunSql(sql, comboBoxChooseGroupProduct);
        }
        private void RunSql(string sql, ComboBox comboBox)
        {
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnString"].ConnectionString))
            {
                var info = connection.Query<TempClass>(sql, new
                {
                    Id = ((KeyValuePair<int, string>)comboBox.SelectedItem).Key
                }).Select(p => new
                {
                    p.Name
                }).ToList();
                dataGridViewShowInfo.DataSource = null;
                dataGridViewShowInfo.DataSource = info;
            }
        }
    }
}
