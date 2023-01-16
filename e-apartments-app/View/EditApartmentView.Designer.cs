namespace e_apartments_app.View
{
    partial class EditApartmentView
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
            this.aIDLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.locationLa = new System.Windows.Forms.TextBox();
            this.locationLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.statusBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.floorLabel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.classLabel = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.classBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.buildingLabel = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.buildingBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.reasonLabel = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.occupantLabel = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Edit Apartment Details";
            // 
            // aIDLabel
            // 
            this.aIDLabel.AutoSize = true;
            this.aIDLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.aIDLabel.Location = new System.Drawing.Point(12, 54);
            this.aIDLabel.Name = "aIDLabel";
            this.aIDLabel.Size = new System.Drawing.Size(149, 20);
            this.aIDLabel.TabIndex = 1;
            this.aIDLabel.Text = "Apartment ID: A0001";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.locationLa);
            this.panel1.Controls.Add(this.locationLabel);
            this.panel1.Location = new System.Drawing.Point(20, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(506, 59);
            this.panel1.TabIndex = 2;
            // 
            // locationLa
            // 
            this.locationLa.Location = new System.Drawing.Point(85, 19);
            this.locationLa.Name = "locationLa";
            this.locationLa.Size = new System.Drawing.Size(408, 27);
            this.locationLa.TabIndex = 3;
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Location = new System.Drawing.Point(13, 22);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(73, 20);
            this.locationLabel.TabIndex = 3;
            this.locationLabel.Text = "Location: ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.statusBox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(20, 146);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(296, 59);
            this.panel2.TabIndex = 4;
            // 
            // statusBox
            // 
            this.statusBox.FormattingEnabled = true;
            this.statusBox.Items.AddRange(new object[] {
            "Available",
            "Unavailable"});
            this.statusBox.Location = new System.Drawing.Point(121, 19);
            this.statusBox.Name = "statusBox";
            this.statusBox.Size = new System.Drawing.Size(151, 28);
            this.statusBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Change status: ";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.floorLabel);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(20, 210);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(296, 59);
            this.panel3.TabIndex = 5;
            // 
            // floorLabel
            // 
            this.floorLabel.Location = new System.Drawing.Point(124, 19);
            this.floorLabel.Name = "floorLabel";
            this.floorLabel.Size = new System.Drawing.Size(102, 27);
            this.floorLabel.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Change Floor: ";
            // 
            // classLabel
            // 
            this.classLabel.AutoSize = true;
            this.classLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.classLabel.Location = new System.Drawing.Point(19, 284);
            this.classLabel.Name = "classLabel";
            this.classLabel.Size = new System.Drawing.Size(199, 20);
            this.classLabel.TabIndex = 6;
            this.classLabel.Text = "Current Class name: Class 01";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.classBox);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(21, 299);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(296, 59);
            this.panel4.TabIndex = 6;
            // 
            // classBox
            // 
            this.classBox.FormattingEnabled = true;
            this.classBox.Location = new System.Drawing.Point(116, 19);
            this.classBox.Name = "classBox";
            this.classBox.Size = new System.Drawing.Size(151, 28);
            this.classBox.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Change class: ";
            // 
            // buildingLabel
            // 
            this.buildingLabel.AutoSize = true;
            this.buildingLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buildingLabel.Location = new System.Drawing.Point(19, 380);
            this.buildingLabel.Name = "buildingLabel";
            this.buildingLabel.Size = new System.Drawing.Size(171, 20);
            this.buildingLabel.TabIndex = 7;
            this.buildingLabel.Text = "Current Building: B0002";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.buildingBox);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Location = new System.Drawing.Point(21, 395);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(319, 59);
            this.panel5.TabIndex = 8;
            // 
            // buildingBox
            // 
            this.buildingBox.FormattingEnabled = true;
            this.buildingBox.Location = new System.Drawing.Point(135, 19);
            this.buildingBox.Name = "buildingBox";
            this.buildingBox.Size = new System.Drawing.Size(151, 28);
            this.buildingBox.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Change building: ";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.reasonLabel);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Location = new System.Drawing.Point(321, 146);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(599, 59);
            this.panel6.TabIndex = 4;
            // 
            // reasonLabel
            // 
            this.reasonLabel.Location = new System.Drawing.Point(156, 19);
            this.reasonLabel.Name = "reasonLabel";
            this.reasonLabel.Size = new System.Drawing.Size(423, 27);
            this.reasonLabel.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "Unavailable Reason: ";
            // 
            // occupantLabel
            // 
            this.occupantLabel.AutoSize = true;
            this.occupantLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.occupantLabel.Location = new System.Drawing.Point(18, 472);
            this.occupantLabel.Name = "occupantLabel";
            this.occupantLabel.Size = new System.Drawing.Size(247, 20);
            this.occupantLabel.TabIndex = 9;
            this.occupantLabel.Text = "No Occupant: Available Apartment";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.comboBox4);
            this.panel7.Controls.Add(this.label10);
            this.panel7.Location = new System.Drawing.Point(20, 487);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(319, 59);
            this.panel7.TabIndex = 10;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(134, 19);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(151, 28);
            this.comboBox4.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(-1, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(133, 20);
            this.label10.TabIndex = 3;
            this.label10.Text = "Change Occupant: ";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.textBox4);
            this.panel8.Controls.Add(this.label11);
            this.panel8.Location = new System.Drawing.Point(19, 561);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(321, 59);
            this.panel8.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(183, 19);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(102, 27);
            this.textBox4.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(-1, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(183, 20);
            this.label11.TabIndex = 3;
            this.label11.Text = "Change Init Deposit Price: ";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.textBox5);
            this.panel9.Controls.Add(this.label12);
            this.panel9.Location = new System.Drawing.Point(19, 626);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(321, 59);
            this.panel9.TabIndex = 7;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(160, 19);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(102, 27);
            this.textBox5.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(-1, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(160, 20);
            this.label12.TabIndex = 3;
            this.label12.Text = "Change Monthly Price: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(689, 237);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(398, 255);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(19, 718);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(94, 29);
            this.saveBtn.TabIndex = 12;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // EditApartmentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 773);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.occupantLabel);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.buildingLabel);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.classLabel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.aIDLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel4);
            this.Name = "EditApartmentView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Apartment";
            this.Load += new System.EventHandler(this.EditApartmentView_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label aIDLabel;
        private Panel panel1;
        private TextBox locationLa;
        private Label locationLabel;
        private Panel panel2;
        private Label label2;
        private Panel panel3;
        private TextBox floorLabel;
        private Label label3;
        private Label classLabel;
        private Panel panel4;
        private ComboBox classBox;
        private Label label5;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ComboBox statusBox;
        private Label buildingLabel;
        private Panel panel5;
        private ComboBox buildingBox;
        private Label label7;
        private Panel panel6;
        private TextBox reasonLabel;
        private Label label8;
        private Label occupantLabel;
        private Panel panel7;
        private ComboBox comboBox4;
        private Label label10;
        private Panel panel8;
        private TextBox textBox4;
        private Label label11;
        private Panel panel9;
        private TextBox textBox5;
        private Label label12;
        private PictureBox pictureBox1;
        private Button saveBtn;
    }
}