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
        Modify modify = new Modify();
         public void button1_Click(object sender, EventArgs e)
        {
            string tentk = txtusername.Text;
            string mk = txtpassword.Text;
            if (tentk.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tài khoản!");
            }
            else if (mk.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!");
            }
            else
            {
                string query = "select * from Taikhoan where tentaikhoan='" + tentk + "' and matkhau='"+mk+"'";
                if (modify.taiKhoan(query).Count>0)
                {
                    Main main = new Main(tentk);
                    Login login = new Login();
                    main.Show();
                    login.Close();
                }
                else
                {
                    MessageBox.Show("Tên tài khoản hoặc mật khẩu sai!");
                }
            }
        }

       
      
    }
}
