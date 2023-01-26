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
            int lineStockId;
            int productId;
            int stockId;
        }

        public FormStockProduct()
        {
            InitializeComponent();
            ShowInfo();
        }
        private void ShowInfo()
        {
            string sqlShowStockProduct = "SELECT ls.LineStockId, ls.StockId, ls.Price, p.ProductId, ls.ProductId, p.Name " +
                "FROM LineStock ls " +
                "INNER JOIN Product p ON ls.ProductId = p.ProductId " +
                "ORDER BY p.Name, ls.StockId";
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnString"].ConnectionString))
            {
                var infoStockProduct = connection.Query<LineStock, Product, LineStock>(sqlShowStockProduct, (linestock, product) =>
                 {
                     linestock.Product = product;
                     return linestock;
                 }, splitOn: "ProductId").Select(p => new
                 {
                     p.LineStockId,
                     Number_Stock = p.StockId,
                     Product_Name = p.Product.Name,
                     p.Price
                 }).ToList();
                dataGridViewShowStockProduct.DataSource = infoStockProduct;
                dataGridViewEditStockProduct.DataSource = infoStockProduct;
                dataGridViewDeleteStockProduct.DataSource = infoStockProduct;
            }
        }

        private void buttonInputStockProduct_Click(object sender, EventArgs e)
        {

        }
    }
}
