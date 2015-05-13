using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProductInfoAPP.BAL;
using ProductInfoAPP.Model;

namespace ProductInfoAPP
{
    public partial class ProductEntryUI : Form
    {
        public ProductEntryUI()
        {
            InitializeComponent();
        }

        ProductManager aProductManager = new ProductManager();
        private void saveButton_Click(object sender, EventArgs e)
        {
            Product aProduct = new Product();

            string productCode = productCodeTextBox.Text;
            string description = descriptionTextBox.Text;
            int quantity = Convert.ToInt32(quantityTextBox.Text);

            aProduct.prductCode = productCode;
            aProduct.description = description;
            aProduct.quantity = quantity;
            

            bool insertResult = 
        }
    }
}
