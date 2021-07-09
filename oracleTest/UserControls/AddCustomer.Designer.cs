namespace oracleTest
{
    partial class AddCustomer
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_CustomerName = new System.Windows.Forms.TextBox();
            this.txt_CustomerPH = new System.Windows.Forms.TextBox();
            this.txt_CustomerEmail = new System.Windows.Forms.TextBox();
            this.btn_SaveNewCustomer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Customer phone number";
            // 
            // txt_CustomerName
            // 
            this.txt_CustomerName.Location = new System.Drawing.Point(219, 39);
            this.txt_CustomerName.Name = "txt_CustomerName";
            this.txt_CustomerName.Size = new System.Drawing.Size(100, 22);
            this.txt_CustomerName.TabIndex = 3;
            // 
            // txt_CustomerPH
            // 
            this.txt_CustomerPH.Location = new System.Drawing.Point(219, 128);
            this.txt_CustomerPH.Name = "txt_CustomerPH";
            this.txt_CustomerPH.Size = new System.Drawing.Size(100, 22);
            this.txt_CustomerPH.TabIndex = 4;
            // 
            // txt_CustomerEmail
            // 
            this.txt_CustomerEmail.Location = new System.Drawing.Point(219, 85);
            this.txt_CustomerEmail.Name = "txt_CustomerEmail";
            this.txt_CustomerEmail.Size = new System.Drawing.Size(100, 22);
            this.txt_CustomerEmail.TabIndex = 5;
            // 
            // btn_SaveNewCustomer
            // 
            this.btn_SaveNewCustomer.Location = new System.Drawing.Point(129, 187);
            this.btn_SaveNewCustomer.Name = "btn_SaveNewCustomer";
            this.btn_SaveNewCustomer.Size = new System.Drawing.Size(102, 50);
            this.btn_SaveNewCustomer.TabIndex = 6;
            this.btn_SaveNewCustomer.Text = "Save";
            this.btn_SaveNewCustomer.UseVisualStyleBackColor = true;
            this.btn_SaveNewCustomer.Click += new System.EventHandler(this.btn_SaveNewCustomer_Click);
            // 
            // AddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_SaveNewCustomer);
            this.Controls.Add(this.txt_CustomerEmail);
            this.Controls.Add(this.txt_CustomerPH);
            this.Controls.Add(this.txt_CustomerName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddCustomer";
            this.Size = new System.Drawing.Size(377, 273);
            this.Load += new System.EventHandler(this.AddCustomer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_CustomerName;
        private System.Windows.Forms.TextBox txt_CustomerPH;
        private System.Windows.Forms.TextBox txt_CustomerEmail;
        private System.Windows.Forms.Button btn_SaveNewCustomer;
    }
}
