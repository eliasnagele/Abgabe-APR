namespace Nagele_Jahresprojekt
{
    partial class Calendar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calendar));
            this.bt_CloseCalendar = new System.Windows.Forms.Button();
            this.bt_ReturnCalendar = new System.Windows.Forms.Button();
            this.tb_CalendarCountry = new System.Windows.Forms.TextBox();
            this.tb_CalendarRaceName = new System.Windows.Forms.TextBox();
            this.tb_CalendarDate = new System.Windows.Forms.TextBox();
            this.bt_next = new System.Windows.Forms.Button();
            this.bt_latest = new System.Windows.Forms.Button();
            this.dtv_Calendar = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.bt_CalendarSave = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.lb_AdminInfoCalendar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtv_Calendar)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_CloseCalendar
            // 
            this.bt_CloseCalendar.BackColor = System.Drawing.Color.Red;
            this.bt_CloseCalendar.Location = new System.Drawing.Point(942, 12);
            this.bt_CloseCalendar.Name = "bt_CloseCalendar";
            this.bt_CloseCalendar.Size = new System.Drawing.Size(30, 30);
            this.bt_CloseCalendar.TabIndex = 5;
            this.bt_CloseCalendar.Text = "x";
            this.bt_CloseCalendar.UseVisualStyleBackColor = false;
            this.bt_CloseCalendar.Click += new System.EventHandler(this.bt_CloseCalendar_Click);
            // 
            // bt_ReturnCalendar
            // 
            this.bt_ReturnCalendar.Location = new System.Drawing.Point(900, 520);
            this.bt_ReturnCalendar.Name = "bt_ReturnCalendar";
            this.bt_ReturnCalendar.Size = new System.Drawing.Size(72, 29);
            this.bt_ReturnCalendar.TabIndex = 4;
            this.bt_ReturnCalendar.Text = "Return";
            this.bt_ReturnCalendar.UseVisualStyleBackColor = true;
            this.bt_ReturnCalendar.Click += new System.EventHandler(this.bt_ReturnCalendar_Click);
            // 
            // tb_CalendarCountry
            // 
            this.tb_CalendarCountry.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_CalendarCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_CalendarCountry.Location = new System.Drawing.Point(415, 80);
            this.tb_CalendarCountry.Name = "tb_CalendarCountry";
            this.tb_CalendarCountry.ReadOnly = true;
            this.tb_CalendarCountry.Size = new System.Drawing.Size(170, 23);
            this.tb_CalendarCountry.TabIndex = 20;
            this.tb_CalendarCountry.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_CalendarRaceName
            // 
            this.tb_CalendarRaceName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_CalendarRaceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_CalendarRaceName.Location = new System.Drawing.Point(315, 129);
            this.tb_CalendarRaceName.Multiline = true;
            this.tb_CalendarRaceName.Name = "tb_CalendarRaceName";
            this.tb_CalendarRaceName.ReadOnly = true;
            this.tb_CalendarRaceName.Size = new System.Drawing.Size(370, 170);
            this.tb_CalendarRaceName.TabIndex = 21;
            this.tb_CalendarRaceName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_CalendarDate
            // 
            this.tb_CalendarDate.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_CalendarDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_CalendarDate.Location = new System.Drawing.Point(415, 326);
            this.tb_CalendarDate.Name = "tb_CalendarDate";
            this.tb_CalendarDate.ReadOnly = true;
            this.tb_CalendarDate.Size = new System.Drawing.Size(170, 21);
            this.tb_CalendarDate.TabIndex = 22;
            this.tb_CalendarDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bt_next
            // 
            this.bt_next.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_next.Location = new System.Drawing.Point(718, 192);
            this.bt_next.Name = "bt_next";
            this.bt_next.Size = new System.Drawing.Size(45, 45);
            this.bt_next.TabIndex = 2;
            this.bt_next.Text = "->";
            this.bt_next.UseVisualStyleBackColor = true;
            this.bt_next.Click += new System.EventHandler(this.bt_next_Click);
            // 
            // bt_latest
            // 
            this.bt_latest.Location = new System.Drawing.Point(236, 192);
            this.bt_latest.Name = "bt_latest";
            this.bt_latest.Size = new System.Drawing.Size(45, 45);
            this.bt_latest.TabIndex = 1;
            this.bt_latest.Text = "<-";
            this.bt_latest.UseVisualStyleBackColor = true;
            this.bt_latest.Click += new System.EventHandler(this.bt_latest_Click);
            // 
            // dtv_Calendar
            // 
            this.dtv_Calendar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtv_Calendar.Location = new System.Drawing.Point(12, 393);
            this.dtv_Calendar.Name = "dtv_Calendar";
            this.dtv_Calendar.Size = new System.Drawing.Size(654, 156);
            this.dtv_Calendar.TabIndex = 25;
            // 
            // bt_CalendarSave
            // 
            this.bt_CalendarSave.Location = new System.Drawing.Point(900, 485);
            this.bt_CalendarSave.Name = "bt_CalendarSave";
            this.bt_CalendarSave.Size = new System.Drawing.Size(72, 29);
            this.bt_CalendarSave.TabIndex = 3;
            this.bt_CalendarSave.Text = "Save";
            this.bt_CalendarSave.UseVisualStyleBackColor = true;
            this.bt_CalendarSave.Click += new System.EventHandler(this.bt_CalendarSave_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // lb_AdminInfoCalendar
            // 
            this.lb_AdminInfoCalendar.AutoSize = true;
            this.lb_AdminInfoCalendar.Location = new System.Drawing.Point(10, 374);
            this.lb_AdminInfoCalendar.Name = "lb_AdminInfoCalendar";
            this.lb_AdminInfoCalendar.Size = new System.Drawing.Size(255, 13);
            this.lb_AdminInfoCalendar.TabIndex = 26;
            this.lb_AdminInfoCalendar.Text = "This datagridview can only be updated or expanded.";
            this.lb_AdminInfoCalendar.Visible = false;
            // 
            // Calendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.lb_AdminInfoCalendar);
            this.Controls.Add(this.bt_CalendarSave);
            this.Controls.Add(this.dtv_Calendar);
            this.Controls.Add(this.bt_latest);
            this.Controls.Add(this.bt_next);
            this.Controls.Add(this.tb_CalendarDate);
            this.Controls.Add(this.tb_CalendarRaceName);
            this.Controls.Add(this.tb_CalendarCountry);
            this.Controls.Add(this.bt_ReturnCalendar);
            this.Controls.Add(this.bt_CloseCalendar);
            this.Name = "Calendar";
            this.Text = "Calendar";
            ((System.ComponentModel.ISupportInitialize)(this.dtv_Calendar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_CloseCalendar;
        private System.Windows.Forms.Button bt_ReturnCalendar;
        private System.Windows.Forms.TextBox tb_CalendarCountry;
        private System.Windows.Forms.TextBox tb_CalendarRaceName;
        private System.Windows.Forms.TextBox tb_CalendarDate;
        private System.Windows.Forms.Button bt_next;
        private System.Windows.Forms.Button bt_latest;
        private System.Windows.Forms.DataGridView dtv_Calendar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button bt_CalendarSave;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label lb_AdminInfoCalendar;
    }
}