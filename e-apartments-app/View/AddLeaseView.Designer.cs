namespace e_apartments_app.View
{
    partial class AddLeaseView
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.apartmentBox = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.customerBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.endDate = new System.Windows.Forms.DateTimePicker();
            this.panel6 = new System.Windows.Forms.Panel();
            this.amountBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.addLease = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select apartment:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.apartmentBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(406, 54);
            this.panel1.TabIndex = 1;
            // 
            // apartmentBox
            // 
            this.apartmentBox.FormattingEnabled = true;
            this.apartmentBox.Location = new System.Drawing.Point(156, 13);
            this.apartmentBox.Name = "apartmentBox";
            this.apartmentBox.Size = new System.Drawing.Size(239, 28);
            this.apartmentBox.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.customerBox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(406, 54);
            this.panel2.TabIndex = 2;
            // 
            // customerBox
            // 
            this.customerBox.FormattingEnabled = true;
            this.customerBox.Location = new System.Drawing.Point(156, 13);
            this.customerBox.Name = "customerBox";
            this.customerBox.Size = new System.Drawing.Size(239, 28);
            this.customerBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Select Customer:";
            // 
            // startDate
            // 
            this.startDate.Location = new System.Drawing.Point(120, 16);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(275, 27);
            this.startDate.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.startDate);
            this.panel3.Location = new System.Drawing.Point(12, 107);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(417, 54);
            this.panel3.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Start Date:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.endDate);
            this.panel4.Location = new System.Drawing.Point(12, 158);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(417, 54);
            this.panel4.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "End Date:";
            // 
            // endDate
            // 
            this.endDate.Location = new System.Drawing.Point(120, 16);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(275, 27);
            this.endDate.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.amountBox);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Location = new System.Drawing.Point(12, 211);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(406, 54);
            this.panel6.TabIndex = 3;
            // 
            // amountBox
            // 
            this.amountBox.Location = new System.Drawing.Point(146, 16);
            this.amountBox.Name = "amountBox";
            this.amountBox.Size = new System.Drawing.Size(249, 27);
            this.amountBox.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Deposit amount: ";
            // 
            // addLease
            // 
            this.addLease.BackColor = System.Drawing.SystemColors.HotTrack;
            this.addLease.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addLease.Location = new System.Drawing.Point(12, 285);
            this.addLease.Name = "addLease";
            this.addLease.Size = new System.Drawing.Size(110, 36);
            this.addLease.TabIndex = 5;
            this.addLease.Text = "Add Lease";
            this.addLease.UseVisualStyleBackColor = false;
            this.addLease.Click += new System.EventHandler(this.addLease_Click);
            // 
            // AddLeaseView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 351);
            this.Controls.Add(this.addLease);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AddLeaseView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Lease View";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private Panel panel1;
        private ComboBox apartmentBox;
        private Panel panel2;
        private ComboBox customerBox;
        private Label label2;
        private Panel panel3;
        private Label label3;
        private DateTimePicker startDate;
        private Panel panel4;
        private Label label4;
        private DateTimePicker endDate;
        private Panel panel6;
        private TextBox amountBox;
        private Label label6;
        private Button addLease;
    }
}