using BECodeFirst;
using GameEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestCodeFirst
{
    public partial class FormTestCodeFirst : Form
    {
        private string conn = "";
        public FormTestCodeFirst()
        {
            InitializeComponent();
            comboBoxChooseTypeConnection.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn = $@"Data Source={textBoxNameSQLServer.Text}; Initial Catalog={textBoxNameDB.Text}; Integrated Security=True";
            using (GameContext context = new GameContext(conn))
            {
                List<Company> companies = new List<Company>()
                {
                    new Company{ Name = "Lesta Games" },
                    new Company{ Name = "Rockstar Gamess" },
                    new Company{ Name = "1C"}
                };
                context.Company.AddRange(companies);
                context.SaveChanges();
            }
            MessageBox.Show("The database has been created!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void comboBoxChooseTypeConnection_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxLogin.Enabled = comboBoxChooseTypeConnection.SelectedIndex == 1;
            textBoxPassword.Enabled = comboBoxChooseTypeConnection.SelectedIndex == 1;
        }
    }
}
