using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace OnlineShoping
{
    public partial class SignUp : Form
    {
        SignUpClass NewUser = new SignUpClass();
        public SignUp()
        {
            InitializeComponent();

        }
        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            Login log = new Login();
            log.Show();
        }

        public void btn_sign_Click(object sender, EventArgs e)
        {
            
            NewUser.username = ProName.Text;
            NewUser.pass = ProPrice.Text;
            this.Close();
            Login log = new Login(NewUser);
            log.Show();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            
        }
    }
}
