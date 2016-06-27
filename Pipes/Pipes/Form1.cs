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
        Selection selector = Selection.Add;
        //Component selectedComponent = null;

        public Form1()
        {

            InitializeComponent();
            system.showsave += allowSave;
            system.saveload = new SaveLoad();
            system.grid = new Grid(GridPanel, system.CurrentXsize);
            system.drawTheComponent += drawComponent;

            

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
            system.AlterSinceSave = false;
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



        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            PointP position = new PointP();
            Point point = GridPanel.PointToClient(Cursor.Position);
            //mouse position is relative to panel 
            position = system.grid.returnMousePosition(point);
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

            int x = -1;
            foreach (Component c in system.Components)
            {
                x++;
                // checks if  a component with the current location exists
                if (c.location.X == p.X && c.location.Y == p.Y)
                {
                    system.index = x;
                    //system.selectedComponent = c;
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
                    else if (c is Pump)
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
                        RightClickOutputB.Enabled = true;
                        RightClickChange.Enabled = true;
                        RightClickDelete.Enabled = true;

                    }
                    else if (c is Sink)
                    {
                        //RightClickInputA.Visible = true;



                        //RightClickChange.Visible = true;
                        //RightClickDelete.Visible = true;
                        RightClickInputA.Enabled = true;
                        RightClickInputB.Enabled = false;
                        RightClickOutputA.Enabled = false;
                        RightClickOutputB.Enabled = false;
                        RightClickChange.Enabled = true;
                        RightClickDelete.Enabled = true;
                    }

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
        private void drawComponent(Component component)
        {
            using (Graphics g = GridPanel.CreateGraphics())
            {
                system.grid.drawComponent(component, g);
            }
        }

        private void GridPanel_Click(object sender, EventArgs e)
            /*
            This changes how the click even works according to the context menu selection. It looks correct,
            but for some reason takes in the wrong coordinates, and I can't figure out why.
            */
        {
            

            switch (selector)
            {
                case Selection.Add:
                    {
                        //When Clicked in the Panel selectedComponent will be selected based on grid space
                        PointP position = new PointP();
                        Point point = GridPanel.PointToClient(Cursor.Position);
                        //mouse position is relative to panel 
                        p = system.grid.returnMousePosition(point);
                        return;
                    }
                case Selection.InputA:
                    {
                        PointP position = new PointP();
                        Point point = GridPanel.PointToClient(Cursor.Position);
                        //mouse position is relative to panel 
                        p = system.grid.returnMousePosition(point);
                        foreach (Component c in system.Components)
                        {
                            // checks if  a component with the current location exists
                            if (c.location.X == position.X && c.location.Y == position.Y)
                            {
                                // parameter neeed to be assignet 
                                system.Components[system.index].attachInputA(c);
                                
                            }
                        }
                        selector = Selection.Add;
                            return;
                    }
                    
                case Selection.InputB:
                    {
                        //When Clicked in the Panel selectedComponent will be selected based on grid space
                        PointP position = new PointP();
                        Point point = GridPanel.PointToClient(Cursor.Position);
                        //mouse position is relative to panel 
                        p = system.grid.returnMousePosition(point);
                        foreach (Component c in system.Components)
                        {
                            // checks if  a component with the current location exists
                            if (c.location.X == position.X && c.location.Y == position.Y)
                            {
                                // parameter neeed to be assignet 
                                system.Components[system.index].attachInputB(c);

                            }
                        }
                        selector = Selection.Add;
                        return;
                    }
                case Selection.OutputA:
                    {
                        //When Clicked in the Panel selectedComponent will be selected based on grid space
                        PointP position = new PointP();
                        Point point = GridPanel.PointToClient(Cursor.Position);
                        //mouse position is relative to panel 
                        p = system.grid.returnMousePosition(point);
                        foreach (Component c in system.Components)
                        {
                            // checks if  a component with the current location exists
                            if (c.location.X == position.X && c.location.Y == position.Y)
                            {
                                // parameter neeed to be assignet 
                                system.Components[system.index].attachOutputA(c);

                            }
                        }
                        selector = Selection.Add;
                        return;
                    }
                case Selection.OutputB:
                    {
                        //When Clicked in the Panel selectedComponent will be selected based on grid space
                        PointP position = new PointP();
                        Point point = GridPanel.PointToClient(Cursor.Position);
                        //mouse position is relative to panel 
                        p = system.grid.returnMousePosition(point);
                        foreach (Component c in system.Components)
                        {
                            // checks if  a component with the current location exists
                            if (c.location.X == position.X && c.location.Y == position.Y)
                            {
                                // parameter neeed to be assignet 
                                system.Components[system.index].attachOutputB(c);

                            }
                        }
                        selector = Selection.Add;
                        return;
                    }
                default:
                    return;
            }


        }


        private void contextMenuStrip1_Opened(object sender, EventArgs e)
        {
        }

        private void contextMenuStrip1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int flow = Convert.ToInt32(textBox1.Text);
                PointP position = new PointP();
                Point point = GridPanel.PointToClient(Cursor.Position);
                //mouse position is relative to panel 
                position = system.grid.returnMousePosition(point);
                foreach (Component c in system.Components)
                {
                    // checks if  a component with the current location exists
                    if (c.location.X == p.X && c.location.Y == p.Y)
                    {

                        c.SetFlow(flow);

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PointP position = new PointP();
            Point point = GridPanel.PointToClient(Cursor.Position);
            //mouse position is relative to panel 
            position = system.grid.returnMousePosition(point);
            foreach (Component c in system.Components)
            {
                // checks if  a component with the current location exists
                if (c.location.X == p.X && c.location.Y==p.Y)
                {
                    label2.Text = c.Flow.ToString();
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        /*
        ------------------------------------------------------------------
            Right click context menu
        ------------------------------------------------------------------
        */



        private void RightClickOutputA_Click(object sender, EventArgs e)
        {
            PointP position = new PointP();
            Point point = GridPanel.PointToClient(Cursor.Position);
            //mouse position is relative to panel 
            position = system.grid.returnMousePosition(point);
            foreach (Component c in system.Components)
            {
                // checks if  a component with the current location exists
                if (c.location.X == position.X && c.location.Y == position.Y)
                {
                    // parameter neeed to be assignet 
                    //selectedComponent = c;
                    selector = Selection.OutputA;
                }
            }
        }

        private void RightClickOutputB_Click(object sender, EventArgs e)
        {
            PointP position = new PointP();
            Point point = GridPanel.PointToClient(Cursor.Position);
            //mouse position is relative to panel 
            position = system.grid.returnMousePosition(point);
            foreach (Component c in system.Components)
            {
                // checks if  a component with the current location exists
                if (c.location.X == position.X && c.location.Y == position.Y)
                {
                    // parameter neeed to be assignet 
                    selector = Selection.OutputB;
                }
            }
        }
        private void RightClickInputB_Click(object sender, EventArgs e)
        {
            PointP position = new PointP();
            Point point = GridPanel.PointToClient(Cursor.Position);
            //mouse position is relative to panel 
            position = system.grid.returnMousePosition(point);
            foreach (Component c in system.Components)
            {
                // checks if  a component with the current location exists
                if (c.location.X == position.X && c.location.Y == position.Y)
                {
                    // parameter neeed to be assignet 
                    selector = Selection.InputB;
                }
            }
        }

        private void RightClickInputA_Click(object sender, EventArgs e)
        {
            PointP position = new PointP();
            Point point = GridPanel.PointToClient(Cursor.Position);
            //mouse position is relative to panel 
            position = system.grid.returnMousePosition(point);
            foreach (Component c in system.Components)
            {
                // checks if  a component with the current location exists
                if (c.location.X == position.X && c.location.Y == position.Y)
                {
                    //Point b = new Point()
                    // parameter neeed to be assignet 
                    //c.attachInputA(c);
                    selector = Selection.InputA;
                }
            }
        }
        private void RightClickChange_Click(object sender, EventArgs e)
        {
            foreach (Component c in system.Components)
            {
                // checks if  a component with the current location exists
                if (c.location.X == MousePosition.X && c.location.Y == MousePosition.Y)
                {
                    // parameter neeed to be assignet 
                    system.MOdifyComponent(c);
                }
            }
        }
        private void RightClickDelete_Click(object sender, EventArgs e)
        {
            foreach (Component c in system.Components)
            {
                // checks if  a component with the current location exists
                if (c.location.X == p.Y && c.location.Y == p.Y)
                {
                    using (Graphics g = GridPanel.CreateGraphics())
                    {
                        if ((c is Pump)||(c is Sink)||(c is Merger)||(c is Splitter))
                        {
                            system.removeComponent(c, g);
                        }
                        else if (c is Pipe)
                        {
                            system.removePipes(c, g);
                        }
                    }
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            foreach (Component c in system.Components)
            {
                // checks if  a component with the current location exists
                 if (c.location.X == p.Y && c.location.Y == p.Y)
                {
                    if (c is Pipe)
                    {
                        c.SetSafetyLimit(Convert.ToInt32(textBox1.Text));
                    }
                }
            }
        }

        private void GridPanel_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
