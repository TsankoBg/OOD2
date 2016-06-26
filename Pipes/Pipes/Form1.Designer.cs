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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnAddFlow = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.showflow = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ToolPanel.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToolPanel
            // 
            this.ToolPanel.BackColor = System.Drawing.Color.MintCream;
            this.ToolPanel.Controls.Add(this.btnAddFlow);
            this.ToolPanel.Controls.Add(this.textBox1);
            this.ToolPanel.Controls.Add(this.BtnSink);
            this.ToolPanel.Controls.Add(this.BtnPump);
            this.ToolPanel.Controls.Add(this.BtnMerger);
            this.ToolPanel.Controls.Add(this.BtnSplitter);
            this.ToolPanel.Controls.Add(this.BtnAddpipe);
            this.ToolPanel.Controls.Add(this.SaveButton);
            this.ToolPanel.Controls.Add(this.LoadButton);
            this.ToolPanel.Location = new System.Drawing.Point(6, 13);
            this.ToolPanel.Margin = new System.Windows.Forms.Padding(1);
            this.ToolPanel.MaximumSize = new System.Drawing.Size(80, 253);
            this.ToolPanel.MinimumSize = new System.Drawing.Size(80, 253);
            this.ToolPanel.Name = "ToolPanel";
            this.ToolPanel.Size = new System.Drawing.Size(80, 253);
            this.ToolPanel.TabIndex = 0;
            // 
            // BtnSink
            // 
            this.BtnSink.BackColor = System.Drawing.Color.LightSlateGray;
            this.BtnSink.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnSink.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSink.Location = new System.Drawing.Point(2, 116);
            this.BtnSink.Margin = new System.Windows.Forms.Padding(1);
            this.BtnSink.Name = "BtnSink";
            this.BtnSink.Size = new System.Drawing.Size(77, 21);
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
            this.BtnPump.Location = new System.Drawing.Point(2, 94);
            this.BtnPump.Margin = new System.Windows.Forms.Padding(1);
            this.BtnPump.Name = "BtnPump";
            this.BtnPump.Size = new System.Drawing.Size(77, 21);
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
            this.BtnMerger.Location = new System.Drawing.Point(2, 70);
            this.BtnMerger.Margin = new System.Windows.Forms.Padding(1);
            this.BtnMerger.Name = "BtnMerger";
            this.BtnMerger.Size = new System.Drawing.Size(77, 21);
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
            this.BtnSplitter.Location = new System.Drawing.Point(1, 47);
            this.BtnSplitter.Margin = new System.Windows.Forms.Padding(1);
            this.BtnSplitter.Name = "BtnSplitter";
            this.BtnSplitter.Size = new System.Drawing.Size(77, 21);
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
            this.BtnAddpipe.Location = new System.Drawing.Point(1, 23);
            this.BtnAddpipe.Margin = new System.Windows.Forms.Padding(1);
            this.BtnAddpipe.Name = "BtnAddpipe";
            this.BtnAddpipe.Size = new System.Drawing.Size(77, 21);
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
            this.SaveButton.Location = new System.Drawing.Point(2, 208);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(1);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(115, 32);
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
            this.LoadButton.Location = new System.Drawing.Point(2, 231);
            this.LoadButton.Margin = new System.Windows.Forms.Padding(1);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(115, 32);
            this.LoadButton.TabIndex = 0;
            this.LoadButton.Text = "Load";
            this.LoadButton.UseVisualStyleBackColor = false;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // GridPanel
            // 
            this.GridPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.GridPanel.Location = new System.Drawing.Point(95, 13);
            this.GridPanel.Margin = new System.Windows.Forms.Padding(1);
            this.GridPanel.Name = "GridPanel";
            this.GridPanel.Size = new System.Drawing.Size(400, 390);
            this.GridPanel.TabIndex = 1;
            this.GridPanel.Click += new System.EventHandler(this.GridPanel_Click);
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
            this.contextMenuStrip1.Size = new System.Drawing.Size(146, 136);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            this.contextMenuStrip1.Opened += new System.EventHandler(this.contextMenuStrip1_Opened);
            this.contextMenuStrip1.Click += new System.EventHandler(this.contextMenuStrip1_Click);
            // 
            // RightClickInputA
            // 
            this.RightClickInputA.Name = "RightClickInputA";
            this.RightClickInputA.Size = new System.Drawing.Size(145, 22);
            this.RightClickInputA.Text = "Add InputA";
            this.RightClickInputA.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // RightClickInputB
            // 
            this.RightClickInputB.Name = "RightClickInputB";
            this.RightClickInputB.Size = new System.Drawing.Size(145, 22);
            this.RightClickInputB.Text = "Add Input B";
            this.RightClickInputB.Click += new System.EventHandler(this.addOutputAToolStripMenuItem_Click);
            // 
            // RightClickOutputA
            // 
            this.RightClickOutputA.Name = "RightClickOutputA";
            this.RightClickOutputA.Size = new System.Drawing.Size(145, 22);
            this.RightClickOutputA.Text = "Add OutputA";
            // 
            // RightClickOutputB
            // 
            this.RightClickOutputB.Name = "RightClickOutputB";
            this.RightClickOutputB.Size = new System.Drawing.Size(145, 22);
            this.RightClickOutputB.Text = "Add OutPutB";
            // 
            // RightClickChange
            // 
            this.RightClickChange.Name = "RightClickChange";
            this.RightClickChange.Size = new System.Drawing.Size(145, 22);
            this.RightClickChange.Text = "Change";
            this.RightClickChange.Click += new System.EventHandler(this.RightClickChange_Click);
            // 
            // RightClickDelete
            // 
            this.RightClickDelete.Name = "RightClickDelete";
            this.RightClickDelete.Size = new System.Drawing.Size(145, 22);
            this.RightClickDelete.Text = "Delete";
            this.RightClickDelete.Click += new System.EventHandler(this.RightClickDelete_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 173);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(49, 20);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnAddFlow
            // 
            this.btnAddFlow.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnAddFlow.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAddFlow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFlow.Location = new System.Drawing.Point(0, 148);
            this.btnAddFlow.Margin = new System.Windows.Forms.Padding(1);
            this.btnAddFlow.Name = "btnAddFlow";
            this.btnAddFlow.Size = new System.Drawing.Size(77, 21);
            this.btnAddFlow.TabIndex = 8;
            this.btnAddFlow.Text = "Set Flow";
            this.btnAddFlow.UseVisualStyleBackColor = false;
            this.btnAddFlow.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 329);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            // 
            // showflow
            // 
            this.showflow.Location = new System.Drawing.Point(7, 292);
            this.showflow.Name = "showflow";
            this.showflow.Size = new System.Drawing.Size(75, 23);
            this.showflow.TabIndex = 3;
            this.showflow.Text = "Show flow:";
            this.showflow.UseVisualStyleBackColor = true;
            this.showflow.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 443);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.showflow);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GridPanel);
            this.Controls.Add(this.ToolPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(571, 497);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(571, 481);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ToolPanel.ResumeLayout(false);
            this.ToolPanel.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button btnAddFlow;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button showflow;
        private System.Windows.Forms.Label label2;
    }
}

