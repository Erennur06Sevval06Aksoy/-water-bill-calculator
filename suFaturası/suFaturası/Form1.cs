using System;
using System.Windows.Forms;
namespace suFaturası
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("Abone türü olarak 'Mesken','İşyeri','Sanayi' kullanılabilir.");
        }
        private void button1_Click(object sender, EventArgs e)
        { 
            string abone = Convert.ToString(textBox1.Text);
            int ilkİndex = Convert.ToInt32(textBox2.Text);
            int sonİndex = Convert.ToInt32(textBox3.Text);
            int tuketim = sonİndex - ilkİndex;
            int yaz1 = 0, yaz2 = 0;
            if (abone=="mesken")
            {
                int otuz = tuketim - 30;
                if (otuz > 30)
                {
                    yaz1 = 30 * 3;
                    listBox1.Items.Add("30 * 3");
                }
                int yetmis = otuz - 70;
                if (otuz > 70)
                {
                    yaz2 = 70 * 4;
                    listBox1.Items.Add("70 * 4");
                }
                int kalan = yetmis * 5;
                listBox1.Items.Add(yetmis + " * 5");
                listBox1.Items.Add("Fatura miktarınız: " +( yaz1 + yaz2 + kalan));
            }
            if (abone == "işyeri")
            {
                int otuz = tuketim - 30;
                if (otuz > 30)
                {
                    yaz1 = 30 * 4;
                    listBox1.Items.Add("30 * 3");
                }
                int yetmis = otuz - 70;
                if (otuz > 70)
                {
                    yaz2 = 70 * 5;
                    listBox1.Items.Add("70 * 4");
                }
                int kalan = yetmis * 10;
                listBox1.Items.Add(yetmis + " * 5");
                listBox1.Items.Add("Fatura miktarınız: " + (yaz1 + yaz2 + kalan));
            }
            if (abone == "sanayi")
            {
                int otuz = tuketim - 30;
                if (otuz > 30)
                {
                    yaz1 = 30 * 5;
                    listBox1.Items.Add("30 * 3");
                }
                int yetmis = otuz - 70;
                if (otuz > 70)
                {
                    yaz2 = 70 * 6;
                    listBox1.Items.Add("70 * 4");
                }
                int kalan = yetmis * 11;
                listBox1.Items.Add(yetmis + " * 5");
                listBox1.Items.Add("Fatura miktarınız: " + (yaz1 + yaz2 + kalan));
            }
        }
    }
}
