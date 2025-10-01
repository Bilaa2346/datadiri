namespace UTS__NABILAH_ATIFAH
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnPilGam_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "image Files | *.jpg;*,jpeg;*.png*;*.bmp;*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofd.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnDaftar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtNama.Text))
            {
                MessageBox.Show("Nama tidak boleh kosong!", "peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNama.Focus();
                return;
            }
            if (!rdbBiasa.Checked && !rdbPremium.Checked && !rdbVIP.Checked)
            {
                MessageBox.Show("Pilih jenis keanggotaan terlebih dahulu!", "peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(pictureBox1.Image == null)
            {
                MessageBox.Show("Silahkn pilih foto terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

                       
            string nama = txtNama.Text;
            string keanggotaan = "";

            if (rdbBiasa.Checked) keanggotaan = "Biasa";
            else if (rdbPremium.Checked) keanggotaan = "Premium";
            else if (rdbVIP.Checked) keanggotaan = "VIP";

            Form2 fv = new Form2();
            fv.SetData(nama, keanggotaan, pictureBox1.Image);
            fv.Show();

            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNama.Text = "";

            rdbBiasa.Checked = false;
            rdbPremium.Checked = false;
            rdbVIP.Checked = false;

            pictureBox1.Image = null;

        }
    }
}
