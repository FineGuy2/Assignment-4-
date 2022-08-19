using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_4
{
    public partial class ProductCardShower : Form
    {
        public ProductCardShower()
        {
            InitializeComponent();
        }

        private void ProductCardShower_Load(object sender, EventArgs e)
        {
            flpPCS.Controls.Clear();

            foreach (var item in model.Product.GetAllProducts())
            {
                ProductCard pc = new ProductCard() {
                    PcId = item.InvNumber.ToString(),
                    PcName = item.ObjName,
                    PcPrice = item.Price.ToString(),
                    
                };
                //     pc.Click += Custom;
                pc.Click += (object o, EventArgs ev) =>
                {
                    DetailPage Dp = new DetailPage()
                    {
                        DpNum = item.Number.ToString(),
                        DpInvNum = item.InvNumber.ToString(),
                        DpObjName = item.ObjName,
                        DPregDate = item.Date,
                        DpPrice = item.Price.ToString(),
                        DpCount = item.Count.ToString(),
                    };
                    Dp.Show();
                    Hide();
                };
                flpPCS.Controls.Add(pc);
            }

        }
        /*
        private void Custom(object sender,EventArgs e)
        {
            MessageBox.Show(" Clicked ");
        }*/

        private void btnGreen_Click(object sender, EventArgs e)
        {
            flpPCS.BackColor= Color.Green;
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            flpPCS.BackColor = Color.Red;
        }

        private void btnAqua_Click(object sender, EventArgs e)
        {
            flpPCS.BackColor = Color.Aqua;
        }
    }
}
