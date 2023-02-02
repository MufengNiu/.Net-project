namespace Assignment_2
{
    partial class LoginWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
       
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.usernameInput = new System.Windows.Forms.TextBox();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // usernameInput
            // 
            this.usernameInput.Location = new System.Drawing.Point(297, 161);
            this.usernameInput.Name = "usernameInput";
            this.usernameInput.Size = new System.Drawing.Size(354, 42);
            this.usernameInput.TabIndex = 0;
            // 
            // passwordInput
            // 
            this.passwordInput.Location = new System.Drawing.Point(297, 246);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.Size = new System.Drawing.Size(354, 42);
            this.passwordInput.TabIndex = 1;
            this.passwordInput.UseSystemPasswordChar = true;
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.LoginButton.Location = new System.Drawing.Point(347, 319);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(228, 54);
            this.LoginButton.TabIndex = 2;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // RegisterButton
            // 
            this.RegisterButton.Location = new System.Drawing.Point(313, 404);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(301, 52);
            this.RegisterButton.TabIndex = 3;
            this.RegisterButton.Text = "New User";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(37, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 35);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter Username";
            this.label1.UseMnemonic = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(37, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 35);
            this.label2.TabIndex = 5;
            this.label2.Text = "Enter Password";
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.White;
            this.ExitButton.Location = new System.Drawing.Point(579, 715);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(130, 48);
            this.ExitButton.TabIndex = 6;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(252, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 35);
            this.label4.TabIndex = 8;
            this.label4.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(252, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 35);
            this.label5.TabIndex = 9;
            this.label5.Text = "*";
            // 
            // LoginWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(721, 803);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.passwordInput);
            this.Controls.Add(this.usernameInput);
            this.Name = "LoginWindow";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

    

        private TextBox usernameInput;
        private TextBox passwordInput;
        private Button LoginButton;
        private Button RegisterButton;
        private Label label1;
        private Label label2;
        private Button ExitButton;
        private Label label4;
        private Label label5;
    }
}