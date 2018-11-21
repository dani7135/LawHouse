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
    public partial class Overblik : Form
    {
        public Overblik()
        {
            InitializeComponent();
            objectListView1.SetObjects(Controller.HentAlleCases());

        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (objectListView1.SelectedObjects.Count == 1)
            {
                if (objectListView1.SelectedObject != null)
                {
                    Controller.Opdater(objectListView1.SelectedObject);
                        MessageBox.Show("Opdateret");
                }
            }
        }
    }
}
