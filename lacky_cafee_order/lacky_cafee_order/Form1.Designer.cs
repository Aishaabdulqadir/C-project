namespace lacky_cafee_order
{
    partial class Form1
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.rdoTea = new System.Windows.Forms.RadioButton();
            this.rdoJuice = new System.Windows.Forms.RadioButton();
            this.rdoCoffee = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkStudent = new System.Windows.Forms.CheckBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblLucky = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "customer Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(33, 124);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(412, 26);
            this.txtName.TabIndex = 1;
            // 
            // rdoTea
            // 
            this.rdoTea.AutoSize = true;
            this.rdoTea.Location = new System.Drawing.Point(13, 52);
            this.rdoTea.Name = "rdoTea";
            this.rdoTea.Size = new System.Drawing.Size(101, 24);
            this.rdoTea.TabIndex = 2;
            this.rdoTea.TabStop = true;
            this.rdoTea.Text = "Tea ($1)";
            this.rdoTea.UseVisualStyleBackColor = true;
            // 
            // rdoJuice
            // 
            this.rdoJuice.AutoSize = true;
            this.rdoJuice.Location = new System.Drawing.Point(13, 140);
            this.rdoJuice.Name = "rdoJuice";
            this.rdoJuice.Size = new System.Drawing.Size(113, 24);
            this.rdoJuice.TabIndex = 3;
            this.rdoJuice.TabStop = true;
            this.rdoJuice.Text = "Juice ($3)";
            this.rdoJuice.UseVisualStyleBackColor = true;
            // 
            // rdoCoffee
            // 
            this.rdoCoffee.AutoSize = true;
            this.rdoCoffee.Location = new System.Drawing.Point(13, 96);
            this.rdoCoffee.Name = "rdoCoffee";
            this.rdoCoffee.Size = new System.Drawing.Size(125, 24);
            this.rdoCoffee.TabIndex = 4;
            this.rdoCoffee.TabStop = true;
            this.rdoCoffee.Text = "Coffee ($2)";
            this.rdoCoffee.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoCoffee);
            this.groupBox1.Controls.Add(this.rdoJuice);
            this.groupBox1.Controls.Add(this.rdoTea);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(22, 173);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(482, 198);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Drink Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 411);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Quantity:";
            // 
            // chkStudent
            // 
            this.chkStudent.AutoSize = true;
            this.chkStudent.Location = new System.Drawing.Point(308, 411);
            this.chkStudent.Name = "chkStudent";
            this.chkStudent.Size = new System.Drawing.Size(223, 24);
            this.chkStudent.TabIndex = 8;
            this.chkStudent.Text = "Student Member (10% off)";
            this.chkStudent.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(33, 510);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(182, 48);
            this.btnCalculate.TabIndex = 9;
            this.btnCalculate.Text = "Calcate Order";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(266, 510);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(164, 48);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save to file ";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(715, 510);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(200, 48);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "clear ";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(493, 510);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(183, 48);
            this.btnLoad.TabIndex = 13;
            this.btnLoad.Text = "load from file ";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(33, 572);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(975, 110);
            this.label4.TabIndex = 14;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(561, 92);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(443, 384);
            this.listBox1.TabIndex = 15;
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(119, 411);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(120, 26);
            this.txtQty.TabIndex = 16;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblTotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalPrice.Location = new System.Drawing.Point(48, 589);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(456, 31);
            this.lblTotalPrice.TabIndex = 17;
            // 
            // lblLucky
            // 
            this.lblLucky.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblLucky.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLucky.Location = new System.Drawing.Point(48, 641);
            this.lblLucky.Name = "lblLucky";
            this.lblLucky.Size = new System.Drawing.Size(456, 31);
            this.lblLucky.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(507, 41);
            this.label3.TabIndex = 19;
            this.label3.Text = "Lucky Coffee Order";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 702);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblLucky);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.chkStudent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.RadioButton rdoTea;
        private System.Windows.Forms.RadioButton rdoJuice;
        private System.Windows.Forms.RadioButton rdoCoffee;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkStudent;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblLucky;
        private System.Windows.Forms.Label label3;
    }
}

