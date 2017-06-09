namespace Dictionary
{
    partial class fmRecent
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
            this.lvRecent = new System.Windows.Forms.ListView();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // lvRecent
            // 
            this.lvRecent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvRecent.Location = new System.Drawing.Point(27, 37);
            this.lvRecent.Name = "lvRecent";
            this.lvRecent.Size = new System.Drawing.Size(363, 151);
            this.lvRecent.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvRecent.TabIndex = 0;
            this.lvRecent.UseCompatibleStateImageBehavior = false;
            this.lvRecent.View = System.Windows.Forms.View.List;
            this.lvRecent.SelectedIndexChanged += new System.EventHandler(this.lvRecent_SelectedIndexChanged);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Location = new System.Drawing.Point(107, 204);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(193, 30);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "Delete all data";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // fmRecent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(413, 261);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.lvRecent);
            this.Name = "fmRecent";
            this.Text = "fmRecent";
            this.Load += new System.EventHandler(this.fmRecent_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvRecent;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}