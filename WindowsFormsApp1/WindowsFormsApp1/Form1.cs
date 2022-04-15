using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            RSA rSA = new RSA();
            decryption.Text = rSA.Encrypt(encryption.Text, key.Text);
        }

        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
            RSA rSA = new RSA();
            encryption.Text = rSA.Decrypt(decryption.Text, key.Text);
        }
    }
}
