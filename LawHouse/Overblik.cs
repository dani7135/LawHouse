﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;
using DataAccess;

namespace GUI
{
    public partial class Overblik : Form
    {
     

        public Overblik()
        {
            InitializeComponent();
            objectListView1.SetObjects(Controller.GetAllClient());
     

            comboBox1.DataSource = Controller.GetAllItems();
            comboBox1.DisplayMember = "What_type";
            comboBox1.DataSource = Controller.
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (objectListView1.SelectedObjects.Count == 1)
            {
                if (objectListView1.SelectedObject != null)
                {
                    Controller.Update(objectListView1.SelectedObject);
                    MessageBox.Show("Opdateret");
                }
            }
        }

        //Koden under er ikke noget der har med nogle funktionelle krav at gøre, 
        //det er lavt så man kan skifte visningen af kolonner, alt efter om det er sag, klient osv.
        //Der er tilføjet en ekstra kolonne, fordi man ikke kan skjule den primære kolonnen
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListItems listItem = (ListItems)comboBox1.SelectedItem;
            switch (listItem.What_type)
            {
                
                case "Klient":
                    objectListView1.SetObjects(Controller.GetAllClient());
                    foreach (var item in objectListView1.AllColumns)
                    {
                        item.IsVisible = false;
                    }
                    KlientNr.IsVisible = true;
                    Navn.IsVisible = true;
                    Adresse.IsVisible = true;
                    TelefonNr.IsVisible = true;
                    break;

                case "Sag":
                    objectListView1.SetObjects(Controller.GetAllCases());
                    foreach (var item in objectListView1.AllColumns)
                    {
                        item.IsVisible = false;
                    }
                    SagsNr.IsVisible = true;
                    Arbejdstitel.IsVisible = true;
                    StartDato.IsVisible = true;
                    SlutDato.IsVisible = true;
                    TimeEstimat.IsVisible = true;
                    SagsBeskrivelse.IsVisible = true;
                    InterneNoter.IsVisible = true;
                    KlientNr.IsVisible = true;
                    MedarbejderNr.IsVisible = true;
                    YdelsesTypeNr.IsVisible = true;
                    break;
            }
                objectListView1.RebuildColumns();
        }
    }
}

