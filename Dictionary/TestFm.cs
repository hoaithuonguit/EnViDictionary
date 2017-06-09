using Dictionary.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionary
{
    public partial class TestFm : Form
    {
        public string lanuage;
        public string notice_correct =  "Correct! Click Listen to restart! ";
        public string notice_incorrect = "Incorrect! This is ";
        public TestFm()
        {
            InitializeComponent();
        }

        public TestFm(int en) : this()
        {
            language = en;
        }

        public string TuDapAn;
        private int language;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            NewWord word = new NewWord();
            TuDapAn = word.GetTuRandom();
            SpeechSynthesizer Speaker = new SpeechSynthesizer();
            Speaker.Speak(TuDapAn);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (tbDapAn.Text.Trim().ToUpper() == TuDapAn.Trim().ToUpper())
            {
                lbDiem.Text = "10";
                tbDapAn.Clear();
                TuDapAn = null;
                MessageBox.Show(notice_correct);
            }
            else
            {
                MessageBox.Show(notice_incorrect + TuDapAn);
            }
        }

        private void TestFm_Load(object sender, EventArgs e)
        {
            if (language == 0) setlanguage("vi-VN");
            else setlanguage("en-US");
        }
        public void setlanguage(string c)
        {

            CultureInfo culture = new CultureInfo(c);
            ResourceManager rm = new
                ResourceManager("Dictionary.Resources.Language.Resource", typeof(fmRecent).Assembly);
            label1.Text = rm.GetString("ClickListenToStart", culture);
            label2.Text = rm.GetString("YourAnswer", culture);
            label3.Text = rm.GetString("YourScore", culture);
            simpleButton1.Text = rm.GetString("Listen", culture);
            simpleButton2.Text = rm.GetString("Finish", culture);
            notice_correct = rm.GetString("notice_correct", culture);
            notice_incorrect = rm.GetString("notice_incorrect", culture);

        }
    }
}
