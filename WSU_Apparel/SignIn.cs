using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSU_Apparel
{
    public partial class SignIn : Form
    {
        string passWord = "";
        public bool loggedIn = false;
        public bool userLoggedIn = true;
        Manager manager = new Manager();
        User user = new User();


        /***************************************************************
         * Author: Anthony Simmons                                      *
         * Assignment: Homework #4 WSU Apparel      	 				*
         * Course: CptS 422 - Software Testing							*
         * Date: October 7, 2013								        *
         * Function Name: SignIn()          		    			    *
         * Description: Constructs the SignIn Form UI                   *
         * Preconditions: None											*
         * Postconditions: None			        						*
         ****************************************************************/
        public SignIn()
        {
            InitializeComponent();

            this.ForeColor = Color.Gray;
            this.BackColor = Color.Maroon;

            this.btnEnterSignIn.BackColor = Color.Gray;
            this.btnEnterSignIn.ForeColor = Color.Maroon;

            this.tbxUserName.BackColor = Color.Gray;
            this.tbxUserName.ForeColor = Color.Maroon;

            this.tbxPassword.BackColor = Color.Gray;
            this.tbxPassword.ForeColor = Color.Maroon;

        }


        /***************************************************************
         * Author: Anthony Simmons                                      *
         * Assignment: Homework #4 WSU Apparel      	 				*
         * Course: CptS 422 - Software Testing							*
         * Date: October 7, 2013								        *
         * Function Name: tbxPassword_KeyPress()	    			    *
         * Description: Replace password w/ *                           *
         * Preconditions: None											*
         * Postconditions: None			        						*
         ****************************************************************/
        private void tbxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            byte[] ascii = Encoding.ASCII.GetBytes(e.KeyChar.ToString());
            if (ascii[0] >= 65 && ascii[0] <= 122)
            {
                passWord += e.KeyChar.ToString();
                tbxPassword.Text = "";
                string str = "";
                for (int i = 0; i < passWord.Length-1; i++)
                {
                    str += "*";
                }
                tbxPassword.Text = str;
                tbxPassword.SelectionStart = str.Length;
            }
        }


        /***************************************************************
         * Author: Anthony Simmons                                      *
         * Assignment: Homework #4 WSU Apparel      	 				*
         * Course: CptS 422 - Software Testing							*
         * Date: October 7, 2013								        *
         * Function Name: tbxPassword_KeyDown()		    			    *
         * Description: Handle BackSpace Key and Enter Key              *
         * Preconditions: None											*
         * Postconditions: None			        						*
         ****************************************************************/
        private void tbxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                string tmp = passWord;
                passWord = "";
                for (int i = 0; i < tmp.Length-1; i++)
                {
                    passWord += tmp[i].ToString();
                }
            }
            if (e.KeyCode == Keys.Enter)
            {
                doLogIn();   
            }
        }
        

        /***************************************************************
         * Author: Anthony Simmons                                      *
         * Assignment: Homework #4 WSU Apparel      	 				*
         * Course: CptS 422 - Software Testing							*
         * Date: October 7, 2013								        *
         * Function Name: doLogIn()         		    			    *
         * Description: Checks if username and password match           *
         * Preconditions: None											*
         * Postconditions: None			        						*
         ****************************************************************/
        private void doLogIn()
        {
            if (passWord == manager.passWord && tbxUserName.Text == manager.userName)
            {
                userLoggedIn = false;
                loggedIn = true;
            }
            if(passWord == user.passWord && tbxUserName.Text == user.userName)
            {
                userLoggedIn = true;
                loggedIn = true;
            }
            if(loggedIn)
            {
                if (userLoggedIn)
                {
                    MessageBox.Show(user.userName+" Logged In");
                    this.Close();
                }
                else
                {
                    MessageBox.Show(manager.userName+" Logged In");
                    this.Close();
                    //drawImage();
                }
            }
            else
            {
                MessageBox.Show("Invalid User Name / Password");
                loggedIn = false;
            }
        }

        private void btnEnterSignIn_Click(object sender, EventArgs e)
        {
            doLogIn();
        }
    }

    public class Manager
    {
        public string userName = "Butch";
        public string passWord = "goCougs";
    }
    public class User
    {
        public string userName = "user";
        public string passWord = "password";
    }
}
