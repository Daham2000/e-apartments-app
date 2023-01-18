namespace e_apartments_app.View
{
    partial class EditClassView
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
            this.label1 = new System.Windows.Forms.Label();
            this.savebtn = new System.Windows.Forms.Button();
            this.clsName = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.bedRooms = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.commonBath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.attachBathNum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.servantRoomNum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.servantBathNum = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 28);
            this.label1.TabIndex = 0;
            // 
            // savebtn
            // 
            this.savebtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.savebtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.savebtn.Location = new System.Drawing.Point(18, 226);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(94, 29);
            this.savebtn.TabIndex = 1;
            this.savebtn.Text = "Save";
            this.savebtn.UseVisualStyleBackColor = false;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // clsName
            // 
            this.clsName.AutoSize = true;
            this.clsName.Location = new System.Drawing.Point(18, 19);
            this.clsName.Name = "clsName";
            this.clsName.Size = new System.Drawing.Size(89, 20);
            this.clsName.TabIndex = 2;
            this.clsName.Text = "Class Name:";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(187, 16);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(211, 27);
            this.name.TabIndex = 3;
            // 
            // bedRooms
            // 
            this.bedRooms.Location = new System.Drawing.Point(187, 51);
            this.bedRooms.Name = "bedRooms";
            this.bedRooms.Size = new System.Drawing.Size(211, 27);
            this.bedRooms.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Num Of Bed Rooms:";
            // 
            // commonBath
            // 
            this.commonBath.Location = new System.Drawing.Point(187, 85);
            this.commonBath.Name = "commonBath";
            this.commonBath.Size = new System.Drawing.Size(211, 27);
            this.commonBath.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Num Of Common Bath:";
            // 
            // attachBathNum
            // 
            this.attachBathNum.Location = new System.Drawing.Point(187, 118);
            this.attachBathNum.Name = "attachBathNum";
            this.attachBathNum.Size = new System.Drawing.Size(211, 27);
            this.attachBathNum.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Num Of Attach Bath:";
            // 
            // servantRoomNum
            // 
            this.servantRoomNum.Location = new System.Drawing.Point(187, 153);
            this.servantRoomNum.Name = "servantRoomNum";
            this.servantRoomNum.Size = new System.Drawing.Size(211, 27);
            this.servantRoomNum.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Num Of Servant Rooms:";
            // 
            // servantBathNum
            // 
            this.servantBathNum.Location = new System.Drawing.Point(187, 185);
            this.servantBathNum.Name = "servantBathNum";
            this.servantBathNum.Size = new System.Drawing.Size(211, 27);
            this.servantBathNum.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Num Of Servant Bath:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(681, 261);
            this.panel1.TabIndex = 14;
            // 
            // EditClassView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.servantBathNum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.servantRoomNum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.attachBathNum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.commonBath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bedRooms);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.name);
            this.Controls.Add(this.clsName);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "EditClassView";
            this.Size = new System.Drawing.Size(681, 276);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button savebtn;
        private Label clsName;
        private TextBox name;
        private TextBox bedRooms;
        private Label label2;
        private TextBox commonBath;
        private Label label3;
        private TextBox attachBathNum;
        private Label label4;
        private TextBox servantRoomNum;
        private Label label5;
        private TextBox servantBathNum;
        private Label label6;
        private Panel panel1;
    }
}
