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
    public partial class ProductShower : UserControl
    {
        public ProductShower()
        {
            InitializeComponent();
        }
        private String _PSid;

        public String PSid
        {
            get { return _PSid; }
            set { _PSid = value; lblPSId.Text = PSid; }
        }
        private String _PSName;

        public String PSName
        {
            get { return _PSName; }
            set { _PSName = value; lblPSName.Text = PSName; }
        }
        private String _PSPrice;

        public String PSPrice
        {
            get { return _PSPrice; }
            set { _PSPrice = value; lblPSPrice.Text = PSPrice; }
        }



    }
}
