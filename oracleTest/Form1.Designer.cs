namespace oracleTest
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
            this.btn_searchFilmWorkers = new System.Windows.Forms.TabControl();
            this.mainTab = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.la = new System.Windows.Forms.Label();
            this.txt_empName = new System.Windows.Forms.TextBox();
            this.txt_empId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_logIn = new System.Windows.Forms.Button();
            this.CustomerTab = new System.Windows.Forms.TabPage();
            this.lb_customerTypeinterest = new System.Windows.Forms.Label();
            this.txt_customerTypeinterest = new System.Windows.Forms.TextBox();
            this.lb_customerIDinterest = new System.Windows.Forms.Label();
            this.txt_customerIDinterest = new System.Windows.Forms.TextBox();
            this.btn_showCustomerInt = new System.Windows.Forms.Button();
            this.tb_customerID = new System.Windows.Forms.TextBox();
            this.l1 = new System.Windows.Forms.Label();
            this.btn_getCustomerInterest = new System.Windows.Forms.Button();
            this.btn_showCustomer = new System.Windows.Forms.Button();
            this.customer_dgv = new System.Windows.Forms.DataGridView();
            this.c_CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_CustomerEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_CustomerPoints = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_CustomerPH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Employee_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_addCustomer = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.showTab = new System.Windows.Forms.TabPage();
            this.btn_searchShow = new System.Windows.Forms.Button();
            this.tb_searchShow = new System.Windows.Forms.TextBox();
            this.lb_searchShow = new System.Windows.Forms.Label();
            this.show_dgv = new System.Windows.Forms.DataGridView();
            this.c_showid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_showDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_showPoints = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_showPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_filmDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_filmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_filmDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_employeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_showroomID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_filmID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_showroomName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_employeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brn_showAllShows = new System.Windows.Forms.Button();
            this.btn_addNewShow = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.BookingTab = new System.Windows.Forms.TabPage();
            this.btn_searchBooking = new System.Windows.Forms.Button();
            this.tb_searchBooking = new System.Windows.Forms.TextBox();
            this.lb_searchBooking = new System.Windows.Forms.Label();
            this.booking_dgv = new System.Windows.Forms.DataGridView();
            this.c_booking_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_booking_at_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_customer_paid_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_Seats = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_booking_canceled = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_Show_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_Customer_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_employee_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_employee_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_viewAllBooking = new System.Windows.Forms.Button();
            this.btn_addNewBooking = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.SeatPriceTab = new System.Windows.Forms.TabPage();
            this.btn_searchSeats = new System.Windows.Forms.Button();
            this.tb_searchSeat = new System.Windows.Forms.TextBox();
            this.lb_searchSeat = new System.Windows.Forms.Label();
            this.dgv_seatPrices = new System.Windows.Forms.DataGridView();
            this.c_seat_row = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_seat_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_showroom_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_show_id_seats = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_seat_additional_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_seat_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_total_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_seat_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_showroom_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_ViewSeatPrices = new System.Windows.Forms.Button();
            this.btn_addSeatPrice = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.DiscountTab = new System.Windows.Forms.TabPage();
            this.discount_dgv = new System.Windows.Forms.DataGridView();
            this.c_rule_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_start_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_end_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_film_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_points = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_type_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_viewAllRules = new System.Windows.Forms.Button();
            this.btn_addNewDiscount = new System.Windows.Forms.Button();
            this.label29 = new System.Windows.Forms.Label();
            this.FilmTab = new System.Windows.Forms.TabPage();
            this.btn_searchFilm = new System.Windows.Forms.Button();
            this.tb_searchFilm = new System.Windows.Forms.TextBox();
            this.lb_searchFilm = new System.Windows.Forms.Label();
            this.film_dgv = new System.Windows.Forms.DataGridView();
            this.c_film_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_film_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_filmDes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_film_dur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FilmType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_viewAllFilms = new System.Windows.Forms.Button();
            this.btn_addFilm = new System.Windows.Forms.Button();
            this.label34 = new System.Windows.Forms.Label();
            this.WorkerTab = new System.Windows.Forms.TabPage();
            this.btn_1 = new System.Windows.Forms.Button();
            this.tb_searchFilmWorkers = new System.Windows.Forms.TextBox();
            this.lb_searchFilmWorkers = new System.Windows.Forms.Label();
            this.dgv_worker = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkerRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_viewAllWorkers = new System.Windows.Forms.Button();
            this.btn_addWorker = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.TabReport = new System.Windows.Forms.TabPage();
            this.btn_shorResult = new System.Windows.Forms.Button();
            this.lbl_empid = new System.Windows.Forms.Label();
            this.txt_emloyee_ID = new System.Windows.Forms.TextBox();
            this.lbl_option = new System.Windows.Forms.Label();
            this.cb_reportOption = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtp_toDateF = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dtp_FromDateF = new System.Windows.Forms.DateTimePicker();
            this.dgv_reports = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_employeeReport = new System.Windows.Forms.Button();
            this.btn_filmReports = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_searchFilmWorkers.SuspendLayout();
            this.mainTab.SuspendLayout();
            this.CustomerTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customer_dgv)).BeginInit();
            this.showTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.show_dgv)).BeginInit();
            this.BookingTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booking_dgv)).BeginInit();
            this.SeatPriceTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_seatPrices)).BeginInit();
            this.DiscountTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.discount_dgv)).BeginInit();
            this.FilmTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.film_dgv)).BeginInit();
            this.WorkerTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_worker)).BeginInit();
            this.TabReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reports)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_searchFilmWorkers
            // 
            this.btn_searchFilmWorkers.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.btn_searchFilmWorkers.Controls.Add(this.mainTab);
            this.btn_searchFilmWorkers.Controls.Add(this.CustomerTab);
            this.btn_searchFilmWorkers.Controls.Add(this.showTab);
            this.btn_searchFilmWorkers.Controls.Add(this.BookingTab);
            this.btn_searchFilmWorkers.Controls.Add(this.SeatPriceTab);
            this.btn_searchFilmWorkers.Controls.Add(this.DiscountTab);
            this.btn_searchFilmWorkers.Controls.Add(this.FilmTab);
            this.btn_searchFilmWorkers.Controls.Add(this.WorkerTab);
            this.btn_searchFilmWorkers.Controls.Add(this.TabReport);
            this.btn_searchFilmWorkers.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_searchFilmWorkers.Location = new System.Drawing.Point(12, 12);
            this.btn_searchFilmWorkers.Name = "btn_searchFilmWorkers";
            this.btn_searchFilmWorkers.SelectedIndex = 0;
            this.btn_searchFilmWorkers.Size = new System.Drawing.Size(1389, 578);
            this.btn_searchFilmWorkers.TabIndex = 1;
            // 
            // mainTab
            // 
            this.mainTab.BackColor = System.Drawing.Color.Transparent;
            this.mainTab.Controls.Add(this.label3);
            this.mainTab.Controls.Add(this.linkLabel1);
            this.mainTab.Controls.Add(this.la);
            this.mainTab.Controls.Add(this.txt_empName);
            this.mainTab.Controls.Add(this.txt_empId);
            this.mainTab.Controls.Add(this.label2);
            this.mainTab.Controls.Add(this.label1);
            this.mainTab.Controls.Add(this.btn_logIn);
            this.mainTab.Location = new System.Drawing.Point(4, 28);
            this.mainTab.Name = "mainTab";
            this.mainTab.Padding = new System.Windows.Forms.Padding(3);
            this.mainTab.Size = new System.Drawing.Size(1381, 546);
            this.mainTab.TabIndex = 0;
            this.mainTab.Text = "Main Page";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(507, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 29);
            this.label3.TabIndex = 32;
            this.label3.Text = "Welcome!";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(585, 357);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(158, 17);
            this.linkLabel1.TabIndex = 31;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Did you forget your ID ?";
            // 
            // la
            // 
            this.la.AutoSize = true;
            this.la.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.la.Location = new System.Drawing.Point(640, 90);
            this.la.Name = "la";
            this.la.Size = new System.Drawing.Size(159, 29);
            this.la.TabIndex = 30;
            this.la.Text = "Please log In";
            this.la.Visible = false;
            // 
            // txt_empName
            // 
            this.txt_empName.Location = new System.Drawing.Point(662, 226);
            this.txt_empName.Name = "txt_empName";
            this.txt_empName.Size = new System.Drawing.Size(100, 22);
            this.txt_empName.TabIndex = 29;
            this.txt_empName.Text = "rami_man";
            this.txt_empName.Visible = false;
            // 
            // txt_empId
            // 
            this.txt_empId.Location = new System.Drawing.Point(662, 169);
            this.txt_empId.Name = "txt_empId";
            this.txt_empId.Size = new System.Drawing.Size(100, 22);
            this.txt_empId.TabIndex = 28;
            this.txt_empId.Text = "2";
            this.txt_empId.Visible = false;
            this.txt_empId.TextChanged += new System.EventHandler(this.txt_empId_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(574, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "Name";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(574, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "ID";
            this.label1.Visible = false;
            // 
            // btn_logIn
            // 
            this.btn_logIn.Location = new System.Drawing.Point(599, 285);
            this.btn_logIn.Name = "btn_logIn";
            this.btn_logIn.Size = new System.Drawing.Size(123, 55);
            this.btn_logIn.TabIndex = 25;
            this.btn_logIn.Text = "Log in";
            this.btn_logIn.UseVisualStyleBackColor = true;
            this.btn_logIn.Visible = false;
            this.btn_logIn.Click += new System.EventHandler(this.btn_logIn_Click);
            // 
            // CustomerTab
            // 
            this.CustomerTab.Controls.Add(this.lb_customerTypeinterest);
            this.CustomerTab.Controls.Add(this.txt_customerTypeinterest);
            this.CustomerTab.Controls.Add(this.lb_customerIDinterest);
            this.CustomerTab.Controls.Add(this.txt_customerIDinterest);
            this.CustomerTab.Controls.Add(this.btn_showCustomerInt);
            this.CustomerTab.Controls.Add(this.tb_customerID);
            this.CustomerTab.Controls.Add(this.l1);
            this.CustomerTab.Controls.Add(this.btn_getCustomerInterest);
            this.CustomerTab.Controls.Add(this.btn_showCustomer);
            this.CustomerTab.Controls.Add(this.customer_dgv);
            this.CustomerTab.Controls.Add(this.btn_addCustomer);
            this.CustomerTab.Controls.Add(this.label8);
            this.CustomerTab.Location = new System.Drawing.Point(4, 28);
            this.CustomerTab.Name = "CustomerTab";
            this.CustomerTab.Padding = new System.Windows.Forms.Padding(3);
            this.CustomerTab.Size = new System.Drawing.Size(1381, 546);
            this.CustomerTab.TabIndex = 1;
            this.CustomerTab.Text = "Customer";
            this.CustomerTab.ToolTipText = "Add a new customer";
            this.CustomerTab.UseVisualStyleBackColor = true;
            // 
            // lb_customerTypeinterest
            // 
            this.lb_customerTypeinterest.AutoSize = true;
            this.lb_customerTypeinterest.Location = new System.Drawing.Point(125, 297);
            this.lb_customerTypeinterest.Name = "lb_customerTypeinterest";
            this.lb_customerTypeinterest.Size = new System.Drawing.Size(62, 17);
            this.lb_customerTypeinterest.TabIndex = 103;
            this.lb_customerTypeinterest.Text = "Fav type";
            this.lb_customerTypeinterest.Visible = false;
            // 
            // txt_customerTypeinterest
            // 
            this.txt_customerTypeinterest.Location = new System.Drawing.Point(255, 292);
            this.txt_customerTypeinterest.Name = "txt_customerTypeinterest";
            this.txt_customerTypeinterest.ReadOnly = true;
            this.txt_customerTypeinterest.Size = new System.Drawing.Size(100, 22);
            this.txt_customerTypeinterest.TabIndex = 102;
            this.txt_customerTypeinterest.Visible = false;
            // 
            // lb_customerIDinterest
            // 
            this.lb_customerIDinterest.AutoSize = true;
            this.lb_customerIDinterest.Location = new System.Drawing.Point(125, 250);
            this.lb_customerIDinterest.Name = "lb_customerIDinterest";
            this.lb_customerIDinterest.Size = new System.Drawing.Size(85, 17);
            this.lb_customerIDinterest.TabIndex = 101;
            this.lb_customerIDinterest.Text = "Customer ID";
            this.lb_customerIDinterest.Visible = false;
            // 
            // txt_customerIDinterest
            // 
            this.txt_customerIDinterest.Location = new System.Drawing.Point(255, 247);
            this.txt_customerIDinterest.Name = "txt_customerIDinterest";
            this.txt_customerIDinterest.Size = new System.Drawing.Size(100, 22);
            this.txt_customerIDinterest.TabIndex = 100;
            this.txt_customerIDinterest.Text = "1";
            this.txt_customerIDinterest.Visible = false;
            this.txt_customerIDinterest.TextChanged += new System.EventHandler(this.txt_customerIDinterest_TextChanged);
            // 
            // btn_showCustomerInt
            // 
            this.btn_showCustomerInt.Location = new System.Drawing.Point(1022, 23);
            this.btn_showCustomerInt.Name = "btn_showCustomerInt";
            this.btn_showCustomerInt.Size = new System.Drawing.Size(89, 37);
            this.btn_showCustomerInt.TabIndex = 21;
            this.btn_showCustomerInt.Text = "Show";
            this.btn_showCustomerInt.UseVisualStyleBackColor = true;
            this.btn_showCustomerInt.Visible = false;
            this.btn_showCustomerInt.Click += new System.EventHandler(this.btn_showCustomerInt_Click);
            // 
            // tb_customerID
            // 
            this.tb_customerID.Location = new System.Drawing.Point(899, 30);
            this.tb_customerID.Name = "tb_customerID";
            this.tb_customerID.Size = new System.Drawing.Size(117, 22);
            this.tb_customerID.TabIndex = 20;
            this.tb_customerID.Visible = false;
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.Location = new System.Drawing.Point(784, 33);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(109, 17);
            this.l1.TabIndex = 19;
            this.l1.Text = "Customer Name";
            this.l1.Visible = false;
            // 
            // btn_getCustomerInterest
            // 
            this.btn_getCustomerInterest.Location = new System.Drawing.Point(187, 79);
            this.btn_getCustomerInterest.Name = "btn_getCustomerInterest";
            this.btn_getCustomerInterest.Size = new System.Drawing.Size(132, 58);
            this.btn_getCustomerInterest.TabIndex = 16;
            this.btn_getCustomerInterest.Text = "Get Customer Interest";
            this.btn_getCustomerInterest.UseVisualStyleBackColor = true;
            this.btn_getCustomerInterest.Click += new System.EventHandler(this.btn_getCustomerInterest_Click);
            // 
            // btn_showCustomer
            // 
            this.btn_showCustomer.Location = new System.Drawing.Point(325, 79);
            this.btn_showCustomer.Name = "btn_showCustomer";
            this.btn_showCustomer.Size = new System.Drawing.Size(134, 58);
            this.btn_showCustomer.TabIndex = 13;
            this.btn_showCustomer.Text = "Show/Update Customers";
            this.btn_showCustomer.UseVisualStyleBackColor = true;
            this.btn_showCustomer.Click += new System.EventHandler(this.btn_showCustomer_Click);
            // 
            // customer_dgv
            // 
            this.customer_dgv.AllowUserToAddRows = false;
            this.customer_dgv.AllowUserToDeleteRows = false;
            this.customer_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.customer_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customer_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c_CustomerID,
            this.c_CustomerName,
            this.c_CustomerEmail,
            this.c_CustomerPoints,
            this.c_CustomerPH,
            this.Employee_id});
            this.customer_dgv.Location = new System.Drawing.Point(518, 79);
            this.customer_dgv.Name = "customer_dgv";
            this.customer_dgv.RowTemplate.Height = 24;
            this.customer_dgv.Size = new System.Drawing.Size(857, 461);
            this.customer_dgv.TabIndex = 12;
            this.customer_dgv.Visible = false;
            this.customer_dgv.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.customer_dgv_CellValueChanged);
            // 
            // c_CustomerID
            // 
            this.c_CustomerID.DataPropertyName = "customer_id";
            this.c_CustomerID.HeaderText = "Customer ID";
            this.c_CustomerID.Name = "c_CustomerID";
            this.c_CustomerID.Visible = false;
            // 
            // c_CustomerName
            // 
            this.c_CustomerName.DataPropertyName = "customer_name";
            this.c_CustomerName.HeaderText = "Custome Name";
            this.c_CustomerName.Name = "c_CustomerName";
            // 
            // c_CustomerEmail
            // 
            this.c_CustomerEmail.DataPropertyName = "customer_email";
            this.c_CustomerEmail.HeaderText = "Customer email";
            this.c_CustomerEmail.MinimumWidth = 50;
            this.c_CustomerEmail.Name = "c_CustomerEmail";
            // 
            // c_CustomerPoints
            // 
            this.c_CustomerPoints.DataPropertyName = "customer_points";
            this.c_CustomerPoints.HeaderText = "Customer Points";
            this.c_CustomerPoints.Name = "c_CustomerPoints";
            // 
            // c_CustomerPH
            // 
            this.c_CustomerPH.DataPropertyName = "Customer_Phone_Number";
            this.c_CustomerPH.HeaderText = "Customer Phone Number";
            this.c_CustomerPH.Name = "c_CustomerPH";
            // 
            // Employee_id
            // 
            this.Employee_id.DataPropertyName = "employee_id";
            this.Employee_id.HeaderText = "Employee ID";
            this.Employee_id.Name = "Employee_id";
            this.Employee_id.ReadOnly = true;
            // 
            // btn_addCustomer
            // 
            this.btn_addCustomer.Location = new System.Drawing.Point(68, 79);
            this.btn_addCustomer.Name = "btn_addCustomer";
            this.btn_addCustomer.Size = new System.Drawing.Size(113, 58);
            this.btn_addCustomer.TabIndex = 1;
            this.btn_addCustomer.Text = "Add Customer";
            this.btn_addCustomer.UseVisualStyleBackColor = true;
            this.btn_addCustomer.Click += new System.EventHandler(this.btn_addCustomer_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(197, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 29);
            this.label8.TabIndex = 0;
            this.label8.Text = "Options";
            // 
            // showTab
            // 
            this.showTab.BackColor = System.Drawing.Color.Transparent;
            this.showTab.Controls.Add(this.btn_searchShow);
            this.showTab.Controls.Add(this.tb_searchShow);
            this.showTab.Controls.Add(this.lb_searchShow);
            this.showTab.Controls.Add(this.show_dgv);
            this.showTab.Controls.Add(this.brn_showAllShows);
            this.showTab.Controls.Add(this.btn_addNewShow);
            this.showTab.Controls.Add(this.label12);
            this.showTab.Location = new System.Drawing.Point(4, 28);
            this.showTab.Name = "showTab";
            this.showTab.Padding = new System.Windows.Forms.Padding(3);
            this.showTab.Size = new System.Drawing.Size(1381, 546);
            this.showTab.TabIndex = 2;
            this.showTab.Text = "Show";
            // 
            // btn_searchShow
            // 
            this.btn_searchShow.Location = new System.Drawing.Point(987, 27);
            this.btn_searchShow.Name = "btn_searchShow";
            this.btn_searchShow.Size = new System.Drawing.Size(89, 30);
            this.btn_searchShow.TabIndex = 36;
            this.btn_searchShow.Text = "Show";
            this.btn_searchShow.UseVisualStyleBackColor = true;
            this.btn_searchShow.Visible = false;
            this.btn_searchShow.Click += new System.EventHandler(this.btn_searchShow_Click);
            // 
            // tb_searchShow
            // 
            this.tb_searchShow.Location = new System.Drawing.Point(864, 31);
            this.tb_searchShow.Name = "tb_searchShow";
            this.tb_searchShow.Size = new System.Drawing.Size(117, 22);
            this.tb_searchShow.TabIndex = 35;
            this.tb_searchShow.Visible = false;
            // 
            // lb_searchShow
            // 
            this.lb_searchShow.AutoSize = true;
            this.lb_searchShow.Location = new System.Drawing.Point(784, 33);
            this.lb_searchShow.Name = "lb_searchShow";
            this.lb_searchShow.Size = new System.Drawing.Size(74, 17);
            this.lb_searchShow.TabIndex = 34;
            this.lb_searchShow.Text = "Film Name";
            this.lb_searchShow.Visible = false;
            // 
            // show_dgv
            // 
            this.show_dgv.AllowUserToAddRows = false;
            this.show_dgv.AllowUserToDeleteRows = false;
            this.show_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.show_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.show_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c_showid,
            this.c_showDate,
            this.c_showPoints,
            this.c_showPrice,
            this.c_filmDuration,
            this.c_filmName,
            this.c_filmDesc,
            this.c_employeeID,
            this.c_showroomID,
            this.c_filmID,
            this.c_showroomName,
            this.c_employeeName});
            this.show_dgv.Location = new System.Drawing.Point(518, 79);
            this.show_dgv.Name = "show_dgv";
            this.show_dgv.RowTemplate.Height = 24;
            this.show_dgv.Size = new System.Drawing.Size(857, 461);
            this.show_dgv.TabIndex = 33;
            this.show_dgv.Visible = false;
            this.show_dgv.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.show_dgv_CellValueChanged);
            // 
            // c_showid
            // 
            this.c_showid.DataPropertyName = "show_id";
            this.c_showid.HeaderText = "Show ID";
            this.c_showid.Name = "c_showid";
            this.c_showid.Visible = false;
            // 
            // c_showDate
            // 
            this.c_showDate.DataPropertyName = "show_date";
            this.c_showDate.HeaderText = "Show Date";
            this.c_showDate.Name = "c_showDate";
            // 
            // c_showPoints
            // 
            this.c_showPoints.DataPropertyName = "show_points";
            this.c_showPoints.HeaderText = "Show Points";
            this.c_showPoints.Name = "c_showPoints";
            // 
            // c_showPrice
            // 
            this.c_showPrice.DataPropertyName = "show_price";
            this.c_showPrice.HeaderText = "Show Price";
            this.c_showPrice.Name = "c_showPrice";
            // 
            // c_filmDuration
            // 
            this.c_filmDuration.DataPropertyName = "film_duration";
            this.c_filmDuration.HeaderText = "film duration";
            this.c_filmDuration.Name = "c_filmDuration";
            this.c_filmDuration.Visible = false;
            // 
            // c_filmName
            // 
            this.c_filmName.DataPropertyName = "film_name";
            this.c_filmName.HeaderText = "Film Name";
            this.c_filmName.Name = "c_filmName";
            this.c_filmName.ReadOnly = true;
            // 
            // c_filmDesc
            // 
            this.c_filmDesc.DataPropertyName = "film_description";
            this.c_filmDesc.HeaderText = "film decreption";
            this.c_filmDesc.Name = "c_filmDesc";
            this.c_filmDesc.Visible = false;
            // 
            // c_employeeID
            // 
            this.c_employeeID.DataPropertyName = "employee_id";
            this.c_employeeID.HeaderText = "Employee ID";
            this.c_employeeID.Name = "c_employeeID";
            this.c_employeeID.Visible = false;
            // 
            // c_showroomID
            // 
            this.c_showroomID.DataPropertyName = "showroom_id";
            this.c_showroomID.HeaderText = "Showroom ID";
            this.c_showroomID.Name = "c_showroomID";
            this.c_showroomID.Visible = false;
            // 
            // c_filmID
            // 
            this.c_filmID.DataPropertyName = "film_id";
            this.c_filmID.HeaderText = "Film ID";
            this.c_filmID.Name = "c_filmID";
            this.c_filmID.Visible = false;
            // 
            // c_showroomName
            // 
            this.c_showroomName.DataPropertyName = "showroom_name";
            this.c_showroomName.HeaderText = "Showroom Name";
            this.c_showroomName.Name = "c_showroomName";
            this.c_showroomName.ReadOnly = true;
            // 
            // c_employeeName
            // 
            this.c_employeeName.DataPropertyName = "employee_name";
            this.c_employeeName.HeaderText = "Employee Name";
            this.c_employeeName.Name = "c_employeeName";
            // 
            // brn_showAllShows
            // 
            this.brn_showAllShows.Location = new System.Drawing.Point(242, 79);
            this.brn_showAllShows.Name = "brn_showAllShows";
            this.brn_showAllShows.Size = new System.Drawing.Size(141, 58);
            this.brn_showAllShows.TabIndex = 17;
            this.brn_showAllShows.Text = "Show/Update shows";
            this.brn_showAllShows.UseVisualStyleBackColor = true;
            this.brn_showAllShows.Click += new System.EventHandler(this.brn_showAllShows_Click);
            // 
            // btn_addNewShow
            // 
            this.btn_addNewShow.Location = new System.Drawing.Point(98, 79);
            this.btn_addNewShow.Name = "btn_addNewShow";
            this.btn_addNewShow.Size = new System.Drawing.Size(138, 58);
            this.btn_addNewShow.TabIndex = 15;
            this.btn_addNewShow.Text = "Add Show";
            this.btn_addNewShow.UseVisualStyleBackColor = true;
            this.btn_addNewShow.Click += new System.EventHandler(this.btn_addNewShow_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(197, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 29);
            this.label12.TabIndex = 14;
            this.label12.Text = "Options";
            // 
            // BookingTab
            // 
            this.BookingTab.Controls.Add(this.btn_searchBooking);
            this.BookingTab.Controls.Add(this.tb_searchBooking);
            this.BookingTab.Controls.Add(this.lb_searchBooking);
            this.BookingTab.Controls.Add(this.booking_dgv);
            this.BookingTab.Controls.Add(this.btn_viewAllBooking);
            this.BookingTab.Controls.Add(this.btn_addNewBooking);
            this.BookingTab.Controls.Add(this.label23);
            this.BookingTab.Location = new System.Drawing.Point(4, 28);
            this.BookingTab.Name = "BookingTab";
            this.BookingTab.Padding = new System.Windows.Forms.Padding(3);
            this.BookingTab.Size = new System.Drawing.Size(1381, 546);
            this.BookingTab.TabIndex = 3;
            this.BookingTab.Text = "Booking";
            this.BookingTab.UseVisualStyleBackColor = true;
            // 
            // btn_searchBooking
            // 
            this.btn_searchBooking.Location = new System.Drawing.Point(1040, 23);
            this.btn_searchBooking.Name = "btn_searchBooking";
            this.btn_searchBooking.Size = new System.Drawing.Size(89, 37);
            this.btn_searchBooking.TabIndex = 53;
            this.btn_searchBooking.Text = "Show";
            this.btn_searchBooking.UseVisualStyleBackColor = true;
            this.btn_searchBooking.Visible = false;
            this.btn_searchBooking.Click += new System.EventHandler(this.btn_searchBooking_Click);
            // 
            // tb_searchBooking
            // 
            this.tb_searchBooking.Location = new System.Drawing.Point(896, 30);
            this.tb_searchBooking.Name = "tb_searchBooking";
            this.tb_searchBooking.Size = new System.Drawing.Size(117, 22);
            this.tb_searchBooking.TabIndex = 52;
            this.tb_searchBooking.Visible = false;
            // 
            // lb_searchBooking
            // 
            this.lb_searchBooking.AutoSize = true;
            this.lb_searchBooking.Location = new System.Drawing.Point(784, 33);
            this.lb_searchBooking.Name = "lb_searchBooking";
            this.lb_searchBooking.Size = new System.Drawing.Size(59, 17);
            this.lb_searchBooking.TabIndex = 51;
            this.lb_searchBooking.Text = "Show ID";
            this.lb_searchBooking.Visible = false;
            // 
            // booking_dgv
            // 
            this.booking_dgv.AllowUserToAddRows = false;
            this.booking_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.booking_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.booking_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c_booking_id,
            this.c_booking_at_date,
            this.c_customer_paid_time,
            this.c_Seats,
            this.c_booking_canceled,
            this.c_Show_Id,
            this.c_Customer_Id,
            this.c_employee_id,
            this.c_employee_name});
            this.booking_dgv.Location = new System.Drawing.Point(518, 79);
            this.booking_dgv.Name = "booking_dgv";
            this.booking_dgv.RowTemplate.Height = 24;
            this.booking_dgv.Size = new System.Drawing.Size(857, 461);
            this.booking_dgv.TabIndex = 50;
            this.booking_dgv.Visible = false;
            this.booking_dgv.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.booking_dgv_CellValueChanged);
            // 
            // c_booking_id
            // 
            this.c_booking_id.DataPropertyName = "booking_id";
            this.c_booking_id.HeaderText = "Booking ID";
            this.c_booking_id.Name = "c_booking_id";
            this.c_booking_id.Visible = false;
            // 
            // c_booking_at_date
            // 
            this.c_booking_at_date.DataPropertyName = "booking_at_date";
            this.c_booking_at_date.HeaderText = "Booking At Date";
            this.c_booking_at_date.Name = "c_booking_at_date";
            this.c_booking_at_date.ReadOnly = true;
            // 
            // c_customer_paid_time
            // 
            this.c_customer_paid_time.DataPropertyName = "customer_paid_time";
            this.c_customer_paid_time.HeaderText = "Customer Paid Time";
            this.c_customer_paid_time.Name = "c_customer_paid_time";
            // 
            // c_Seats
            // 
            this.c_Seats.DataPropertyName = "Seats";
            this.c_Seats.HeaderText = "Seats Booked";
            this.c_Seats.Name = "c_Seats";
            // 
            // c_booking_canceled
            // 
            this.c_booking_canceled.DataPropertyName = "booking_canceled";
            this.c_booking_canceled.HeaderText = "Booking Canceled";
            this.c_booking_canceled.Name = "c_booking_canceled";
            // 
            // c_Show_Id
            // 
            this.c_Show_Id.DataPropertyName = "Show_Id";
            this.c_Show_Id.HeaderText = "Show ID";
            this.c_Show_Id.Name = "c_Show_Id";
            this.c_Show_Id.ReadOnly = true;
            // 
            // c_Customer_Id
            // 
            this.c_Customer_Id.DataPropertyName = "Customer_Id";
            this.c_Customer_Id.HeaderText = "Customer ID";
            this.c_Customer_Id.Name = "c_Customer_Id";
            this.c_Customer_Id.ReadOnly = true;
            // 
            // c_employee_id
            // 
            this.c_employee_id.DataPropertyName = "employee_id";
            this.c_employee_id.HeaderText = "Employee ID";
            this.c_employee_id.Name = "c_employee_id";
            this.c_employee_id.Visible = false;
            // 
            // c_employee_name
            // 
            this.c_employee_name.DataPropertyName = "employee_name";
            this.c_employee_name.HeaderText = "Employee Name";
            this.c_employee_name.Name = "c_employee_name";
            this.c_employee_name.ReadOnly = true;
            // 
            // btn_viewAllBooking
            // 
            this.btn_viewAllBooking.Location = new System.Drawing.Point(247, 79);
            this.btn_viewAllBooking.Name = "btn_viewAllBooking";
            this.btn_viewAllBooking.Size = new System.Drawing.Size(141, 58);
            this.btn_viewAllBooking.TabIndex = 37;
            this.btn_viewAllBooking.Text = "Show/Update Booking";
            this.btn_viewAllBooking.UseVisualStyleBackColor = true;
            this.btn_viewAllBooking.Click += new System.EventHandler(this.btn_viewAllBooking_Click);
            // 
            // btn_addNewBooking
            // 
            this.btn_addNewBooking.Location = new System.Drawing.Point(94, 79);
            this.btn_addNewBooking.Name = "btn_addNewBooking";
            this.btn_addNewBooking.Size = new System.Drawing.Size(147, 58);
            this.btn_addNewBooking.TabIndex = 35;
            this.btn_addNewBooking.Text = "Add Booking";
            this.btn_addNewBooking.UseVisualStyleBackColor = true;
            this.btn_addNewBooking.Click += new System.EventHandler(this.btn_addNewBooking_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(206, 23);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(100, 29);
            this.label23.TabIndex = 34;
            this.label23.Text = "Options";
            // 
            // SeatPriceTab
            // 
            this.SeatPriceTab.Controls.Add(this.btn_searchSeats);
            this.SeatPriceTab.Controls.Add(this.tb_searchSeat);
            this.SeatPriceTab.Controls.Add(this.lb_searchSeat);
            this.SeatPriceTab.Controls.Add(this.dgv_seatPrices);
            this.SeatPriceTab.Controls.Add(this.btn_ViewSeatPrices);
            this.SeatPriceTab.Controls.Add(this.btn_addSeatPrice);
            this.SeatPriceTab.Controls.Add(this.label4);
            this.SeatPriceTab.Location = new System.Drawing.Point(4, 28);
            this.SeatPriceTab.Name = "SeatPriceTab";
            this.SeatPriceTab.Size = new System.Drawing.Size(1381, 546);
            this.SeatPriceTab.TabIndex = 6;
            this.SeatPriceTab.Text = "Seats Prices";
            this.SeatPriceTab.UseVisualStyleBackColor = true;
            // 
            // btn_searchSeats
            // 
            this.btn_searchSeats.Location = new System.Drawing.Point(972, 23);
            this.btn_searchSeats.Name = "btn_searchSeats";
            this.btn_searchSeats.Size = new System.Drawing.Size(89, 37);
            this.btn_searchSeats.TabIndex = 88;
            this.btn_searchSeats.Text = "Show";
            this.btn_searchSeats.UseVisualStyleBackColor = true;
            this.btn_searchSeats.Visible = false;
            this.btn_searchSeats.Click += new System.EventHandler(this.btn_searchSeats_Click);
            // 
            // tb_searchSeat
            // 
            this.tb_searchSeat.Location = new System.Drawing.Point(849, 31);
            this.tb_searchSeat.Name = "tb_searchSeat";
            this.tb_searchSeat.Size = new System.Drawing.Size(117, 22);
            this.tb_searchSeat.TabIndex = 87;
            this.tb_searchSeat.Visible = false;
            // 
            // lb_searchSeat
            // 
            this.lb_searchSeat.AutoSize = true;
            this.lb_searchSeat.Location = new System.Drawing.Point(784, 33);
            this.lb_searchSeat.Name = "lb_searchSeat";
            this.lb_searchSeat.Size = new System.Drawing.Size(59, 17);
            this.lb_searchSeat.TabIndex = 86;
            this.lb_searchSeat.Text = "Show ID";
            this.lb_searchSeat.Visible = false;
            // 
            // dgv_seatPrices
            // 
            this.dgv_seatPrices.AllowUserToAddRows = false;
            this.dgv_seatPrices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_seatPrices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_seatPrices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c_seat_row,
            this.c_seat_number,
            this.c_showroom_name,
            this.c_show_id_seats,
            this.c_seat_additional_price,
            this.c_seat_price,
            this.c_total_price,
            this.c_seat_id,
            this.c_showroom_id});
            this.dgv_seatPrices.Location = new System.Drawing.Point(518, 79);
            this.dgv_seatPrices.Name = "dgv_seatPrices";
            this.dgv_seatPrices.RowTemplate.Height = 24;
            this.dgv_seatPrices.Size = new System.Drawing.Size(857, 461);
            this.dgv_seatPrices.TabIndex = 85;
            this.dgv_seatPrices.Visible = false;
            this.dgv_seatPrices.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_seatPrices_CellValueChanged);
            // 
            // c_seat_row
            // 
            this.c_seat_row.DataPropertyName = "seat_row";
            this.c_seat_row.HeaderText = "Seat Row";
            this.c_seat_row.Name = "c_seat_row";
            this.c_seat_row.ReadOnly = true;
            // 
            // c_seat_number
            // 
            this.c_seat_number.DataPropertyName = "seat_number";
            this.c_seat_number.HeaderText = "Seat Number";
            this.c_seat_number.Name = "c_seat_number";
            this.c_seat_number.ReadOnly = true;
            // 
            // c_showroom_name
            // 
            this.c_showroom_name.DataPropertyName = "showroom_name";
            this.c_showroom_name.HeaderText = "Showroom Name";
            this.c_showroom_name.Name = "c_showroom_name";
            this.c_showroom_name.ReadOnly = true;
            // 
            // c_show_id_seats
            // 
            this.c_show_id_seats.DataPropertyName = "show_id";
            this.c_show_id_seats.HeaderText = "Show ID";
            this.c_show_id_seats.Name = "c_show_id_seats";
            this.c_show_id_seats.ReadOnly = true;
            // 
            // c_seat_additional_price
            // 
            this.c_seat_additional_price.DataPropertyName = "seat_additional_price";
            this.c_seat_additional_price.HeaderText = "added Price";
            this.c_seat_additional_price.Name = "c_seat_additional_price";
            // 
            // c_seat_price
            // 
            this.c_seat_price.DataPropertyName = "seat_price";
            this.c_seat_price.HeaderText = "Seat Price";
            this.c_seat_price.Name = "c_seat_price";
            this.c_seat_price.ReadOnly = true;
            this.c_seat_price.Visible = false;
            // 
            // c_total_price
            // 
            this.c_total_price.DataPropertyName = "total_price";
            this.c_total_price.HeaderText = "Seat Price";
            this.c_total_price.Name = "c_total_price";
            // 
            // c_seat_id
            // 
            this.c_seat_id.DataPropertyName = "seat_id";
            this.c_seat_id.HeaderText = "Seat ID";
            this.c_seat_id.Name = "c_seat_id";
            this.c_seat_id.Visible = false;
            // 
            // c_showroom_id
            // 
            this.c_showroom_id.DataPropertyName = "showroom_id";
            this.c_showroom_id.HeaderText = "Showroom ID";
            this.c_showroom_id.Name = "c_showroom_id";
            this.c_showroom_id.Visible = false;
            // 
            // btn_ViewSeatPrices
            // 
            this.btn_ViewSeatPrices.Location = new System.Drawing.Point(247, 79);
            this.btn_ViewSeatPrices.Name = "btn_ViewSeatPrices";
            this.btn_ViewSeatPrices.Size = new System.Drawing.Size(145, 58);
            this.btn_ViewSeatPrices.TabIndex = 84;
            this.btn_ViewSeatPrices.Text = "Show/Update Seat prices";
            this.btn_ViewSeatPrices.UseVisualStyleBackColor = true;
            this.btn_ViewSeatPrices.Click += new System.EventHandler(this.btn_ViewSeatPrices_Click);
            // 
            // btn_addSeatPrice
            // 
            this.btn_addSeatPrice.Location = new System.Drawing.Point(102, 79);
            this.btn_addSeatPrice.Name = "btn_addSeatPrice";
            this.btn_addSeatPrice.Size = new System.Drawing.Size(139, 58);
            this.btn_addSeatPrice.TabIndex = 82;
            this.btn_addSeatPrice.Text = "Add additional seat price";
            this.btn_addSeatPrice.UseVisualStyleBackColor = true;
            this.btn_addSeatPrice.Click += new System.EventHandler(this.btn_addSeatPrice_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(197, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 29);
            this.label4.TabIndex = 81;
            this.label4.Text = "Options";
            // 
            // DiscountTab
            // 
            this.DiscountTab.Controls.Add(this.discount_dgv);
            this.DiscountTab.Controls.Add(this.btn_viewAllRules);
            this.DiscountTab.Controls.Add(this.btn_addNewDiscount);
            this.DiscountTab.Controls.Add(this.label29);
            this.DiscountTab.Location = new System.Drawing.Point(4, 28);
            this.DiscountTab.Name = "DiscountTab";
            this.DiscountTab.Padding = new System.Windows.Forms.Padding(3);
            this.DiscountTab.Size = new System.Drawing.Size(1381, 546);
            this.DiscountTab.TabIndex = 4;
            this.DiscountTab.Text = "Discount";
            this.DiscountTab.UseVisualStyleBackColor = true;
            // 
            // discount_dgv
            // 
            this.discount_dgv.AllowUserToAddRows = false;
            this.discount_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.discount_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.discount_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c_rule_id,
            this.c_discount,
            this.c_start_date,
            this.c_end_date,
            this.c_film_type,
            this.c_points,
            this.c_type_id});
            this.discount_dgv.Location = new System.Drawing.Point(518, 79);
            this.discount_dgv.Name = "discount_dgv";
            this.discount_dgv.RowTemplate.Height = 24;
            this.discount_dgv.Size = new System.Drawing.Size(857, 463);
            this.discount_dgv.TabIndex = 68;
            this.discount_dgv.Visible = false;
            this.discount_dgv.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.discount_dgv_CellValueChanged);
            // 
            // c_rule_id
            // 
            this.c_rule_id.DataPropertyName = "rule_id";
            this.c_rule_id.HeaderText = "Rule ID";
            this.c_rule_id.Name = "c_rule_id";
            this.c_rule_id.Visible = false;
            // 
            // c_discount
            // 
            this.c_discount.DataPropertyName = "discount";
            this.c_discount.HeaderText = "Discount (%)";
            this.c_discount.Name = "c_discount";
            // 
            // c_start_date
            // 
            this.c_start_date.DataPropertyName = "start_date";
            this.c_start_date.HeaderText = "Start Date";
            this.c_start_date.Name = "c_start_date";
            // 
            // c_end_date
            // 
            this.c_end_date.DataPropertyName = "end_date";
            this.c_end_date.HeaderText = "End Date";
            this.c_end_date.Name = "c_end_date";
            // 
            // c_film_type
            // 
            this.c_film_type.DataPropertyName = "film_type";
            this.c_film_type.HeaderText = "Type";
            this.c_film_type.Name = "c_film_type";
            // 
            // c_points
            // 
            this.c_points.DataPropertyName = "points";
            this.c_points.HeaderText = "Minimum Points";
            this.c_points.Name = "c_points";
            // 
            // c_type_id
            // 
            this.c_type_id.DataPropertyName = "type_id";
            this.c_type_id.HeaderText = "Type ID";
            this.c_type_id.Name = "c_type_id";
            this.c_type_id.Visible = false;
            // 
            // btn_viewAllRules
            // 
            this.btn_viewAllRules.Location = new System.Drawing.Point(243, 79);
            this.btn_viewAllRules.Name = "btn_viewAllRules";
            this.btn_viewAllRules.Size = new System.Drawing.Size(137, 58);
            this.btn_viewAllRules.TabIndex = 55;
            this.btn_viewAllRules.Text = "Show/Update Discounts";
            this.btn_viewAllRules.UseVisualStyleBackColor = true;
            this.btn_viewAllRules.Click += new System.EventHandler(this.btn_viewAllRules_Click);
            // 
            // btn_addNewDiscount
            // 
            this.btn_addNewDiscount.Location = new System.Drawing.Point(105, 79);
            this.btn_addNewDiscount.Name = "btn_addNewDiscount";
            this.btn_addNewDiscount.Size = new System.Drawing.Size(132, 58);
            this.btn_addNewDiscount.TabIndex = 53;
            this.btn_addNewDiscount.Text = "Add Discount";
            this.btn_addNewDiscount.UseVisualStyleBackColor = true;
            this.btn_addNewDiscount.Click += new System.EventHandler(this.btn_addNewDiscount_Click);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(197, 23);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(100, 29);
            this.label29.TabIndex = 52;
            this.label29.Text = "Options";
            // 
            // FilmTab
            // 
            this.FilmTab.Controls.Add(this.btn_searchFilm);
            this.FilmTab.Controls.Add(this.tb_searchFilm);
            this.FilmTab.Controls.Add(this.lb_searchFilm);
            this.FilmTab.Controls.Add(this.film_dgv);
            this.FilmTab.Controls.Add(this.btn_viewAllFilms);
            this.FilmTab.Controls.Add(this.btn_addFilm);
            this.FilmTab.Controls.Add(this.label34);
            this.FilmTab.Location = new System.Drawing.Point(4, 28);
            this.FilmTab.Name = "FilmTab";
            this.FilmTab.Padding = new System.Windows.Forms.Padding(3);
            this.FilmTab.Size = new System.Drawing.Size(1381, 546);
            this.FilmTab.TabIndex = 5;
            this.FilmTab.Text = "Film";
            this.FilmTab.UseVisualStyleBackColor = true;
            // 
            // btn_searchFilm
            // 
            this.btn_searchFilm.Location = new System.Drawing.Point(987, 23);
            this.btn_searchFilm.Name = "btn_searchFilm";
            this.btn_searchFilm.Size = new System.Drawing.Size(89, 37);
            this.btn_searchFilm.TabIndex = 83;
            this.btn_searchFilm.Text = "Show";
            this.btn_searchFilm.UseVisualStyleBackColor = true;
            this.btn_searchFilm.Visible = false;
            this.btn_searchFilm.Click += new System.EventHandler(this.btn_searchFilm_Click);
            // 
            // tb_searchFilm
            // 
            this.tb_searchFilm.Location = new System.Drawing.Point(864, 30);
            this.tb_searchFilm.Name = "tb_searchFilm";
            this.tb_searchFilm.Size = new System.Drawing.Size(117, 22);
            this.tb_searchFilm.TabIndex = 82;
            this.tb_searchFilm.Visible = false;
            // 
            // lb_searchFilm
            // 
            this.lb_searchFilm.AutoSize = true;
            this.lb_searchFilm.Location = new System.Drawing.Point(784, 33);
            this.lb_searchFilm.Name = "lb_searchFilm";
            this.lb_searchFilm.Size = new System.Drawing.Size(74, 17);
            this.lb_searchFilm.TabIndex = 81;
            this.lb_searchFilm.Text = "Film Name";
            this.lb_searchFilm.Visible = false;
            // 
            // film_dgv
            // 
            this.film_dgv.AllowUserToAddRows = false;
            this.film_dgv.AllowUserToDeleteRows = false;
            this.film_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.film_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.film_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c_film_id,
            this.c_film_name,
            this.c_filmDes,
            this.c_film_dur,
            this.type_id,
            this.FilmType});
            this.film_dgv.Location = new System.Drawing.Point(518, 79);
            this.film_dgv.Name = "film_dgv";
            this.film_dgv.RowTemplate.Height = 24;
            this.film_dgv.Size = new System.Drawing.Size(857, 461);
            this.film_dgv.TabIndex = 67;
            this.film_dgv.Visible = false;
            this.film_dgv.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.film_dgv_CellValueChanged);
            // 
            // c_film_id
            // 
            this.c_film_id.DataPropertyName = "film_id";
            this.c_film_id.HeaderText = "Film ID";
            this.c_film_id.Name = "c_film_id";
            this.c_film_id.Visible = false;
            // 
            // c_film_name
            // 
            this.c_film_name.DataPropertyName = "film_name";
            this.c_film_name.HeaderText = "Film Name";
            this.c_film_name.Name = "c_film_name";
            // 
            // c_filmDes
            // 
            this.c_filmDes.DataPropertyName = "film_description";
            this.c_filmDes.HeaderText = "Film Description";
            this.c_filmDes.Name = "c_filmDes";
            // 
            // c_film_dur
            // 
            this.c_film_dur.DataPropertyName = "film_duration";
            this.c_film_dur.HeaderText = "Film Duration";
            this.c_film_dur.Name = "c_film_dur";
            // 
            // type_id
            // 
            this.type_id.DataPropertyName = "type_id";
            this.type_id.HeaderText = "Type ID";
            this.type_id.Name = "type_id";
            this.type_id.Visible = false;
            // 
            // FilmType
            // 
            this.FilmType.DataPropertyName = "film_type";
            this.FilmType.HeaderText = "Film Type";
            this.FilmType.Name = "FilmType";
            // 
            // btn_viewAllFilms
            // 
            this.btn_viewAllFilms.Location = new System.Drawing.Point(248, 79);
            this.btn_viewAllFilms.Name = "btn_viewAllFilms";
            this.btn_viewAllFilms.Size = new System.Drawing.Size(138, 58);
            this.btn_viewAllFilms.TabIndex = 55;
            this.btn_viewAllFilms.Text = "Show/Update Films";
            this.btn_viewAllFilms.UseVisualStyleBackColor = true;
            this.btn_viewAllFilms.Click += new System.EventHandler(this.btn_viewAllFilms_Click);
            // 
            // btn_addFilm
            // 
            this.btn_addFilm.Location = new System.Drawing.Point(104, 79);
            this.btn_addFilm.Name = "btn_addFilm";
            this.btn_addFilm.Size = new System.Drawing.Size(138, 58);
            this.btn_addFilm.TabIndex = 53;
            this.btn_addFilm.Text = "Add Film";
            this.btn_addFilm.UseVisualStyleBackColor = true;
            this.btn_addFilm.Click += new System.EventHandler(this.btn_addFilm_Click);
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(197, 23);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(100, 29);
            this.label34.TabIndex = 52;
            this.label34.Text = "Options";
            // 
            // WorkerTab
            // 
            this.WorkerTab.Controls.Add(this.btn_1);
            this.WorkerTab.Controls.Add(this.tb_searchFilmWorkers);
            this.WorkerTab.Controls.Add(this.lb_searchFilmWorkers);
            this.WorkerTab.Controls.Add(this.dgv_worker);
            this.WorkerTab.Controls.Add(this.btn_viewAllWorkers);
            this.WorkerTab.Controls.Add(this.btn_addWorker);
            this.WorkerTab.Controls.Add(this.label5);
            this.WorkerTab.Location = new System.Drawing.Point(4, 28);
            this.WorkerTab.Name = "WorkerTab";
            this.WorkerTab.Padding = new System.Windows.Forms.Padding(3);
            this.WorkerTab.Size = new System.Drawing.Size(1381, 546);
            this.WorkerTab.TabIndex = 7;
            this.WorkerTab.Text = "Film Workers";
            this.WorkerTab.UseVisualStyleBackColor = true;
            // 
            // btn_1
            // 
            this.btn_1.Location = new System.Drawing.Point(987, 23);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(89, 37);
            this.btn_1.TabIndex = 89;
            this.btn_1.Text = "Show";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Visible = false;
            this.btn_1.Click += new System.EventHandler(this.btn_searchWorkers_Click);
            // 
            // tb_searchFilmWorkers
            // 
            this.tb_searchFilmWorkers.Location = new System.Drawing.Point(864, 30);
            this.tb_searchFilmWorkers.Name = "tb_searchFilmWorkers";
            this.tb_searchFilmWorkers.Size = new System.Drawing.Size(117, 22);
            this.tb_searchFilmWorkers.TabIndex = 88;
            this.tb_searchFilmWorkers.Visible = false;
            // 
            // lb_searchFilmWorkers
            // 
            this.lb_searchFilmWorkers.AutoSize = true;
            this.lb_searchFilmWorkers.Location = new System.Drawing.Point(784, 33);
            this.lb_searchFilmWorkers.Name = "lb_searchFilmWorkers";
            this.lb_searchFilmWorkers.Size = new System.Drawing.Size(74, 17);
            this.lb_searchFilmWorkers.TabIndex = 87;
            this.lb_searchFilmWorkers.Text = "Film Name";
            this.lb_searchFilmWorkers.Visible = false;
            // 
            // dgv_worker
            // 
            this.dgv_worker.AllowUserToAddRows = false;
            this.dgv_worker.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_worker.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_worker.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.workerID,
            this.WorkeName,
            this.WorkerRole});
            this.dgv_worker.Location = new System.Drawing.Point(518, 79);
            this.dgv_worker.Name = "dgv_worker";
            this.dgv_worker.RowTemplate.Height = 24;
            this.dgv_worker.Size = new System.Drawing.Size(857, 461);
            this.dgv_worker.TabIndex = 85;
            this.dgv_worker.Visible = false;
            this.dgv_worker.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_worker_CellValueChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "film_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Film ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "film_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Film Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "film_description";
            this.dataGridViewTextBoxColumn3.HeaderText = "Film Description";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "film_duration";
            this.dataGridViewTextBoxColumn4.HeaderText = "Film Duration";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // workerID
            // 
            this.workerID.DataPropertyName = "worker_id";
            this.workerID.HeaderText = "Worker ID";
            this.workerID.Name = "workerID";
            this.workerID.Visible = false;
            // 
            // WorkeName
            // 
            this.WorkeName.DataPropertyName = "worker_name";
            this.WorkeName.HeaderText = "Worker Name";
            this.WorkeName.Name = "WorkeName";
            // 
            // WorkerRole
            // 
            this.WorkerRole.DataPropertyName = "worker_role";
            this.WorkerRole.HeaderText = "Worker Role";
            this.WorkerRole.Name = "WorkerRole";
            // 
            // btn_viewAllWorkers
            // 
            this.btn_viewAllWorkers.Location = new System.Drawing.Point(245, 79);
            this.btn_viewAllWorkers.Name = "btn_viewAllWorkers";
            this.btn_viewAllWorkers.Size = new System.Drawing.Size(155, 58);
            this.btn_viewAllWorkers.TabIndex = 84;
            this.btn_viewAllWorkers.Text = "Show/Update Workers";
            this.btn_viewAllWorkers.UseVisualStyleBackColor = true;
            this.btn_viewAllWorkers.Click += new System.EventHandler(this.btn_viewAllWorkers_Click);
            // 
            // btn_addWorker
            // 
            this.btn_addWorker.Location = new System.Drawing.Point(89, 79);
            this.btn_addWorker.Name = "btn_addWorker";
            this.btn_addWorker.Size = new System.Drawing.Size(150, 58);
            this.btn_addWorker.TabIndex = 82;
            this.btn_addWorker.Text = "Add Film Worker";
            this.btn_addWorker.UseVisualStyleBackColor = true;
            this.btn_addWorker.Click += new System.EventHandler(this.btn_addWorker_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(197, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 29);
            this.label5.TabIndex = 81;
            this.label5.Text = "Options";
            // 
            // TabReport
            // 
            this.TabReport.Controls.Add(this.btn_shorResult);
            this.TabReport.Controls.Add(this.lbl_empid);
            this.TabReport.Controls.Add(this.txt_emloyee_ID);
            this.TabReport.Controls.Add(this.lbl_option);
            this.TabReport.Controls.Add(this.cb_reportOption);
            this.TabReport.Controls.Add(this.label9);
            this.TabReport.Controls.Add(this.dtp_toDateF);
            this.TabReport.Controls.Add(this.label7);
            this.TabReport.Controls.Add(this.dtp_FromDateF);
            this.TabReport.Controls.Add(this.dgv_reports);
            this.TabReport.Controls.Add(this.btn_employeeReport);
            this.TabReport.Controls.Add(this.btn_filmReports);
            this.TabReport.Controls.Add(this.label6);
            this.TabReport.Location = new System.Drawing.Point(4, 28);
            this.TabReport.Name = "TabReport";
            this.TabReport.Padding = new System.Windows.Forms.Padding(3);
            this.TabReport.Size = new System.Drawing.Size(1381, 546);
            this.TabReport.TabIndex = 8;
            this.TabReport.Text = "Reports";
            this.TabReport.UseVisualStyleBackColor = true;
            // 
            // btn_shorResult
            // 
            this.btn_shorResult.Location = new System.Drawing.Point(181, 424);
            this.btn_shorResult.Name = "btn_shorResult";
            this.btn_shorResult.Size = new System.Drawing.Size(100, 44);
            this.btn_shorResult.TabIndex = 100;
            this.btn_shorResult.Text = "Show";
            this.btn_shorResult.UseVisualStyleBackColor = true;
            this.btn_shorResult.Visible = false;
            this.btn_shorResult.Click += new System.EventHandler(this.btn_shorResult_Click);
            // 
            // lbl_empid
            // 
            this.lbl_empid.AutoSize = true;
            this.lbl_empid.Location = new System.Drawing.Point(49, 372);
            this.lbl_empid.Name = "lbl_empid";
            this.lbl_empid.Size = new System.Drawing.Size(87, 17);
            this.lbl_empid.TabIndex = 99;
            this.lbl_empid.Text = "Employee ID";
            this.lbl_empid.Visible = false;
            // 
            // txt_emloyee_ID
            // 
            this.txt_emloyee_ID.Location = new System.Drawing.Point(181, 372);
            this.txt_emloyee_ID.Name = "txt_emloyee_ID";
            this.txt_emloyee_ID.Size = new System.Drawing.Size(100, 22);
            this.txt_emloyee_ID.TabIndex = 98;
            this.txt_emloyee_ID.Text = "1";
            this.txt_emloyee_ID.Visible = false;
            // 
            // lbl_option
            // 
            this.lbl_option.AutoSize = true;
            this.lbl_option.Location = new System.Drawing.Point(49, 322);
            this.lbl_option.Name = "lbl_option";
            this.lbl_option.Size = new System.Drawing.Size(97, 17);
            this.lbl_option.TabIndex = 97;
            this.lbl_option.Text = "Report Option";
            this.lbl_option.Visible = false;
            // 
            // cb_reportOption
            // 
            this.cb_reportOption.FormattingEnabled = true;
            this.cb_reportOption.Location = new System.Drawing.Point(181, 322);
            this.cb_reportOption.Name = "cb_reportOption";
            this.cb_reportOption.Size = new System.Drawing.Size(213, 24);
            this.cb_reportOption.TabIndex = 96;
            this.cb_reportOption.Visible = false;
            this.cb_reportOption.SelectedIndexChanged += new System.EventHandler(this.cb_reportOption_SelectedIndexChanged);
            this.cb_reportOption.SelectedValueChanged += new System.EventHandler(this.vb_reportOption_SelectedValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(49, 275);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 17);
            this.label9.TabIndex = 94;
            this.label9.Text = "To Date";
            this.label9.Visible = false;
            // 
            // dtp_toDateF
            // 
            this.dtp_toDateF.CustomFormat = "dd-MMM-yy";
            this.dtp_toDateF.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_toDateF.Location = new System.Drawing.Point(181, 275);
            this.dtp_toDateF.Name = "dtp_toDateF";
            this.dtp_toDateF.Size = new System.Drawing.Size(100, 22);
            this.dtp_toDateF.TabIndex = 95;
            this.dtp_toDateF.Value = new System.DateTime(2019, 3, 1, 0, 0, 0, 0);
            this.dtp_toDateF.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 17);
            this.label7.TabIndex = 92;
            this.label7.Text = "From Date";
            this.label7.Visible = false;
            // 
            // dtp_FromDateF
            // 
            this.dtp_FromDateF.CustomFormat = "dd-MMM-yy";
            this.dtp_FromDateF.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_FromDateF.Location = new System.Drawing.Point(181, 226);
            this.dtp_FromDateF.Name = "dtp_FromDateF";
            this.dtp_FromDateF.Size = new System.Drawing.Size(100, 22);
            this.dtp_FromDateF.TabIndex = 93;
            this.dtp_FromDateF.Value = new System.DateTime(2019, 2, 1, 0, 0, 0, 0);
            this.dtp_FromDateF.Visible = false;
            // 
            // dgv_reports
            // 
            this.dgv_reports.AllowUserToAddRows = false;
            this.dgv_reports.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_reports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_reports.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dgv_reports.Location = new System.Drawing.Point(518, 79);
            this.dgv_reports.Name = "dgv_reports";
            this.dgv_reports.ReadOnly = true;
            this.dgv_reports.RowTemplate.Height = 24;
            this.dgv_reports.Size = new System.Drawing.Size(857, 461);
            this.dgv_reports.TabIndex = 91;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "show_id";
            this.Column1.HeaderText = "Show ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "film_name";
            this.Column2.HeaderText = "Film Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "s";
            this.Column3.HeaderText = "Booked Seats";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "tot";
            this.Column4.HeaderText = "Total Profit";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "empID";
            this.Column5.HeaderText = "Employee ID";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "empName";
            this.Column6.HeaderText = "Employee Name";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "tot1";
            this.Column7.HeaderText = "Number of Seats Booked";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "tot2";
            this.Column8.HeaderText = "Number of Bookings made";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "Booking_id";
            this.Column9.HeaderText = "Booking ID";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // btn_employeeReport
            // 
            this.btn_employeeReport.Location = new System.Drawing.Point(250, 79);
            this.btn_employeeReport.Name = "btn_employeeReport";
            this.btn_employeeReport.Size = new System.Drawing.Size(155, 58);
            this.btn_employeeReport.TabIndex = 89;
            this.btn_employeeReport.Text = "Reception Employee Reports";
            this.btn_employeeReport.UseVisualStyleBackColor = true;
            this.btn_employeeReport.Click += new System.EventHandler(this.btn_employeeReport_Click);
            // 
            // btn_filmReports
            // 
            this.btn_filmReports.Location = new System.Drawing.Point(104, 79);
            this.btn_filmReports.Name = "btn_filmReports";
            this.btn_filmReports.Size = new System.Drawing.Size(140, 58);
            this.btn_filmReports.TabIndex = 88;
            this.btn_filmReports.Text = "Film Reports";
            this.btn_filmReports.UseVisualStyleBackColor = true;
            this.btn_filmReports.Click += new System.EventHandler(this.btn_filmReports_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(197, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 29);
            this.label6.TabIndex = 87;
            this.label6.Text = "Options";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1406, 604);
            this.Controls.Add(this.btn_searchFilmWorkers);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Welcome to our cinema";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.btn_searchFilmWorkers.ResumeLayout(false);
            this.mainTab.ResumeLayout(false);
            this.mainTab.PerformLayout();
            this.CustomerTab.ResumeLayout(false);
            this.CustomerTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customer_dgv)).EndInit();
            this.showTab.ResumeLayout(false);
            this.showTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.show_dgv)).EndInit();
            this.BookingTab.ResumeLayout(false);
            this.BookingTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booking_dgv)).EndInit();
            this.SeatPriceTab.ResumeLayout(false);
            this.SeatPriceTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_seatPrices)).EndInit();
            this.DiscountTab.ResumeLayout(false);
            this.DiscountTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.discount_dgv)).EndInit();
            this.FilmTab.ResumeLayout(false);
            this.FilmTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.film_dgv)).EndInit();
            this.WorkerTab.ResumeLayout(false);
            this.WorkerTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_worker)).EndInit();
            this.TabReport.ResumeLayout(false);
            this.TabReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reports)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl btn_searchFilmWorkers;
        private System.Windows.Forms.TabPage mainTab;
        private System.Windows.Forms.TabPage CustomerTab;
        private System.Windows.Forms.TabPage showTab;
        private System.Windows.Forms.TabPage BookingTab;
        private System.Windows.Forms.TabPage DiscountTab;
        private System.Windows.Forms.TabPage FilmTab;
        private System.Windows.Forms.Label la;
        private System.Windows.Forms.TextBox txt_empName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_logIn;
        private System.Windows.Forms.Button btn_addCustomer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView customer_dgv;
        private System.Windows.Forms.Button btn_showCustomer;
        private System.Windows.Forms.Button brn_showAllShows;
        private System.Windows.Forms.Button btn_addNewShow;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView show_dgv;
        private System.Windows.Forms.DataGridView booking_dgv;
        private System.Windows.Forms.Button btn_viewAllBooking;
        private System.Windows.Forms.Button btn_addNewBooking;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.DataGridView discount_dgv;
        private System.Windows.Forms.Button btn_viewAllRules;
        private System.Windows.Forms.Button btn_addNewDiscount;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.DataGridView film_dgv;
        private System.Windows.Forms.Button btn_viewAllFilms;
        private System.Windows.Forms.Button btn_addFilm;
        private System.Windows.Forms.Label label34;
        public System.Windows.Forms.TextBox txt_empId;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage SeatPriceTab;
        private System.Windows.Forms.DataGridView dgv_seatPrices;
        private System.Windows.Forms.Button btn_ViewSeatPrices;
        private System.Windows.Forms.Button btn_addSeatPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage WorkerTab;
        private System.Windows.Forms.DataGridView dgv_worker;
        private System.Windows.Forms.Button btn_viewAllWorkers;
        private System.Windows.Forms.Button btn_addWorker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_getCustomerInterest;
        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.Button btn_showCustomerInt;
        private System.Windows.Forms.TextBox tb_customerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_seat_row;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_seat_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_showroom_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_show_id_seats;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_seat_additional_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_seat_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_total_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_seat_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_showroom_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn workerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkerRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_CustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_CustomerEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_CustomerPoints;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_CustomerPH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Employee_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_showid;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_showDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_showPoints;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_showPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_filmDuration;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_filmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_filmDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_employeeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_showroomID;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_filmID;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_showroomName;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_employeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_booking_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_booking_at_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_customer_paid_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_Seats;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_booking_canceled;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_Show_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_Customer_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_employee_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_employee_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_rule_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_start_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_end_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_film_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_points;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_type_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_film_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_film_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_filmDes;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_film_dur;
        private System.Windows.Forms.DataGridViewTextBoxColumn type_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FilmType;
        private System.Windows.Forms.TabPage TabReport;
        private System.Windows.Forms.DataGridView dgv_reports;
        private System.Windows.Forms.Button btn_employeeReport;
        private System.Windows.Forms.Button btn_filmReports;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_option;
        private System.Windows.Forms.ComboBox cb_reportOption;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtp_toDateF;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtp_FromDateF;
        private System.Windows.Forms.Label lbl_empid;
        private System.Windows.Forms.TextBox txt_emloyee_ID;
        private System.Windows.Forms.Button btn_shorResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.Button btn_searchShow;
        private System.Windows.Forms.TextBox tb_searchShow;
        private System.Windows.Forms.Label lb_searchShow;
        private System.Windows.Forms.Button btn_searchBooking;
        private System.Windows.Forms.TextBox tb_searchBooking;
        private System.Windows.Forms.Label lb_searchBooking;
        private System.Windows.Forms.Button btn_searchSeats;
        private System.Windows.Forms.TextBox tb_searchSeat;
        private System.Windows.Forms.Label lb_searchSeat;
        private System.Windows.Forms.Button btn_searchFilm;
        private System.Windows.Forms.TextBox tb_searchFilm;
        private System.Windows.Forms.Label lb_searchFilm;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.TextBox tb_searchFilmWorkers;
        private System.Windows.Forms.Label lb_searchFilmWorkers;
        private System.Windows.Forms.Label lb_customerTypeinterest;
        private System.Windows.Forms.TextBox txt_customerTypeinterest;
        private System.Windows.Forms.Label lb_customerIDinterest;
        private System.Windows.Forms.TextBox txt_customerIDinterest;

    }
}

