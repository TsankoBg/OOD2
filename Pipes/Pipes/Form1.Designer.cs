namespace Pipes
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ToolPanel = new System.Windows.Forms.Panel();
            this.BtnSink = new System.Windows.Forms.Button();
            this.BtnPump = new System.Windows.Forms.Button();
            this.BtnMerger = new System.Windows.Forms.Button();
            this.BtnSplitter = new System.Windows.Forms.Button();
            this.BtnAddpipe = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.LoadButton = new System.Windows.Forms.Button();
            this.GridPanel = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.RightClickInputA = new System.Windows.Forms.ToolStripMenuItem();
            this.RightClickInputB = new System.Windows.Forms.ToolStripMenuItem();
            this.RightClickOutputA = new System.Windows.Forms.ToolStripMenuItem();
            this.RightClickOutputB = new System.Windows.Forms.ToolStripMenuItem();
            this.RightClickChange = new System.Windows.Forms.ToolStripMenuItem();
            this.RightClickDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolPanel.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToolPanel
            // 
            this.ToolPanel.BackColor = System.Drawing.Color.MintCream;
            this.ToolPanel.Controls.Add(this.BtnSink);
            this.ToolPanel.Controls.Add(this.BtnPump);
            this.ToolPanel.Controls.Add(this.BtnMerger);
            this.ToolPanel.Controls.Add(this.BtnSplitter);
            this.ToolPanel.Controls.Add(this.BtnAddpipe);
            this.ToolPanel.Controls.Add(this.SaveButton);
            this.ToolPanel.Controls.Add(this.LoadButton);
<<<<<<< HEAD
            this.ToolPanel.Location = new System.Drawing.Point(14, 31);
            this.ToolPanel.MaximumSize = new System.Drawing.Size(180, 600);
            this.ToolPanel.MinimumSize = new System.Drawing.Size(180, 600);
=======
            this.ToolPanel.Location = new System.Drawing.Point(9, 20);
            this.ToolPanel.Margin = new System.Windows.Forms.Padding(2);
            this.ToolPanel.MaximumSize = new System.Drawing.Size(120, 390);
            this.ToolPanel.MinimumSize = new System.Drawing.Size(120, 390);
>>>>>>> origin/master
            this.ToolPanel.Name = "ToolPanel";
            this.ToolPanel.Size = new System.Drawing.Size(180, 600);
            this.ToolPanel.TabIndex = 0;
            // 
            // BtnSink
            // 
            this.BtnSink.BackColor = System.Drawing.Color.LightSlateGray;
            this.BtnSink.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnSink.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
<<<<<<< HEAD
            this.BtnSink.Location = new System.Drawing.Point(4, 275);
            this.BtnSink.Name = "BtnSink";
            this.BtnSink.Size = new System.Drawing.Size(172, 49);
=======
            this.BtnSink.Location = new System.Drawing.Point(3, 179);
            this.BtnSink.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSink.Name = "BtnSink";
            this.BtnSink.Size = new System.Drawing.Size(115, 32);
>>>>>>> origin/master
            this.BtnSink.TabIndex = 6;
            this.BtnSink.Text = "Sink";
            this.BtnSink.UseVisualStyleBackColor = false;
            this.BtnSink.Click += new System.EventHandler(this.BtnSink_Click);
            // 
            // BtnPump
            // 
            this.BtnPump.BackColor = System.Drawing.Color.LightSlateGray;
            this.BtnPump.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnPump.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
<<<<<<< HEAD
            this.BtnPump.Location = new System.Drawing.Point(4, 222);
            this.BtnPump.Name = "BtnPump";
            this.BtnPump.Size = new System.Drawing.Size(172, 49);
=======
            this.BtnPump.Location = new System.Drawing.Point(3, 144);
            this.BtnPump.Margin = new System.Windows.Forms.Padding(2);
            this.BtnPump.Name = "BtnPump";
            this.BtnPump.Size = new System.Drawing.Size(115, 32);
>>>>>>> origin/master
            this.BtnPump.TabIndex = 5;
            this.BtnPump.Text = "Pump";
            this.BtnPump.UseVisualStyleBackColor = false;
            this.BtnPump.Click += new System.EventHandler(this.BtnPump_Click);
            // 
            // BtnMerger
            // 
            this.BtnMerger.BackColor = System.Drawing.Color.LightSlateGray;
            this.BtnMerger.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnMerger.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
<<<<<<< HEAD
            this.BtnMerger.Location = new System.Drawing.Point(4, 166);
            this.BtnMerger.Name = "BtnMerger";
            this.BtnMerger.Size = new System.Drawing.Size(172, 49);
=======
            this.BtnMerger.Location = new System.Drawing.Point(3, 108);
            this.BtnMerger.Margin = new System.Windows.Forms.Padding(2);
            this.BtnMerger.Name = "BtnMerger";
            this.BtnMerger.Size = new System.Drawing.Size(115, 32);
>>>>>>> origin/master
            this.BtnMerger.TabIndex = 4;
            this.BtnMerger.Text = "Merger";
            this.BtnMerger.UseVisualStyleBackColor = false;
            this.BtnMerger.Click += new System.EventHandler(this.BtnMerger_Click);
            // 
            // BtnSplitter
            // 
            this.BtnSplitter.BackColor = System.Drawing.Color.LightSlateGray;
            this.BtnSplitter.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnSplitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
<<<<<<< HEAD
            this.BtnSplitter.Location = new System.Drawing.Point(3, 111);
            this.BtnSplitter.Name = "BtnSplitter";
            this.BtnSplitter.Size = new System.Drawing.Size(172, 49);
=======
            this.BtnSplitter.Location = new System.Drawing.Point(2, 72);
            this.BtnSplitter.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSplitter.Name = "BtnSplitter";
            this.BtnSplitter.Size = new System.Drawing.Size(115, 32);
>>>>>>> origin/master
            this.BtnSplitter.TabIndex = 3;
            this.BtnSplitter.Text = "Splitter";
            this.BtnSplitter.UseVisualStyleBackColor = false;
            this.BtnSplitter.Click += new System.EventHandler(this.BtnSplitter_Click);
            // 
            // BtnAddpipe
            // 
            this.BtnAddpipe.BackColor = System.Drawing.Color.LightSlateGray;
            this.BtnAddpipe.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnAddpipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
<<<<<<< HEAD
            this.BtnAddpipe.Location = new System.Drawing.Point(3, 55);
            this.BtnAddpipe.Name = "BtnAddpipe";
            this.BtnAddpipe.Size = new System.Drawing.Size(172, 49);
=======
            this.BtnAddpipe.Location = new System.Drawing.Point(2, 36);
            this.BtnAddpipe.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAddpipe.Name = "BtnAddpipe";
            this.BtnAddpipe.Size = new System.Drawing.Size(115, 32);
>>>>>>> origin/master
            this.BtnAddpipe.TabIndex = 2;
            this.BtnAddpipe.Text = "Pipe";
            this.BtnAddpipe.UseVisualStyleBackColor = false;
            this.BtnAddpipe.Click += new System.EventHandler(this.BtnAddpipe_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.LightSlateGray;
            this.SaveButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
<<<<<<< HEAD
            this.SaveButton.Location = new System.Drawing.Point(4, 492);
=======
            this.SaveButton.Location = new System.Drawing.Point(3, 320);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(2);
>>>>>>> origin/master
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(172, 49);
            this.SaveButton.TabIndex = 1;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // LoadButton
            // 
            this.LoadButton.BackColor = System.Drawing.Color.LightSlateGray;
            this.LoadButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.LoadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
<<<<<<< HEAD
            this.LoadButton.Location = new System.Drawing.Point(4, 548);
=======
            this.LoadButton.Location = new System.Drawing.Point(3, 356);
            this.LoadButton.Margin = new System.Windows.Forms.Padding(2);
>>>>>>> origin/master
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(172, 49);
            this.LoadButton.TabIndex = 0;
            this.LoadButton.Text = "Load";
            this.LoadButton.UseVisualStyleBackColor = false;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // GridPanel
            // 
<<<<<<< HEAD
            this.GridPanel.BackColor = System.Drawing.Color.White;
            this.GridPanel.Location = new System.Drawing.Point(208, 31);
=======
            this.GridPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.GridPanel.Location = new System.Drawing.Point(142, 20);
            this.GridPanel.Margin = new System.Windows.Forms.Padding(2);
>>>>>>> origin/master
            this.GridPanel.Name = "GridPanel";
            this.GridPanel.Size = new System.Drawing.Size(600, 600);
            this.GridPanel.TabIndex = 1;
<<<<<<< HEAD
=======
            this.GridPanel.Click += new System.EventHandler(this.GridPanel_Click);
>>>>>>> origin/master
            this.GridPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.GridPanel_Paint);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RightClickInputA,
            this.RightClickInputB,
            this.RightClickOutputA,
            this.RightClickOutputB,
            this.RightClickChange,
            this.RightClickDelete});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(206, 184);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // RightClickInputA
            // 
            this.RightClickInputA.Name = "RightClickInputA";
            this.RightClickInputA.Size = new System.Drawing.Size(205, 30);
            this.RightClickInputA.Text = "Add InputA";
            this.RightClickInputA.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // RightClickInputB
            // 
            this.RightClickInputB.Name = "RightClickInputB";
            this.RightClickInputB.Size = new System.Drawing.Size(205, 30);
            this.RightClickInputB.Text = "Add Input B";
            this.RightClickInputB.Click += new System.EventHandler(this.addOutputAToolStripMenuItem_Click);
            // 
            // RightClickOutputA
            // 
            this.RightClickOutputA.Name = "RightClickOutputA";
            this.RightClickOutputA.Size = new System.Drawing.Size(205, 30);
            this.RightClickOutputA.Text = "Add OutputA";
            // 
            // RightClickOutputB
            // 
            this.RightClickOutputB.Name = "RightClickOutputB";
            this.RightClickOutputB.Size = new System.Drawing.Size(205, 30);
            this.RightClickOutputB.Text = "Add OutPutB";
            // 
            // RightClickChange
            // 
            this.RightClickChange.Name = "RightClickChange";
            this.RightClickChange.Size = new System.Drawing.Size(205, 30);
            this.RightClickChange.Text = "Change";
            this.RightClickChange.Click += new System.EventHandler(this.RightClickChange_Click);
            // 
            // RightClickDelete
            // 
            this.RightClickDelete.Name = "RightClickDelete";
            this.RightClickDelete.Size = new System.Drawing.Size(205, 30);
            this.RightClickDelete.Text = "Delete";
            this.RightClickDelete.Click += new System.EventHandler(this.RightClickDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 682);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.GridPanel);
            this.Controls.Add(this.ToolPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(846, 742);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(846, 717);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ToolPanel.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ToolPanel;
        private System.Windows.Forms.Panel GridPanel;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem RightClickInputA;
        private System.Windows.Forms.ToolStripMenuItem RightClickInputB;
        private System.Windows.Forms.ToolStripMenuItem RightClickOutputA;
        private System.Windows.Forms.ToolStripMenuItem RightClickOutputB;
        private System.Windows.Forms.ToolStripMenuItem RightClickChange;
        private System.Windows.Forms.ToolStripMenuItem RightClickDelete;
        private System.Windows.Forms.Button BtnAddpipe;
        private System.Windows.Forms.Button BtnSplitter;
        private System.Windows.Forms.Button BtnMerger;
        private System.Windows.Forms.Button BtnSink;
        private System.Windows.Forms.Button BtnPump;
    }
}

