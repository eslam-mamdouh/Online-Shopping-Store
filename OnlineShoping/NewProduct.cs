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
    public partial class NewProduct : Form
    {
        LinkedList<ProductContainer> StoragePro = new LinkedList<ProductContainer>();

        
        public NewProduct()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 data = new Form1(StoragePro);
            this.Hide();
            data.Show();
           // ProductsManagement newMang = new ProductsManagement();
            //newMang.Show();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                
                ProductContainer NPro = new ProductContainer();
                NPro.name = ProName.Text;
                NPro.disc = ProDis.Text;
                NPro.price = ProPrice.Value;
                if (StoragePro.Count == 0)
                {

                    StoragePro.AddFirst(NPro);
                    MessageBox.Show("Product Created Successfully ");
                }

                else
                {
                    
                    StoragePro.AddLast(NPro);
                    MessageBox.Show("Product Created Successfully ");
                    
                }


            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }



        }

        private void NewProduct_Load(object sender, EventArgs e)
        {

        }
    }
}
