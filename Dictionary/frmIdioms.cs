using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dictionary.DictionaryBL.Idioms;
using Dictionary.DictionaryDA;
using Dictionary.Class;

namespace Dictionary
{
    public partial class frmIdioms : Form
    {
        private int language;

        public frmIdioms()
        {
            InitializeComponent();
        }

        public frmIdioms(int en) : this()
        {
            language = en;
        }

        private void frmIdioms_Load(object sender, EventArgs e)
        {
            LoadDatabase(dataGridView1);
        }

        void LoadDatabase(DataGridView dtgv)
        {
            Idioms idiorm = new Idioms();
            var source = idiorm.GetAllIdiormInDatabase();
            dtgv.DataSource = source;
            dtgv.Columns[0].Visible = false;
        }
    }
}
