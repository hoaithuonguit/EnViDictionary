namespace Dictionary
{
    partial class frmDictionary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDictionary));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dictionaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.favouriteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.irregularVerbsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newWordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onlineSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pronounToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gUIEVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btSearch = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btIrregularVerbs = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.label7 = new System.Windows.Forms.Label();
            this.Main = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tvType = new System.Windows.Forms.Label();
            this.tvExample = new System.Windows.Forms.Label();
            this.tvMeaning = new System.Windows.Forms.Label();
            this.lbMeaning = new System.Windows.Forms.Label();
            this.lbEngWord = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbFamily = new System.Windows.Forms.Label();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.listView1 = new System.Windows.Forms.ListView();
            this.menuStrip1.SuspendLayout();
            this.Main.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dictionaryToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(210, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dictionaryToolStripMenuItem
            // 
            this.dictionaryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recentToolStripMenuItem,
            this.favouriteToolStripMenuItem,
            this.irregularVerbsToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.dictionaryToolStripMenuItem.Name = "dictionaryToolStripMenuItem";
            this.dictionaryToolStripMenuItem.Size = new System.Drawing.Size(93, 25);
            this.dictionaryToolStripMenuItem.Text = "Dictionary";
            // 
            // recentToolStripMenuItem
            // 
            this.recentToolStripMenuItem.Name = "recentToolStripMenuItem";
            this.recentToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.recentToolStripMenuItem.Text = "Recent";
            this.recentToolStripMenuItem.Click += new System.EventHandler(this.recentToolStripMenuItem_Click);
            // 
            // favouriteToolStripMenuItem
            // 
            this.favouriteToolStripMenuItem.Name = "favouriteToolStripMenuItem";
            this.favouriteToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.favouriteToolStripMenuItem.Text = "Favourite";
            this.favouriteToolStripMenuItem.Click += new System.EventHandler(this.favouriteToolStripMenuItem_Click);
            // 
            // irregularVerbsToolStripMenuItem
            // 
            this.irregularVerbsToolStripMenuItem.Name = "irregularVerbsToolStripMenuItem";
            this.irregularVerbsToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.irregularVerbsToolStripMenuItem.Text = "Irregular Verbs";
            this.irregularVerbsToolStripMenuItem.Click += new System.EventHandler(this.irregularVerbsToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.quitToolStripMenuItem.Text = "Study";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newWordToolStripMenuItem,
            this.onlineSearchToolStripMenuItem,
            this.pronounToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(57, 25);
            this.toolsToolStripMenuItem.Text = "Tools";
            this.toolsToolStripMenuItem.Click += new System.EventHandler(this.toolsToolStripMenuItem_Click);
            // 
            // newWordToolStripMenuItem
            // 
            this.newWordToolStripMenuItem.Name = "newWordToolStripMenuItem";
            this.newWordToolStripMenuItem.Size = new System.Drawing.Size(155, 26);
            this.newWordToolStripMenuItem.Text = "New Word";
            this.newWordToolStripMenuItem.Click += new System.EventHandler(this.newWordToolStripMenuItem_Click);
            // 
            // onlineSearchToolStripMenuItem
            // 
            this.onlineSearchToolStripMenuItem.Name = "onlineSearchToolStripMenuItem";
            this.onlineSearchToolStripMenuItem.Size = new System.Drawing.Size(155, 26);
            this.onlineSearchToolStripMenuItem.Text = "Try Game";
            this.onlineSearchToolStripMenuItem.Click += new System.EventHandler(this.onlineSearchToolStripMenuItem_Click);
            // 
            // pronounToolStripMenuItem
            // 
            this.pronounToolStripMenuItem.Name = "pronounToolStripMenuItem";
            this.pronounToolStripMenuItem.Size = new System.Drawing.Size(155, 26);
            this.pronounToolStripMenuItem.Text = "Pronounce";
            this.pronounToolStripMenuItem.Click += new System.EventHandler(this.pronounToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.gUIEVToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(54, 25);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // gUIEVToolStripMenuItem
            // 
            this.gUIEVToolStripMenuItem.Name = "gUIEVToolStripMenuItem";
            this.gUIEVToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
            this.gUIEVToolStripMenuItem.Text = "GUI E_V";
            this.gUIEVToolStripMenuItem.Click += new System.EventHandler(this.gUIEVToolStripMenuItem_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Location = new System.Drawing.Point(25, 47);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(2);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(140, 26);
            this.tbSearch.TabIndex = 1;
            this.tbSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lost);
            // 
            // btSearch
            // 
            this.btSearch.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSearch.Appearance.Options.UseFont = true;
            this.btSearch.Location = new System.Drawing.Point(168, 47);
            this.btSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(79, 27);
            this.btSearch.TabIndex = 16;
            this.btSearch.Text = "Search";
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Location = new System.Drawing.Point(590, 47);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(2);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(160, 24);
            this.simpleButton1.TabIndex = 17;
            this.simpleButton1.Text = "Try Game";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btIrregularVerbs
            // 
            this.btIrregularVerbs.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btIrregularVerbs.Appearance.Options.UseFont = true;
            this.btIrregularVerbs.Location = new System.Drawing.Point(299, 47);
            this.btIrregularVerbs.Margin = new System.Windows.Forms.Padding(2);
            this.btIrregularVerbs.Name = "btIrregularVerbs";
            this.btIrregularVerbs.Size = new System.Drawing.Size(164, 24);
            this.btIrregularVerbs.TabIndex = 20;
            this.btIrregularVerbs.Text = "Irregular Verbs";
            this.btIrregularVerbs.Click += new System.EventHandler(this.btIrregularVerbs_Click);
            // 
            // simpleButton4
            // 
            this.simpleButton4.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton4.Appearance.Options.UseFont = true;
            this.simpleButton4.Location = new System.Drawing.Point(467, 47);
            this.simpleButton4.Margin = new System.Windows.Forms.Padding(2);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(119, 24);
            this.simpleButton4.TabIndex = 21;
            this.simpleButton4.Text = "Idioms";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(31, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 24);
            this.label7.TabIndex = 28;
            this.label7.Text = "List Of Words";
            // 
            // Main
            // 
            this.Main.Controls.Add(this.tabPage2);
            this.Main.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Main.Location = new System.Drawing.Point(299, 78);
            this.Main.Margin = new System.Windows.Forms.Padding(2);
            this.Main.Name = "Main";
            this.Main.SelectedIndex = 0;
            this.Main.Size = new System.Drawing.Size(451, 329);
            this.Main.TabIndex = 23;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tabPage2.Controls.Add(this.simpleButton5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.tvType);
            this.tabPage2.Controls.Add(this.tvExample);
            this.tabPage2.Controls.Add(this.tvMeaning);
            this.tabPage2.Controls.Add(this.lbMeaning);
            this.tabPage2.Controls.Add(this.lbEngWord);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.lbFamily);
            this.tabPage2.Controls.Add(this.simpleButton3);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(443, 296);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Main";
            // 
            // simpleButton5
            // 
            this.simpleButton5.BackgroundImage = global::Dictionary.Properties.Resources._1496052566_heart;
            this.simpleButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.simpleButton5.ImageOptions.Image = global::Dictionary.Properties.Resources._1496052566_heart;
            this.simpleButton5.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.simpleButton5.Location = new System.Drawing.Point(51, 11);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(37, 24);
            this.simpleButton5.TabIndex = 27;
            this.simpleButton5.Click += new System.EventHandler(this.simpleButton5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Example : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "Type: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Meaning:";
            // 
            // tvType
            // 
            this.tvType.AutoSize = true;
            this.tvType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvType.Location = new System.Drawing.Point(140, 93);
            this.tvType.Name = "tvType";
            this.tvType.Size = new System.Drawing.Size(0, 20);
            this.tvType.TabIndex = 25;
            // 
            // tvExample
            // 
            this.tvExample.AutoSize = true;
            this.tvExample.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvExample.Location = new System.Drawing.Point(140, 131);
            this.tvExample.Name = "tvExample";
            this.tvExample.Size = new System.Drawing.Size(0, 20);
            this.tvExample.TabIndex = 25;
            // 
            // tvMeaning
            // 
            this.tvMeaning.AutoSize = true;
            this.tvMeaning.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvMeaning.Location = new System.Drawing.Point(140, 54);
            this.tvMeaning.Name = "tvMeaning";
            this.tvMeaning.Size = new System.Drawing.Size(0, 20);
            this.tvMeaning.TabIndex = 25;
            this.tvMeaning.Click += new System.EventHandler(this.tvMeaning_Click);
            // 
            // lbMeaning
            // 
            this.lbMeaning.AutoSize = true;
            this.lbMeaning.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMeaning.Location = new System.Drawing.Point(36, 49);
            this.lbMeaning.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMeaning.Name = "lbMeaning";
            this.lbMeaning.Size = new System.Drawing.Size(0, 20);
            this.lbMeaning.TabIndex = 22;
            // 
            // lbEngWord
            // 
            this.lbEngWord.AutoSize = true;
            this.lbEngWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEngWord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbEngWord.Location = new System.Drawing.Point(36, 11);
            this.lbEngWord.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbEngWord.Name = "lbEngWord";
            this.lbEngWord.Size = new System.Drawing.Size(0, 24);
            this.lbEngWord.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 126);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 21;
            // 
            // lbFamily
            // 
            this.lbFamily.AutoSize = true;
            this.lbFamily.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFamily.Location = new System.Drawing.Point(36, 88);
            this.lbFamily.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbFamily.Name = "lbFamily";
            this.lbFamily.Size = new System.Drawing.Size(0, 20);
            this.lbFamily.TabIndex = 23;
            // 
            // simpleButton3
            // 
            this.simpleButton3.BackgroundImage = global::Dictionary.Properties.Resources._1491244795_black_8_audio_headphones;
            this.simpleButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.simpleButton3.ImageOptions.Image = global::Dictionary.Properties.Resources._1491244795_black_8_audio_headphones;
            this.simpleButton3.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.simpleButton3.Location = new System.Drawing.Point(9, 11);
            this.simpleButton3.Margin = new System.Windows.Forms.Padding(2);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(37, 24);
            this.simpleButton3.TabIndex = 24;
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.simpleButton2.Location = new System.Drawing.Point(251, 47);
            this.simpleButton2.Margin = new System.Windows.Forms.Padding(2);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(22, 24);
            this.simpleButton2.TabIndex = 18;
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // listView1
            // 
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.GridLines = true;
            this.listView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.listView1.Location = new System.Drawing.Point(25, 111);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(235, 292);
            this.listView1.TabIndex = 27;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Tile;
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.item_click_listview);
            // 
            // frmDictionary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(772, 454);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.Main);
            this.Controls.Add(this.simpleButton4);
            this.Controls.Add(this.btIrregularVerbs);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmDictionary";
            this.Text = "Dictionary";
            this.Load += new System.EventHandler(this.frmDictionary_Load);
            this.SizeChanged += new System.EventHandler(this.frmDictionary_SizeChanged);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Main.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dictionaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem favouriteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newWordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onlineSearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pronounToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gUIEVToolStripMenuItem;
        private System.Windows.Forms.TextBox tbSearch;
        private DevExpress.XtraEditors.SimpleButton btSearch;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton btIrregularVerbs;
        private System.Windows.Forms.ToolStripMenuItem irregularVerbsToolStripMenuItem;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabControl Main;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label tvType;
        private System.Windows.Forms.Label tvExample;
        private System.Windows.Forms.Label tvMeaning;
        private System.Windows.Forms.Label lbMeaning;
        private System.Windows.Forms.Label lbEngWord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbFamily;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
    }
}

