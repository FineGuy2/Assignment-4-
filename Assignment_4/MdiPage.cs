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
    public partial class MdiPage : Form
    {
        Form Login;
        String Username;
        public MdiPage(String username , Form LoginP)
        {
            InitializeComponent();
            Username = username;
            Login = LoginP;
        }

        private void addNewProductToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }

            HomePage HomeScreen = new HomePage(Username ,Login);
            
            HomeScreen.MdiParent = this;
            
            HomeScreen.Show();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}
