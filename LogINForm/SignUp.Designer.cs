
namespace LogINForm
{
    partial class SignUp
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
            this.labelRegister = new System.Windows.Forms.Label();
            this.signupPasswordTextBox = new System.Windows.Forms.TextBox();
            this.signupEmailTextBox = new System.Windows.Forms.TextBox();
            this.labelRegisterPass = new System.Windows.Forms.Label();
            this.labelRegisterEmail = new System.Windows.Forms.Label();
            this.conPassTextBox = new System.Windows.Forms.TextBox();
            this.labelConfirmPass = new System.Windows.Forms.Label();
            this.clearBtnRegister = new System.Windows.Forms.Button();
            this.signupBtn = new System.Windows.Forms.Button();
            this.signinBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelRegister
            // 
            this.labelRegister.AutoSize = true;
            this.labelRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegister.Location = new System.Drawing.Point(325, 24);
            this.labelRegister.Name = "labelRegister";
            this.labelRegister.Size = new System.Drawing.Size(129, 32);
            this.labelRegister.TabIndex = 1;
            this.labelRegister.Text = "Register";
            // 
            // signupPasswordTextBox
            // 
            this.signupPasswordTextBox.Location = new System.Drawing.Point(354, 166);
            this.signupPasswordTextBox.Name = "signupPasswordTextBox";
            this.signupPasswordTextBox.Size = new System.Drawing.Size(167, 22);
            this.signupPasswordTextBox.TabIndex = 8;
            // 
            // signupEmailTextBox
            // 
            this.signupEmailTextBox.Location = new System.Drawing.Point(354, 119);
            this.signupEmailTextBox.Name = "signupEmailTextBox";
            this.signupEmailTextBox.Size = new System.Drawing.Size(167, 22);
            this.signupEmailTextBox.TabIndex = 7;
            // 
            // labelRegisterPass
            // 
            this.labelRegisterPass.AutoSize = true;
            this.labelRegisterPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegisterPass.Location = new System.Drawing.Point(184, 166);
            this.labelRegisterPass.Name = "labelRegisterPass";
            this.labelRegisterPass.Size = new System.Drawing.Size(106, 25);
            this.labelRegisterPass.TabIndex = 6;
            this.labelRegisterPass.Text = "Password";
            // 
            // labelRegisterEmail
            // 
            this.labelRegisterEmail.AutoSize = true;
            this.labelRegisterEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegisterEmail.Location = new System.Drawing.Point(203, 115);
            this.labelRegisterEmail.Name = "labelRegisterEmail";
            this.labelRegisterEmail.Size = new System.Drawing.Size(65, 25);
            this.labelRegisterEmail.TabIndex = 5;
            this.labelRegisterEmail.Text = "Email";
            // 
            // conPassTextBox
            // 
            this.conPassTextBox.Location = new System.Drawing.Point(354, 211);
            this.conPassTextBox.Name = "conPassTextBox";
            this.conPassTextBox.Size = new System.Drawing.Size(167, 22);
            this.conPassTextBox.TabIndex = 9;
            // 
            // labelConfirmPass
            // 
            this.labelConfirmPass.AutoSize = true;
            this.labelConfirmPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConfirmPass.Location = new System.Drawing.Point(146, 211);
            this.labelConfirmPass.Name = "labelConfirmPass";
            this.labelConfirmPass.Size = new System.Drawing.Size(187, 25);
            this.labelConfirmPass.TabIndex = 10;
            this.labelConfirmPass.Text = "Confirm Password";
            // 
            // clearBtnRegister
            // 
            this.clearBtnRegister.Location = new System.Drawing.Point(402, 295);
            this.clearBtnRegister.Name = "clearBtnRegister";
            this.clearBtnRegister.Size = new System.Drawing.Size(75, 39);
            this.clearBtnRegister.TabIndex = 12;
            this.clearBtnRegister.Text = "Clear";
            this.clearBtnRegister.UseVisualStyleBackColor = true;
            this.clearBtnRegister.Click += new System.EventHandler(this.clearBtnRegister_Click);
            // 
            // signupBtn
            // 
            this.signupBtn.Location = new System.Drawing.Point(278, 295);
            this.signupBtn.Name = "signupBtn";
            this.signupBtn.Size = new System.Drawing.Size(75, 39);
            this.signupBtn.TabIndex = 11;
            this.signupBtn.Text = "Signup";
            this.signupBtn.UseVisualStyleBackColor = true;
            this.signupBtn.Click += new System.EventHandler(this.signupBtn_Click);
            // 
            // signinBtn
            // 
            this.signinBtn.Location = new System.Drawing.Point(521, 295);
            this.signinBtn.Name = "signinBtn";
            this.signinBtn.Size = new System.Drawing.Size(75, 39);
            this.signinBtn.TabIndex = 13;
            this.signinBtn.Text = "Sign In";
            this.signinBtn.UseVisualStyleBackColor = true;
            this.signinBtn.Click += new System.EventHandler(this.signinBtn_Click);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.signinBtn);
            this.Controls.Add(this.clearBtnRegister);
            this.Controls.Add(this.signupBtn);
            this.Controls.Add(this.labelConfirmPass);
            this.Controls.Add(this.conPassTextBox);
            this.Controls.Add(this.signupPasswordTextBox);
            this.Controls.Add(this.signupEmailTextBox);
            this.Controls.Add(this.labelRegisterPass);
            this.Controls.Add(this.labelRegisterEmail);
            this.Controls.Add(this.labelRegister);
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRegister;
        private System.Windows.Forms.TextBox signupPasswordTextBox;
        private System.Windows.Forms.TextBox signupEmailTextBox;
        private System.Windows.Forms.Label labelRegisterPass;
        private System.Windows.Forms.Label labelRegisterEmail;
        private System.Windows.Forms.TextBox conPassTextBox;
        private System.Windows.Forms.Label labelConfirmPass;
        private System.Windows.Forms.Button clearBtnRegister;
        private System.Windows.Forms.Button signupBtn;
        private System.Windows.Forms.Button signinBtn;
    }
}