namespace prjWinCsStringDateTime
{
    partial class frmBookString
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtFullname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtCppc = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblFistname = new System.Windows.Forms.Label();
            this.lblLastname = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblProvince = new System.Windows.Forms.Label();
            this.lblPostal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(400, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADDRESS-BOOK";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lastname, Firstname";
            // 
            // txtFullname
            // 
            this.txtFullname.Location = new System.Drawing.Point(64, 128);
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.Size = new System.Drawing.Size(315, 30);
            this.txtFullname.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(276, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "City, Province, Postal Code";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(64, 212);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(315, 30);
            this.txtAddress.TabIndex = 5;
            // 
            // txtCppc
            // 
            this.txtCppc.Location = new System.Drawing.Point(64, 295);
            this.txtCppc.Name = "txtCppc";
            this.txtCppc.Size = new System.Drawing.Size(315, 30);
            this.txtCppc.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(505, 370);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(198, 58);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "button1";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblFistname
            // 
            this.lblFistname.Location = new System.Drawing.Point(64, 515);
            this.lblFistname.Name = "lblFistname";
            this.lblFistname.Size = new System.Drawing.Size(385, 39);
            this.lblFistname.TabIndex = 8;
            this.lblFistname.Text = "label5";
            // 
            // lblLastname
            // 
            this.lblLastname.Location = new System.Drawing.Point(553, 515);
            this.lblLastname.Name = "lblLastname";
            this.lblLastname.Size = new System.Drawing.Size(379, 39);
            this.lblLastname.TabIndex = 12;
            this.lblLastname.Text = "label7";
            // 
            // lblAddress
            // 
            this.lblAddress.Location = new System.Drawing.Point(64, 637);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(869, 39);
            this.lblAddress.TabIndex = 13;
            this.lblAddress.Text = "label6";
            // 
            // lblCity
            // 
            this.lblCity.Location = new System.Drawing.Point(64, 710);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(276, 39);
            this.lblCity.TabIndex = 14;
            this.lblCity.Text = "label8";
            // 
            // lblProvince
            // 
            this.lblProvince.Location = new System.Drawing.Point(393, 710);
            this.lblProvince.Name = "lblProvince";
            this.lblProvince.Size = new System.Drawing.Size(276, 39);
            this.lblProvince.TabIndex = 15;
            this.lblProvince.Text = "label9";
            // 
            // lblPostal
            // 
            this.lblPostal.Location = new System.Drawing.Point(663, 710);
            this.lblPostal.Name = "lblPostal";
            this.lblPostal.Size = new System.Drawing.Size(270, 39);
            this.lblPostal.TabIndex = 16;
            this.lblPostal.Text = "label10";
            // 
            // frmBookString
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 855);
            this.Controls.Add(this.lblPostal);
            this.Controls.Add(this.lblProvince);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblLastname);
            this.Controls.Add(this.lblFistname);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtCppc);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFullname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmBookString";
            this.Text = "frmBookString";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFullname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtCppc;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblFistname;
        private System.Windows.Forms.Label lblLastname;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblProvince;
        private System.Windows.Forms.Label lblPostal;
    }
}