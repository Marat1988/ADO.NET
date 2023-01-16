using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork4_5
{
    public partial class FormMain : Form
    {
        DbConnection conn = null;
        DbProviderFactory fact = null;
        string providerName = "";
        public FormMain()
        {
            InitializeComponent();
            DataTable t = DbProviderFactories.GetFactoryClasses();
            foreach (DataRow dr in t.Rows)
            {
                comboBoxChooseProvider.Items.Add(dr["InvariantName"]);
            }
            comboBoxChooseProvider.SelectedIndex = 0;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxChooseProvider_SelectedIndexChanged(object sender, EventArgs e)
        {
            fact = DbProviderFactories.GetFactory(comboBoxChooseProvider.SelectedItem.ToString());
            conn = fact.CreateConnection();
            providerName = GetConnectionStringByProvider(comboBoxChooseProvider.SelectedItem.ToString());
        }

        private string GetConnectionStringByProvider(string providerName)
        {
            string returnValue = null;

            //Читаем все строки подключения из App.config
            ConnectionStringSettingsCollection settings = ConfigurationManager.ConnectionStrings;

            //Ищем и возвращаем строку подключения для providerName
            if (settings != null)
            {
                foreach (ConnectionStringSettings cs in settings)
                {
                    if (cs.ProviderName == providerName)
                    {
                        returnValue = cs.ConnectionString;
                        break;
                    }
                }
            }
            return returnValue;
        }

        private void buttonShowInfo_Click(object sender, EventArgs e)
        {
            try
            {
                conn.ConnectionString = providerName;
                //Создаем адаптер из фабрики
                DbDataAdapter adapter = fact.CreateDataAdapter();
                adapter.SelectCommand = conn.CreateCommand();
                adapter.SelectCommand.CommandText = "WAITFOR DELAY '00:00:10'; SELECT * FROM Product";
                //Выполняем запрос select из адаптера
                DataTable table = new DataTable();
                adapter.Fill(table);
                //Выводим результаты запроса
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                string value1 = row.Cells[0].Value.ToString();
                string value2 = row.Cells[1].Value.ToString();
                //...
            }
        }
    }
}
