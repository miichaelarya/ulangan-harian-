namespace ulangan_mk2
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
            groupBox1 = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            cmbminuman = new ComboBox();
            cmbmakanan = new ComboBox();
            groupBox2 = new GroupBox();
            txtmakanan = new TextBox();
            txtminuman = new TextBox();
            btnproses = new Button();
            txttotal = new TextBox();
            txtbayar = new TextBox();
            txtkembali = new TextBox();
            button2 = new Button();
            btnlogout = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            colorDialog1 = new ColorDialog();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cmbminuman);
            groupBox1.Controls.Add(cmbmakanan);
            groupBox1.Location = new Point(30, 26);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(348, 162);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Daftar menu korean food";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 97);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 5;
            label2.Text = "minuman";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 44);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 4;
            label1.Text = "makanan";
            // 
            // cmbminuman
            // 
            cmbminuman.BackColor = Color.FromArgb(255, 128, 0);
            cmbminuman.FormattingEnabled = true;
            cmbminuman.Items.AddRange(new object[] { "Matcha", "Green tea", "Banana milk" });
            cmbminuman.Location = new Point(161, 97);
            cmbminuman.Name = "cmbminuman";
            cmbminuman.Size = new Size(151, 28);
            cmbminuman.TabIndex = 3;
            cmbminuman.SelectedIndexChanged += cmbminuman_SelectedIndexChanged;
            // 
            // cmbmakanan
            // 
            cmbmakanan.BackColor = Color.FromArgb(255, 128, 0);
            cmbmakanan.FormattingEnabled = true;
            cmbmakanan.Items.AddRange(new object[] { "Kimbab", "Bibimbap", "Ramyeon" });
            cmbmakanan.Location = new Point(161, 37);
            cmbmakanan.Name = "cmbmakanan";
            cmbmakanan.Size = new Size(151, 28);
            cmbmakanan.TabIndex = 2;
            cmbmakanan.SelectedIndexChanged += cmbmakanan_SelectedIndexChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtmakanan);
            groupBox2.Controls.Add(txtminuman);
            groupBox2.Location = new Point(398, 26);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(256, 162);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "harga";
            // 
            // txtmakanan
            // 
            txtmakanan.BackColor = Color.FromArgb(255, 128, 0);
            txtmakanan.Location = new Point(49, 37);
            txtmakanan.Multiline = true;
            txtmakanan.Name = "txtmakanan";
            txtmakanan.Size = new Size(157, 37);
            txtmakanan.TabIndex = 2;
            // 
            // txtminuman
            // 
            txtminuman.BackColor = Color.FromArgb(255, 128, 0);
            txtminuman.Location = new Point(49, 88);
            txtminuman.Multiline = true;
            txtminuman.Name = "txtminuman";
            txtminuman.Size = new Size(157, 37);
            txtminuman.TabIndex = 1;
            // 
            // btnproses
            // 
            btnproses.BackColor = Color.Red;
            btnproses.Location = new Point(313, 394);
            btnproses.Name = "btnproses";
            btnproses.Size = new Size(94, 29);
            btnproses.TabIndex = 2;
            btnproses.Text = "Proses";
            btnproses.UseVisualStyleBackColor = false;
            btnproses.Click += button1_Click;
            // 
            // txttotal
            // 
            txttotal.BackColor = Color.FromArgb(255, 128, 0);
            txttotal.Location = new Point(447, 222);
            txttotal.Multiline = true;
            txttotal.Name = "txttotal";
            txttotal.Size = new Size(184, 37);
            txttotal.TabIndex = 3;
            // 
            // txtbayar
            // 
            txtbayar.BackColor = Color.FromArgb(255, 128, 0);
            txtbayar.Location = new Point(447, 274);
            txtbayar.Multiline = true;
            txtbayar.Name = "txtbayar";
            txtbayar.Size = new Size(184, 37);
            txtbayar.TabIndex = 4;
            txtbayar.TextChanged += txtbayar_TextChanged;
            // 
            // txtkembali
            // 
            txtkembali.BackColor = Color.FromArgb(255, 128, 0);
            txtkembali.Location = new Point(447, 326);
            txtkembali.Multiline = true;
            txtkembali.Name = "txtkembali";
            txtkembali.Size = new Size(184, 37);
            txtkembali.TabIndex = 5;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 0, 0);
            button2.Location = new Point(510, 394);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 6;
            button2.Text = "Tutup";
            button2.UseVisualStyleBackColor = false;
            // 
            // btnlogout
            // 
            btnlogout.BackColor = Color.FromArgb(192, 0, 0);
            btnlogout.Location = new Point(89, 394);
            btnlogout.Name = "btnlogout";
            btnlogout.Size = new Size(94, 29);
            btnlogout.TabIndex = 7;
            btnlogout.Text = "logout";
            btnlogout.UseVisualStyleBackColor = false;
            btnlogout.Click += button3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(384, 230);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 6;
            label3.Text = "Total";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(379, 280);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 8;
            label4.Text = "Bayar";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(361, 337);
            label5.Name = "label5";
            label5.Size = new Size(64, 20);
            label5.TabIndex = 9;
            label5.Text = "Kembali";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 0);
            ClientSize = new Size(713, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnlogout);
            Controls.Add(button2);
            Controls.Add(txtkembali);
            Controls.Add(txtbayar);
            Controls.Add(txttotal);
            Controls.Add(btnproses);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox cmbminuman;
        private ComboBox cmbmakanan;
        private GroupBox groupBox2;
        private TextBox txtmakanan;
        private TextBox txtminuman;
        private Button btnproses;
        private TextBox txttotal;
        private TextBox txtbayar;
        private TextBox txtkembali;
        private Label label2;
        private Label label1;
        private Button button2;
        private Button btnlogout;
        private Label label3;
        private Label label4;
        private Label label5;
        private ColorDialog colorDialog1;
    }
}
