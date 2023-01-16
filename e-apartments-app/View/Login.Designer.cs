namespace e_apartments_app.ui
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.passwordVali = new System.Windows.Forms.Label();
            this.userValida = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.passwordVali);
            this.panel1.Controls.Add(this.userValida);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.loginBtn);
            this.panel1.Controls.Add(this.password);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.username);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Location = new System.Drawing.Point(77, 117);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 383);
            this.panel1.TabIndex = 19;
            // 
            // passwordVali
            // 
            this.passwordVali.AutoSize = true;
            this.passwordVali.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordVali.ForeColor = System.Drawing.Color.Red;
            this.passwordVali.Location = new System.Drawing.Point(489, 233);
            this.passwordVali.Name = "passwordVali";
            this.passwordVali.Size = new System.Drawing.Size(0, 15);
            this.passwordVali.TabIndex = 18;
            // 
            // userValida
            // 
            this.userValida.AutoSize = true;
            this.userValida.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userValida.ForeColor = System.Drawing.Color.Red;
            this.userValida.Location = new System.Drawing.Point(489, 171);
            this.userValida.Name = "userValida";
            this.userValida.Size = new System.Drawing.Size(0, 15);
            this.userValida.TabIndex = 17;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(47, 98);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(404, 165);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.loginBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.loginBtn.Location = new System.Drawing.Point(551, 259);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(119, 33);
            this.loginBtn.TabIndex = 12;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(482, 210);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(278, 27);
            this.password.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(482, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Password:";
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(482, 141);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(278, 27);
            this.username.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(482, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "User Name: ";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 598);
            this.Controls.Add(this.panel1);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "E-appartments Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Label userValida;
        private Label passwordVali;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button loginBtn;
        private TextBox password;
        private Label label2;
        private TextBox username;
        private Label label1;
    }
}