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
    public partial class frmFavourite : Form
    {
        int language;
        public frmFavourite()
        {
            InitializeComponent();
        }
        public frmFavourite(int en): this()
        {
            language = en;
           
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmFavourite_Load(object sender, EventArgs e)
        {
            loadData(lvFavorite);
           
            if (language  == 0) setlanguage("vi-VN");
            else setlanguage("en-US");
        }
        public void setlanguage(string c)
        {

            CultureInfo culture = new CultureInfo(c);
            ResourceManager rm = new
                ResourceManager("Dictionary.Resources.Language.Resource", typeof(frmFavourite).Assembly);

            label1.Text = rm.GetString("Favorite", culture);
            btClose.Text = rm.GetString("Close", culture);
            btRemove.Text = rm.GetString("Remove", culture);

        }
        private void loadData(ListView lvFavorite)
        {
            NewWord word = new NewWord();
            List<string> source = word.GetFavoriteWord();
            for (int i = 0; i < source.Count; i++)
            {
                lvFavorite.Items.Add(source[i]);
            }
            lvFavorite.Sort();
        }

        private void btRemove_Click(object sender, EventArgs e)
        {
            NewWord word = new NewWord();
            for (int i = 0; i < lvFavorite.Items.Count; i++)
            {
                if (lvFavorite.Items[i].Selected)
                {
                    word.XoaFavorite(lvFavorite.Items[i].Text);
                    lvFavorite.Clear();
                    loadData(lvFavorite);
                    MessageBox.Show("Xóa từ yêu thích thành công");

                }
            }


        }

        private void lvFavorite_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
