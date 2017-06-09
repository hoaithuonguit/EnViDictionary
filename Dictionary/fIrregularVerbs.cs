using Dictionary.Class;
using Dictionary.DictionaryDA;
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
    public partial class frmIrregularVerbs : Form
    {
        int language =0;
        public frmIrregularVerbs()
        {
            InitializeComponent();
        }
        public frmIrregularVerbs(int en): this()
        {
            language = en;

        }
        private void lookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void frmIrregularVerbs_Load(object sender, EventArgs e)
        {
            LoadDatabase(dataGridView1);
            if (language == 0) setlanguage("vi-VN");
            else setlanguage("en-US");
        }
        public void setlanguage(string c)
        {

            CultureInfo culture = new CultureInfo(c);
            ResourceManager rm = new
                ResourceManager("Dictionary.Resources.Language.Resource", typeof(frmIrregularVerbs).Assembly);
            simpleButton1.Text = rm.GetString("Search", culture);
        }
         public  void LoadDatabase(DataGridView dtgv)
        {
            Verbs verb = new Verbs();
            var source = verb.GetAllVerbs();
            dtgv.DataSource = source;
            dtgv.Columns[0].Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string key = tbsearch.Text;
            Verbs v = new Verbs();
           var            ver = v.SearchVerbs(key, 0);
            
            if (ver != null)
                MessageBox.Show(ver.First().First.Trim().ToString() + " - " + ver.First().Second.Trim().ToString() + " - " + ver.First().Thirst.Trim().ToString() + " : " + ver.First().Meaning.Trim().ToString());
        }
    }
}
