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

        public string name;
        public string disc ;
        public decimal price;
        
        public ProductContainer()
        {
            InitializeComponent();
        }



        private void ProductContainer_Load(object sender, EventArgs e)
        {
            NProName.Text = this.name;
            NProPrice.Text = this.price.ToString();
            NproDis.Text =  this.disc;

        }
    }
}
