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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ToolPanel = new System.Windows.Forms.Panel();
            this.SaveButton = new System.Windows.Forms.Button();
            this.LoadButton = new System.Windows.Forms.Button();
            this.GridPanel = new System.Windows.Forms.Panel();
            this.ToolPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToolPanel
            // 
            this.ToolPanel.BackColor = System.Drawing.Color.MintCream;
            this.ToolPanel.Controls.Add(this.SaveButton);
            this.ToolPanel.Controls.Add(this.LoadButton);
            this.ToolPanel.Location = new System.Drawing.Point(13, 31);
            this.ToolPanel.MaximumSize = new System.Drawing.Size(180, 600);
            this.ToolPanel.MinimumSize = new System.Drawing.Size(180, 600);
            this.ToolPanel.Name = "ToolPanel";
            this.ToolPanel.Size = new System.Drawing.Size(180, 600);
            this.ToolPanel.TabIndex = 0;
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.LightSlateGray;
            this.SaveButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.SaveButton.Font = new System.Drawing.Font("Minion Pro", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(5, 493);
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
            this.LoadButton.Font = new System.Drawing.Font("Minion Pro", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadButton.Location = new System.Drawing.Point(5, 548);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(172, 49);
            this.LoadButton.TabIndex = 0;
            this.LoadButton.Text = "Load";
            this.LoadButton.UseVisualStyleBackColor = false;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // GridPanel
            // 
            this.GridPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.GridPanel.Location = new System.Drawing.Point(209, 31);
            this.GridPanel.Name = "GridPanel";
            this.GridPanel.Size = new System.Drawing.Size(600, 600);
            this.GridPanel.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 690);
            this.Controls.Add(this.GridPanel);
            this.Controls.Add(this.ToolPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(850, 750);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(850, 750);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ToolPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ToolPanel;
        private System.Windows.Forms.Panel GridPanel;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button LoadButton;
    }
}

