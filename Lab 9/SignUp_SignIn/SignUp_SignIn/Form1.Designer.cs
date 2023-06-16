namespace SignUp_SignIn
{
    partial class frm_SignUp
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
            this.lbl_header = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.lbl_role = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.txt_role = new System.Windows.Forms.TextBox();
            this.btn_signUp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lil_login = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lbl_header
            // 
            this.lbl_header.AutoSize = true;
            this.lbl_header.Font = new System.Drawing.Font("Monotype Corsiva", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_header.Location = new System.Drawing.Point(223, 31);
            this.lbl_header.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_header.Name = "lbl_header";
            this.lbl_header.Size = new System.Drawing.Size(554, 79);
            this.lbl_header.TabIndex = 0;
            this.lbl_header.Text = "Sign UP Sign IN App";
            this.lbl_header.Click += new System.EventHandler(this.lbl_header_Click);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Britannic Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(268, 159);
            this.lbl_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(93, 36);
            this.lbl_name.TabIndex = 1;
            this.lbl_name.Text = "Name";
            this.lbl_name.Click += new System.EventHandler(this.lbl_name_Click);
            // 
            // lbl_pass
            // 
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.Font = new System.Drawing.Font("Britannic Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pass.Location = new System.Drawing.Point(233, 226);
            this.lbl_pass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(150, 36);
            this.lbl_pass.TabIndex = 4;
            this.lbl_pass.Text = "Password";
            this.lbl_pass.Click += new System.EventHandler(this.lbl_pass_Click);
            // 
            // lbl_role
            // 
            this.lbl_role.AutoSize = true;
            this.lbl_role.Font = new System.Drawing.Font("Britannic Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_role.Location = new System.Drawing.Point(289, 302);
            this.lbl_role.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_role.Name = "lbl_role";
            this.lbl_role.Size = new System.Drawing.Size(77, 36);
            this.lbl_role.TabIndex = 5;
            this.lbl_role.Text = "Role";
            this.lbl_role.Click += new System.EventHandler(this.lbl_role_Click);
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(480, 160);
            this.txt_name.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_name.Multiline = true;
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(321, 42);
            this.txt_name.TabIndex = 6;
            this.txt_name.TextChanged += new System.EventHandler(this.txt_name_TextChanged);
            // 
            // txt_pass
            // 
            this.txt_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass.Location = new System.Drawing.Point(480, 228);
            this.txt_pass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_pass.Multiline = true;
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '*';
            this.txt_pass.Size = new System.Drawing.Size(321, 42);
            this.txt_pass.TabIndex = 7;
            this.txt_pass.TextChanged += new System.EventHandler(this.txt_pass_TextChanged);
            // 
            // txt_role
            // 
            this.txt_role.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_role.Location = new System.Drawing.Point(480, 302);
            this.txt_role.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_role.Multiline = true;
            this.txt_role.Name = "txt_role";
            this.txt_role.Size = new System.Drawing.Size(321, 42);
            this.txt_role.TabIndex = 8;
            this.txt_role.TextChanged += new System.EventHandler(this.txt_role_TextChanged);
            // 
            // btn_signUp
            // 
            this.btn_signUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_signUp.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_signUp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_signUp.Location = new System.Drawing.Point(457, 369);
            this.btn_signUp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_signUp.Name = "btn_signUp";
            this.btn_signUp.Size = new System.Drawing.Size(212, 59);
            this.btn_signUp.TabIndex = 9;
            this.btn_signUp.Text = "Sign UP";
            this.btn_signUp.UseVisualStyleBackColor = false;
            this.btn_signUp.Click += new System.EventHandler(this.btn_signUp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(416, 459);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Already have an account?";
            this.label1.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // lil_login
            // 
            this.lil_login.AutoSize = true;
            this.lil_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lil_login.Location = new System.Drawing.Point(616, 459);
            this.lil_login.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lil_login.Name = "lil_login";
            this.lil_login.Size = new System.Drawing.Size(48, 20);
            this.lil_login.TabIndex = 11;
            this.lil_login.TabStop = true;
            this.lil_login.Text = "Login";
            this.lil_login.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lil_login_LinkClicked);
            // 
            // frm_SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 554);
            this.Controls.Add(this.lil_login);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_signUp);
            this.Controls.Add(this.txt_role);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.lbl_role);
            this.Controls.Add(this.lbl_pass);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lbl_header);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_SignUp";
            this.Text = "frm_SignUP";
            this.Load += new System.EventHandler(this.SignUpSignInApp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_header;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.Label lbl_role;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.TextBox txt_role;
        private System.Windows.Forms.Button btn_signUp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lil_login;
    }
}

