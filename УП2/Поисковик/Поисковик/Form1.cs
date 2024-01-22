using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Поисковик
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                dlg.Filter = "jpg files (*.jpg)|*.jpg;*.jpeg";
                if (dlg.ShowDialog() == DialogResult.OK)
                {

                    pictureBox1.Image = new Bitmap(dlg.FileName);

                    this.Controls.Add(pictureBox1);
                }
            }
        }
    }
}
