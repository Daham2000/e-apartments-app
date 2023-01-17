namespace e_apartments_app.View
{
    partial class AdminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.customerBtn = new System.Windows.Forms.Button();
            this.editClassBtn = new System.Windows.Forms.Button();
            this.leaseBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.apartmentBtn = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.apartmentListFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.refreshBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.apartmentListFlow.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(42, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(86)))), ((int)(((byte)(103)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(47, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Admin Dashboard";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(86)))), ((int)(((byte)(103)))));
            this.panel1.Controls.Add(this.customerBtn);
            this.panel1.Controls.Add(this.editClassBtn);
            this.panel1.Controls.Add(this.leaseBtn);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.apartmentBtn);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 840);
            this.panel1.TabIndex = 6;
            // 
            // customerBtn
            // 
            this.customerBtn.Location = new System.Drawing.Point(3, 326);
            this.customerBtn.Name = "customerBtn";
            this.customerBtn.Size = new System.Drawing.Size(247, 29);
            this.customerBtn.TabIndex = 11;
            this.customerBtn.Text = "Customer Management";
            this.customerBtn.UseVisualStyleBackColor = true;
            this.customerBtn.Click += new System.EventHandler(this.customerBtn_Click);
            // 
            // editClassBtn
            // 
            this.editClassBtn.Location = new System.Drawing.Point(3, 272);
            this.editClassBtn.Name = "editClassBtn";
            this.editClassBtn.Size = new System.Drawing.Size(247, 29);
            this.editClassBtn.TabIndex = 10;
            this.editClassBtn.Text = "Edit Class";
            this.editClassBtn.UseVisualStyleBackColor = true;
            this.editClassBtn.Click += new System.EventHandler(this.editClassBtn_Click);
            // 
            // leaseBtn
            // 
            this.leaseBtn.Location = new System.Drawing.Point(3, 216);
            this.leaseBtn.Name = "leaseBtn";
            this.leaseBtn.Size = new System.Drawing.Size(247, 29);
            this.leaseBtn.TabIndex = 9;
            this.leaseBtn.Text = "Lease details";
            this.leaseBtn.UseVisualStyleBackColor = true;
            this.leaseBtn.Click += new System.EventHandler(this.leaseBtn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 770);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(247, 29);
            this.button2.TabIndex = 8;
            this.button2.Text = "Logout";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // apartmentBtn
            // 
            this.apartmentBtn.Location = new System.Drawing.Point(3, 164);
            this.apartmentBtn.Name = "apartmentBtn";
            this.apartmentBtn.Size = new System.Drawing.Size(247, 29);
            this.apartmentBtn.TabIndex = 7;
            this.apartmentBtn.Text = "Apartment details";
            this.apartmentBtn.UseVisualStyleBackColor = true;
            this.apartmentBtn.Click += new System.EventHandler(this.apartmentBtn_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.Location = new System.Drawing.Point(262, 22);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(200, 31);
            this.titleLabel.TabIndex = 7;
            this.titleLabel.Text = "Apartment details";
            // 
            // apartmentListFlow
            // 
            this.apartmentListFlow.AutoScroll = true;
            this.apartmentListFlow.Controls.Add(this.flowLayoutPanel2);
            this.apartmentListFlow.Location = new System.Drawing.Point(269, 69);
            this.apartmentListFlow.Name = "apartmentListFlow";
            this.apartmentListFlow.Size = new System.Drawing.Size(899, 727);
            this.apartmentListFlow.TabIndex = 11;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(8, 8);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // refreshBtn
            // 
            this.refreshBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.refreshBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.refreshBtn.Location = new System.Drawing.Point(1074, 27);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(94, 29);
            this.refreshBtn.TabIndex = 12;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = false;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 838);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.apartmentListFlow);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "E-appartments - Dashboard";
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.apartmentListFlow.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel1;
        private Button leaseBtn;
        private Button button2;
        private Button apartmentBtn;
        private Label titleLabel;
        private FlowLayoutPanel apartmentListFlow;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button editClassBtn;
        private Button refreshBtn;
        private Button customerBtn;
    }
}