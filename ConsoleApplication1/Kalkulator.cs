using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApplication1.Kalkulator
{
    public partial class Kalkulator : Form
    {

        bool Dodawanie = false;
        bool Dzielenie = false;
        bool Mnozenie = false;
        bool odejmowanie = false;

        int pierwsza_liczba;
        int druga_liczba;

       


    public Kalkulator()
        {
            InitializeComponent();
              

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            textBox1.Text += "1";
           
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
           
        }

        private void button13_Click(object sender, EventArgs e)
        {
             Dodawanie = true;
            pierwsza_liczba = int.Parse(textBox1.Text);
            textBox1.Clear();
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            

            int wynik = 0 ;
            druga_liczba = int.Parse(textBox1.Text);
            if (Dodawanie)
            {
                 wynik = pierwsza_liczba + druga_liczba;
            }
            else if(odejmowanie)
            {
                 wynik = pierwsza_liczba - druga_liczba;
            }
            else if(Dzielenie)
            {
                 wynik = pierwsza_liczba / druga_liczba;
            }
            else if(Mnozenie)
            {
                 wynik = pierwsza_liczba * druga_liczba;
            }

            textBox2.Text = wynik.ToString();

        }

        private void button12_Click(object sender, EventArgs e)
        {
            Dzielenie = true;
            pierwsza_liczba = int.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Mnozenie = true;
            pierwsza_liczba = int.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            odejmowanie = true;
            pierwsza_liczba = int.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            bool Dodawanie = false;
            bool Dzielenie = false;
            bool Mnozenie = false;
            bool odejmowanie = false;

            textBox1.Clear();
            textBox2.Clear();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Program.Main_menu();

        }

        private void Kalkulator_Load(object sender, EventArgs e)
        {

        }
    }
}
