using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeNumberCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (int.TryParse(textBox1.Text, out int number))
            {
                var primes = await Task.Run(() => FindPrimes(number));
                listBox1.Invoke(new Action(() =>
                {
                    foreach (var prime in primes)
                    {
                        listBox1.Items.Add(prime);
                    }
                }));
            }
            else
            {
                MessageBox.Show("Please enter a valid number!");
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            if (int.TryParse(textBox2.Text, out int number))
            {
                var primes = await Task.Run(() => FindPrimes(number));
                listBox2.Invoke(new Action(() =>
                {
                    foreach (var prime in primes)
                    {
                        listBox2.Items.Add(prime);
                    }
                }));
            }
            else
            {
                MessageBox.Show("Please enter a valid number!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private List<int> FindPrimes(int max)
        {
            List<int> primes = new List<int>();
            for (int i = 2; i <= max; i++)
            {
                if (IsPrime(i))
                {
                    primes.Add(i);
                }
            }
            return primes;
        }

        private bool IsPrime(int number)
        {
            if (number < 2) return false;
            for (int i = 2; i * i <= number; i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
    }
}
