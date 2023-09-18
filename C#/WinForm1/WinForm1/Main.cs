using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm1
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        public Main(String Message): this()
        {
           this.lbwelcome.Text = "WELCOME " + Message;
        }
      

        private void Form2_Load_1(object sender, EventArgs e)
        {
            PictureBox pb1 = new PictureBox();
            pb1.Image = Image.FromFile("C://Users//ADMIN//Desktop//VNA.jpg");
            pb1.SizeMode = PictureBoxSizeMode.AutoSize;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
