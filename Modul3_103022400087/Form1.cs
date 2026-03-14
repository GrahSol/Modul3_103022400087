namespace Modul3_103022400087
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        int nilai = 0;
        string awal = " ";
        string akhir = " ";
        //string awal = label1_Click.SelectedItem.ToString();
        //string akhirl = comboBox2_SelectedIndexChanged.SelectedItem.ToString();
        private void button1_Click(object sender, EventArgs e)
        {
            if (label1_Click == null || comboBox2_SelectedIndexChanged == null)
            {
                MessageBox.Show("Pilih satuan terlebih dahulu");
                return;
            }
            if (string.IsNullOrWhiteSpace(textBox1.Text) || !int.TryParse(textBox1.Text, out int nilai)){
                MessageBox.Show("Masukkan angka yang valid");
                return;


            }
            int kelvin = 0;
            if(awal == "Celcius")
            {
                kelvin = nilai + 273;
            }
            else if(awal == "Fahrenheit")
            {
                kelvin = (nilai - 32) * 5 / 9 + 273;
            }
            else if(awal == "Kelvin")
            {
                kelvin = nilai;
            }
            else if(awal == "Reamur")
            {
                kelvin = nilai;
            }
            

            int hasil = 0;
            if (akhir == "Celcius")
            {
                kelvin = nilai - 273;
            }
            else if (awal == "Fahrenheit")
            {

            }
            else if (awal == "Kelvin")
            {
                kelvin = nilai;
            }
            else if (awal == "Reamur")
            {
                kelvin = nilai;
            }


        }
    }
}
