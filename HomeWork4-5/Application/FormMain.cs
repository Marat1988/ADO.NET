using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork4_5
{
    public partial class FormMain : Form
    {
        private int idProduct = 0;
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

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                textBoxNewColor.Text = row.Cells[3].Value.ToString();
                numericUpDownNewCaloric.Value = int.Parse(row.Cells[4].Value.ToString());
                idProduct = int.Parse(row.Cells[0].Value.ToString());
            }
        }

        private  async void buttonShowInfo_Click(object sender, EventArgs e)
        {
            labelSecond.Text = "0";
            try
            {
                timer1.Start();
                conn.ConnectionString = providerName;
                await conn.OpenAsync();
                DbCommand comm = conn.CreateCommand();
                comm.CommandText = "WAITFOR DELAY '00:00:05';";
                comm.CommandText += "SELECT * FROM vw_ShowInfoProduct";
                DataTable table = new DataTable();
                MessageBox.Show("Обновление информации", "INFO UPDATE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                using(DbDataReader reader = await comm.ExecuteReaderAsync())
                {
                    int line = 0;
                    do
                    {
                        while (await reader.ReadAsync())
                        {
                            if (line == 0)
                            {
                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    table.Columns.Add(reader.GetName(i));
                                }
                                line++;
                            }
                            DataRow row = table.NewRow();
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                row[i] = await reader.GetFieldValueAsync<Object>(i);
                            }
                            table.Rows.Add(row);
                        }
                    } while (reader.NextResult());
                }
                //выводим результаты запроса
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn?.Close();
                timer1.Stop();
            }
        }

        private async void buttonUpdateInfo_Click(object sender, EventArgs e)
        {
            labelSecond.Text = "0";
            try
            {
                conn.ConnectionString = providerName;
                await conn.OpenAsync();
                SqlCommand cmd = new SqlCommand($"UPDATE PRODUCT SET Color=@Color, Caloric=@Caloric WHERE Id={idProduct}", (SqlConnection)conn);
                cmd.Parameters.Add("@Color",SqlDbType.VarChar).Value = textBoxNewColor.Text;
                cmd.Parameters.Add("@Caloric", SqlDbType.Int).Value = int.Parse(numericUpDownNewCaloric.Value.ToString());
                await cmd.ExecuteNonQueryAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn?.Close();
            }
            buttonShowInfo_Click(sender, e);
        }

        private async void buttonDeleteInfo_Click(object sender, EventArgs e)
        {
            labelSecond.Text = "0";
            try
            {
                conn.ConnectionString = providerName;
                await conn.OpenAsync();
                SqlCommand cmd = new SqlCommand($"DELETE Product WHERE Id={idProduct}", (SqlConnection)conn);
                await cmd.ExecuteNonQueryAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn?.Close();
            }
            buttonShowInfo_Click(sender, e);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelSecond.Text = $"{int.Parse(labelSecond.Text) + 1}";
        }
    }
}
