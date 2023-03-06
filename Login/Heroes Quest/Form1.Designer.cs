namespace Heroes_Quest
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtUser = new TextBox();
            txtPassword = new TextBox();
            lblTitle = new Label();
            label1 = new Label();
            label2 = new Label();
            btnLogin = new Button();
            button1 = new Button();
            btn_mute = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // txtUser
            // 
            txtUser.BackColor = Color.Wheat;
            txtUser.BorderStyle = BorderStyle.FixedSingle;
            txtUser.Font = new Font("Monocraft", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtUser.Location = new Point(212, 134);
            txtUser.Margin = new Padding(3, 2, 3, 2);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(110, 21);
            txtUser.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.Wheat;
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Monocraft", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtPassword.Location = new Point(361, 134);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(110, 21);
            txtPassword.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.AntiqueWhite;
            lblTitle.Font = new Font("Monocraft", 16.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lblTitle.Location = new Point(244, 32);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(190, 24);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Heroes Quest";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.AntiqueWhite;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Monocraft", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(220, 119);
            label1.Name = "label1";
            label1.Size = new Size(79, 13);
            label1.TabIndex = 3;
            label1.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.AntiqueWhite;
            label2.FlatStyle = FlatStyle.Popup;
            label2.Font = new Font("Monocraft", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(369, 119);
            label2.Name = "label2";
            label2.Size = new Size(79, 13);
            label2.TabIndex = 4;
            label2.Text = "Password:";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Wheat;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderColor = Color.White;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Monocraft", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = SystemColors.ActiveCaptionText;
            btnLogin.Location = new Point(212, 173);
            btnLogin.Margin = new Padding(3, 2, 3, 2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(129, 60);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += button1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Wheat;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Monocraft", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(590, 296);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(100, 33);
            button1.TabIndex = 6;
            button1.Text = "Quit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // btn_mute
            // 
            btn_mute.BackColor = Color.Wheat;
            btn_mute.FlatStyle = FlatStyle.Flat;
            btn_mute.Location = new Point(10, 296);
            btn_mute.Margin = new Padding(3, 2, 3, 2);
            btn_mute.Name = "btn_mute";
            btn_mute.Size = new Size(59, 33);
            btn_mute.TabIndex = 7;
            btn_mute.Text = "Mute";
            btn_mute.UseVisualStyleBackColor = false;
            btn_mute.Click += btn_mute_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Wheat;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Monocraft", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.InfoText;
            button2.Location = new Point(347, 173);
            button2.Name = "button2";
            button2.Size = new Size(129, 60);
            button2.TabIndex = 8;
            button2.Text = "Sign Up";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = Properties.Resources.f80e949bf67f6ba4906e82b9cec44286;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(700, 338);
            ControlBox = false;
            Controls.Add(button2);
            Controls.Add(btn_mute);
            Controls.Add(button1);
            Controls.Add(btnLogin);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblTitle);
            Controls.Add(txtPassword);
            Controls.Add(txtUser);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Heroes Quest: Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUser;
        private TextBox txtPassword;
        private Label lblTitle;
        private Label label1;
        private Label label2;
        private Button btnLogin;
        private Button button1;
        private Button btn_mute;
        private Button button2;
    }
}