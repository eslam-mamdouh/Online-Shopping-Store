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
using System.IO;
using System.Xml;

namespace OnlineShoping
{
    public partial class Form1 : Form
    {
        LinkedList<ProductContainer> StoragePro;
       // private ProductContainer NPro;

        public Form1()
        {
            InitializeComponent();

           
            /*ProductContainer pro1 = new ProductContainer();
            pro1.name = "Eslam";
            pro1.price = 530;
            pro1.disc = "Esla  smnadb damb jhsajc jhsakf fksajfiw jyw iwfhwe voidue b";
            flowLayoutPanel1.Controls.Add(pro1);
            ProductContainer pro2 = new ProductContainer();
            pro2.name = "smsm";
            pro2.price = 530;
            pro2.disc = "Esla  smnadb ;slv';d.s'v.d's ,;lsmdkfvnks jhsajc jhsakf fksajfiw jyw iwfhwe voidue b";
            flowLayoutPanel1.Controls.Add(pro2);

            /*try
            {
                var current = StoragePro.First.Next;
                while (current != null)
                {

                    flowLayoutPanel1.Controls.Add(current.Value);
                }
            }
            catch(Exception exx)
            {
                MessageBox.Show(exx.Message);
            }
           /* for(int i = 0 ; i<7 ; i++)
            {
                ProductContainer pro = new ProductContainer();
                
                flowLayoutPanel1.Controls.Add(pro);
            }*/
      
        }


        public Form1(LinkedList<ProductContainer> StoragePro)
        {
            InitializeComponent();
            //this.StoragePro = StoragePro;
            //var current = StoragePro.First;
            //while(current != null)
            //{
            //    ProductContainer pro = new ProductContainer();
            //    pro.name = current.Value.name;
            //    pro.disc = current.Value.disc;
            //    pro.price = current.Value.price;
            //    flowLayoutPanel1.Controls.Add(pro);
            //    current = current.Next;
            //}
        }
        //ProductContainer Npro = new ProductContainer();
        public Form1(ProductContainer NPro)
        {
            InitializeComponent();
            // TODO: Complete member 
            flowLayoutPanel1.Controls.Add(NPro);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            try
            {

                StoragePro = new LinkedList<ProductContainer>();
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load("products.xml");
                XmlNodeList nodes = xmlDoc.DocumentElement.ChildNodes;
                foreach (XmlNode node in nodes)
                {
                    ProductContainer pro = new ProductContainer();
                    pro.name = node["Product_Name"].InnerText;
                    pro.disc = node["Product_Disc"].InnerText;
                    //pro.price = node["product_Price"].InnerXml;
                    StoragePro.AddLast(pro);

                }
                foreach (ProductContainer p in StoragePro)
                {
                    ProductContainer pro = new ProductContainer();
                    pro.name = p.name;
                    pro.disc = p.disc;
                    pro.price = 200;
                    flowLayoutPanel1.Controls.Add(pro);

                }
            }catch(Exception er)
            {
                MessageBox.Show(er.Message);
            }
            //LinkedList<object> Link = new LinkedList<object>();
            //NewProductClass P = new NewProductClass();
            //P.name = "Mobile";
            //File.AppendAllText("File.txt", P.name);
            //P.price = 2000;
            //File.AppendAllText("File.txt", P.price.ToString());
            //P.disc = "Eslam mamdouh mohamed";
            //File.AppendAllText("File.txt", P.disc);
            ////Link.AddLast(P);
            ////object[] data = Link.ToArray();
            //////string data = P.ToString();
            ////File.WriteAllText("File.txt", data.ToString());
            //test.Text = File.ReadAllText("File.txt");
            
            

            


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
            this.Hide();
            UserByAdmin nuser = new UserByAdmin();
            nuser.Show();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {


        }

        private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

     

       
    }
}
