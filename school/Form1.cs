using school.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace school
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayac = 0;
        Bitmap[] images={
                Resources.ddr4,Resources.anakart,Resources.kasa,Resources.mouse,Resources.asus_geforce,Resources.islemci,Resources.klavye
            };

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac= sayac % 7;
            pictureBox1.Image= images[sayac];
            sayac+=1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode=PictureBoxSizeMode.StretchImage;
            timer1.Start();
            timer1.Enabled= true;
        }
    }
}
