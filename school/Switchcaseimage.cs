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
    public partial class Switchcaseimage : Form
    {
        Color orjinal;
        public Switchcaseimage()
        {
            InitializeComponent();
        }

        private void Switchcaseimage_Load(object sender, EventArgs e)
        {
            orjinal = this.BackColor;
            pictureBox1.Image = Resources.yok;
            pictureBox1.SizeMode=PictureBoxSizeMode.StretchImage;
            comboBox1.SelectedItem = "Orjinal";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem)
            {
                case "Mor":
                    BackColor = Color.Purple;
                    break;
                case "Mavi":
                    BackColor = Color.Blue;
                    break;
                case "Yeşil":
                    BackColor = Color.Green;
                    break;
                case "Kırmızı":
                    BackColor = Color.Red;
                    break;
                case "Orjinal":
                    this.BackColor= orjinal;
                    break;
                default:
                    break;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
             İşlemci
             Bellek
             Ekran kartı
             Anakart
             Kasa
             Klavye
             Fare
             */
            switch (comboBox2.SelectedItem)
            {
                case "İşlemci":
                    textBox1.Text = "İşlemci";
                    pictureBox1.Image = Resources.islemci;
                    break;
                case "Bellek":
                    textBox1.Text = "Bellek";
                    pictureBox1.Image = Resources.ddr4;
                    break;
                case "Ekran kartı":
                    textBox1.Text = "Ekran kartı";
                    pictureBox1.Image = Resources.asus_geforce;
                    break;
                case "Anakart":
                    textBox1.Text = "Anakart";
                    pictureBox1.Image = Resources.anakart;
                    break;
                case "Kasa":
                    textBox1.Text = "Kasa";
                    pictureBox1.Image= Resources.kasa;
                    break;
                case "Klavye":
                    textBox1.Text = "Klavye";
                    pictureBox1.Image= Resources.klavye;
                    break;
                case "Fare":
                    textBox1.Text = "Fare";
                    pictureBox1.Image= Resources.mouse;
                    break;
                default:
                    textBox1.Text = "Ürün Bulunamadı";
                    pictureBox1.Image= Resources.yok;
                    break;
            }
        }
    }
}
