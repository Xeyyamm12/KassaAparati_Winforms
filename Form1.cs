using KassaAparati.Entity;

namespace KassaAparati
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Product p = new Product();
        decimal result = 0;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("13212. Lays \n 12333. Kola");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] code = { "13212", "12333" };
            string[] name = {"Lays","Coca-Cola"};
            decimal[] price = {4.50M ,2.00M};
            if (textBox3.Text == code[0])
            {
                object[] Product1 = { p.Name = name[0], p.Price = price[0] };
                foreach (var item in Product1)
                {
                    listBox1.Items.Add(item);
                }
                result = result + p.Price;
            }
          
           else if (textBox3.Text == code[1])
            {
                object[] Product2 = { p.Name = name[1], p.Price = price[1] };
                foreach (var item in Product2)
                {
                    listBox1.Items.Add(item);
                }
                result = result + p.Price;

            }
            else
            {
                MessageBox.Show("Bu kod movcud deyil ");
            }
            label5.Text = $"{result.ToString()} azn";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox2.Text += btn.Text;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox2.Text += btn.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox2.Text += btn.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox2.Text += btn.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox2.Text += btn.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox2.Text += btn.Text;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            decimal mebleg = Convert.ToDecimal(textBox2.Text);
            if (mebleg > result)
            {
                label6.Text = $"{mebleg} azn";
                decimal qaliq = mebleg - result;
                label7.Text = $"{qaliq} azn";
            }
            else
            {
                label6.Text = "0.00 azn";
                MessageBox.Show("Ödenilen meble? toplam tutardan az ola bilmez !");
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox2.Text += btn.Text;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox2.Text += btn.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox2.Text += btn.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox2.Text += btn.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox2.Text += btn.Text;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}