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

        private void WstawZnak(object przycisk)
        {

            Button wcisnietyPrzycisk = (Button)przycisk;
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
            wcisnietyPrzycisk.Enabled = false;
            wcisnietyPrzycisk.Text = cowyswietlic;
            textBox1.Text = przeciwna;
            bool wynik = SprawdzCzyKtosWygral();
            if (wynik == true)
            {
                string tekstWygranej;
                if (czyjatura == true)
                {
                    tekstWygranej = "Wygrał Gracz X! Rozpocząć jeszcze raz?";
                }
                else
                {
                    tekstWygranej = "Wygrał Gracz O! Rozpocząć jeszcze raz?";
                }
                //Sprawdzamy, czy gracze chcą kontynuować czy nie
                DialogResult odpowiedz = MessageBox.Show(tekstWygranej, "Wygrana",MessageBoxButtons.YesNo);
                if (odpowiedz == DialogResult.No)
                {
                    WylaczWszystkiePrzyciski();
                }
                else
                {
                    WlaczWszystkiePrzyciskiIResetuj();
                }
            }
        }
        private void WstawZnakBot(int numer)
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
            switch (numer)
            {
                case 1:
                    button1.Enabled = false;
                    button1.Text = cowyswietlic;
                    textBox1.Text = przeciwna;
                    break;

                case 2:
                    button2.Enabled = false;
                    button2.Text = cowyswietlic;
                    textBox1.Text = przeciwna;
                    break;

                case 3:
                    button3.Enabled = false;
                    button3.Text = cowyswietlic;
                    textBox1.Text = przeciwna;
                    break;
                case 4:
                    button4.Enabled = false;
                    button4.Text = cowyswietlic;
                    textBox1.Text = przeciwna;
                    break;

                case 5:
                    button5.Enabled = false;
                    button5.Text = cowyswietlic;
                    textBox1.Text = przeciwna;
                    break;

                case 6:
                    button6.Enabled = false;
                    button6.Text = cowyswietlic;
                    textBox1.Text = przeciwna;
                    break;
                case 7:
                    button7.Enabled = false;
                    button7.Text = cowyswietlic;
                    textBox1.Text = przeciwna;
                    break;

                case 8:
                    button8.Enabled = false;
                    button8.Text = cowyswietlic;
                    textBox1.Text = przeciwna;
                    break;

                case 9:
                    button9.Enabled = false;
                    button9.Text = cowyswietlic;
                    textBox1.Text = przeciwna;
                    break;
                default:

                    break;
            }

            bool wynik = SprawdzCzyKtosWygral();
            if (wynik == true)
            {
                string tekstWygranej;
                if (czyjatura == true)
                {
                    tekstWygranej = "Wygrał Gracz X! Rozpocząć jeszcze raz?";
                }
                else
                {
                    tekstWygranej = "Wygrał Gracz O! Rozpocząć jeszcze raz?";
                }
                //Sprawdzamy, czy gracze chcą kontynuować czy nie
                DialogResult odpowiedz = MessageBox.Show(tekstWygranej, "Wygrana", MessageBoxButtons.YesNo);
                if (odpowiedz == DialogResult.No)
                {
                    WylaczWszystkiePrzyciski();
                }
                else
                {
                    WlaczWszystkiePrzyciskiIResetuj();
                }
            }
        }
        private bool SprawdzCzyKtosWygral()
        {
            //Winning Condition For First Row
            if (button1.Text == button2.Text && button2.Text == button3.Text && button1.Text != "")
            //wystarszy sprawdzić tylko jeden, czy nie jest pusty
            {
                return true;
            }
            //Winning Condition For Second Row
            else if (button4.Text == button5.Text && button5.Text == button6.Text && button4.Text != "")
            {
                return true;
            }
            //Winning Condition For Third Row
            else if (button7.Text == button8.Text && button8.Text == button9.Text && button7.Text != "")
            {
                return true;
            }
            //Winning Condition For First Column
            else if (button1.Text == button4.Text && button4.Text == button7.Text && button1.Text != "")
            {
                return true;
            }
            //Winning Condition For Second Column
            else if (button2.Text == button5.Text && button5.Text == button8.Text && button2.Text != "")
            {
                return true;
            }
            //Winning Condition For Third Column

            else if (button3.Text == button6.Text && button6.Text == button9.Text && button3.Text != "")
            {
                return true;
            }
            else if (button1.Text == button5.Text && button5.Text == button9.Text && button1.Text != "")
            {
                return true;
            }
            //Winning Condition For Third Column
            else if (button3.Text == button5.Text && button5.Text == button7.Text && button3.Text != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void WlaczWszystkiePrzyciskiIResetuj()
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button1.Text = "";

            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
        }
        private void WylaczWszystkiePrzyciski()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
        }
        private void button1_Click(object sender, EventArgs e)

        {
            WstawZnak(sender);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            WstawZnak(sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            WstawZnak(sender);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            WstawZnak(sender);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            WstawZnak(sender);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            WstawZnak(sender);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            WstawZnak(sender);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            WstawZnak(sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WstawZnak(sender);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int rInt = r.Next(1, 9);
            switch (rInt)
            {
                case 1:
                    WstawZnakBot(1);
                    break;

                case 2:
                    WstawZnakBot(2); 

                    break;

                case 3:
                    WstawZnakBot(3);

                    break;
                case 4:
                    WstawZnakBot(4);

                    break;

                case 5:
                    WstawZnakBot(5); 

                    break;

                case 6:
                    WstawZnakBot(6); 

                    break;
                case 7:
                    WstawZnakBot(7);

                    break;

                case 8:
                    WstawZnakBot(8);

                    break;

                case 9:
                    WstawZnakBot(9);
                    break;
                default:
                    
                    break;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            WlaczWszystkiePrzyciskiIResetuj();
        }
    }
}
