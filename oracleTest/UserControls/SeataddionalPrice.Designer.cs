namespace oracleTest
{
    partial class SeataddionalPrice
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
            this.btn_saveNewSeatPrice = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.cb_shows = new System.Windows.Forms.ComboBox();
            this.l3 = new System.Windows.Forms.Label();
            this.txt_addionalPrice = new System.Windows.Forms.TextBox();
            this.l1 = new System.Windows.Forms.Label();
            this.clb_seats = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // btn_saveNewSeatPrice
            // 
            this.btn_saveNewSeatPrice.Location = new System.Drawing.Point(137, 307);
            this.btn_saveNewSeatPrice.Name = "btn_saveNewSeatPrice";
            this.btn_saveNewSeatPrice.Size = new System.Drawing.Size(115, 45);
            this.btn_saveNewSeatPrice.TabIndex = 77;
            this.btn_saveNewSeatPrice.Text = "Save";
            this.btn_saveNewSeatPrice.UseVisualStyleBackColor = true;
            this.btn_saveNewSeatPrice.Click += new System.EventHandler(this.btn_saveNewSeatPrice_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(17, 43);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(42, 17);
            this.label17.TabIndex = 79;
            this.label17.Text = "Show";
            // 
            // cb_shows
            // 
            this.cb_shows.FormattingEnabled = true;
            this.cb_shows.Location = new System.Drawing.Point(137, 40);
            this.cb_shows.Name = "cb_shows";
            this.cb_shows.Size = new System.Drawing.Size(146, 24);
            this.cb_shows.TabIndex = 78;
            this.cb_shows.SelectedValueChanged += new System.EventHandler(this.cb_shows_SelectedValueChanged);
            // 
            // l3
            // 
            this.l3.AutoSize = true;
            this.l3.Location = new System.Drawing.Point(17, 257);
            this.l3.Name = "l3";
            this.l3.Size = new System.Drawing.Size(98, 17);
            this.l3.TabIndex = 85;
            this.l3.Text = "Addional price";
            this.l3.Visible = false;
            // 
            // txt_addionalPrice
            // 
            this.txt_addionalPrice.Location = new System.Drawing.Point(137, 254);
            this.txt_addionalPrice.Name = "txt_addionalPrice";
            this.txt_addionalPrice.Size = new System.Drawing.Size(146, 22);
            this.txt_addionalPrice.TabIndex = 84;
            this.txt_addionalPrice.Visible = false;
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.Location = new System.Drawing.Point(17, 145);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(114, 17);
            this.l1.TabIndex = 87;
            this.l1.Text = "Row   -   Number";
            this.l1.Visible = false;
            // 
            // clb_seats
            // 
            this.clb_seats.FormattingEnabled = true;
            this.clb_seats.Location = new System.Drawing.Point(137, 80);
            this.clb_seats.Name = "clb_seats";
            this.clb_seats.Size = new System.Drawing.Size(146, 157);
            this.clb_seats.TabIndex = 86;
            this.clb_seats.Visible = false;
            // 
            // SeataddionalPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.l1);
            this.Controls.Add(this.clb_seats);
            this.Controls.Add(this.l3);
            this.Controls.Add(this.txt_addionalPrice);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.cb_shows);
            this.Controls.Add(this.btn_saveNewSeatPrice);
            this.Name = "SeataddionalPrice";
            this.Size = new System.Drawing.Size(380, 377);
            this.Load += new System.EventHandler(this.SeataddionalPrice_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_saveNewSeatPrice;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cb_shows;
        private System.Windows.Forms.Label l3;
        private System.Windows.Forms.TextBox txt_addionalPrice;
        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.CheckedListBox clb_seats;
    }
}
