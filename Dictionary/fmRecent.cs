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
    public partial class fmRecent : Form
    {
        public  int language;
        public string deletedata = "Delete Successfully!";
        public fmRecent()
        {
            InitializeComponent();
        }

        public fmRecent(int en) : this()
        {
            language = en;
        }
        public void setlanguage(string c)
        {

            CultureInfo culture = new CultureInfo(c);
            ResourceManager rm = new
                ResourceManager("Dictionary.Resources.Language.Resource", typeof(fmRecent).Assembly);

            simpleButton1.Text = rm.GetString("DeleteAllData", culture);
            deletedata = rm.GetString("deleteSuccess", culture);
        }

        private void fmRecent_Load(object sender, EventArgs e)
        {
            if (language == 0) setlanguage("vi-VN");
            else setlanguage("en-US");
            Loaddata(lvRecent);
        }

        private void Loaddata(ListView lvRecent)
        {
            NewWord newword = new NewWord();
            
            List<string> source = newword.GetRecent();
            for (int i = 0; i < source.Count; i++)
            {
                lvRecent.Items.Add(source[i]);
            }
        }

        private void lvRecent_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            NewWord newword = new NewWord();
            newword.DeleteRecent();
            MessageBox.Show(deletedata);
            lvRecent.Clear();
        }
    }
}
