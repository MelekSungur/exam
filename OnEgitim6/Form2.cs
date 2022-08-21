using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnEgitim6
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        List<Product>products=new List<Product>();
        Product urun=new Product();
        
        
        int sayac = 0;
        private void btnSave_Click(object sender, EventArgs e)
        {

            urun.productName = txtPName.Text;
            urun.productQuantity = Convert.ToInt32(txtPQuantity.Text);
            urun.productPrice = Convert.ToInt32(txtPrice.Text);
           products.Add(urun);
            
            Product prd = new Product();
            prd.productName = txtPName.Text;
            prd.productQuantity = Convert.ToInt32(txtPQuantity.Text);
            prd.productPrice = Convert.ToInt32(txtPrice.Text);
            products.Add(prd);
            txtPName.Text = " ";
            txtPQuantity.Text = " ";
            txtPrice.Text = " ";
            txtPName.Focus();

            
          
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            string urunAdi = products[0].productName;
            int urunAdedi = products[0].productQuantity;
            int urunFiyati = products[0].productPrice;
            lstList.Items.Add(urunAdi + "/" + urunAdedi + "-" + urunFiyati);
        }
        
        

        private void btnDiziyeAktar_Click(object sender, EventArgs e)
        {
            



        }

        private void btnElemanSayisi_Click(object sender, EventArgs e)
        {
            //ürünün adını product listin içinden okuyacak 
            urun.productName = txtPName.Text;
            products[sayac] = urun.productName;
        }
    }
}
