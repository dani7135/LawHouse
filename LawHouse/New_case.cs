using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;

namespace GUI
{
    public partial class New_case : Form
    {

        public New_case()
        {
            InitializeComponent();
            StartDato.Text = DateTime.Today.ToString("dd-MM-yyyy", CultureInfo.InvariantCulture);       
            Slutdato.Format = DateTimePickerFormat.Custom;
            Slutdato.MinDate = DateTime.Today;

            txt_MedarbejderNr.DataSource = Controller.GetAllAdvokat();
            txt_MedarbejderNr.DisplayMember= "Navn";
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {            
            Controller.CreateCase(txt_titel.Text, StartDato.Text, Slutdato.Text, txt_kørsel.Text, txt_time.Text,  txt_SagsBeskrivelse.Text , txt_InterneNoter.Text, txt_KlientNr.Text, txt_MedarbejderNr.Text, txt_YdelseTypeNr.Text);
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Overblik overblik = new Overblik();
            overblik.Show();
        }

        private void btn_GoToFormCreateAdvokat_Click(object sender, EventArgs e)
        {
            CreateAdvokatTester advokatTester = new CreateAdvokatTester();
            advokatTester.Show();
        }
    }
}
