using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Assignment_4.model;
namespace Assignment_4
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Product p = new Product
            {
                Number = int.Parse(txtNum.Text),
                Date = dtpDate.Text,
                InvNumber = int.Parse(txtInvNum.Text),
                ObjName = txtObjName.Text,
                Count = int.Parse(txtCount.Text),
                Price = double.Parse(txtPrice.Text),
                Availability = chkAvailablity.Checked,
            };

            p.Save();

            string CheckedItem = " ";
            foreach (var item in chkOption.CheckedItems)
            {
                CheckedItem += item.ToString();

            }
            MessageBox.Show(CheckedItem);



            dgvShowData.DataSource = null;
            dgvShowData.DataSource = Product.GetAllProducts();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNum.Text = " ";
            dtpDate.Value = DateTime.Now;
            txtInvNum.Text = " ";
            txtObjName.Text = " ";
            txtCount.Text = " ";
            txtPrice.Text = " ";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
