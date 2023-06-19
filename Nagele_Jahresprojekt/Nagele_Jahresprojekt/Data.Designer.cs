namespace Nagele_Jahresprojekt
{
    partial class Data
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
            this.dtv_Data = new System.Windows.Forms.DataGridView();
            this.bt_CloseData = new System.Windows.Forms.Button();
            this.bt_SaveData = new System.Windows.Forms.Button();
            this.bt_ReturnData = new System.Windows.Forms.Button();
            this.tb_Search = new System.Windows.Forms.TextBox();
            this.bt_Search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtv_Data)).BeginInit();
            this.SuspendLayout();
            // 
            // dtv_Data
            // 
            this.dtv_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtv_Data.Location = new System.Drawing.Point(13, 47);
            this.dtv_Data.Name = "dtv_Data";
            this.dtv_Data.Size = new System.Drawing.Size(868, 502);
            this.dtv_Data.TabIndex = 0;
            // 
            // bt_CloseData
            // 
            this.bt_CloseData.BackColor = System.Drawing.Color.Red;
            this.bt_CloseData.Location = new System.Drawing.Point(942, 12);
            this.bt_CloseData.Name = "bt_CloseData";
            this.bt_CloseData.Size = new System.Drawing.Size(30, 30);
            this.bt_CloseData.TabIndex = 5;
            this.bt_CloseData.Text = "x";
            this.bt_CloseData.UseVisualStyleBackColor = false;
            this.bt_CloseData.Click += new System.EventHandler(this.bt_CloseData_Click);
            // 
            // bt_SaveData
            // 
            this.bt_SaveData.Location = new System.Drawing.Point(900, 482);
            this.bt_SaveData.Name = "bt_SaveData";
            this.bt_SaveData.Size = new System.Drawing.Size(72, 29);
            this.bt_SaveData.TabIndex = 3;
            this.bt_SaveData.Text = "Save";
            this.bt_SaveData.UseVisualStyleBackColor = true;
            this.bt_SaveData.Click += new System.EventHandler(this.bt_SaveData_Click);
            // 
            // bt_ReturnData
            // 
            this.bt_ReturnData.Location = new System.Drawing.Point(900, 520);
            this.bt_ReturnData.Name = "bt_ReturnData";
            this.bt_ReturnData.Size = new System.Drawing.Size(72, 29);
            this.bt_ReturnData.TabIndex = 4;
            this.bt_ReturnData.Text = "Return";
            this.bt_ReturnData.UseVisualStyleBackColor = true;
            this.bt_ReturnData.Click += new System.EventHandler(this.bt_ReturnData_Click);
            // 
            // tb_Search
            // 
            this.tb_Search.Location = new System.Drawing.Point(12, 10);
            this.tb_Search.Name = "tb_Search";
            this.tb_Search.Size = new System.Drawing.Size(142, 20);
            this.tb_Search.TabIndex = 1;
            // 
            // bt_Search
            // 
            this.bt_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bt_Search.Location = new System.Drawing.Point(160, 9);
            this.bt_Search.Name = "bt_Search";
            this.bt_Search.Size = new System.Drawing.Size(61, 22);
            this.bt_Search.TabIndex = 2;
            this.bt_Search.Text = "Search";
            this.bt_Search.UseVisualStyleBackColor = false;
            this.bt_Search.Click += new System.EventHandler(this.bt_Search_Click);
            // 
            // Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.bt_Search);
            this.Controls.Add(this.tb_Search);
            this.Controls.Add(this.bt_ReturnData);
            this.Controls.Add(this.bt_SaveData);
            this.Controls.Add(this.bt_CloseData);
            this.Controls.Add(this.dtv_Data);
            this.Name = "Data";
            this.Text = "Data";
            ((System.ComponentModel.ISupportInitialize)(this.dtv_Data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtv_Data;
        private System.Windows.Forms.Button bt_CloseData;
        private System.Windows.Forms.Button bt_SaveData;
        private System.Windows.Forms.Button bt_ReturnData;
        private System.Windows.Forms.TextBox tb_Search;
        private System.Windows.Forms.Button bt_Search;
    }
}