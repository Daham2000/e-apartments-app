namespace e_apartments_app.View
{
    partial class CustomerDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerDashboard));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.apartmentBtn = new System.Windows.Forms.Button();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.flowLayout = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(43, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(86)))), ((int)(((byte)(103)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.apartmentBtn);
            this.panel1.Location = new System.Drawing.Point(-1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 840);
            this.panel1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(86)))), ((int)(((byte)(103)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(36, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Customer Dashboard";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(86)))), ((int)(((byte)(103)))));
            this.button2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button2.Location = new System.Drawing.Point(3, 777);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(247, 29);
            this.button2.TabIndex = 8;
            this.button2.Text = "Logout";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // apartmentBtn
            // 
            this.apartmentBtn.Location = new System.Drawing.Point(2, 164);
            this.apartmentBtn.Name = "apartmentBtn";
            this.apartmentBtn.Size = new System.Drawing.Size(247, 29);
            this.apartmentBtn.TabIndex = 7;
            this.apartmentBtn.Text = "My Appartments";
            this.apartmentBtn.UseVisualStyleBackColor = true;
            // 
            // refreshBtn
            // 
            this.refreshBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.refreshBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.refreshBtn.Location = new System.Drawing.Point(1092, 14);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(94, 29);
            this.refreshBtn.TabIndex = 14;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = false;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.Location = new System.Drawing.Point(259, 10);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(239, 31);
            this.titleLabel.TabIndex = 13;
            this.titleLabel.Text = "My Apartment details";
            // 
            // flowLayout
            // 
            this.flowLayout.Location = new System.Drawing.Point(264, 69);
            this.flowLayout.Name = "flowLayout";
            this.flowLayout.Size = new System.Drawing.Size(918, 738);
            this.flowLayout.TabIndex = 15;
            // 
            // CustomerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 838);
            this.Controls.Add(this.flowLayout);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "CustomerDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerDashboard";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Button button2;
        private Button apartmentBtn;
        private Label label1;
        private Button refreshBtn;
        private Label titleLabel;
        private FlowLayoutPanel flowLayout;
    }
}