using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UTS__NABILAH_ATIFAH
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public void SetData(string nama, string keanggotaan, Image foto)
        {
            lblNama.Text = "Nama             : " + nama;
            lblKeanggotaan.Text = "Keanggotaan  : " + keanggotaan;
            pictureBox1.Image = foto;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fd = new Form1();
            fd.Show();
                 
        }
    }
}
