namespace Seeder2
{
    partial class Seeder
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.buttonEnc = new System.Windows.Forms.Button();
            this.buttonDec = new System.Windows.Forms.Button();
            this.buttonEK = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSlot5 = new System.Windows.Forms.Button();
            this.buttonSlot4 = new System.Windows.Forms.Button();
            this.buttonSlot3 = new System.Windows.Forms.Button();
            this.buttonSlot2 = new System.Windows.Forms.Button();
            this.buttonSlot1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToInputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyFromOutputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.DetectUrls = false;
            this.richTextBox1.Location = new System.Drawing.Point(13, 39);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(589, 112);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox2.DetectUrls = false;
            this.richTextBox2.Location = new System.Drawing.Point(16, 186);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(589, 112);
            this.richTextBox2.TabIndex = 1;
            this.richTextBox2.Text = "";
            // 
            // buttonEnc
            // 
            this.buttonEnc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonEnc.Enabled = false;
            this.buttonEnc.Location = new System.Drawing.Point(221, 157);
            this.buttonEnc.Name = "buttonEnc";
            this.buttonEnc.Size = new System.Drawing.Size(75, 23);
            this.buttonEnc.TabIndex = 2;
            this.buttonEnc.Text = "Encrypt!";
            this.buttonEnc.UseVisualStyleBackColor = true;
            this.buttonEnc.Click += new System.EventHandler(this.buttonEnc_Click);
            // 
            // buttonDec
            // 
            this.buttonDec.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonDec.Enabled = false;
            this.buttonDec.Location = new System.Drawing.Point(302, 157);
            this.buttonDec.Name = "buttonDec";
            this.buttonDec.Size = new System.Drawing.Size(75, 23);
            this.buttonDec.TabIndex = 3;
            this.buttonDec.Text = "Decrypt!";
            this.buttonDec.UseVisualStyleBackColor = true;
            this.buttonDec.Click += new System.EventHandler(this.buttonDec_Click);
            // 
            // buttonEK
            // 
            this.buttonEK.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonEK.Location = new System.Drawing.Point(13, 157);
            this.buttonEK.Name = "buttonEK";
            this.buttonEK.Size = new System.Drawing.Size(75, 23);
            this.buttonEK.TabIndex = 4;
            this.buttonEK.Text = "Upload EK";
            this.buttonEK.UseVisualStyleBackColor = true;
            this.buttonEK.Click += new System.EventHandler(this.buttonEK_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonSlot5);
            this.panel1.Controls.Add(this.buttonSlot4);
            this.panel1.Controls.Add(this.buttonSlot3);
            this.panel1.Controls.Add(this.buttonSlot2);
            this.panel1.Controls.Add(this.buttonSlot1);
            this.panel1.Location = new System.Drawing.Point(13, 358);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(589, 26);
            this.panel1.TabIndex = 5;
            this.panel1.Visible = false;
            // 
            // buttonSlot5
            // 
            this.buttonSlot5.Location = new System.Drawing.Point(511, 2);
            this.buttonSlot5.MaximumSize = new System.Drawing.Size(75, 23);
            this.buttonSlot5.MinimumSize = new System.Drawing.Size(75, 23);
            this.buttonSlot5.Name = "buttonSlot5";
            this.buttonSlot5.Size = new System.Drawing.Size(75, 23);
            this.buttonSlot5.TabIndex = 4;
            this.buttonSlot5.Text = "Slot 5";
            this.buttonSlot5.UseVisualStyleBackColor = true;
            // 
            // buttonSlot4
            // 
            this.buttonSlot4.Location = new System.Drawing.Point(384, 2);
            this.buttonSlot4.MaximumSize = new System.Drawing.Size(75, 23);
            this.buttonSlot4.MinimumSize = new System.Drawing.Size(75, 23);
            this.buttonSlot4.Name = "buttonSlot4";
            this.buttonSlot4.Size = new System.Drawing.Size(75, 23);
            this.buttonSlot4.TabIndex = 3;
            this.buttonSlot4.Text = "Slot 4";
            this.buttonSlot4.UseVisualStyleBackColor = true;
            // 
            // buttonSlot3
            // 
            this.buttonSlot3.Location = new System.Drawing.Point(257, 2);
            this.buttonSlot3.MaximumSize = new System.Drawing.Size(75, 23);
            this.buttonSlot3.MinimumSize = new System.Drawing.Size(75, 23);
            this.buttonSlot3.Name = "buttonSlot3";
            this.buttonSlot3.Size = new System.Drawing.Size(75, 23);
            this.buttonSlot3.TabIndex = 2;
            this.buttonSlot3.Text = "Slot 3";
            this.buttonSlot3.UseVisualStyleBackColor = true;
            // 
            // buttonSlot2
            // 
            this.buttonSlot2.Location = new System.Drawing.Point(130, 2);
            this.buttonSlot2.MaximumSize = new System.Drawing.Size(75, 23);
            this.buttonSlot2.MinimumSize = new System.Drawing.Size(75, 23);
            this.buttonSlot2.Name = "buttonSlot2";
            this.buttonSlot2.Size = new System.Drawing.Size(75, 23);
            this.buttonSlot2.TabIndex = 1;
            this.buttonSlot2.Text = "Slot 2";
            this.buttonSlot2.UseVisualStyleBackColor = true;
            // 
            // buttonSlot1
            // 
            this.buttonSlot1.Location = new System.Drawing.Point(3, 2);
            this.buttonSlot1.MaximumSize = new System.Drawing.Size(75, 23);
            this.buttonSlot1.MinimumSize = new System.Drawing.Size(75, 23);
            this.buttonSlot1.Name = "buttonSlot1";
            this.buttonSlot1.Size = new System.Drawing.Size(75, 23);
            this.buttonSlot1.TabIndex = 0;
            this.buttonSlot1.Text = "Slot 1";
            this.buttonSlot1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "EK Location:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel1.Location = new System.Drawing.Point(82, 316);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(0, 13);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.Blue;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "EK Version:";
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(13, 157);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(589, 23);
            this.progressBar1.TabIndex = 10;
            this.progressBar1.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(512, 50);
            this.label3.TabIndex = 11;
            this.label3.Text = "Wiggle the mouse for some randomisation!\r\nNote: The bigger the wiggles, the more random!";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(296, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "0%";
            this.label4.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.actionToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(614, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // actionToolStripMenuItem
            // 
            this.actionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pasteToInputToolStripMenuItem,
            this.copyFromOutputToolStripMenuItem});
            this.actionToolStripMenuItem.Name = "actionToolStripMenuItem";
            this.actionToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.actionToolStripMenuItem.Text = "Action";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // pasteToInputToolStripMenuItem
            // 
            this.pasteToInputToolStripMenuItem.Name = "pasteToInputToolStripMenuItem";
            this.pasteToInputToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pasteToInputToolStripMenuItem.Text = "Paste to Input";
            this.pasteToInputToolStripMenuItem.Click += new System.EventHandler(this.pasteToInputToolStripMenuItem_Click);
            // 
            // copyFromOutputToolStripMenuItem
            // 
            this.copyFromOutputToolStripMenuItem.Name = "copyFromOutputToolStripMenuItem";
            this.copyFromOutputToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.copyFromOutputToolStripMenuItem.Text = "Copy from Output";
            this.copyFromOutputToolStripMenuItem.Click += new System.EventHandler(this.copyFromOutputToolStripMenuItem_Click);
            // 
            // Seeder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 351);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonEK);
            this.Controls.Add(this.buttonDec);
            this.Controls.Add(this.buttonEnc);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(100000, 390);
            this.MinimumSize = new System.Drawing.Size(398, 390);
            this.Name = "Seeder";
            this.Text = "Seeder";
            this.Load += new System.EventHandler(this.Seeder_Load);
            this.Resize += new System.EventHandler(this.Seeder_Resize);
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button buttonEnc;
        private System.Windows.Forms.Button buttonDec;
        private System.Windows.Forms.Button buttonEK;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonSlot3;
        private System.Windows.Forms.Button buttonSlot2;
        private System.Windows.Forms.Button buttonSlot1;
        private System.Windows.Forms.Button buttonSlot5;
        private System.Windows.Forms.Button buttonSlot4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToInputToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyFromOutputToolStripMenuItem;
    }
}

