namespace Assignment_2
{
    partial class TextEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextEditor));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.openToolBut = new System.Windows.Forms.ToolStripButton();
            this.newToolBut = new System.Windows.Forms.ToolStripButton();
            this.saveToolBut = new System.Windows.Forms.ToolStripButton();
            this.saveasToolBut = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.boldToolBut = new System.Windows.Forms.ToolStripButton();
            this.ItalicsToolBut = new System.Windows.Forms.ToolStripButton();
            this.underlineStripeBut = new System.Windows.Forms.ToolStripButton();
            this.UserLabel = new System.Windows.Forms.ToolStripLabel();
            this.SizeToolBut = new System.Windows.Forms.ToolStripComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openMenuBut = new System.Windows.Forms.ToolStripMenuItem();
            this.newMenuBut = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.saveMenuBut = new System.Windows.Forms.ToolStripMenuItem();
            this.saveasMenuBut = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.logOutMenuBut = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutMenuBut = new System.Windows.Forms.ToolStripMenuItem();
            this.copyMenuBut = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteMenuBut = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontMenuBut = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.underlineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boldMenuBut = new System.Windows.Forms.ToolStripMenuItem();
            this.italicMenuBut = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenuBut = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.cutToolBut = new System.Windows.Forms.ToolStripButton();
            this.copyToolBut = new System.Windows.Forms.ToolStripButton();
            this.pasteToolBut = new System.Windows.Forms.ToolStripButton();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolBut,
            this.newToolBut,
            this.saveToolBut,
            this.saveasToolBut,
            this.toolStripSeparator1,
            this.boldToolBut,
            this.ItalicsToolBut,
            this.underlineStripeBut,
            this.UserLabel,
            this.SizeToolBut});
            this.toolStrip1.Location = new System.Drawing.Point(0, 43);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(2051, 74);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // openToolBut
            // 
            this.openToolBut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolBut.Image = ((System.Drawing.Image)(resources.GetObject("openToolBut.Image")));
            this.openToolBut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolBut.Name = "openToolBut";
            this.openToolBut.Size = new System.Drawing.Size(52, 68);
            this.openToolBut.Text = "Open";
            this.openToolBut.Click += new System.EventHandler(this.openMenuBut_Click);
            // 
            // newToolBut
            // 
            this.newToolBut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolBut.Image = ((System.Drawing.Image)(resources.GetObject("newToolBut.Image")));
            this.newToolBut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolBut.Name = "newToolBut";
            this.newToolBut.Size = new System.Drawing.Size(52, 68);
            this.newToolBut.Text = "New";
            this.newToolBut.Click += new System.EventHandler(this.newMenuBut_Click);
            // 
            // saveToolBut
            // 
            this.saveToolBut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolBut.Image = ((System.Drawing.Image)(resources.GetObject("saveToolBut.Image")));
            this.saveToolBut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolBut.Name = "saveToolBut";
            this.saveToolBut.Size = new System.Drawing.Size(52, 68);
            this.saveToolBut.Text = "Save";
            this.saveToolBut.Click += new System.EventHandler(this.saveMenuBut_Click);
            // 
            // saveasToolBut
            // 
            this.saveasToolBut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveasToolBut.Image = ((System.Drawing.Image)(resources.GetObject("saveasToolBut.Image")));
            this.saveasToolBut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveasToolBut.Name = "saveasToolBut";
            this.saveasToolBut.Size = new System.Drawing.Size(52, 68);
            this.saveasToolBut.Text = "Save as";
            this.saveasToolBut.Click += new System.EventHandler(this.saveAsMenuBut_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 74);
            // 
            // boldToolBut
            // 
            this.boldToolBut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.boldToolBut.Image = ((System.Drawing.Image)(resources.GetObject("boldToolBut.Image")));
            this.boldToolBut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.boldToolBut.Name = "boldToolBut";
            this.boldToolBut.Size = new System.Drawing.Size(52, 68);
            this.boldToolBut.Text = "Bold";
            this.boldToolBut.Click += new System.EventHandler(this.boldMenuBut_Click);
            // 
            // ItalicsToolBut
            // 
            this.ItalicsToolBut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ItalicsToolBut.Image = ((System.Drawing.Image)(resources.GetObject("ItalicsToolBut.Image")));
            this.ItalicsToolBut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ItalicsToolBut.Name = "ItalicsToolBut";
            this.ItalicsToolBut.Size = new System.Drawing.Size(52, 68);
            this.ItalicsToolBut.Text = "Italics";
            this.ItalicsToolBut.Click += new System.EventHandler(this.italicMenuBut_Click);
            // 
            // underlineStripeBut
            // 
            this.underlineStripeBut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.underlineStripeBut.Image = ((System.Drawing.Image)(resources.GetObject("underlineStripeBut.Image")));
            this.underlineStripeBut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.underlineStripeBut.Name = "underlineStripeBut";
            this.underlineStripeBut.Size = new System.Drawing.Size(52, 68);
            this.underlineStripeBut.Text = "Underline";
            this.underlineStripeBut.Click += new System.EventHandler(this.underlineMenuBut_Click);
            // 
            // UserLabel
            // 
            this.UserLabel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(314, 68);
            this.UserLabel.Text = "Currently logged in as: ";
            // 
            // SizeToolBut
            // 
            this.SizeToolBut.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.SizeToolBut.Name = "SizeToolBut";
            this.SizeToolBut.Size = new System.Drawing.Size(121, 74);
            this.SizeToolBut.Text = "Size";
            this.SizeToolBut.ToolTipText = "Font Size";
            this.SizeToolBut.TextChanged += new System.EventHandler(this.fontSizeMenuBut_Change);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.fontToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(2051, 43);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openMenuBut,
            this.newMenuBut,
            this.toolStripSeparator2,
            this.saveMenuBut,
            this.saveasMenuBut,
            this.toolStripSeparator3,
            this.logOutMenuBut});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(80, 39);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openMenuBut
            // 
            this.openMenuBut.Image = ((System.Drawing.Image)(resources.GetObject("openMenuBut.Image")));
            this.openMenuBut.Name = "openMenuBut";
            this.openMenuBut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openMenuBut.Size = new System.Drawing.Size(455, 48);
            this.openMenuBut.Text = "Open";
            this.openMenuBut.Click += new System.EventHandler(this.openMenuBut_Click);
            // 
            // newMenuBut
            // 
            this.newMenuBut.Image = ((System.Drawing.Image)(resources.GetObject("newMenuBut.Image")));
            this.newMenuBut.Name = "newMenuBut";
            this.newMenuBut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newMenuBut.Size = new System.Drawing.Size(455, 48);
            this.newMenuBut.Text = "New          ";
            this.newMenuBut.Click += new System.EventHandler(this.newMenuBut_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(452, 6);
            // 
            // saveMenuBut
            // 
            this.saveMenuBut.Image = ((System.Drawing.Image)(resources.GetObject("saveMenuBut.Image")));
            this.saveMenuBut.Name = "saveMenuBut";
            this.saveMenuBut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveMenuBut.Size = new System.Drawing.Size(455, 48);
            this.saveMenuBut.Text = "Save";
            this.saveMenuBut.Click += new System.EventHandler(this.saveMenuBut_Click);
            // 
            // saveasMenuBut
            // 
            this.saveasMenuBut.Image = ((System.Drawing.Image)(resources.GetObject("saveasMenuBut.Image")));
            this.saveasMenuBut.Name = "saveasMenuBut";
            this.saveasMenuBut.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveasMenuBut.Size = new System.Drawing.Size(455, 48);
            this.saveasMenuBut.Text = "Save as...";
            this.saveasMenuBut.Click += new System.EventHandler(this.saveAsMenuBut_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(452, 6);
            // 
            // logOutMenuBut
            // 
            this.logOutMenuBut.Image = ((System.Drawing.Image)(resources.GetObject("logOutMenuBut.Image")));
            this.logOutMenuBut.Name = "logOutMenuBut";
            this.logOutMenuBut.Size = new System.Drawing.Size(455, 48);
            this.logOutMenuBut.Text = "Log Out";
            this.logOutMenuBut.Click += new System.EventHandler(this.logOutMenuBut_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutMenuBut,
            this.copyMenuBut,
            this.pasteMenuBut});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(86, 39);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // cutMenuBut
            // 
            this.cutMenuBut.Image = ((System.Drawing.Image)(resources.GetObject("cutMenuBut.Image")));
            this.cutMenuBut.Name = "cutMenuBut";
            this.cutMenuBut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutMenuBut.Size = new System.Drawing.Size(331, 48);
            this.cutMenuBut.Text = "Cut";
            this.cutMenuBut.Click += new System.EventHandler(this.cutMenuBut_Click);
            // 
            // copyMenuBut
            // 
            this.copyMenuBut.Image = ((System.Drawing.Image)(resources.GetObject("copyMenuBut.Image")));
            this.copyMenuBut.Name = "copyMenuBut";
            this.copyMenuBut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyMenuBut.Size = new System.Drawing.Size(331, 48);
            this.copyMenuBut.Text = "Copy";
            this.copyMenuBut.Click += new System.EventHandler(this.copyMenuBut_Click);
            // 
            // pasteMenuBut
            // 
            this.pasteMenuBut.Image = ((System.Drawing.Image)(resources.GetObject("pasteMenuBut.Image")));
            this.pasteMenuBut.Name = "pasteMenuBut";
            this.pasteMenuBut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteMenuBut.Size = new System.Drawing.Size(331, 48);
            this.pasteMenuBut.Text = "Paste";
            this.pasteMenuBut.Click += new System.EventHandler(this.pasteMenuBut_Click);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontMenuBut,
            this.toolStripSeparator4,
            this.underlineToolStripMenuItem,
            this.boldMenuBut,
            this.italicMenuBut});
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(95, 39);
            this.fontToolStripMenuItem.Text = "Font";
            // 
            // fontMenuBut
            // 
            this.fontMenuBut.Name = "fontMenuBut";
            this.fontMenuBut.Size = new System.Drawing.Size(385, 48);
            this.fontMenuBut.Text = "Font";
            this.fontMenuBut.Click += new System.EventHandler(this.fontStyleMenuBut_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(382, 6);
            // 
            // underlineToolStripMenuItem
            // 
            this.underlineToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("underlineToolStripMenuItem.Image")));
            this.underlineToolStripMenuItem.Name = "underlineToolStripMenuItem";
            this.underlineToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.underlineToolStripMenuItem.Size = new System.Drawing.Size(385, 48);
            this.underlineToolStripMenuItem.Text = "Underline";
            this.underlineToolStripMenuItem.Click += new System.EventHandler(this.underlineMenuBut_Click);
            // 
            // boldMenuBut
            // 
            this.boldMenuBut.Image = ((System.Drawing.Image)(resources.GetObject("boldMenuBut.Image")));
            this.boldMenuBut.Name = "boldMenuBut";
            this.boldMenuBut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.boldMenuBut.Size = new System.Drawing.Size(385, 48);
            this.boldMenuBut.Text = "Bold";
            this.boldMenuBut.Click += new System.EventHandler(this.boldMenuBut_Click);
            // 
            // italicMenuBut
            // 
            this.italicMenuBut.Image = ((System.Drawing.Image)(resources.GetObject("italicMenuBut.Image")));
            this.italicMenuBut.Name = "italicMenuBut";
            this.italicMenuBut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.italicMenuBut.Size = new System.Drawing.Size(385, 48);
            this.italicMenuBut.Text = "Italic";
            this.italicMenuBut.Click += new System.EventHandler(this.italicMenuBut_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutMenuBut});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(97, 39);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutMenuBut
            // 
            this.aboutMenuBut.Name = "aboutMenuBut";
            this.aboutMenuBut.Size = new System.Drawing.Size(257, 48);
            this.aboutMenuBut.Text = "About..";
            this.aboutMenuBut.Click += new System.EventHandler(this.aboutMenuBut_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutToolBut,
            this.copyToolBut,
            this.pasteToolBut});
            this.toolStrip2.Location = new System.Drawing.Point(0, 117);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(54, 1167);
            this.toolStrip2.TabIndex = 2;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // cutToolBut
            // 
            this.cutToolBut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cutToolBut.Image = ((System.Drawing.Image)(resources.GetObject("cutToolBut.Image")));
            this.cutToolBut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolBut.Name = "cutToolBut";
            this.cutToolBut.Size = new System.Drawing.Size(49, 40);
            this.cutToolBut.Text = "Cut";
            this.cutToolBut.Click += new System.EventHandler(this.cutMenuBut_Click);
            // 
            // copyToolBut
            // 
            this.copyToolBut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copyToolBut.Image = ((System.Drawing.Image)(resources.GetObject("copyToolBut.Image")));
            this.copyToolBut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolBut.Name = "copyToolBut";
            this.copyToolBut.Size = new System.Drawing.Size(49, 40);
            this.copyToolBut.Text = "Copy";
            this.copyToolBut.Click += new System.EventHandler(this.copyMenuBut_Click);
            // 
            // pasteToolBut
            // 
            this.pasteToolBut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pasteToolBut.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolBut.Image")));
            this.pasteToolBut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolBut.Name = "pasteToolBut";
            this.pasteToolBut.Size = new System.Drawing.Size(49, 40);
            this.pasteToolBut.Text = "Paste";
            this.pasteToolBut.Click += new System.EventHandler(this.pasteMenuBut_Click);
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(78, 120);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(1961, 1152);
            this.richTextBox.TabIndex = 3;
            this.richTextBox.Text = "";
            this.richTextBox.TextChanged += new System.EventHandler(this.richTextBox_TextChanged);
            // 
            // TextEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2051, 1284);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TextEditor";
            this.Text = "Text Editor";
            this.Load += new System.EventHandler(this.TextEditor_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip toolStrip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem fontToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripButton openToolBut;
        private ToolStripButton newToolBut;
        private ToolStripButton saveToolBut;
        private ToolStripButton saveasToolBut;
        private ToolStrip toolStrip2;
        private ToolStripButton cutToolBut;
        private ToolStripButton copyToolBut;
        private ToolStripButton pasteToolBut;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton boldToolBut;
        private ToolStripButton ItalicsToolBut;
        private ToolStripButton underlineStripeBut;
        private ToolStripComboBox SizeToolBut;
        private ToolStripLabel UserLabel;
        private RichTextBox richTextBox;
        private ToolStripMenuItem newMenuBut;
        private ToolStripMenuItem openMenuBut;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem saveMenuBut;
        private ToolStripMenuItem saveasMenuBut;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem logOutMenuBut;
        private ToolStripMenuItem cutMenuBut;
        private ToolStripMenuItem copyMenuBut;
        private ToolStripMenuItem pasteMenuBut;
        private ToolStripMenuItem aboutMenuBut;
        private ToolStripMenuItem fontMenuBut;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem underlineToolStripMenuItem;
        private ToolStripMenuItem boldMenuBut;
        private ToolStripMenuItem italicMenuBut;
    }
}