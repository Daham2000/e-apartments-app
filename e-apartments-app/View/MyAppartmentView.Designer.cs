namespace e_apartments_app.View
{
    partial class MyAppartmentView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.reqBtn = new System.Windows.Forms.Button();
            this.dueLable = new System.Windows.Forms.Label();
            this.amount = new System.Windows.Forms.Label();
            this.dPaid = new System.Windows.Forms.Label();
            this.eDate = new System.Windows.Forms.Label();
            this.sDate = new System.Windows.Forms.Label();
            this.apartmentID = new System.Windows.Forms.Label();
            this.leaseID = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.reqBtn);
            this.panel1.Controls.Add(this.dueLable);
            this.panel1.Controls.Add(this.amount);
            this.panel1.Controls.Add(this.dPaid);
            this.panel1.Controls.Add(this.eDate);
            this.panel1.Controls.Add(this.sDate);
            this.panel1.Controls.Add(this.apartmentID);
            this.panel1.Location = new System.Drawing.Point(-1, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(788, 193);
            this.panel1.TabIndex = 0;
            // 
            // reqBtn
            // 
            this.reqBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.reqBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.reqBtn.Location = new System.Drawing.Point(11, 149);
            this.reqBtn.Name = "reqBtn";
            this.reqBtn.Size = new System.Drawing.Size(241, 36);
            this.reqBtn.TabIndex = 17;
            this.reqBtn.Text = "Make Lease Extention Request";
            this.reqBtn.UseVisualStyleBackColor = false;
            this.reqBtn.Click += new System.EventHandler(this.reqBtn_Click);
            // 
            // dueLable
            // 
            this.dueLable.AutoSize = true;
            this.dueLable.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dueLable.Location = new System.Drawing.Point(576, 87);
            this.dueLable.Name = "dueLable";
            this.dueLable.Size = new System.Drawing.Size(180, 23);
            this.dueLable.TabIndex = 16;
            this.dueLable.Text = "Due Balance: Rs 12000";
            // 
            // amount
            // 
            this.amount.AutoSize = true;
            this.amount.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.amount.Location = new System.Drawing.Point(576, 55);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(149, 23);
            this.amount.TabIndex = 15;
            this.amount.Text = "Amount: Rs 23000";
            // 
            // dPaid
            // 
            this.dPaid.AutoSize = true;
            this.dPaid.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dPaid.Location = new System.Drawing.Point(576, 18);
            this.dPaid.Name = "dPaid";
            this.dPaid.Size = new System.Drawing.Size(148, 23);
            this.dPaid.TabIndex = 14;
            this.dPaid.Text = "Deposit Paid: True";
            // 
            // eDate
            // 
            this.eDate.AutoSize = true;
            this.eDate.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.eDate.Location = new System.Drawing.Point(11, 77);
            this.eDate.Name = "eDate";
            this.eDate.Size = new System.Drawing.Size(89, 23);
            this.eDate.TabIndex = 13;
            this.eDate.Text = "End Date: ";
            // 
            // sDate
            // 
            this.sDate.AutoSize = true;
            this.sDate.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sDate.Location = new System.Drawing.Point(11, 48);
            this.sDate.Name = "sDate";
            this.sDate.Size = new System.Drawing.Size(96, 23);
            this.sDate.TabIndex = 12;
            this.sDate.Text = "Start Date: ";
            // 
            // apartmentID
            // 
            this.apartmentID.AutoSize = true;
            this.apartmentID.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.apartmentID.Location = new System.Drawing.Point(11, 18);
            this.apartmentID.Name = "apartmentID";
            this.apartmentID.Size = new System.Drawing.Size(186, 23);
            this.apartmentID.TabIndex = 9;
            this.apartmentID.Text = "Apartment ID: app0001";
            // 
            // leaseID
            // 
            this.leaseID.AutoSize = true;
            this.leaseID.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.leaseID.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.leaseID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.leaseID.Location = new System.Drawing.Point(10, 7);
            this.leaseID.Name = "leaseID";
            this.leaseID.Size = new System.Drawing.Size(94, 28);
            this.leaseID.TabIndex = 1;
            this.leaseID.Text = "Lease ID:";
            // 
            // MyAppartmentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Controls.Add(this.leaseID);
            this.Controls.Add(this.panel1);
            this.Name = "MyAppartmentView";
            this.Size = new System.Drawing.Size(787, 247);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label leaseID;
        private Label dueLable;
        private Label amount;
        private Label dPaid;
        private Label eDate;
        private Label sDate;
        private Label apartmentID;
        private Button reqBtn;
    }
}
