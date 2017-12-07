using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace OnlineShoping
{
    public partial class NewProduct : Form
    {
        LinkedList<ProductContainer> StoragePro = new LinkedList<ProductContainer>();
        DataSet ds = new DataSet();
        
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
               
                DataTable dt = new DataTable();
                dt.Columns.Add(new DataColumn("Product_Name", Type.GetType("System.String")));
                dt.Columns.Add(new DataColumn("Product_Disc", Type.GetType("System.String")));
                dt.Columns.Add(new DataColumn("product_Price", Type.GetType("System.Int32")));
                ds.Tables.Add(dt);
                ds.Tables[0].TableName = "products";

                int count=0;
                while (count < AmountOfPro.Value)
                {
                    ProductContainer NPro = new ProductContainer();
                    NPro.name = ProName.Text;
                    NPro.disc = ProDis.Text;
                    NPro.price = ProPrice.Value; 
                    StoragePro.AddLast(NPro);

                    count++;

                }

                foreach (var pro in StoragePro)
                {
                    DataRow dr;
                    dr = dt.NewRow();
                    dr["Product_Name"] = pro.name;
                    dr["Product_Disc"] = pro.disc;
                    dr["product_Price"] = pro.price;
                    dt.Rows.Add(dr);
                    ds.WriteXml("Products.xml");

                }

                MessageBox.Show("Product Created Successfully ");
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
