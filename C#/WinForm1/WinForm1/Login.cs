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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        String username = "leminhphuc";
        String password = "123456";
         public void button1_Click(object sender, EventArgs e)
        {
            //String txtusername = this.txtusername.Text;
            //String txtpassword = this.txtpassword.Text;
            //if (txtusername == "")
            //{
            //    MessageBox.Show("Enter your username!");
            //}
            //else if (txtpassword == "")
            //{
            //    MessageBox.Show("Enter your password");
            //}
            //else
            //{
            //    if (txtusername != username || txtpassword != password)
            //    {
            //        MessageBox.Show("Username or password is wrong");
            //    }
            //    else
            //    {
                    
            //        Main form2 = new Main(txtusername);
            //        form2.Show();
            //        this.Hide();
            //    }
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      
    }
}
