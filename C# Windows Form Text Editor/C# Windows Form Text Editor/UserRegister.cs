namespace Assignment_2
{
    public partial class UserRegister : Form
    {
        // Previous login window
        private LoginWindow loginWindow;

        // Pass accounts hashmap for repeated username check , and add new created account to it
        private Dictionary<String, Account> accounts;

        public UserRegister(LoginWindow loginWindow, Dictionary<String, Account> accounts)
        {
            InitializeComponent();
            this.loginWindow = loginWindow;
            this.accounts = accounts;
        }

        public void registerForm_Load(object sender , EventArgs e)
        {
            userTypeInput.SelectedItem = null;
            userTypeInput.SelectedText = "View";
        }

        
        private void submitButton_Click(object sender, EventArgs e)
        {
            String username = usernameInput.Text;
            String password = passwordInput.Text;
            String passwordCheck = passwordInput2.Text;
            String firstname = firstnameInput.Text;
            String lastname = lastnameInput.Text;
            String dateOfBirth = dateOfBirthInput.Text;
            String usertype = (String)userTypeInput.SelectedItem;

            // Check whether all field is filled
            if (username == "" || password == "" || passwordCheck == "" ||
                firstname == "" || lastname == "" || usertype == "")
            {
                MessageBox.Show("Please enter all nececssary fields", "Error",
                       MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            // Check for username repeated
            else if (accounts.ContainsKey(username))
            {
                MessageBox.Show("Account name already existed, Please try another one", "Error",
                       MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            // Check for whether two password input is the same
            else if (!password.Equals(passwordCheck))
            {
                MessageBox.Show("Passwords must match", "Error",
                       MessageBoxButtons.OK, MessageBoxIcon.Stop);
            // Can not contain comma as it is used as delimiter
            }else if (username.Contains(",") || password.Contains(",") || firstname.Contains(",") || lastname.Contains(","))
            {
                MessageBox.Show("Your input cannot include a comma", "Error",
                       MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                Account newAccount = new Account(username, password, usertype, firstname, lastname, dateOfBirth);

                if (newAccount.storeAccount())
                {
                    MessageBox.Show("Account created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    accounts.Add(newAccount.getUsername(), newAccount);
                    Close();
                    loginWindow.Show();
                }
                else
                {
                    MessageBox.Show("Account information store failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Hide();
            loginWindow.Show();
        }

    }
}
