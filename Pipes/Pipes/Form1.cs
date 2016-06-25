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
        PointP p;
        

        public Form1()
        {

            InitializeComponent();
            system.showsave += allowSave;
            system.saveload = new SaveLoad();
            system.grid = new Grid(GridPanel, system.CurrentXsize);

            p = new PointP();
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
            //RightClickInputA.Visible = false;
            //RightClickInputB.Visible = false;
            //RightClickOutputA.Visible = false;
            //RightClickOutputB.Visible = false;
            //RightClickChange.Visible = false;
            //RightClickDelete.Visible = false;
            RightClickInputA.Enabled = false;
            RightClickInputB.Enabled = false;
            RightClickOutputA.Enabled = false;
            RightClickOutputB.Enabled = false;
            RightClickDelete.Enabled = false;
            RightClickChange.Enabled = false;


            foreach (Component c in system.Components)
            {
                // checks if  a component with the current location exists
                if (c.location.X==MousePosition.X & c.location.Y==MousePosition.Y)
                {


                    //  toolStripMenuItem1.HideDropDown();
                    if (c is Pipe)
                    {
                        // when you right click only Pipe properties are shown 

                        //RightClickInputA.Visible = true;
                        //RightClickOutputA.Visible = true;
                        //RightClickChange.Visible = true;
                        //RightClickDelete.Visible = true;
                        RightClickInputA.Enabled = true;
                        RightClickInputB.Enabled = false;
                        RightClickOutputA.Enabled = true;
                        RightClickOutputB.Enabled = false;
                        RightClickChange.Enabled = true;
                        RightClickDelete.Enabled = true;

                    }
                   else if(c is Pump)
                    {


                        //RightClickOutputA.Visible = true;
                        //RightClickChange.Visible = true;
                        //RightClickDelete.Visible = true;
                        RightClickInputA.Enabled = false;
                        RightClickInputB.Enabled = false;
                        RightClickOutputA.Enabled = true;
                        RightClickOutputB.Enabled = false;
                        RightClickChange.Enabled = true;
                        RightClickDelete.Enabled = true;

                    }
                    else if (c is Merger)
                    {

                        //RightClickInputA.Visible = true;
                        //RightClickOutputA.Visible = true;
                        //RightClickOutputB.Visible = true;
                        //RightClickChange.Visible = true;
                        //RightClickDelete.Visible = true;
                        RightClickInputA.Enabled = true;
                        RightClickInputB.Enabled = true;
                        RightClickOutputA.Enabled = true;
                        RightClickOutputB.Enabled = false;
                        RightClickChange.Enabled = true;
                        RightClickDelete.Enabled = true;

                    }
                    else if (c is Splitter)
                    {
                        //RightClickInputA.Visible = true;
                        //RightClickInputB.Visible = true;
                        //RightClickOutputA.Visible = true;

                        //RightClickChange.Visible = true;
                        //RightClickDelete.Visible = true;
                        RightClickInputA.Enabled = true;
                        RightClickInputB.Enabled = false;
                        RightClickOutputA.Enabled = true;
                        RightClickOutputB.Enabled =true;
                        RightClickChange.Enabled = true;
                        RightClickDelete.Enabled = true;

                    }
                    else if ( c is Sink)
                    {
                        //RightClickInputA.Visible = true;



                        //RightClickChange.Visible = true;
                        //RightClickDelete.Visible = true;
                        RightClickInputA.Enabled = true;
                        RightClickInputB.Enabled = false;
                        RightClickOutputA.Enabled =false;
                        RightClickOutputB.Enabled = false;
                        RightClickChange.Enabled = true;
                        RightClickDelete.Enabled = true;
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
            
            system.addComponent(new Pipe(p));
        }

        private void BtnSplitter_Click(object sender, EventArgs e)
        {
           
            system.addComponent(new Splitter(p));
        }

        private void BtnMerger_Click(object sender, EventArgs e)
        {
            
            system.addComponent(new Merger(p));
        }

        private void BtnPump_Click(object sender, EventArgs e)
        {
           
            system.addComponent(new Pump(p));
        }

        private void BtnSink_Click(object sender, EventArgs e)
        {
           
            system.addComponent(new Sink(p));
        }

        private void GridPanel_Paint(object sender, PaintEventArgs e)
        {
//<<<<<<< HEAD
            base.OnPaint(e);
            using (Graphics g = e.Graphics)
            {
                system.grid.drawGrid(g, system.CurrentXsize);
            }
           
            


        }

        private void GridPanel_Click(object sender, EventArgs e)
        {
            //When Clicked in the Panel selectedComponent will be selected based on grid space
            PointP position = new PointP();
            Point point = GridPanel.PointToClient(Cursor.Position);
            //mouse position is relative to panel 
            position = system.grid.returnMousePosition(point);
            foreach(var y in system.Components)
            {
                if(y.location == position)
                {
                    system.selectedComponent = y;
                    return;
                }
            }
            

        }

        private void contextMenuStrip1_Opened(object sender, EventArgs e)
        {
        }

        private void contextMenuStrip1_Click(object sender, EventArgs e)
        {

        }
    }
}
