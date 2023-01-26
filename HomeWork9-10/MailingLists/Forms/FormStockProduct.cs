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
    public partial class FormStockProduct : Form
    {
        private struct InfoStockProduct
        {
            public int lineStockId;
            public int productId;
            public int stockId;
        };

        private InfoStockProduct infoStockProduct;

        public FormStockProduct()
        {
            InitializeComponent();
            ShowInfo();
        }
        private void ShowInfo()
        {
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnString"].ConnectionString))
            {
                var infoStockProduct = connection.Query("up_sel_ShowInfoStockProduct", commandType: CommandType.StoredProcedure);
                var result = infoStockProduct.Select(p => new
                {
                    p.LineStockId,
                    Product_Name = p.Name,
                    p.ProductId,
                    Number_Stock = p.StockId,
                    p.Stock_Name,
                    p.Price,
                }).ToList();
                dataGridViewShowStockProduct.DataSource = result;
                dataGridViewEditStockProduct.DataSource = result;
                dataGridViewDeleteStockProduct.DataSource = result;
            }
            LoadInfoToComboBox(comboBoxChooseStockNumberAdd, "SELECT StockId AS Id, CONCAT([Name],'. Номер акции: ',StockId) AS Name FROM Stock");
            LoadInfoToComboBox(comboBoxChooseProductAdd, "SELECT ProductId AS Id, Name FROM Product");
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
        private void tabControlStockProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlStockProduct.SelectedIndex == 0)
                ShowInfo();
        }
        private void ExecureProcedure(int lineStockId, int productId, int stockId, decimal price)
        {
            try
            {
                using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnString"].ConnectionString))
                {
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@LineStockId", lineStockId);
                    parameters.Add("@ProductId", productId);
                    parameters.Add("@StockId", stockId);
                    parameters.Add("@Price", price);
                    parameters.Add("@LineAnswer", "", dbType: DbType.String, direction: ParameterDirection.Output);
                    connection.Execute("up_StockProductAddEditDelete", parameters, commandType: CommandType.StoredProcedure);
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
        private void buttonInputStockProduct_Click(object sender, EventArgs e)
        {
            ExecureProcedure(0, ((KeyValuePair<int, string>)comboBoxChooseProductAdd.SelectedItem).Key, ((KeyValuePair<int, string>)comboBoxChooseStockNumberAdd.SelectedItem).Key, numericUpDownPriceAdd.Value);
        }

        private void buttonEditStockProduct_Click(object sender, EventArgs e)
        {
            ExecureProcedure(infoStockProduct.lineStockId, infoStockProduct.productId, infoStockProduct.stockId, numericUpDownPriceEdit.Value);
        }

        private void buttonDeleteStockProduct_Click(object sender, EventArgs e)
        {
            ExecureProcedure(-infoStockProduct.lineStockId, 0, 0, 0);
        }

        private void dataGridViewShowStockProduct_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewShowStockProduct.SelectedRows)
            {
                infoStockProduct.lineStockId = int.Parse(row.Cells["LineStockId"].Value.ToString());
                infoStockProduct.productId = int.Parse(row.Cells["ProductId"].Value.ToString());
                infoStockProduct.stockId = int.Parse(row.Cells["Number_Stock"].Value.ToString());
                numericUpDownPriceEdit.Value = Convert.ToDecimal(row.Cells["Price"].Value.ToString());
            }
        }
    }
}
