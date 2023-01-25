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
    public partial class FormCountry : Form
    {
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
                dataGridViewShowCountry.DataSource = infoCountry;
            }
        }

        private void buttonEditCountry_Click(object sender, EventArgs e)
        {

        }

        private void buttonInputCountry_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewShowCountry_SelectionChanged(object sender, EventArgs e)
        {
            //
        }
    }
}
