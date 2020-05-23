using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MemeFox
{
    public partial class SingleForm : Form
    {
        public SingleForm()
        {
            InitializeComponent();
        }
        private void сГЕНЕРИТЬПИКЧУToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics g = Graphics.FromImage(bmp);
            g.FillRectangle(Brushes.White, new RectangleF(0, 0, pictureBox1.Width, pictureBox1.Height));
            Random rnd = new Random();
            List<string> textdb = new List<string>();
            using (StreamReader reader = new StreamReader("data/textdb.txt", Encoding.Default))
            {
                while (true)
                {
                    string line = reader.ReadLine();
                    if (line != null)
                    {
                        textdb.Add(line);
                    }
                    else { break; }
                }
            }
            g.DrawString(textdb[rnd.Next(0, textdb.Count)], new Font("Times New Roman", 16), Brushes.Black, new Point(10, 10));
            g.DrawImage(new Bitmap($"data/pictures/{rnd.Next(1, 310)}.png"), new Rectangle(10, 86, 140, 140));
            pictureBox1.Image = bmp;
        }

        private void сОХРАНИТЬToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics g = Graphics.FromImage(bmp);
            g.DrawImage(pictureBox1.Image, new PointF(0, 0));
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PNG-изображение|*.png";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                bmp.Save(sfd.FileName);
            }
        }

        private void иНФОToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Info().ShowDialog();
        }

        private void кОМИКСНЫЙToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ComicForm().Show();
            Hide();
        }

        private void SingleForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
