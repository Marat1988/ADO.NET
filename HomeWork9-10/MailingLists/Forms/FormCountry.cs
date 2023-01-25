using Dapper;
using MailingLists.Class;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace MailingLists.Forms
{
    public partial class FormCountry : Form
    {
        private int CountryId;
        public FormCountry()
        {
            InitializeComponent();
            ShowInfo();
        }
        private void ShowInfo()
        {
            string sqlShowCountry = "SELECT * FROM Country";
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnString"].ConnectionString))
            {
                var infoCountry = connection.Query<Country>(sqlShowCountry).Select(p => new
                {
                    p.CountryId,
                    p.Name,
                    p.OKSM
                }).ToList();
                dataGridViewShowCountry.DataSource = infoCountry;
                dataGridViewEditCountry.DataSource = infoCountry;
                dataGridViewDeleteCountry.DataSource = infoCountry;
            }
        }
        private void tabControlCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlCountry.SelectedIndex == 0)
                ShowInfo();
        }
        private void ExecuteProcedure(int countryId, string name, string oksm)
        {
            try
            {
                using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnString"].ConnectionString))
                {
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@CountryId", countryId);
                    parameters.Add("@Name", name);
                    parameters.Add("@OKSM", oksm);
                    parameters.Add("@LineAnswer", "", dbType: DbType.String, direction: ParameterDirection.Output);
                    connection.Execute("up_CountryAddEditDetele", parameters, commandType: CommandType.StoredProcedure);
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
        private void buttonInputCountry_Click(object sender, EventArgs e)
        {
            ExecuteProcedure(0, textBoxCountryNameAdd.Text, textBoxCountryOKSMAdd.Text);
        }
        private void buttonEditCountry_Click(object sender, EventArgs e)
        {
            ExecuteProcedure(CountryId, textBoxCountryNameEdit.Text, textBoxCountryOKSMEdit.Text);
        }
        private void buttonDeleteCountry_Click(object sender, EventArgs e)
        {
            ExecuteProcedure(-CountryId, "", "");
        }
        private void dataGridViewShowCountry_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewShowCountry.SelectedRows)
            {
                textBoxCountryNameEdit.Text = row.Cells["Name"].Value.ToString();
                textBoxCountryOKSMEdit.Text = row.Cells["OKSM"].Value.ToString();
                CountryId = int.Parse(row.Cells["CountryId"].Value.ToString());
            }
        }
    }
}
