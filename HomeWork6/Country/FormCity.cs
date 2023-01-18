using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Country
{
    public partial class FormCity : Form
    {
        private DataClasses1DataContext db = new DataClasses1DataContext();
        private int idCity;
        public FormCity()
        {
            InitializeComponent();
            ShowInfoCountry();
        }

        private void tabControlCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlCity.SelectedIndex == 0)
            {
                ShowInfoCountry();
            }
        }

        private void ShowInfoCountry()
        {
            var queryResult = from c1 in db.Country
                              join c2 in db.City on c1.CountryId equals c2.CountryId
                              select new
                              {
                                  Id = c2.CityId,
                                  Name = c2.Name,
                                  Count_people = c2.CountPeople,
                                  Name_Country = c1.Name
                              };
            dataGridViewShowCity.DataSource = queryResult;
            dataGridViewEditCity.DataSource = queryResult;
            dataGridViewDeleteCity.DataSource = queryResult;
        }




        private void buttonDeleteCountry_Click(object sender, EventArgs e)
        {

        }

        private void buttonInputCountry_Click(object sender, EventArgs e)
        {

        }


    }
}
