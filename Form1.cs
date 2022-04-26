using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace login_sistema
{
    public partial class Form1 : Form
    {
        Thread form;

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Ana Luiza" && textBox2.Text == "Bce@123456")
            {
                this.Close();
                form = new Thread(novoForm);
                form.SetApartmentState(ApartmentState.STA);
                form.Start();
            }
                 else
            {
                MessageBox.Show("Inválido.");
            }
             
           }
        private void novoForm()
        {
            Application.Run(new Form2());
        }
        }
    }

