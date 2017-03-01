namespace LearnToType
{
    partial class Login
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
            this.materialCheckBox4 = new MaterialSkin.Controls.MaterialCheckBox();
            this.PasswordField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.UsernameField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.RegisterLink = new System.Windows.Forms.LinkLabel();
            this.AccountQuestion = new MaterialSkin.Controls.MaterialLabel();
            this.LoginButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // materialCheckBox4
            // 
            this.materialCheckBox4.AutoSize = true;
            this.materialCheckBox4.Depth = 0;
            this.materialCheckBox4.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialCheckBox4.Location = new System.Drawing.Point(329, 259);
            this.materialCheckBox4.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckBox4.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckBox4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckBox4.Name = "materialCheckBox4";
            this.materialCheckBox4.Ripple = true;
            this.materialCheckBox4.Size = new System.Drawing.Size(128, 30);
            this.materialCheckBox4.TabIndex = 16;
            this.materialCheckBox4.Text = "Show Password";
            this.materialCheckBox4.UseVisualStyleBackColor = true;
            this.materialCheckBox4.CheckedChanged += new System.EventHandler(this.materialCheckBox4_CheckedChanged);
            // 
            // PasswordField
            // 
            this.PasswordField.Depth = 0;
            this.PasswordField.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordField.Hint = "Password";
            this.PasswordField.Location = new System.Drawing.Point(264, 218);
            this.PasswordField.MaxLength = 32767;
            this.PasswordField.MouseState = MaterialSkin.MouseState.HOVER;
            this.PasswordField.Name = "PasswordField";
            this.PasswordField.PasswordChar = '\0';
            this.PasswordField.SelectedText = "";
            this.PasswordField.SelectionLength = 0;
            this.PasswordField.SelectionStart = 0;
            this.PasswordField.Size = new System.Drawing.Size(267, 23);
            this.PasswordField.TabIndex = 15;
            this.PasswordField.TabStop = false;
            this.PasswordField.UseSystemPasswordChar = true;
            // 
            // UsernameField
            // 
            this.UsernameField.BackColor = System.Drawing.Color.White;
            this.UsernameField.Depth = 0;
            this.UsernameField.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameField.Hint = "Username";
            this.UsernameField.Location = new System.Drawing.Point(264, 171);
            this.UsernameField.MaxLength = 32767;
            this.UsernameField.MouseState = MaterialSkin.MouseState.HOVER;
            this.UsernameField.Name = "UsernameField";
            this.UsernameField.PasswordChar = '\0';
            this.UsernameField.SelectedText = "";
            this.UsernameField.SelectionLength = 0;
            this.UsernameField.SelectionStart = 0;
            this.UsernameField.Size = new System.Drawing.Size(267, 23);
            this.UsernameField.TabIndex = 14;
            this.UsernameField.TabStop = false;
            this.UsernameField.UseSystemPasswordChar = false;
            // 
            // RegisterLink
            // 
            this.RegisterLink.AutoSize = true;
            this.RegisterLink.Font = new System.Drawing.Font("Rockwell", 10F);
            this.RegisterLink.Location = new System.Drawing.Point(448, 387);
            this.RegisterLink.Name = "RegisterLink";
            this.RegisterLink.Size = new System.Drawing.Size(76, 17);
            this.RegisterLink.TabIndex = 19;
            this.RegisterLink.TabStop = true;
            this.RegisterLink.Text = "Click here";
            this.RegisterLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // AccountQuestion
            // 
            this.AccountQuestion.AutoSize = true;
            this.AccountQuestion.Depth = 0;
            this.AccountQuestion.Font = new System.Drawing.Font("Roboto", 11F);
            this.AccountQuestion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AccountQuestion.Location = new System.Drawing.Point(271, 387);
            this.AccountQuestion.MouseState = MaterialSkin.MouseState.HOVER;
            this.AccountQuestion.Name = "AccountQuestion";
            this.AccountQuestion.Size = new System.Drawing.Size(164, 19);
            this.AccountQuestion.TabIndex = 20;
            this.AccountQuestion.Text = "Don\'t have an account?";
            // 
            // LoginButton
            // 
            this.LoginButton.AutoSize = true;
            this.LoginButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LoginButton.Depth = 0;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Icon = null;
            this.LoginButton.Location = new System.Drawing.Point(365, 321);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.LoginButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Primary = false;
            this.LoginButton.Size = new System.Drawing.Size(61, 36);
            this.LoginButton.TabIndex = 21;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseCompatibleTextRendering = true;
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(817, 467);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.AccountQuestion);
            this.Controls.Add(this.RegisterLink);
            this.Controls.Add(this.materialCheckBox4);
            this.Controls.Add(this.PasswordField);
            this.Controls.Add(this.UsernameField);
            this.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "Login";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialCheckBox materialCheckBox4;
        private MaterialSkin.Controls.MaterialSingleLineTextField PasswordField;
        private MaterialSkin.Controls.MaterialSingleLineTextField UsernameField;
        private System.Windows.Forms.LinkLabel RegisterLink;
        private MaterialSkin.Controls.MaterialLabel AccountQuestion;
        private MaterialSkin.Controls.MaterialFlatButton LoginButton;
    }
}

