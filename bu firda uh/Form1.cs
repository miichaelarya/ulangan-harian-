namespace ulangan_mk2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void Total()//Mendeklarasikan Variabel Global
        {
            int total, hrgmakan = 0, hrgminum = 0;
            //TryParse untuk mengubah nilai dari string ke int
            int.TryParse(txtmakanan.Text, out hrgmakan);
            int.TryParse(txtminuman.Text, out hrgminum);
            //program membaca int / nominal
            total = hrgmakan + hrgminum;
            //Convert. To string = mengembalikan nilai dari int ke string
            txttotal.Text = Convert.ToString(total);
            //txttotal = text box menampilkan total
        }
        private void label1_Click(object sender, EventArgs e)
        {
            int total, hrgmakan = 0, hrgminum = 0;
            int.TryParse(txtmakanan.Text, out hrgmakan);
            int.TryParse(txtminuman.Text, out hrgminum);

            total = hrgmakan + hrgminum;
            txttotal.Text = Convert.ToString(total);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void cmbmakanan_SelectedIndexChanged(object sender, EventArgs e)
        {
            int pilih;
            pilih = cmbmakanan.SelectedIndex;
            switch (pilih)
            {
                case 0://Kimbab
                    txtmakanan.Text = "12000";
                    break;
                case 1://Bibimpab
                    txtmakanan.Text = "15000";
                    break;
                case 2://Ramyeon
                    txtmakanan.Text = "13000";
                    break;

            }
            Total();
        }

        private void cmbminuman_SelectedIndexChanged(object sender, EventArgs e)
        {
            int pilih;
            pilih = cmbminuman.SelectedIndex;
            switch (pilih)
            {
                case 0://Matcha
                    txtminuman.Text = "12000";
                    break;
                case 1://Green tea
                    txtminuman.Text = "10000";
                    break;
                case 2://Banana milk
                    txtminuman.Text = "12000";
                    break;

            }
            Total();//memanggil variabel globalnya
        }

        private void txtbayar_TextChanged(object sender, EventArgs e)
        {
            if (txtbayar.Text == "" || txtbayar.Text == "")
            {
                txtbayar.Text = "0";
            }
            else
            {
                int a = Convert.ToInt32(txtbayar.Text);
                int b = Convert.ToInt32(txttotal.Text);
                int kembali = 0;
                kembali = a - b;

                txtkembali.Text = kembali.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
    }
}
