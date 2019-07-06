using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lotto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonLotto.Checked)
            {
                Clear();  
            }
        }
        private void radioButtonMiniLotto_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonMiniLotto.Checked)
            {
                Clear();
            }

        }

        private void radioButtonMultiMulti_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonMultiMulti.Checked)
            {
                Clear();
                textBox1.Visible = true;
                labelHowMuch.Visible = true;
                checkBoxPlus.Visible = true;



            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButtonLotto.Checked)
            {

                Clear();
                ThreadManager thr = new ThreadManager(6, 49);
                Thread myThread = new Thread(new ParameterizedThreadStart(Losuj));
                myThread.Start(thr);

            }
            if (radioButtonMiniLotto.Checked)
            {
                Clear();
                ThreadManager thr = new ThreadManager(5, 42);
                Thread myThread = new Thread(new ParameterizedThreadStart(Losuj));
                myThread.Start(thr);
            }

            if (radioButtonMultiMulti.Checked)
            {
                Clear();
                textBox1.Visible = true;
                labelHowMuch.Visible = true;
                checkBoxPlus.Visible = true;

                int x = 0;

                if ((!int.TryParse(textBox1.Text, out x)) || ((x < 1) || (x > 10)))
                {
              
                    MessageBox.Show("Podaj liczbę od 1 do 10!");
                    textBox1.Text = "";
                }

                if ((int.TryParse(textBox1.Text, out x)) && ((x > 0) || (x < 11)))
                {
                    ThreadManager thr = new ThreadManager(x, 80);
                    Thread myThread = new Thread(new ParameterizedThreadStart(Losuj));
                    myThread.Start(thr);
                }
            }


        }

        private void Losuj(object data)
        {
            if (data is ThreadManager)
            {
                ThreadManager thr = (ThreadManager)data;

                Random rand = new Random();
                int plus = 0;

                int[] numbers = new int[thr.n];
                ArrayList randNumbers = new ArrayList();

                for (int i = 0; i < thr.n; i++)
                    numbers[i] = i + 1;

                label1.Invoke((MethodInvoker)(() => label1.Visible = true));

                for (int i = 0; i < thr.k; i++)
                {
                    for (int j = 0; j < thr.n; j++)
                    {
                        int d = rand.Next(thr.n);

                        RandFontColour(label1);
                        label1.Invoke((MethodInvoker)(() => label1.Text = numbers[d].ToString()));
                        Thread.Sleep(25);
                        label1.Invoke((MethodInvoker)(() => label1.Text = ""));

                    }

                    int r = rand.Next(thr.n);

                
                   if (thr.k >7)
                    {
                        labelRand.Invoke((MethodInvoker)(() => labelRand.Font = new Font("Verdana", 16, FontStyle.Bold)));
                        labelSrt.Invoke((MethodInvoker)(() => labelSrt.Font = new Font("Verdana", 16, FontStyle.Bold)));
                    }

                    randNumbers.Add(numbers[r]);
                    labelOneSort.Invoke((MethodInvoker)(() => labelOneSort.Visible = true));
                    RandFontColour(labelOneSort);
                    labelOneSort.Invoke((MethodInvoker)(() => labelOneSort.Text = randNumbers[i].ToString()));
                    labelRand.Invoke((MethodInvoker)(() => labelRand.Text += randNumbers[i].ToString() + " "));
                    numbers[r] = numbers[thr.n - 1];
                    thr.n--;

                    if (i == thr.k - 1)
                    {
                        plus = (int)randNumbers[i];
                    }


                }
                labelOneSort.Invoke((MethodInvoker)(() => labelOneSort.Visible = false));

                labelGoodLuck.Invoke((MethodInvoker)(() => labelGoodLuck.Visible = true));
                randNumbers.Sort();

                labelSrt.Invoke((MethodInvoker)(() => labelSrt.Text = ""));

                foreach (int numb in randNumbers)
                labelSrt.Invoke((MethodInvoker)(() => labelSrt.Text += numb.ToString() + " "));

                labelSorted.Invoke((MethodInvoker)(() => labelSorted.Visible = true));
                labelSrt.Invoke((MethodInvoker)(() => labelSrt.Visible = true));

                if (checkBoxPlus.Checked)
                {
                    labelPlus.Invoke((MethodInvoker)(() => labelPlus.Visible = true));
                    labelPlus.Invoke((MethodInvoker)(() => labelPlus.Text = $"Liczba {plus} będzie plusem!"));

                }


            }


        }

        private void Clear()
        {
            labelRand.Text = "";
            labelGoodLuck.Visible = false;
            labelSorted.Visible = false;
            labelSrt.Visible = false;
            labelOneSort.Visible = false;
            labelPlus.Visible = false;
            textBox1.Visible = false;
            labelHowMuch.Visible = false;
            checkBoxPlus.Visible = false;
            labelRand.Font = new Font("Verdana", 20, FontStyle.Bold);
            labelSrt.Font = new Font("Verdana", 20, FontStyle.Bold);

        }
        private void labelRand_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void buttonSort_Click(object sender, EventArgs e)
        {

        }

        private void RandFontColour(Label myLabel)
        {
            int n = 256;
            Random rand = new Random();

            int d = rand.Next(n);
            int e = rand.Next(n);
            int f = rand.Next(n);
            myLabel.ForeColor = Color.FromArgb(d, e, f);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

