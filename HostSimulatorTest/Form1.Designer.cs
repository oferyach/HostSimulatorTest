namespace HostSimulatorTest
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
            this.button1 = new System.Windows.Forms.Button();
            this.CardNumber = new System.Windows.Forms.TextBox();
            this.Allowed = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Code = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Message = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SendTrans = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Reference = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Money = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Volume = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Product = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.DriverName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Limit = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Request";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CardNumber
            // 
            this.CardNumber.Location = new System.Drawing.Point(134, 41);
            this.CardNumber.Name = "CardNumber";
            this.CardNumber.Size = new System.Drawing.Size(143, 20);
            this.CardNumber.TabIndex = 1;
            this.CardNumber.Text = "72023434502834";
            // 
            // Allowed
            // 
            this.Allowed.Location = new System.Drawing.Point(110, 29);
            this.Allowed.Name = "Allowed";
            this.Allowed.Size = new System.Drawing.Size(143, 20);
            this.Allowed.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Card Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(321, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Station Code:";
            // 
            // Code
            // 
            this.Code.Location = new System.Drawing.Point(440, 47);
            this.Code.Name = "Code";
            this.Code.Size = new System.Drawing.Size(100, 20);
            this.Code.TabIndex = 5;
            this.Code.Text = "1236";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Limit);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.DriverName);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.Reference);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Message);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Allowed);
            this.groupBox1.Location = new System.Drawing.Point(40, 142);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(635, 137);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Respond";
            // 
            // Message
            // 
            this.Message.Location = new System.Drawing.Point(400, 35);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(218, 20);
            this.Message.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(314, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Message:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Approved:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Product);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.Volume);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.Money);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.SendTrans);
            this.groupBox2.Location = new System.Drawing.Point(40, 303);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(635, 194);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Transaction";
            // 
            // SendTrans
            // 
            this.SendTrans.Location = new System.Drawing.Point(533, 159);
            this.SendTrans.Name = "SendTrans";
            this.SendTrans.Size = new System.Drawing.Size(75, 23);
            this.SendTrans.TabIndex = 0;
            this.SendTrans.Text = "Send";
            this.SendTrans.UseVisualStyleBackColor = true;
            this.SendTrans.Click += new System.EventHandler(this.SendTrans_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Reference:";
            // 
            // Reference
            // 
            this.Reference.Location = new System.Drawing.Point(110, 74);
            this.Reference.Name = "Reference";
            this.Reference.Size = new System.Drawing.Size(143, 20);
            this.Reference.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Money:";
            // 
            // Money
            // 
            this.Money.Location = new System.Drawing.Point(110, 41);
            this.Money.Name = "Money";
            this.Money.Size = new System.Drawing.Size(143, 20);
            this.Money.TabIndex = 2;
            this.Money.Text = "234.6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(317, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Volume:";
            // 
            // Volume
            // 
            this.Volume.Location = new System.Drawing.Point(400, 40);
            this.Volume.Name = "Volume";
            this.Volume.Size = new System.Drawing.Size(144, 20);
            this.Volume.TabIndex = 4;
            this.Volume.Text = "45.9";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Product Code:";
            // 
            // Product
            // 
            this.Product.Location = new System.Drawing.Point(110, 98);
            this.Product.Name = "Product";
            this.Product.Size = new System.Drawing.Size(143, 20);
            this.Product.TabIndex = 6;
            this.Product.Text = "103";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(317, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Driver:";
            // 
            // DriverName
            // 
            this.DriverName.Location = new System.Drawing.Point(400, 80);
            this.DriverName.Name = "DriverName";
            this.DriverName.Size = new System.Drawing.Size(218, 20);
            this.DriverName.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 106);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Limit:";
            // 
            // Limit
            // 
            this.Limit.Location = new System.Drawing.Point(110, 106);
            this.Limit.Name = "Limit";
            this.Limit.Size = new System.Drawing.Size(143, 20);
            this.Limit.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 509);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Code);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CardNumber);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox CardNumber;
        private System.Windows.Forms.TextBox Allowed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Code;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Message;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button SendTrans;
        private System.Windows.Forms.TextBox Reference;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Product;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Volume;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Money;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Limit;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox DriverName;
        private System.Windows.Forms.Label label9;
    }
}

