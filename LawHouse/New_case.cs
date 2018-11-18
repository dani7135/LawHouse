using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {            
            Controller.CreateCase(txt_titel.Text, null, null, txt_time.Text, txt_time.Text, txt_Klientnr.Text, txt_MedarbejderNr.Text);
            this.Close();
        }
    }
}
