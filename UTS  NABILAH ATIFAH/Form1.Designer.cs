namespace UTS__NABILAH_ATIFAH
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtNama = new TextBox();
            rdbBiasa = new RadioButton();
            rdbPremium = new RadioButton();
            rdbVIP = new RadioButton();
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            btnPilGam = new Button();
            btnDaftar = new Button();
            btnClear = new Button();
            label2 = new Label();
            label3 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 11F, FontStyle.Bold);
            label1.Location = new Point(12, 36);
            label1.Name = "label1";
            label1.Size = new Size(107, 17);
            label1.TabIndex = 0;
            label1.Text = "Nama Lengkap";
            // 
            // txtNama
            // 
            txtNama.BackColor = SystemColors.Window;
            txtNama.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNama.Location = new Point(12, 56);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(250, 21);
            txtNama.TabIndex = 1;
            // 
            // rdbBiasa
            // 
            rdbBiasa.AutoSize = true;
            rdbBiasa.Font = new Font("Times New Roman", 11F, FontStyle.Bold);
            rdbBiasa.Location = new Point(15, 33);
            rdbBiasa.Name = "rdbBiasa";
            rdbBiasa.Size = new Size(62, 21);
            rdbBiasa.TabIndex = 2;
            rdbBiasa.TabStop = true;
            rdbBiasa.Text = "Biasa";
            rdbBiasa.UseVisualStyleBackColor = true;
            // 
            // rdbPremium
            // 
            rdbPremium.AutoSize = true;
            rdbPremium.Font = new Font("Times New Roman", 11F, FontStyle.Bold);
            rdbPremium.Location = new Point(15, 60);
            rdbPremium.Name = "rdbPremium";
            rdbPremium.Size = new Size(85, 21);
            rdbPremium.TabIndex = 3;
            rdbPremium.TabStop = true;
            rdbPremium.Text = "Premium";
            rdbPremium.UseVisualStyleBackColor = true;
            // 
            // rdbVIP
            // 
            rdbVIP.AutoSize = true;
            rdbVIP.Font = new Font("Times New Roman", 11F, FontStyle.Bold);
            rdbVIP.Location = new Point(15, 87);
            rdbVIP.Name = "rdbVIP";
            rdbVIP.Size = new Size(51, 21);
            rdbVIP.TabIndex = 4;
            rdbVIP.TabStop = true;
            rdbVIP.Text = "VIP";
            rdbVIP.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdbVIP);
            groupBox1.Controls.Add(rdbPremium);
            groupBox1.Controls.Add(rdbBiasa);
            groupBox1.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            groupBox1.Location = new Point(12, 99);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 120);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Jenis Keanggotaan";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ButtonHighlight;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(299, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(118, 143);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btnPilGam
            // 
            btnPilGam.BackColor = Color.Pink;
            btnPilGam.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPilGam.Location = new Point(299, 175);
            btnPilGam.Name = "btnPilGam";
            btnPilGam.RightToLeft = RightToLeft.No;
            btnPilGam.Size = new Size(118, 28);
            btnPilGam.TabIndex = 7;
            btnPilGam.Text = "Pilih Gambar";
            btnPilGam.UseVisualStyleBackColor = false;
            btnPilGam.Click += btnPilGam_Click;
            // 
            // btnDaftar
            // 
            btnDaftar.BackColor = Color.HotPink;
            btnDaftar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDaftar.Location = new Point(298, 243);
            btnDaftar.Name = "btnDaftar";
            btnDaftar.Size = new Size(118, 49);
            btnDaftar.TabIndex = 8;
            btnDaftar.Text = "Daftar";
            btnDaftar.UseVisualStyleBackColor = false;
            btnDaftar.Click += btnDaftar_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Pink;
            btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(298, 209);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(118, 28);
            btnClear.TabIndex = 10;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(1, 274);
            label2.Name = "label2";
            label2.Size = new Size(128, 18);
            label2.TabIndex = 11;
            label2.Text = "Nama : Nabilah Atifah";
            // 
            // label3
            // 
            label3.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(1, 292);
            label3.Name = "label3";
            label3.Size = new Size(118, 19);
            label3.TabIndex = 12;
            label3.Text = "NIM  : 5243151044";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(428, 314);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnClear);
            Controls.Add(btnDaftar);
            Controls.Add(btnPilGam);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            Controls.Add(txtNama);
            Controls.Add(label1);
            Name = "Form1";
            ShowIcon = false;
            Text = "Pendaftaran Anggota";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNama;
        private RadioButton rdbBiasa;
        private RadioButton rdbPremium;
        private RadioButton rdbVIP;
        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private Button btnPilGam;
        private Button btnDaftar;
        private Button btnClear;
        private Label label2;
        private Label label3;
    }
}
