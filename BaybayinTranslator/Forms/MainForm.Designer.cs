namespace BaybayinTranslator.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.configurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baybayinChartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sourceText = new System.Windows.Forms.TextBox();
            this.label_size = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.comboBox_size = new System.Windows.Forms.ComboBox();
            this.comboBox_Translation = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox_ShowBox = new System.Windows.Forms.CheckBox();
            this.checkBox_ShowLetter = new System.Windows.Forms.CheckBox();
            this.panelPicture = new System.Windows.Forms.Panel();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.buttonBackColor = new System.Windows.Forms.Button();
            this.buttonBoxColor = new System.Windows.Forms.Button();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panelPicture.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configurationToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(747, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // configurationToolStripMenuItem
            // 
            this.configurationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.printToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.configurationToolStripMenuItem.Name = "configurationToolStripMenuItem";
            this.configurationToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.configurationToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.openToolStripMenuItem.Text = "Open Text File";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imageToolStripMenuItem,
            this.pDFToolStripMenuItem});
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.printToolStripMenuItem.Text = "Save as";
            // 
            // imageToolStripMenuItem
            // 
            this.imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            this.imageToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.imageToolStripMenuItem.Text = "Image";
            this.imageToolStripMenuItem.Click += new System.EventHandler(this.saveImageAsToolStripMenuItem_Click);
            // 
            // pDFToolStripMenuItem
            // 
            this.pDFToolStripMenuItem.Name = "pDFToolStripMenuItem";
            this.pDFToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.pDFToolStripMenuItem.Text = "PDF";
            this.pDFToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.baybayinChartToolStripMenuItem,
            this.aboutToolStripMenuItem1});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.aboutToolStripMenuItem.Text = "Help";
            // 
            // baybayinChartToolStripMenuItem
            // 
            this.baybayinChartToolStripMenuItem.Name = "baybayinChartToolStripMenuItem";
            this.baybayinChartToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.baybayinChartToolStripMenuItem.Text = "Baybayin Chart";
            this.baybayinChartToolStripMenuItem.Click += new System.EventHandler(this.baybayinChartToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(154, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // sourceText
            // 
            this.sourceText.Location = new System.Drawing.Point(8, 20);
            this.sourceText.Multiline = true;
            this.sourceText.Name = "sourceText";
            this.sourceText.Size = new System.Drawing.Size(328, 442);
            this.sourceText.TabIndex = 2;
            // 
            // label_size
            // 
            this.label_size.AutoSize = true;
            this.label_size.Location = new System.Drawing.Point(86, 557);
            this.label_size.Name = "label_size";
            this.label_size.Size = new System.Drawing.Size(27, 13);
            this.label_size.TabIndex = 1;
            this.label_size.Text = "Size";
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.Location = new System.Drawing.Point(12, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(337, 328);
            this.pictureBox.TabIndex = 4;
            this.pictureBox.TabStop = false;
            // 
            // comboBox_size
            // 
            this.comboBox_size.FormattingEnabled = true;
            this.comboBox_size.Location = new System.Drawing.Point(119, 552);
            this.comboBox_size.Name = "comboBox_size";
            this.comboBox_size.Size = new System.Drawing.Size(82, 21);
            this.comboBox_size.TabIndex = 6;
            this.comboBox_size.SelectedIndexChanged += new System.EventHandler(this.drawLetter);
            // 
            // comboBox_Translation
            // 
            this.comboBox_Translation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_Translation.FormattingEnabled = true;
            this.comboBox_Translation.Location = new System.Drawing.Point(119, 579);
            this.comboBox_Translation.Name = "comboBox_Translation";
            this.comboBox_Translation.Size = new System.Drawing.Size(122, 21);
            this.comboBox_Translation.TabIndex = 7;
            this.comboBox_Translation.SelectedIndexChanged += new System.EventHandler(this.comboBox_Translation_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 582);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Translation Version";
            // 
            // checkBox_ShowBox
            // 
            this.checkBox_ShowBox.AutoSize = true;
            this.checkBox_ShowBox.Location = new System.Drawing.Point(59, 627);
            this.checkBox_ShowBox.Name = "checkBox_ShowBox";
            this.checkBox_ShowBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox_ShowBox.Size = new System.Drawing.Size(74, 17);
            this.checkBox_ShowBox.TabIndex = 14;
            this.checkBox_ShowBox.Text = "Show Box";
            this.checkBox_ShowBox.UseVisualStyleBackColor = true;
            this.checkBox_ShowBox.CheckStateChanged += new System.EventHandler(this.drawLetter);
            // 
            // checkBox_ShowLetter
            // 
            this.checkBox_ShowLetter.AutoSize = true;
            this.checkBox_ShowLetter.Checked = true;
            this.checkBox_ShowLetter.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_ShowLetter.Location = new System.Drawing.Point(50, 606);
            this.checkBox_ShowLetter.Name = "checkBox_ShowLetter";
            this.checkBox_ShowLetter.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox_ShowLetter.Size = new System.Drawing.Size(83, 17);
            this.checkBox_ShowLetter.TabIndex = 15;
            this.checkBox_ShowLetter.Text = "Show Letter";
            this.checkBox_ShowLetter.UseVisualStyleBackColor = true;
            this.checkBox_ShowLetter.CheckStateChanged += new System.EventHandler(this.drawLetter);
            // 
            // panelPicture
            // 
            this.panelPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPicture.AutoScroll = true;
            this.panelPicture.AutoSize = true;
            this.panelPicture.BackColor = System.Drawing.SystemColors.Control;
            this.panelPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPicture.Controls.Add(this.pictureBox);
            this.panelPicture.Location = new System.Drawing.Point(370, 47);
            this.panelPicture.Name = "panelPicture";
            this.panelPicture.Size = new System.Drawing.Size(365, 508);
            this.panelPicture.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sourceText);
            this.groupBox1.Location = new System.Drawing.Point(9, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 480);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter text to conver";
            // 
            // openFileDialog
            // 
            this.openFileDialog.Title = "Open File";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Title = "Save Image As";
            // 
            // buttonBackColor
            // 
            this.buttonBackColor.Location = new System.Drawing.Point(19, 650);
            this.buttonBackColor.Name = "buttonBackColor";
            this.buttonBackColor.Size = new System.Drawing.Size(71, 24);
            this.buttonBackColor.TabIndex = 19;
            this.buttonBackColor.Text = "Back Color";
            this.buttonBackColor.UseVisualStyleBackColor = true;
            this.buttonBackColor.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonBoxColor
            // 
            this.buttonBoxColor.Location = new System.Drawing.Point(19, 679);
            this.buttonBoxColor.Name = "buttonBoxColor";
            this.buttonBoxColor.Size = new System.Drawing.Size(71, 24);
            this.buttonBoxColor.TabIndex = 20;
            this.buttonBoxColor.Text = "Box Color";
            this.buttonBoxColor.UseVisualStyleBackColor = true;
            this.buttonBoxColor.Click += new System.EventHandler(this.buttonBoxColor_Click);
            // 
            // printDocument
            // 
            this.printDocument.EndPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument_EndPrint);
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(164, 650);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 53);
            this.button1.TabIndex = 21;
            this.button1.Text = "Convert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 750);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonBoxColor);
            this.Controls.Add(this.buttonBackColor);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panelPicture);
            this.Controls.Add(this.checkBox_ShowLetter);
            this.Controls.Add(this.checkBox_ShowBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_Translation);
            this.Controls.Add(this.comboBox_size);
            this.Controls.Add(this.label_size);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panelPicture.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem configurationToolStripMenuItem;
        private System.Windows.Forms.TextBox sourceText;
        private System.Windows.Forms.Label label_size;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ComboBox comboBox_size;
        private System.Windows.Forms.ComboBox comboBox_Translation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox_ShowBox;
        private System.Windows.Forms.CheckBox checkBox_ShowLetter;
        private System.Windows.Forms.Panel panelPicture;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolStripMenuItem baybayinChartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.Button buttonBackColor;
        private System.Windows.Forms.Button buttonBoxColor;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.ToolStripMenuItem pDFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}