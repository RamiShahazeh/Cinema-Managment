namespace oracleTest
{
    partial class FilmWorker
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
            this.btn_saveNewShow = new System.Windows.Forms.Button();
            this.cb_filmName = new System.Windows.Forms.ComboBox();
            this.txt_workerName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_workerRole = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_saveNewShow
            // 
            this.btn_saveNewShow.Location = new System.Drawing.Point(109, 187);
            this.btn_saveNewShow.Name = "btn_saveNewShow";
            this.btn_saveNewShow.Size = new System.Drawing.Size(107, 50);
            this.btn_saveNewShow.TabIndex = 72;
            this.btn_saveNewShow.Text = "Save";
            this.btn_saveNewShow.UseVisualStyleBackColor = true;
            this.btn_saveNewShow.Click += new System.EventHandler(this.btn_saveNewShow_Click);
            // 
            // cb_filmName
            // 
            this.cb_filmName.FormattingEnabled = true;
            this.cb_filmName.Location = new System.Drawing.Point(181, 138);
            this.cb_filmName.Name = "cb_filmName";
            this.cb_filmName.Size = new System.Drawing.Size(100, 24);
            this.cb_filmName.TabIndex = 71;
            // 
            // txt_workerName
            // 
            this.txt_workerName.Location = new System.Drawing.Point(181, 40);
            this.txt_workerName.Name = "txt_workerName";
            this.txt_workerName.Size = new System.Drawing.Size(100, 22);
            this.txt_workerName.TabIndex = 69;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 68;
            this.label4.Text = "Film Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 67;
            this.label3.Text = "Worker role";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 66;
            this.label2.Text = "Worker Name";
            // 
            // txt_workerRole
            // 
            this.txt_workerRole.Location = new System.Drawing.Point(181, 89);
            this.txt_workerRole.Name = "txt_workerRole";
            this.txt_workerRole.Size = new System.Drawing.Size(100, 22);
            this.txt_workerRole.TabIndex = 73;
            // 
            // FilmWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txt_workerRole);
            this.Controls.Add(this.btn_saveNewShow);
            this.Controls.Add(this.cb_filmName);
            this.Controls.Add(this.txt_workerName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "FilmWorker";
            this.Size = new System.Drawing.Size(321, 252);
            this.Load += new System.EventHandler(this.FilmWorker_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_saveNewShow;
        private System.Windows.Forms.ComboBox cb_filmName;
        private System.Windows.Forms.TextBox txt_workerName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_workerRole;
    }
}
