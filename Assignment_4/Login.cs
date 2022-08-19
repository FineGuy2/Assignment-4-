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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
<<<<<<< Updated upstream
            String Username = txtUserName.Text;
            String Password = txtPassword.Text;

            HomePage Screen = new HomePage(Username ,this);

            Screen.Show();
            Hide();
=======

            if (String.IsNullOrEmpty(txtUserName.Text) || String.IsNullOrEmpty(txtPassword.Text)) {
                if (String.IsNullOrEmpty(txtPassword.Text))
                {
                    Wrong.SetError(txtPassword, " Password Can't be empty ");
                }
                else
                {
                    Correct.SetError(txtPassword, " Accepted ");

                }
                if (String.IsNullOrEmpty(txtUserName.Text))
                {
                    Wrong.SetError(txtUserName, " Username Can't be empty ");
                }
                else
                {
                    Correct.SetError(txtUserName, " Accepted ");
                }


            }
            

            else {
              


                String Username = txtUserName.Text;
                String Password = txtPassword.Text;

                if (Username == "Admin" && Password == "0")
                {
                    
                    MdiPage Screen = new MdiPage(Username, this);

                    Screen.Show();
                    Hide();
                }
                else
                {
                   
                    if (Username != "Admin")
                    {
                       
                            Wrong.SetError(txtUserName, "Incorrect Username");
                    }
                    else
                    {
                        
                            Wrong.SetError(txtPassword, "Incorrect Password");
                    }
                        
                    
                }
            }
>>>>>>> Stashed changes

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtUserName.Text = "";
            txtPassword.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
