using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineShoping
{
    public partial class ProductContainer : UserControl
    {
        NewProductClass NewPro = new NewProductClass();
        public ProductContainer()
        {
            InitializeComponent();
        }

        public ProductContainer( NewProductClass NPro )
        {
            InitializeComponent();
            this.NewPro = NPro;

        }

        private void ProductContainer_Load(object sender, EventArgs e)
        {
            NProName.Text = NewPro.name;
            NProPrice.Text = NewPro.price.ToString();
            NproDis.Text = NewPro.disc;

        }
    }
}
