using System;
using System.Windows.Forms;

namespace Aula12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int num;
        string msg;

        public void FOR()
        {
            msg = "";

            for (int i = 0; i <= num; i++)
            {
                if (i % 2 == 0 && i % 7 == 0)
                {
                    msg += '\n' + '\n' + "Número " + i + " é divisível por 2 e 7.";
                }
            }
            TXTFINAL.Text = msg;

        }

        public void WHILE()
        {
            msg = "";
            int i = 0;
            do
            {
                msg += "\n\n" + i + " X " + num + " = " + (num * i) + System.Environment.NewLine;
                i++;
            } while (i < 11);
            TXTFINAL.Text = msg;
        }

        private void BTNFOR_Click(object sender, EventArgs e)
        {

            try
            {

                num = int.Parse(TXTNUMBER.Text);
                if (num < 2 || num > 200)
                {
                    TXTNUMBER.Focus();
                }
                else
                {
                    FOR();
                }
            }
            catch
            {
                TXTNUMBER.Focus();
                MessageBox.Show("Numero errado!");
            }
        }

        private void BTNWHILE_Click(object sender, EventArgs e)
        {

            try
            {
                num = int.Parse(TXTNUMBER.Text);
                WHILE();

            }
            catch
            {
                TXTNUMBER.Focus();
                MessageBox.Show("Numero errado!");
            }
        }
    }
}
