namespace BaiTapBuoi5
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.OpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.TaoMoiVB = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LuuNoiDung = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DinhDang = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.TSBLuu = new System.Windows.Forms.ToolStripButton();
            this.TScomboFont = new System.Windows.Forms.ToolStripComboBox();
            this.TScomboSize = new System.Windows.Forms.ToolStripComboBox();
            this.TSBInDam = new System.Windows.Forms.ToolStripButton();
            this.TSBInNghieng = new System.Windows.Forms.ToolStripButton();
            this.TSBGachChan = new System.Windows.Forms.ToolStripButton();
            this.richText = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenFile,
            this.DinhDang});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // OpenFile
            // 
            this.OpenFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TaoMoiVB,
            this.OpenFileToolStripMenuItem,
            this.LuuNoiDung,
            this.thoátToolStripMenuItem});
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(71, 20);
            this.OpenFile.Text = "Hệ Thống";
            // 
            // TaoMoiVB
            // 
            this.TaoMoiVB.Image = global::BaiTapBuoi5.Properties.Resources.new_document;
            this.TaoMoiVB.Name = "TaoMoiVB";
            this.TaoMoiVB.Size = new System.Drawing.Size(193, 22);
            this.TaoMoiVB.Text = "Tạo văn bản mới ";
            this.TaoMoiVB.Click += new System.EventHandler(this.TaoMoiVB_Click);
            // 
            // OpenFileToolStripMenuItem
            // 
            this.OpenFileToolStripMenuItem.Image = global::BaiTapBuoi5.Properties.Resources.folder;
            this.OpenFileToolStripMenuItem.Name = "OpenFileToolStripMenuItem";
            this.OpenFileToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.OpenFileToolStripMenuItem.Text = "Mở tệp tin ";
            this.OpenFileToolStripMenuItem.Click += new System.EventHandler(this.OpenFileToolStripMenuItem_Click_1);
            // 
            // LuuNoiDung
            // 
            this.LuuNoiDung.Image = global::BaiTapBuoi5.Properties.Resources.diskette;
            this.LuuNoiDung.Name = "LuuNoiDung";
            this.LuuNoiDung.Size = new System.Drawing.Size(193, 22);
            this.LuuNoiDung.Text = "Lưu nội dung văn bản ";
            this.LuuNoiDung.Click += new System.EventHandler(this.LuuNoiDung_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // DinhDang
            // 
            this.DinhDang.Name = "DinhDang";
            this.DinhDang.Size = new System.Drawing.Size(74, 20);
            this.DinhDang.Text = "Địng dạng";
            this.DinhDang.Click += new System.EventHandler(this.DinhDang_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2,
            this.TSBLuu,
            this.TScomboFont,
            this.TScomboSize,
            this.TSBInDam,
            this.TSBInNghieng,
            this.TSBGachChan});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::BaiTapBuoi5.Properties.Resources.new_document;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // TSBLuu
            // 
            this.TSBLuu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSBLuu.Image = global::BaiTapBuoi5.Properties.Resources.diskette;
            this.TSBLuu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBLuu.Name = "TSBLuu";
            this.TSBLuu.Size = new System.Drawing.Size(23, 22);
            this.TSBLuu.Text = "toolStripButton1";
            this.TSBLuu.Click += new System.EventHandler(this.TSBLuu_Click);
            // 
            // TScomboFont
            // 
            this.TScomboFont.Name = "TScomboFont";
            this.TScomboFont.Size = new System.Drawing.Size(121, 25);
            this.TScomboFont.SelectedIndexChanged += new System.EventHandler(this.TScomboFont_SelectedIndexChanged);
            // 
            // TScomboSize
            // 
            this.TScomboSize.Name = "TScomboSize";
            this.TScomboSize.Size = new System.Drawing.Size(121, 25);
            this.TScomboSize.SelectedIndexChanged += new System.EventHandler(this.TScomboSize_SelectedIndexChanged);
            // 
            // TSBInDam
            // 
            this.TSBInDam.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSBInDam.Image = global::BaiTapBuoi5.Properties.Resources.format_bold_24dp_5F6368_FILL0_wght400_GRAD0_opsz24;
            this.TSBInDam.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBInDam.Name = "TSBInDam";
            this.TSBInDam.Size = new System.Drawing.Size(23, 22);
            this.TSBInDam.Text = "toolStripButton3";
            this.TSBInDam.Click += new System.EventHandler(this.TSBInDam_Click);
            // 
            // TSBInNghieng
            // 
            this.TSBInNghieng.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSBInNghieng.Image = global::BaiTapBuoi5.Properties.Resources.format_italic_24dp_5F6368;
            this.TSBInNghieng.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBInNghieng.Name = "TSBInNghieng";
            this.TSBInNghieng.Size = new System.Drawing.Size(23, 22);
            this.TSBInNghieng.Text = "toolStripButton4";
            this.TSBInNghieng.Click += new System.EventHandler(this.TSBInNghieng_Click);
            // 
            // TSBGachChan
            // 
            this.TSBGachChan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSBGachChan.Image = global::BaiTapBuoi5.Properties.Resources.format_underlined_24dp_5F6368_FILL0_wght400_GRAD0_opsz24;
            this.TSBGachChan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBGachChan.Name = "TSBGachChan";
            this.TSBGachChan.Size = new System.Drawing.Size(23, 22);
            this.TSBGachChan.Text = "toolStripButton5";
            this.TSBGachChan.Click += new System.EventHandler(this.TSBGachChan_Click);
            // 
            // richText
            // 
            this.richText.Location = new System.Drawing.Point(0, 52);
            this.richText.Name = "richText";
            this.richText.Size = new System.Drawing.Size(800, 401);
            this.richText.TabIndex = 2;
            this.richText.Text = "";
            this.richText.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richText);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Soạn thảo văn bản";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem OpenFile;
        private System.Windows.Forms.ToolStripMenuItem TaoMoiVB;
        private System.Windows.Forms.ToolStripMenuItem OpenFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LuuNoiDung;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DinhDang;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton TSBLuu;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripComboBox TScomboFont;
        private System.Windows.Forms.ToolStripComboBox TScomboSize;
        private System.Windows.Forms.ToolStripButton TSBInDam;
        private System.Windows.Forms.ToolStripButton TSBInNghieng;
        private System.Windows.Forms.ToolStripButton TSBGachChan;
        private System.Windows.Forms.RichTextBox richText;
    }
}

