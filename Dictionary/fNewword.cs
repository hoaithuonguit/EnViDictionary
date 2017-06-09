using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dictionary.Class;
using System.Resources;
using System.Globalization;

namespace Dictionary
{
    public partial class frmNewword : Form
    {
        public int language;
        public string AddNewwordSuccess = "Add NewWord Successfully!";

        public frmNewword()
        {
            InitializeComponent();
        }

        public frmNewword(int en) : this()
        {
            language = en;
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewWord word = new NewWord();
            int number = word.Dem() +1;
            try
            {
                word.InsertNewWords(number, tbAddNewWord.Text, tbAddMeaning.Text, cbType.Text, tbAddExample.Text);
                MessageBox.Show(AddNewwordSuccess);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tbAddNewWord_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmNewword_Load(object sender, EventArgs e)
        {
            if (language == 0) setlanguage("vi-VN");
            else setlanguage("en-US");
        }
        public void setlanguage(string c)
        {

            CultureInfo culture = new CultureInfo(c);
            ResourceManager rm = new
                ResourceManager("Dictionary.Resources.Language.Resource", typeof(fmRecent).Assembly);
            label1.Text = rm.GetString("NewWord", culture);
            label2.Text = rm.GetString("Meaning", culture);
            label3.Text = rm.GetString("Type", culture);
            label4.Text = rm.GetString("Example", culture);
            AddNewwordSuccess = rm.GetString("AddNewwordSuccess", culture);
            button1.Text = rm.GetString("Add", culture);
            btClose.Text = rm.GetString("Close", culture);
        }
    }
}
