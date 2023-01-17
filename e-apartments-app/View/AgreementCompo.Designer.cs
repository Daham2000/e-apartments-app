namespace e_apartments_app.View
{
    partial class AgreementCompo
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
            this.agreeId = new System.Windows.Forms.Label();
            this.apartmentID = new System.Windows.Forms.Label();
            this.customerID = new System.Windows.Forms.Label();
            this.cusName = new System.Windows.Forms.Label();
            this.sDate = new System.Windows.Forms.Label();
            this.eDate = new System.Windows.Forms.Label();
            this.dPaid = new System.Windows.Forms.Label();
            this.amount = new System.Windows.Forms.Label();
            this.dueLable = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // agreeId
            // 
            this.agreeId.AutoSize = true;
            this.agreeId.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.agreeId.Location = new System.Drawing.Point(12, 12);
            this.agreeId.Name = "agreeId";
            this.agreeId.Size = new System.Drawing.Size(214, 28);
            this.agreeId.TabIndex = 0;
            this.agreeId.Text = "Agreement ID: ag0001";
            // 
            // apartmentID
            // 
            this.apartmentID.AutoSize = true;
            this.apartmentID.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.apartmentID.Location = new System.Drawing.Point(12, 49);
            this.apartmentID.Name = "apartmentID";
            this.apartmentID.Size = new System.Drawing.Size(186, 23);
            this.apartmentID.TabIndex = 1;
            this.apartmentID.Text = "Apartment ID: app0001";
            // 
            // customerID
            // 
            this.customerID.AutoSize = true;
            this.customerID.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.customerID.Location = new System.Drawing.Point(12, 81);
            this.customerID.Name = "customerID";
            this.customerID.Size = new System.Drawing.Size(178, 23);
            this.customerID.TabIndex = 2;
            this.customerID.Text = "Customer ID: app0001";
            // 
            // cusName
            // 
            this.cusName.AutoSize = true;
            this.cusName.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cusName.Location = new System.Drawing.Point(12, 114);
            this.cusName.Name = "cusName";
            this.cusName.Size = new System.Drawing.Size(207, 23);
            this.cusName.TabIndex = 3;
            this.cusName.Text = "Customer Name: app0001";
            // 
            // sDate
            // 
            this.sDate.AutoSize = true;
            this.sDate.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sDate.Location = new System.Drawing.Point(12, 147);
            this.sDate.Name = "sDate";
            this.sDate.Size = new System.Drawing.Size(96, 23);
            this.sDate.TabIndex = 4;
            this.sDate.Text = "Start Date: ";
            // 
            // eDate
            // 
            this.eDate.AutoSize = true;
            this.eDate.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.eDate.Location = new System.Drawing.Point(12, 176);
            this.eDate.Name = "eDate";
            this.eDate.Size = new System.Drawing.Size(89, 23);
            this.eDate.TabIndex = 5;
            this.eDate.Text = "End Date: ";
            // 
            // dPaid
            // 
            this.dPaid.AutoSize = true;
            this.dPaid.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dPaid.Location = new System.Drawing.Point(503, 12);
            this.dPaid.Name = "dPaid";
            this.dPaid.Size = new System.Drawing.Size(148, 23);
            this.dPaid.TabIndex = 6;
            this.dPaid.Text = "Deposit Paid: True";
            // 
            // amount
            // 
            this.amount.AutoSize = true;
            this.amount.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.amount.Location = new System.Drawing.Point(503, 49);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(149, 23);
            this.amount.TabIndex = 7;
            this.amount.Text = "Amount: Rs 23000";
            // 
            // dueLable
            // 
            this.dueLable.AutoSize = true;
            this.dueLable.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dueLable.Location = new System.Drawing.Point(503, 81);
            this.dueLable.Name = "dueLable";
            this.dueLable.Size = new System.Drawing.Size(180, 23);
            this.dueLable.TabIndex = 8;
            this.dueLable.Text = "Due Balance: Rs 12000";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(737, 205);
            this.panel1.TabIndex = 9;
            // 
            // AgreementCompo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dueLable);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.dPaid);
            this.Controls.Add(this.eDate);
            this.Controls.Add(this.sDate);
            this.Controls.Add(this.cusName);
            this.Controls.Add(this.customerID);
            this.Controls.Add(this.apartmentID);
            this.Controls.Add(this.agreeId);
            this.Controls.Add(this.panel1);
            this.Name = "AgreementCompo";
            this.Size = new System.Drawing.Size(740, 226);
            this.Load += new System.EventHandler(this.AgreementCompo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label agreeId;
        private Label apartmentID;
        private Label customerID;
        private Label cusName;
        private Label sDate;
        private Label eDate;
        private Label dPaid;
        private Label amount;
        private Label dueLable;
        private Panel panel1;
    }
}
