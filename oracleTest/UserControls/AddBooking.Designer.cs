namespace oracleTest
{
    partial class AddBooking
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
            this.txt_bookingSeatNum = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cb_shows = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txt_bookingCustomer = new System.Windows.Forms.TextBox();
            this.btn_bookingSave = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.dtp_bookingDate = new System.Windows.Forms.DateTimePicker();
            this.ch_customerPaid = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_avSeats = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.clb_seats = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_bookingId = new System.Windows.Forms.TextBox();
            this.btn_check = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_bookingSeatNum
            // 
            this.txt_bookingSeatNum.Location = new System.Drawing.Point(143, 186);
            this.txt_bookingSeatNum.Name = "txt_bookingSeatNum";
            this.txt_bookingSeatNum.Size = new System.Drawing.Size(106, 22);
            this.txt_bookingSeatNum.TabIndex = 62;
            this.txt_bookingSeatNum.TextChanged += new System.EventHandler(this.txt_bookingSeatNum_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(30, 25);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(42, 17);
            this.label17.TabIndex = 61;
            this.label17.Text = "Show";
            // 
            // cb_shows
            // 
            this.cb_shows.FormattingEnabled = true;
            this.cb_shows.Location = new System.Drawing.Point(143, 18);
            this.cb_shows.Name = "cb_shows";
            this.cb_shows.Size = new System.Drawing.Size(146, 24);
            this.cb_shows.TabIndex = 60;
            this.cb_shows.SelectedIndexChanged += new System.EventHandler(this.cb_shows_SelectedIndexChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(30, 239);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(85, 17);
            this.label19.TabIndex = 59;
            this.label19.Text = "Customer ID";
            // 
            // txt_bookingCustomer
            // 
            this.txt_bookingCustomer.Location = new System.Drawing.Point(140, 236);
            this.txt_bookingCustomer.Name = "txt_bookingCustomer";
            this.txt_bookingCustomer.Size = new System.Drawing.Size(149, 22);
            this.txt_bookingCustomer.TabIndex = 58;
            // 
            // btn_bookingSave
            // 
            this.btn_bookingSave.Location = new System.Drawing.Point(37, 287);
            this.btn_bookingSave.Name = "btn_bookingSave";
            this.btn_bookingSave.Size = new System.Drawing.Size(115, 45);
            this.btn_bookingSave.TabIndex = 57;
            this.btn_bookingSave.Text = "Save";
            this.btn_bookingSave.UseVisualStyleBackColor = true;
            this.btn_bookingSave.Click += new System.EventHandler(this.btn_bookingSave_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(30, 191);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(112, 17);
            this.label20.TabIndex = 56;
            this.label20.Text = "Number of seats";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(34, 69);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(38, 17);
            this.label22.TabIndex = 54;
            this.label22.Text = "Date";
            // 
            // dtp_bookingDate
            // 
            this.dtp_bookingDate.CustomFormat = "dd-MMM-yy";
            this.dtp_bookingDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_bookingDate.Location = new System.Drawing.Point(143, 64);
            this.dtp_bookingDate.Name = "dtp_bookingDate";
            this.dtp_bookingDate.Size = new System.Drawing.Size(149, 22);
            this.dtp_bookingDate.TabIndex = 63;
            // 
            // ch_customerPaid
            // 
            this.ch_customerPaid.AutoSize = true;
            this.ch_customerPaid.Location = new System.Drawing.Point(143, 104);
            this.ch_customerPaid.Name = "ch_customerPaid";
            this.ch_customerPaid.Size = new System.Drawing.Size(122, 21);
            this.ch_customerPaid.TabIndex = 66;
            this.ch_customerPaid.Text = "Customer Paid";
            this.ch_customerPaid.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(186, 287);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 45);
            this.button1.TabIndex = 67;
            this.button1.Text = "Print customer Card";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txt_avSeats
            // 
            this.txt_avSeats.Location = new System.Drawing.Point(186, 141);
            this.txt_avSeats.Name = "txt_avSeats";
            this.txt_avSeats.ReadOnly = true;
            this.txt_avSeats.Size = new System.Drawing.Size(46, 22);
            this.txt_avSeats.TabIndex = 68;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 69;
            this.label1.Text = "Available seats";
            // 
            // clb_seats
            // 
            this.clb_seats.FormattingEnabled = true;
            this.clb_seats.Location = new System.Drawing.Point(327, 40);
            this.clb_seats.Name = "clb_seats";
            this.clb_seats.Size = new System.Drawing.Size(143, 242);
            this.clb_seats.TabIndex = 70;
            this.clb_seats.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(324, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 17);
            this.label2.TabIndex = 71;
            this.label2.Text = "Row   -   Number";
            this.label2.Visible = false;
            // 
            // txt_bookingId
            // 
            this.txt_bookingId.Location = new System.Drawing.Point(344, 298);
            this.txt_bookingId.Name = "txt_bookingId";
            this.txt_bookingId.Size = new System.Drawing.Size(64, 22);
            this.txt_bookingId.TabIndex = 73;
            this.txt_bookingId.Visible = false;
            // 
            // btn_check
            // 
            this.btn_check.Location = new System.Drawing.Point(255, 185);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(58, 25);
            this.btn_check.TabIndex = 74;
            this.btn_check.Text = "Check";
            this.btn_check.UseVisualStyleBackColor = true;
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // AddBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_check);
            this.Controls.Add(this.txt_bookingId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.clb_seats);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_avSeats);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ch_customerPaid);
            this.Controls.Add(this.dtp_bookingDate);
            this.Controls.Add(this.txt_bookingSeatNum);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.cb_shows);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txt_bookingCustomer);
            this.Controls.Add(this.btn_bookingSave);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label22);
            this.Name = "AddBooking";
            this.Size = new System.Drawing.Size(536, 361);
            this.Load += new System.EventHandler(this.AddBooking_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_bookingSeatNum;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cb_shows;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txt_bookingCustomer;
        private System.Windows.Forms.Button btn_bookingSave;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.DateTimePicker dtp_bookingDate;
        private System.Windows.Forms.CheckBox ch_customerPaid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_avSeats;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox clb_seats;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_bookingId;
        private System.Windows.Forms.Button btn_check;
    }
}
