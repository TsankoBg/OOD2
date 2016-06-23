﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pipes
{
    public partial class Form1 : Form
    {
        PipeSystem system = new PipeSystem();
       

        public Form1()
        {
            InitializeComponent();
            system.grid = new Grid(this.GridPanel, system.CurrentXsize);
            system.showsave += allowSave;
            //When the SaveSinceLast is at anypoint turned to false,
            //an event will rise not allowing the Save Button to be clicked

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            
            if (system.saveload == null)
            {
                system.saveload = new SaveLoad();
            }
            else
            {
                system.saveload.updateFileName();
            }
        }
        void allowSave(bool showSave)
        {
            if(showSave == false)
            {
                SaveButton.Enabled = false;
            }
            else
            {
                SaveButton.Enabled = true;
            }
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            if(system.AlterSinceSave == false)
            {
                DialogResult result = new DialogResult;
                result = MessageBox.Show("Warning, If")
                    if)result == DialogResult.OK){

                }
             

                }
            else
            {
                system.saveload.load();
            }
            
        }
    }
}
