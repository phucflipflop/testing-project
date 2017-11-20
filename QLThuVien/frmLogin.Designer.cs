namespace QLThuvien
{
    partial class frmLogin
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAcc = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.ckbShowPass = new System.Windows.Forms.CheckBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lbIncorrect = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grbLogin = new System.Windows.Forms.GroupBox();
            this.grbLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(145, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Account";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(145, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Password";
            // 
            // txtAcc
            // 
            this.txtAcc.Location = new System.Drawing.Point(257, 45);
            this.txtAcc.MaxLength = 50;
            this.txtAcc.Name = "txtAcc";
            this.txtAcc.Size = new System.Drawing.Size(212, 22);
            this.txtAcc.TabIndex = 0;
            this.txtAcc.TextChanged += new System.EventHandler(this.txtAcc_TextChanged);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(257, 129);
            this.txtPass.MaxLength = 50;
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(212, 22);
            this.txtPass.TabIndex = 1;
            this.txtPass.UseSystemPasswordChar = true;
            this.txtPass.TextChanged += new System.EventHandler(this.txtPass_TextChanged);
            this.txtPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPass_KeyDown);
            // 
            // ckbShowPass
            // 
            this.ckbShowPass.AutoSize = true;
            this.ckbShowPass.Location = new System.Drawing.Point(113, 186);
            this.ckbShowPass.Name = "ckbShowPass";
            this.ckbShowPass.Size = new System.Drawing.Size(129, 21);
            this.ckbShowPass.TabIndex = 2;
            this.ckbShowPass.Text = "Show Password";
            this.ckbShowPass.UseVisualStyleBackColor = true;
            this.ckbShowPass.CheckedChanged += new System.EventHandler(this.ckbShowPass_CheckedChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(283, 284);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(85, 31);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lbIncorrect
            // 
            this.lbIncorrect.ForeColor = System.Drawing.Color.Red;
            this.lbIncorrect.Location = new System.Drawing.Point(110, 235);
            this.lbIncorrect.Name = "lbIncorrect";
            this.lbIncorrect.Size = new System.Drawing.Size(356, 29);
            this.lbIncorrect.TabIndex = 5;
            this.lbIncorrect.Click += new System.EventHandler(this.lbIncorrect_Click);
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(200, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(356, 29);
            this.label3.TabIndex = 5;
            this.label3.Click += new System.EventHandler(this.lbIncorrect_Click);
            // 
            // label4
            // 
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(200, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(356, 29);
            this.label4.TabIndex = 5;
            this.label4.Click += new System.EventHandler(this.lbIncorrect_Click);
            // 
            // grbLogin
            // 
            this.grbLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbLogin.Controls.Add(this.txtAcc);
            this.grbLogin.Controls.Add(this.lbIncorrect);
            this.grbLogin.Controls.Add(this.label4);
            this.grbLogin.Controls.Add(this.btnLogin);
            this.grbLogin.Controls.Add(this.txtPass);
            this.grbLogin.Controls.Add(this.ckbShowPass);
            this.grbLogin.Controls.Add(this.label3);
            this.grbLogin.Controls.Add(this.label2);
            this.grbLogin.Controls.Add(this.label1);
            this.grbLogin.Location = new System.Drawing.Point(30, 57);
            this.grbLogin.Name = "grbLogin";
            this.grbLogin.Size = new System.Drawing.Size(644, 340);
            this.grbLogin.TabIndex = 6;
            this.grbLogin.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 492);
            this.Controls.Add(this.grbLogin);
            this.Name = "frmLogin";
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLogin_FormClosing);
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.grbLogin.ResumeLayout(false);
            this.grbLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAcc;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.CheckBox ckbShowPass;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lbIncorrect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grbLogin;
    }
}