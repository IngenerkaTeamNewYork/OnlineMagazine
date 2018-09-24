using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApplication4
{
    public struct AuthorStat
    {
        public string name;
        public int Views;
        public int Likes;
        public int DisLikes;
    }
    
    class Author
    {
        public String login;
        public String parol;
        // Image img = Image.FromFile(Photo);
        // public List<Image> photo;
        public int kolvo_podpischikov; //я не могу придумать, как организовать рейтинг по-другому
        public String text_character;

        public void ShowText()
        {
            MessageBox.Show("1");
        }
    }
}
