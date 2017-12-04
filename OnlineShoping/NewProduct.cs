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
        public NewProduct()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            ProductsManagement newMang = new ProductsManagement();
            newMang.Show();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            NewProductClass NewP = new NewProductClass();
            NewP.name = ProName.Text;
            NewP.disc = ProDis.Text;
            NewP.price = ProPrice.Value;
            ProductContainer con = new ProductContainer(NewP);
            
        }
    }
}
