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
            ((Control)pictureBox1).AllowDrop = true;
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

        private void pictureBox1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void pictureBox1_DragDrop(object sender, DragEventArgs e)
        {
            int x = this.PointToClient(new Point(e.X, e.Y)).X;

            int y = this.PointToClient(new Point(e.X, e.Y)).Y;

            if (x >= pictureBox1.Location.X && x <= pictureBox1.Location.X + pictureBox1.Width && y >= pictureBox1.Location.Y && y <= pictureBox1.Location.Y + pictureBox1.Height)

            {

                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

                pictureBox1.Image = Image.FromFile(files[0]);

            }
            
        }
        
      
    }
}
