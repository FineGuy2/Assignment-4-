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
    public partial class DetailPage : Form
    {
        public DetailPage()
        {
            InitializeComponent();
        }

        private String _DpNum;

        public String DpNum
        {
            get { return _DpNum; }
            set { _DpNum = value; lblDpPID.Text = DpNum; }

        }
        private String _DpInvNum;

        public String DpInvNum
        {
            get { return _DpInvNum; }
            set { _DpInvNum = value; lblDpInvNum.Text = DpInvNum; }
        }
        private String _DpObjName;

        public String DpObjName
        {
            get { return _DpObjName; }
            set { _DpObjName = value; lblDpName.Text = DpObjName; }
        }
        private String _DpRegDate;

        public String DPregDate
        {
            get { return _DpRegDate; }
            set { _DpRegDate = value; lblDpRdate.Text = DPregDate; }
        }
        private String _DpCount;
        public String DpCount
        {
            get { return _DpCount; }
            set { _DpCount = value; lblDpCount.Text = DpCount;  }
        }

        private String _DpPrice;

        public String DpPrice
        {
            get { return _DpPrice; }
            set { _DpPrice = value; lblDpPrice.Text = DpPrice; }
        }







    }
}
