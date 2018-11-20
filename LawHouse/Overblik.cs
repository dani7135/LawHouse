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
    }
}
