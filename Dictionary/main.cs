using Dictionary.Class;
using Dictionary.DictionaryBL.Word;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Globalization;
using System.Resources;

namespace Dictionary
{
    public partial class frmDictionary : Form
    {
        string message_wordnotfound = "Word is not found";
        string addSuccess = "Add to Favorite successfully";
        int language = 1;
        public frmDictionary()
        {
            InitializeComponent();

        }

        private void favouriteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFavourite fav = new frmFavourite(language);
            fav.Show();
        }

        private void newWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNewword add = new frmNewword(language);
            add.Show();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmHoc fm = new fmHoc(language);
            fm.Show();
        }

        private void setLanguage(string cultureName)
        {
            CultureInfo culture = new CultureInfo(cultureName);
            ResourceManager rm = new
                ResourceManager("Dictionary.Resources.Language.Resource", typeof(frmDictionary).Assembly);
            dictionaryToolStripMenuItem.Text = rm.GetString("Dictionary", culture);
            recentToolStripMenuItem.Text = rm.GetString("Recent", culture);
            favouriteToolStripMenuItem.Text = rm.GetString("Favorite", culture);
            quitToolStripMenuItem.Text = rm.GetString("Study", culture);
            toolsToolStripMenuItem.Text = rm.GetString("Tool", culture);
            newWordToolStripMenuItem.Text = rm.GetString("NewWord", culture);
            onlineSearchToolStripMenuItem.Text = rm.GetString("TryGame", culture);
            pronounToolStripMenuItem.Text = rm.GetString("Listen", culture);
            helpToolStripMenuItem.Text = rm.GetString("Help", culture);
            gUIEVToolStripMenuItem.Text = rm.GetString("GUIV_E", culture);
            aboutToolStripMenuItem.Text = rm.GetString("about", culture);
            btIrregularVerbs.Text = rm.GetString("IrregularVerbs", culture);
            btSearch.Text = rm.GetString("Search", culture);
            label7.Text = rm.GetString("ListOfWords", culture);
            label1.Text = rm.GetString("Meaning", culture);
            label3.Text = rm.GetString("Type", culture);
            label4.Text = rm.GetString("Example", culture);
            simpleButton4.Text = rm.GetString("Idoims", culture);
            simpleButton1.Text = rm.GetString("TryGame", culture);
            message_wordnotfound = rm.GetString("wordnotfound", culture);
            addSuccess = rm.GetString("addSuccess", culture);
        }
        private void gUIEVToolStripMenuItem_Click(object sender, EventArgs e)
        {


            if (gUIEVToolStripMenuItem.Text == "GUI E_V")
            {
                language = 0;
                setLanguage("vi-VN");
            }
            else
            {
                language = 1;
                setLanguage("en-US");
            }
        }

        private void btIrregularVerbs_Click(object sender, EventArgs e)
        {
            frmIrregularVerbs irr = new frmIrregularVerbs(language);
            irr.Show();
        }

        private void irregularVerbsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIrregularVerbs irr = new frmIrregularVerbs(language);
            irr.Show();
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            string KeyWord = tbSearch.Text;
            NewWord resultSearch = new NewWord();
            Word result = new Word();
            resultSearch.AddRecentWord(KeyWord);
            result = resultSearch.GetWordWhenSearch(KeyWord);
            if (result != null)
            {
                tvMeaning.Text = result.ViWord;
                tvExample.Text = result.Example;
                tvType.Text = result.Type;
            }
            else
                MessageBox.Show(message_wordnotfound);

        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            frmIdioms idiom = new frmIdioms(language);
            idiom.Show();
        }


        private void frmDictionary_Load(object sender, EventArgs e)
        {
            LoadWord(listView1);

        }

        void LoadWord(ListView dtword)
        {
            NewWord word = new NewWord();
            List<string> source = word.Init();
            for (int i = 0; i < source.Count; i++)
            {
                dtword.Items.Add(source[i]);
            }
            listView1.Sort();
        }
        public void item_click_listview(object sender, MouseEventArgs e)
        {
            tbSearch.Text = listView1.SelectedItems[0].Text;
            NewWord resultSearch = new NewWord();
            Word result = new Word();
            result = resultSearch.GetWordWhenSearch(tbSearch.Text);
            tvMeaning.Text = result.ViWord;
            tvExample.Text = result.Example;
            tvType.Text = result.Type;

        }

        public void lost(object sender, KeyPressEventArgs e)
        {

        }

        private void tvMeaning_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer Speaker = new SpeechSynthesizer();
            Speaker.Speak(tbSearch.Text);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            frmNewword form = new frmNewword(language);
            form.Show();
        }

        private void pronounToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer Speaker = new SpeechSynthesizer();
            Speaker.Speak(tbSearch.Text);
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {


            NewWord word = new NewWord();
            try
            {
                word.SetFavorite(tbSearch.Text);
                MessageBox.Show(addSuccess);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            TestFm fm = new TestFm(language);
            fm.Show();
        }



        private void frmDictionary_SizeChanged(object sender, EventArgs e)
        {

            //fmHoc fm = new fmHoc();
            //fm.Show();
        }

        private void recentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmRecent recent = new fmRecent(language);
            recent.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Info info = new Info();
            info.Show();
        }

        private void onlineSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TestFm fm = new TestFm(language);
            fm.Show();
        }

        private void toolsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
