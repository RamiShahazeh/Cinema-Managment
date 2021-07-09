namespace oracleTest
{
    partial class AddShow
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
            this.label4 = new System.Windows.Forms.Label();
            this.txt_showPoints = new System.Windows.Forms.TextBox();
            this.cb_showroomId = new System.Windows.Forms.ComboBox();
            this.cb_filmName = new System.Windows.Forms.ComboBox();
            this.btn_saveNewShow = new System.Windows.Forms.Button();
            this.txt_showPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtp_ShowDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Show Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Show Points";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Showroom ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Film Name";
            // 
            // txt_showPoints
            // 
            this.txt_showPoints.Location = new System.Drawing.Point(146, 79);
            this.txt_showPoints.Name = "txt_showPoints";
            this.txt_showPoints.Size = new System.Drawing.Size(100, 22);
            this.txt_showPoints.TabIndex = 5;
            // 
            // cb_showroomId
            // 
            this.cb_showroomId.FormattingEnabled = true;
            this.cb_showroomId.Location = new System.Drawing.Point(146, 131);
            this.cb_showroomId.Name = "cb_showroomId";
            this.cb_showroomId.Size = new System.Drawing.Size(100, 24);
            this.cb_showroomId.TabIndex = 6;
            // 
            // cb_filmName
            // 
            this.cb_filmName.FormattingEnabled = true;
            this.cb_filmName.Location = new System.Drawing.Point(146, 176);
            this.cb_filmName.Name = "cb_filmName";
            this.cb_filmName.Size = new System.Drawing.Size(100, 24);
            this.cb_filmName.TabIndex = 7;
            // 
            // btn_saveNewShow
            // 
            this.btn_saveNewShow.Location = new System.Drawing.Point(78, 284);
            this.btn_saveNewShow.Name = "btn_saveNewShow";
            this.btn_saveNewShow.Size = new System.Drawing.Size(107, 50);
            this.btn_saveNewShow.TabIndex = 8;
            this.btn_saveNewShow.Text = "Save";
            this.btn_saveNewShow.UseVisualStyleBackColor = true;
            this.btn_saveNewShow.Click += new System.EventHandler(this.btn_saveNewShow_Click);
            // 
            // txt_showPrice
            // 
            this.txt_showPrice.Location = new System.Drawing.Point(146, 228);
            this.txt_showPrice.Name = "txt_showPrice";
            this.txt_showPrice.Size = new System.Drawing.Size(100, 22);
            this.txt_showPrice.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Show Price";
            // 
            // dtp_ShowDate
            // 
            this.dtp_ShowDate.CustomFormat = "dd-MMM-yy";
            this.dtp_ShowDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_ShowDate.Location = new System.Drawing.Point(146, 28);
            this.dtp_ShowDate.Name = "dtp_ShowDate";
            this.dtp_ShowDate.Size = new System.Drawing.Size(100, 22);
            this.dtp_ShowDate.TabIndex = 64;
            this.dtp_ShowDate.Value = new System.DateTime(2019, 2, 23, 0, 0, 0, 0);
            this.dtp_ShowDate.ValueChanged += new System.EventHandler(this.dtp_ShowDate_ValueChanged);
            // 
            // AddShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txt_showPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_saveNewShow);
            this.Controls.Add(this.cb_filmName);
            this.Controls.Add(this.cb_showroomId);
            this.Controls.Add(this.txt_showPoints);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtp_ShowDate);
            this.Name = "AddShow";
            this.Size = new System.Drawing.Size(302, 365);
            this.Load += new System.EventHandler(this.AddShow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_showPoints;
        private System.Windows.Forms.ComboBox cb_showroomId;
        private System.Windows.Forms.ComboBox cb_filmName;
        private System.Windows.Forms.Button btn_saveNewShow;
        private System.Windows.Forms.TextBox txt_showPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtp_ShowDate;
    }
}
