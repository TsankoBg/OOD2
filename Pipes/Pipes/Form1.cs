using System;
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
            system.saveload = new SaveLoad();
            //When the SaveSinceLast is at anypoint turned to false,
            //an event will rise not allowing the Save Button to be clicked
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

            system.saveload.save(system.Components);
        }
        void allowSave(bool showSave)
        {
            if (showSave == false)
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
            if (system.AlterSinceSave == false)
            { 
                DialogResult result = new DialogResult();
                result = MessageBox.Show(this, "Warning, If you load current data will be overwritten", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    
                        system.saveload.load();
                }
            }
            else
            {
                
                system.saveload.load();
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach (Component c in system.Components)
            {
                // checks if  a component with the current location exists
                if (c.location.X == MousePosition.X & c.location.Y == MousePosition.Y)
                {
                    // parameter neeed to be assignet 
                    c.AttachComponent(system.selectedComponent);
                }
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
          
            foreach (Component c in system.Components)
            {
                // checks if  a component with the current location exists
                if (c.location.X==MousePosition.X & c.location.Y==MousePosition.Y)
                {


                    //  toolStripMenuItem1.HideDropDown();
                    if (c is Pipe)
                    {
                        // when you right click only Pipe properties are shown 
                        RightClickInputB.Visible = false;
                        RightClickOutputB.Visible = false;

                    }
                   else if(c is Pump)
                    {
                        RightClickInputA.Visible = false;
                        RightClickInputB.Visible = false;
                        RightClickOutputB.Visible = false;

                    }
                    else if (c is Merger)
                    {
                        RightClickOutputB.Visible = false;

                    }
                    else if (c is Splitter)
                    {
                        RightClickInputB.Visible = false;

                    }
                    else if ( c is Sink)
                    {
                        RightClickInputB.Visible = false;
                        RightClickOutputA.Visible = false;
                        RightClickOutputB.Visible = false;
                    }
                }

            }
        }

        private void addOutputAToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void RightClickDelete_Click(object sender, EventArgs e)
        {
            foreach (Component c in system.Components)
            {
                // checks if  a component with the current location exists
                if (c.location.X == MousePosition.X & c.location.Y == MousePosition.Y)
                {
                    system.removePipes();
                }
            }
        }

        private void RightClickChange_Click(object sender, EventArgs e)
        {
            foreach (Component c in system.Components)
            {
                // checks if  a component with the current location exists
                if (c.location.X == MousePosition.X & c.location.Y == MousePosition.Y)
                {
                    // parameter neeed to be assignet 
                    system.MOdifyComponent(23);
                }
            }
        }

        private void BtnAddpipe_Click(object sender, EventArgs e)
        {
            PointP p = new PointP(MousePosition.X, MousePosition.Y);
            system.addComponent(new Pipe(p));
        }

        private void BtnSplitter_Click(object sender, EventArgs e)
        {
            PointP p = new PointP(MousePosition.X, MousePosition.Y);
            system.addComponent(new Splitter(p));
        }

        private void BtnMerger_Click(object sender, EventArgs e)
        {
            PointP p = new PointP(MousePosition.X, MousePosition.Y);
            system.addComponent(new Merger(p));
        }

        private void BtnPump_Click(object sender, EventArgs e)
        {
            PointP p = new PointP(MousePosition.X, MousePosition.Y);
            system.addComponent(new Pump(p));
        }

        private void BtnSink_Click(object sender, EventArgs e)
        {
            PointP p = new PointP(MousePosition.X, MousePosition.Y);
            system.addComponent(new Sink(p));
        }
    }
}
