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
    public partial class FormGroupProduct : Form
    {
        private int groupProductId;
        public FormGroupProduct()
        {
            InitializeComponent();
            ShowInfo();
        }
        private void ShowInfo()
        {
            string sqlGroup = "SELECT * FROM GroupProduct";
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnString"].ConnectionString))
            {
                var infoGroup = connection.Query<GroupProduct>(sqlGroup).Select(p => new
                {
                    p.GroupProductId,
                    p.Name
                }).ToList();
                dataGridViewShowGroupProduct.DataSource = infoGroup;
                dataGridViewEditGroupProduct.DataSource = infoGroup;
                dataGridViewDeleteGroupProduct.DataSource = infoGroup;
            }
        }
        private void tabControlGroupProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlGroupProduct.SelectedIndex == 0)
                ShowInfo();
        }
        private void ExecuteProcedure(int groupProductId, string name)
        {
            try
            {
                using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnString"].ConnectionString))
                {
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@GroupProductId", groupProductId);
                    parameters.Add("@Name", name);
                    parameters.Add("@LineAnswer", "", dbType: DbType.String, direction: ParameterDirection.Output);
                    connection.Execute("up_GroupProductAddEditDelete", parameters, commandType: CommandType.StoredProcedure);
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
        private void buttonInputGroupProduct_Click(object sender, EventArgs e)
        {
            ExecuteProcedure(0, textBoxGroupProductNameAdd.Text);
        }
        private void buttonEditGroupProduct_Click(object sender, EventArgs e)
        {
            ExecuteProcedure(groupProductId, textBoxGroupProductNameEdit.Text);
        }
        private void buttonDeleteGroupProduct_Click(object sender, EventArgs e)
        {
            ExecuteProcedure(-groupProductId, "");
        }
        private void dataGridViewShowGroupProduct_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewShowGroupProduct.SelectedRows)
            {
                textBoxGroupProductNameEdit.Text = row.Cells["Name"].Value.ToString();
                groupProductId = int.Parse(row.Cells["GroupProductId"].Value.ToString());
            }
        }
    }
}
