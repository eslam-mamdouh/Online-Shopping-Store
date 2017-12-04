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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            for(int i = 0 ; i<7 ; i++)
            {
                flowLayoutPanel1.Controls.Add(new ProductContainer());
            }
      
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProductsManagement manag = new ProductsManagement();
            manag.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Cart cart = new Cart();
            cart.Show();
            //CartManagement cart = new CartManagement();
            //Controls.Add(cart);
            //cart.Visible = true;
            //cart.Hide();
            //cart.SendToBack();
            //cart.Visible = false;
            //cart.BringToFront();
          
        }

        private void button1_Click(object sender, EventArgs e)
        {

            /*Products pro = new Products();
            Controls.Add(pro)
            pro.BringToFront();
            /*Products pro = new Products();
            Controls.Add(pro);
            //pro.Visible = false;
            //pro.Show();
            pro.BringToFront();*/
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login logagain = new Login();
            logagain.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            UserByAdmin nuser = new UserByAdmin();
            nuser.Show();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {


        }

       
    }
}
