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
    public partial class Products : UserControl
    {
        public Products()
        {
            InitializeComponent();
           /* for (int i = 0; i < 5; i++)
            {
                main_container.Controls.Add(new ProductContainer());
            }*/
        }

        private void UserManagment_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        
        private void Pro_Container_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void main_container_Paint(object sender, PaintEventArgs e)
        {
            
            /*for (int i = 0; i < 3; i++)
            {
                ProductContainer newpro = new ProductContainer();
                newpro.Margin.Left.Equals(20);
                newpro.BringToFront();
                Controls.Add(newpro);

                ProductContainer newpro1 = new ProductContainer();
                newpro1.Margin.Left.Equals(20);
                newpro1.BringToFront();
                Controls.Add(newpro1);
                
            //}*/
        }

       
    }
}
