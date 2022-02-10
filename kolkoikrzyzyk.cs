using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public bool czyjatura = false;
        //false kolko x krzyzyk

        public Form1()
        {
            InitializeComponent();
        }



            
            private void button1_Click(object sender, EventArgs e)

        {
            
            string cowyswietlic;
            string przeciwna;
            if (czyjatura == false)
                
            {
                cowyswietlic = "X";
                przeciwna = "O";
                czyjatura = true;

            }
            else
            {
                cowyswietlic = "O";
                przeciwna = "X";
                czyjatura = false;
            }
            button1.Text = cowyswietlic;
            textBox1.Text = przeciwna;
            textBox1.Text = "test22";


        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }
    }
}
