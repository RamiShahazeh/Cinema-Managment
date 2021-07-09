namespace oracleTest
{
    partial class AddDiscount
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
            this.txt_MinPoints = new System.Windows.Forms.TextBox();
            this.cb_filmType = new System.Windows.Forms.ComboBox();
            this.label24 = new System.Windows.Forms.Label();
            this.rb_filmType = new System.Windows.Forms.RadioButton();
            this.rb_points = new System.Windows.Forms.RadioButton();
            this.btn_saveNewDiscount = new System.Windows.Forms.Button();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.txt_Discount = new System.Windows.Forms.TextBox();
            this.dtp_DisEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtp_DisStartDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // txt_MinPoints
            // 
            this.txt_MinPoints.Location = new System.Drawing.Point(264, 206);
            this.txt_MinPoints.Name = "txt_MinPoints";
            this.txt_MinPoints.Size = new System.Drawing.Size(91, 22);
            this.txt_MinPoints.TabIndex = 87;
            // 
            // cb_filmType
            // 
            this.cb_filmType.FormattingEnabled = true;
            this.cb_filmType.Location = new System.Drawing.Point(134, 204);
            this.cb_filmType.Name = "cb_filmType";
            this.cb_filmType.Size = new System.Drawing.Size(104, 24);
            this.cb_filmType.TabIndex = 86;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(19, 163);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(35, 17);
            this.label24.TabIndex = 85;
            this.label24.Text = "type";
            // 
            // rb_filmType
            // 
            this.rb_filmType.AutoSize = true;
            this.rb_filmType.Location = new System.Drawing.Point(134, 161);
            this.rb_filmType.Name = "rb_filmType";
            this.rb_filmType.Size = new System.Drawing.Size(104, 21);
            this.rb_filmType.TabIndex = 84;
            this.rb_filmType.TabStop = true;
            this.rb_filmType.Text = "On film type";
            this.rb_filmType.UseVisualStyleBackColor = true;
            // 
            // rb_points
            // 
            this.rb_points.AutoSize = true;
            this.rb_points.Location = new System.Drawing.Point(264, 161);
            this.rb_points.Name = "rb_points";
            this.rb_points.Size = new System.Drawing.Size(91, 21);
            this.rb_points.TabIndex = 83;
            this.rb_points.TabStop = true;
            this.rb_points.Text = "On Points";
            this.rb_points.UseVisualStyleBackColor = true;
            // 
            // btn_saveNewDiscount
            // 
            this.btn_saveNewDiscount.Location = new System.Drawing.Point(123, 259);
            this.btn_saveNewDiscount.Name = "btn_saveNewDiscount";
            this.btn_saveNewDiscount.Size = new System.Drawing.Size(115, 45);
            this.btn_saveNewDiscount.TabIndex = 81;
            this.btn_saveNewDiscount.Text = "Save";
            this.btn_saveNewDiscount.UseVisualStyleBackColor = true;
            this.btn_saveNewDiscount.Click += new System.EventHandler(this.btn_saveNewDiscount_Click);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(19, 113);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(63, 17);
            this.label26.TabIndex = 80;
            this.label26.Text = "End time";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(19, 66);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(68, 17);
            this.label27.TabIndex = 79;
            this.label27.Text = "Start time";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(19, 26);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(63, 17);
            this.label28.TabIndex = 78;
            this.label28.Text = "Discount";
            // 
            // txt_Discount
            // 
            this.txt_Discount.Location = new System.Drawing.Point(135, 23);
            this.txt_Discount.Name = "txt_Discount";
            this.txt_Discount.Size = new System.Drawing.Size(149, 22);
            this.txt_Discount.TabIndex = 76;
            // 
            // dtp_DisEndDate
            // 
            this.dtp_DisEndDate.CustomFormat = "dd-MMM-yy";
            this.dtp_DisEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_DisEndDate.Location = new System.Drawing.Point(135, 108);
            this.dtp_DisEndDate.Name = "dtp_DisEndDate";
            this.dtp_DisEndDate.Size = new System.Drawing.Size(149, 22);
            this.dtp_DisEndDate.TabIndex = 88;
            // 
            // dtp_DisStartDate
            // 
            this.dtp_DisStartDate.CustomFormat = "dd-MMM-yy";
            this.dtp_DisStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_DisStartDate.Location = new System.Drawing.Point(135, 61);
            this.dtp_DisStartDate.Name = "dtp_DisStartDate";
            this.dtp_DisStartDate.Size = new System.Drawing.Size(149, 22);
            this.dtp_DisStartDate.TabIndex = 89;
            // 
            // AddDiscount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dtp_DisStartDate);
            this.Controls.Add(this.dtp_DisEndDate);
            this.Controls.Add(this.txt_MinPoints);
            this.Controls.Add(this.cb_filmType);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.rb_filmType);
            this.Controls.Add(this.rb_points);
            this.Controls.Add(this.btn_saveNewDiscount);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.txt_Discount);
            this.Name = "AddDiscount";
            this.Size = new System.Drawing.Size(376, 327);
            this.Load += new System.EventHandler(this.AddDiscount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_MinPoints;
        private System.Windows.Forms.ComboBox cb_filmType;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.RadioButton rb_filmType;
        private System.Windows.Forms.RadioButton rb_points;
        private System.Windows.Forms.Button btn_saveNewDiscount;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox txt_Discount;
        private System.Windows.Forms.DateTimePicker dtp_DisEndDate;
        private System.Windows.Forms.DateTimePicker dtp_DisStartDate;
    }
}
