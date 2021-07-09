namespace oracleTest
{
    partial class AddFilm
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
            this.btn_addWorker = new System.Windows.Forms.Button();
            this.label25 = new System.Windows.Forms.Label();
            this.tb_desc = new System.Windows.Forms.RichTextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.txt_duration = new System.Windows.Forms.TextBox();
            this.btn_saveNewFilm = new System.Windows.Forms.Button();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.txt_filmName = new System.Windows.Forms.TextBox();
            this.w2 = new System.Windows.Forms.Label();
            this.w1 = new System.Windows.Forms.Label();
            this.txt_workerName = new System.Windows.Forms.TextBox();
            this.clb_FilmType = new System.Windows.Forms.CheckedListBox();
            this.txt_workerRole = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_addWorker
            // 
            this.btn_addWorker.Location = new System.Drawing.Point(21, 315);
            this.btn_addWorker.Name = "btn_addWorker";
            this.btn_addWorker.Size = new System.Drawing.Size(115, 45);
            this.btn_addWorker.TabIndex = 83;
            this.btn_addWorker.Text = "Add worker";
            this.btn_addWorker.UseVisualStyleBackColor = true;
            this.btn_addWorker.Click += new System.EventHandler(this.btn_addWorker_Click);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(18, 190);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(40, 17);
            this.label25.TabIndex = 81;
            this.label25.Text = "Type";
            // 
            // tb_desc
            // 
            this.tb_desc.Location = new System.Drawing.Point(134, 73);
            this.tb_desc.Name = "tb_desc";
            this.tb_desc.Size = new System.Drawing.Size(152, 59);
            this.tb_desc.TabIndex = 80;
            this.tb_desc.Text = "";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(18, 152);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(62, 17);
            this.label30.TabIndex = 78;
            this.label30.Text = "Duration";
            // 
            // txt_duration
            // 
            this.txt_duration.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_duration.Location = new System.Drawing.Point(134, 152);
            this.txt_duration.Name = "txt_duration";
            this.txt_duration.Size = new System.Drawing.Size(152, 22);
            this.txt_duration.TabIndex = 77;
            // 
            // btn_saveNewFilm
            // 
            this.btn_saveNewFilm.Location = new System.Drawing.Point(171, 315);
            this.btn_saveNewFilm.Name = "btn_saveNewFilm";
            this.btn_saveNewFilm.Size = new System.Drawing.Size(115, 45);
            this.btn_saveNewFilm.TabIndex = 76;
            this.btn_saveNewFilm.Text = "Save";
            this.btn_saveNewFilm.UseVisualStyleBackColor = true;
            this.btn_saveNewFilm.Click += new System.EventHandler(this.btn_saveNewFilm_Click);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(18, 76);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(79, 17);
            this.label32.TabIndex = 75;
            this.label32.Text = "Description";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(18, 36);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(74, 17);
            this.label33.TabIndex = 74;
            this.label33.Text = "Film Name";
            // 
            // txt_filmName
            // 
            this.txt_filmName.Location = new System.Drawing.Point(134, 33);
            this.txt_filmName.Name = "txt_filmName";
            this.txt_filmName.Size = new System.Drawing.Size(149, 22);
            this.txt_filmName.TabIndex = 73;
            // 
            // w2
            // 
            this.w2.AutoSize = true;
            this.w2.Location = new System.Drawing.Point(19, 268);
            this.w2.Name = "w2";
            this.w2.Size = new System.Drawing.Size(87, 17);
            this.w2.TabIndex = 87;
            this.w2.Text = "Worker Role";
            // 
            // w1
            // 
            this.w1.AutoSize = true;
            this.w1.Location = new System.Drawing.Point(19, 220);
            this.w1.Name = "w1";
            this.w1.Size = new System.Drawing.Size(95, 17);
            this.w1.TabIndex = 85;
            this.w1.Text = "Worker Name";
            // 
            // txt_workerName
            // 
            this.txt_workerName.Location = new System.Drawing.Point(137, 217);
            this.txt_workerName.Name = "txt_workerName";
            this.txt_workerName.Size = new System.Drawing.Size(155, 22);
            this.txt_workerName.TabIndex = 84;
            // 
            // clb_FilmType
            // 
            this.clb_FilmType.FormattingEnabled = true;
            this.clb_FilmType.Location = new System.Drawing.Point(134, 190);
            this.clb_FilmType.Name = "clb_FilmType";
            this.clb_FilmType.Size = new System.Drawing.Size(120, 89);
            this.clb_FilmType.TabIndex = 92;
            this.clb_FilmType.SelectedIndexChanged += new System.EventHandler(this.clb_FilmType_SelectedIndexChanged);
            // 
            // txt_workerRole
            // 
            this.txt_workerRole.Location = new System.Drawing.Point(137, 263);
            this.txt_workerRole.Name = "txt_workerRole";
            this.txt_workerRole.Size = new System.Drawing.Size(155, 22);
            this.txt_workerRole.TabIndex = 93;
            // 
            // AddFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txt_workerRole);
            this.Controls.Add(this.clb_FilmType);
            this.Controls.Add(this.w2);
            this.Controls.Add(this.w1);
            this.Controls.Add(this.txt_workerName);
            this.Controls.Add(this.btn_addWorker);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.tb_desc);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.txt_duration);
            this.Controls.Add(this.btn_saveNewFilm);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.txt_filmName);
            this.Name = "AddFilm";
            this.Size = new System.Drawing.Size(340, 389);
            this.Load += new System.EventHandler(this.AddFilm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_addWorker;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.RichTextBox tb_desc;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox txt_duration;
        private System.Windows.Forms.Button btn_saveNewFilm;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox txt_filmName;
        private System.Windows.Forms.Label w2;
        private System.Windows.Forms.Label w1;
        private System.Windows.Forms.TextBox txt_workerName;
        private System.Windows.Forms.CheckedListBox clb_FilmType;
        private System.Windows.Forms.TextBox txt_workerRole;
    }
}
