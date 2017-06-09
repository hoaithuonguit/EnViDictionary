using Dictionary.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionary
{
    public partial class fmHoc : Form
    {
        int language;
        public fmHoc()
        {
            InitializeComponent();
        }
        public fmHoc(int en): this()
        {
            language = en;

        }

        private void fmHoc_MinimumSizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                notifyIcon1.Icon = SystemIcons.Application;
                MessageBox.Show("ung dung van chay");
                
            }
        }

        private void fmHoc_Deactivate(object sender, EventArgs e)
        {
          //  Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {          
            Application.Exit();
        }

        private void dtgvTu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgvThanhNgu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fmHoc_Load(object sender, EventArgs e)
        {
            if (language == 0) setlanguage("vi-VN");
            else setlanguage("en-US");
            LoadDataWord(dtgvTu);
            LoadDataIdiorm(dtgvThanhNgu);
        }

        public void setlanguage(string c)
        {
            CultureInfo culture = new CultureInfo(c);
            ResourceManager rm = new
                ResourceManager("Dictionary.Resources.Language.Resource", typeof(fmHoc).Assembly);
            label1.Text = rm.GetString("ToDay", culture);
            label2.Text = rm.GetString("ListWords", culture);
            label3.Text = rm.GetString("ListIdoims", culture);
        }
        public void LoadDataIdiorm(DataGridView dtgvThanhNgu)
        {
            Idioms source = new Idioms();
            dtgvThanhNgu.DataSource = source.GetDataIdiorm();
            dtgvThanhNgu.Columns[0].Visible = false;
        }

        public void LoadDataWord(DataGridView dtgv)
        {
            NewWord nword = new NewWord();
            var source = nword.GetDataWord();
            dtgv.DataSource = source;
            dtgv.Columns[0].Visible = false;
            
        }
    }
}
