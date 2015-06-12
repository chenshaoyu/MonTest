namespace MonTest
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.buttonStart = new System.Windows.Forms.Button();
            this.textBoxInfo = new System.Windows.Forms.TextBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.checkBoxFullScreen = new System.Windows.Forms.CheckBox();
            this.linkLabel = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStart.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.ForeColor = System.Drawing.Color.Blue;
            this.buttonStart.Location = new System.Drawing.Point(211, 179);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(80, 27);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start Test";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // textBoxInfo
            // 
            this.textBoxInfo.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxInfo.Location = new System.Drawing.Point(12, 12);
            this.textBoxInfo.Multiline = true;
            this.textBoxInfo.Name = "textBoxInfo";
            this.textBoxInfo.ReadOnly = true;
            this.textBoxInfo.Size = new System.Drawing.Size(348, 131);
            this.textBoxInfo.TabIndex = 2;
            this.textBoxInfo.Text = resources.GetString("textBoxInfo.Text");
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExit.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(296, 179);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(2);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(65, 27);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // checkBoxFullScreen
            // 
            this.checkBoxFullScreen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxFullScreen.AutoSize = true;
            this.checkBoxFullScreen.Checked = true;
            this.checkBoxFullScreen.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxFullScreen.Location = new System.Drawing.Point(84, 184);
            this.checkBoxFullScreen.Name = "checkBoxFullScreen";
            this.checkBoxFullScreen.Size = new System.Drawing.Size(121, 19);
            this.checkBoxFullScreen.TabIndex = 4;
            this.checkBoxFullScreen.Text = "Test in Full Screen";
            this.checkBoxFullScreen.UseVisualStyleBackColor = true;
            // 
            // linkLabel
            // 
            this.linkLabel.AutoSize = true;
            this.linkLabel.Location = new System.Drawing.Point(12, 146);
            this.linkLabel.Name = "linkLabel";
            this.linkLabel.Size = new System.Drawing.Size(230, 15);
            this.linkLabel.TabIndex = 5;
            this.linkLabel.TabStop = true;
            this.linkLabel.Text = "https://github.com/chenshaoyu/MonTest";
            this.linkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "MonTest";
            // 
            // mainForm
            // 
            this.AcceptButton = this.buttonStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 218);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabel);
            this.Controls.Add(this.checkBoxFullScreen);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.textBoxInfo);
            this.Controls.Add(this.buttonStart);
            this.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainForm";
            this.Text = "MonTest 0.3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.TextBox textBoxInfo;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.CheckBox checkBoxFullScreen;
        private System.Windows.Forms.LinkLabel linkLabel;
        private System.Windows.Forms.Label label1;
    }
}

