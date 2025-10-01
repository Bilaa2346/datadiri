namespace UTS__NABILAH_ATIFAH
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            lblNama = new Label();
            lblKeanggotaan = new Label();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            BtnClose = new Button();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14F, FontStyle.Bold);
            label1.Location = new Point(126, 9);
            label1.Name = "label1";
            label1.Size = new Size(161, 22);
            label1.TabIndex = 0;
            label1.Text = "DATA ANGGOTA";
            // 
            // lblNama
            // 
            lblNama.AutoSize = true;
            lblNama.Font = new Font("Times New Roman", 13F, FontStyle.Bold);
            lblNama.Location = new Point(16, 177);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(120, 20);
            lblNama.TabIndex = 1;
            lblNama.Text = "Nama            :";
            // 
            // lblKeanggotaan
            // 
            lblKeanggotaan.AutoSize = true;
            lblKeanggotaan.Font = new Font("Times New Roman", 13F, FontStyle.Bold);
            lblKeanggotaan.Location = new Point(16, 208);
            lblKeanggotaan.Name = "lblKeanggotaan";
            lblKeanggotaan.Size = new Size(122, 20);
            lblKeanggotaan.TabIndex = 2;
            lblKeanggotaan.Text = "Keanggotaan :";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ButtonHighlight;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(135, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(119, 143);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.LavenderBlush;
            groupBox1.Controls.Add(lblNama);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(lblKeanggotaan);
            groupBox1.Location = new Point(12, 34);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(397, 246);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // BtnClose
            // 
            BtnClose.BackColor = Color.Pink;
            BtnClose.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnClose.Location = new Point(334, 288);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(75, 33);
            BtnClose.TabIndex = 5;
            BtnClose.Text = "Close";
            BtnClose.UseVisualStyleBackColor = false;
            BtnClose.Click += button1_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Pink;
            btnBack.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            btnBack.Location = new Point(258, 288);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(70, 33);
            btnBack.TabIndex = 6;
            btnBack.Text = "← ";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(429, 340);
            Controls.Add(btnBack);
            Controls.Add(BtnClose);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form2";
            ShowIcon = false;
            Text = "View";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblNama;
        private Label lblKeanggotaan;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private Button BtnClose;
        private Button btnBack;
    }
}