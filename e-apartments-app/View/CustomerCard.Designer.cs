namespace e_apartments_app.View
{
    partial class CustomerCard
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
            this.editBtn = new System.Windows.Forms.Button();
            this.flowDependant = new System.Windows.Forms.FlowLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.contactLabel = new System.Windows.Forms.Label();
            this.nicLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.editBtn);
            this.panel1.Controls.Add(this.flowDependant);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.contactLabel);
            this.panel1.Controls.Add(this.nicLabel);
            this.panel1.Controls.Add(this.addressLabel);
            this.panel1.Controls.Add(this.userNameLabel);
            this.panel1.Controls.Add(this.name);
            this.panel1.Location = new System.Drawing.Point(1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(854, 217);
            this.panel1.TabIndex = 0;
            // 
            // editBtn
            // 
            this.editBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.editBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.editBtn.Location = new System.Drawing.Point(739, 14);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(94, 29);
            this.editBtn.TabIndex = 7;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = false;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // flowDependant
            // 
            this.flowDependant.Location = new System.Drawing.Point(499, 83);
            this.flowDependant.Name = "flowDependant";
            this.flowDependant.Size = new System.Drawing.Size(299, 125);
            this.flowDependant.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(483, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Dependents Details:";
            // 
            // contactLabel
            // 
            this.contactLabel.AutoSize = true;
            this.contactLabel.Location = new System.Drawing.Point(19, 160);
            this.contactLabel.Name = "contactLabel";
            this.contactLabel.Size = new System.Drawing.Size(167, 20);
            this.contactLabel.TabIndex = 4;
            this.contactLabel.Text = "Customer Contact num: ";
            // 
            // nicLabel
            // 
            this.nicLabel.AutoSize = true;
            this.nicLabel.Location = new System.Drawing.Point(19, 127);
            this.nicLabel.Name = "nicLabel";
            this.nicLabel.Size = new System.Drawing.Size(107, 20);
            this.nicLabel.TabIndex = 3;
            this.nicLabel.Text = "Customer NIC: ";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(19, 94);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(136, 20);
            this.addressLabel.TabIndex = 2;
            this.addressLabel.Text = "Customer Address: ";
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Location = new System.Drawing.Point(19, 61);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(156, 20);
            this.userNameLabel.TabIndex = 1;
            this.userNameLabel.Text = "Customer User Name: ";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.name.Location = new System.Drawing.Point(19, 18);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(156, 25);
            this.name.TabIndex = 0;
            this.name.Text = "Customer Name: ";
            // 
            // CustomerCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "CustomerCard";
            this.Size = new System.Drawing.Size(855, 234);
            this.Load += new System.EventHandler(this.CustomerCard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label nicLabel;
        private Label addressLabel;
        private Label userNameLabel;
        private Label name;
        private Label contactLabel;
        private Label label6;
        private Panel panelDependant;
        private FlowLayoutPanel flowDependant;
        private Button editBtn;
    }
}
