using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ativador
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        int numAtivador = 19922013;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = random.Next(1000000,10000000).ToString();
            random.Next();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                if(Convert.ToInt32(label1.Text) - Convert.ToInt32(textBox1.Text) == numAtivador)
                {
                    label2.Text = "SOFTWARE ATIVADO";
                }
                else
                {
                    MessageBox.Show("Serial invalido!", "MENSAGEM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    label2.Text = "SOFTWARE NÃO REGISTRADO!";
                }                
            }
        }
    }
}
