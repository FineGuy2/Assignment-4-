using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Assignment_4.model;
namespace Assignment_4
{
    public partial class HomePage : Form
    {
        Form LoginPage;
        public HomePage(String Username , Form f)
        {
            InitializeComponent();
            lblUser.Text = Username;
            LoginPage = f;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            Regex NumVal = new Regex($"[0-9]{3}-[0-9]{3} ");
            Regex NameVal = new Regex($"[A-Z]{1}-[a-z]");
            
            if (string.IsNullOrEmpty(txtCount.Text) || string.IsNullOrEmpty(txtPrice.Text) || string.IsNullOrEmpty(txtInvNum.Text) || string.IsNullOrEmpty(txtObjName.Text) || string.IsNullOrEmpty(txtNum.Text))
            {
                
                if (!NumVal.IsMatch(txtNum.Text))
                {
                    Wrong.SetError(txtNum, "Only [0-9] is Accepted");
                    txtNum.Text = "";
                }
                else
                {
                    Wrong.SetError(txtNum, "");
                }
                
                if (!NumVal.IsMatch(txtInvNum.Text))
                {
                    Wrong.SetError(txtInvNum, "Only [0-9] is Accepted");
                    txtInvNum.Text = "";
                }
                else
                {
                    Wrong.SetError(txtInvNum, "");
                }
                if (!NumVal.IsMatch(txtPrice.Text))
                {
                    Wrong.SetError(txtPrice, "Only [0-9] is Accepted");
                    txtPrice.Text = "";
                }
                else
                {
                    Wrong.SetError(txtPrice, "");
                }
                if (!NumVal.IsMatch(txtCount.Text))
                {
                    Wrong.SetError(txtCount, "Only [0-9] is Accepted");
                    txtCount.Text = "";
                }
                else
                {
                    Correct.SetError(txtCount, "");
                }
                if (!NameVal.IsMatch(txtObjName.Text))
                {
                    Wrong.SetError(txtObjName, "Capitalize The First letter and only [a-z] is accepted");
                    txtObjName.Text = "";
                }
                else
                {
                    Wrong.SetError(txtObjName, "");
                }
            }
            else
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



              

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNum.Text = " ";
            dtpDate.Value = DateTime.Now;
            txtInvNum.Text = " ";
            txtObjName.Text = " ";
            txtCount.Text = " ";
            txtPrice.Text = " ";

            Correct.Clear();
            Wrong.Clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Login screen = new Login();
            screen.Show();
            Hide();

        }
    }
}
