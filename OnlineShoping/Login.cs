using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OnlineShoping
{
    public partial class Login : Form
    {
        Users NewUser = new Users();
       
        public Login()
        {
            InitializeComponent();
            
        }

        public Login(Users NewUser)
        {
            InitializeComponent();
            this.NewUser = NewUser;


        }
       

        private void btnCreate_Click(object sender, EventArgs e)
        {

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        public void btn_login_Click(object sender, EventArgs e)
        {
            if(UserName.Text ==NewUser.name  && Password.Text == NewUser.password )
            {
                this.Hide();
                Form1 main = new Form1();
                main.Show();
            }
            if (UserName.Text == "1" && Password.Text == "1")
            {
                this.Hide();
                Form1 main = new Form1();
                main.Show();
            }
            else
            {
                MessageBox.Show("UserName or Password is Not Valid !");
            }
            /*SqlConnection myConnection = new SqlConnection("Data Source=DESKTOP-NHUPJV2;Initial Catalog=shopping;");
            string query = "select username , password from users where username='" + UserName.Text + "'and Password='" + Password.Text;
            try
            {
                myConnection.Open();
                SqlCommand myCommand = new SqlCommand(query, myConnection);
                DataTable dt = new DataTable();
                if (dt.Rows.Count == 1)
                {
                    this.Hide();
                    Form1 main = new Form1();
                    main.Show();
                }
                else
                {
                    MessageBox.Show("UserName or Password is Not Valid !");
                }

            }
            catch(Exception ex)
            {
                ex.Message.ToString();
                MessageBox.Show("Can not open connection ! ");

            }
           */
           
           
            
            
        }

        private void btn_sign_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            SignUp reg = new SignUp();
            reg.Show();
        }
    }
}
