using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Assignment_2
{
    public partial class LoginWindow : Form
    {
        private Dictionary<String, Account> accounts;

        public LoginWindow()
        {
            InitializeComponent();
            accounts = new Dictionary<string, Account>();
            storeAccounts();
        }

        // Store all username and accounts combination to a hashmap
        private void storeAccounts()
        {
            String fileLocation = "login.txt";

            if (File.Exists(fileLocation))
            {
                String[] lines = File.ReadAllLines(fileLocation);
                foreach (string line in lines)
                {

                    Account newAccount = new Account(line.Split(",")[0] , line.Split(",")[1] , 
                        line.Split(",")[2], line.Split(",")[3] , line.Split(",")[4] , line.Split(",")[5]);

                    accounts.Add(line.Split(",")[0], newAccount);
                }

            }
            else
            {
                MessageBox.Show("Accounts file not exist", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }


        private void LoginWindow_Load(object sender, EventArgs e)
        {
            
        }

        // lOGIN IN BUTTON click event , check whether input mathch the username-password combination
        private void LoginButton_Click(object sender, EventArgs e)
        {
            String userName = usernameInput.Text;
            String password = passwordInput.Text;

            if(userName == "" || password == "")
            {
                MessageBox.Show("Please Enter both username and password", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                if (accounts.ContainsKey(userName) && accounts[userName].getPassword().Equals(password))
                {
                    //load all account information based on given username
                    Account newAccount = accounts[userName];
          
                    // Valid input, direct to Text Editor Window
                    TextEditor newEditor = new TextEditor(newAccount);
                    Hide();
                    newEditor.Show();
                }
                else
                {
                    // Invalid input.
                    MessageBox.Show("Incorrect username or password, Please try again", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        // Go to registration window
        public void RegisterButton_Click(object sender, EventArgs e)
        {
            Hide();
            UserRegister register = new UserRegister(this , accounts);
            register.Show();
        }

        private void ExitButton_Click(object sender , EventArgs e)
        {
            System.Environment.Exit(0);
        }

    }
}
