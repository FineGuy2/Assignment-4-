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
    public partial class ProoductCard : UserControl
    {
        public ProoductCard()
        {
            InitializeComponent();
        }
        private String _PcId;

        public String PcId
        {
            get { return _PcId; }
            set { _PcId = value; lblPcId.Text = PcId; }
        }
        private String _PcName;

        public String PcName
        {
            get { return  _PcName; }
            set {  _PcName = value; lblPcName.Text = PcName; }
        }

        private String _PcPrice;

        public String PcPrice
        {
            get { return _PcPrice; }
            set { _PcPrice = value; lblPcPrice.Text = PcPrice; }
        }


    }
}
