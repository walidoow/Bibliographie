using System;
using System.Drawing;
using System.Windows.Forms;

namespace Ecole
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String author = textBox1.Text;
            String title = textBox2.Text;
            String link = textBox3.Text;
            int day = monthCalendar1.SelectionStart.Day;
            Mois month = (Mois)monthCalendar1.SelectionStart.Month;
            int year = monthCalendar1.SelectionStart.Year;

            //OUTPUT
            richTextBox1.Text = author + ". " + title + ", [En ligne]. Adresse URL: " + link + " (Page consultée le " + day + " " + MoisManager.getStringMois(month) + " " + year + ").";
            //AUTHOR
            int index_author = richTextBox1.Text.IndexOf(author);
            int length_author = author.Length;
            richTextBox1.Select(index_author, length_author);
            //TITLE
            int index_title = richTextBox1.Text.IndexOf(title);
            int length_title = title.Length;
            richTextBox1.Select(index_title, length_title);
            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Italic);
            //LINK
            int index_link = richTextBox1.Text.IndexOf(link);
            int length_link = link.Length;
            richTextBox1.Select(index_link, length_link);
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            richTextBox1.Text = "";
        }
    }
}
