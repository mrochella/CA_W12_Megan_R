namespace THA_W12_Megan_R
{
    partial class UPDATE
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
            this.comboBox_tName = new System.Windows.Forms.ComboBox();
            this.label_tName = new System.Windows.Forms.Label();
            this.button_update = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label_mName = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_tName
            // 
            this.comboBox_tName.FormattingEnabled = true;
            this.comboBox_tName.Location = new System.Drawing.Point(373, 10);
            this.comboBox_tName.Name = "comboBox_tName";
            this.comboBox_tName.Size = new System.Drawing.Size(121, 21);
            this.comboBox_tName.TabIndex = 47;
            this.comboBox_tName.SelectionChangeCommitted += new System.EventHandler(this.comboBox_tName_SelectionChangeCommitted);
            // 
            // label_tName
            // 
            this.label_tName.AutoSize = true;
            this.label_tName.Location = new System.Drawing.Point(286, 13);
            this.label_tName.Name = "label_tName";
            this.label_tName.Size = new System.Drawing.Size(71, 13);
            this.label_tName.TabIndex = 46;
            this.label_tName.Text = "Team_Name:";
            // 
            // button_update
            // 
            this.button_update.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_update.Location = new System.Drawing.Point(350, 96);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(79, 23);
            this.button_update.TabIndex = 45;
            this.button_update.Text = "UPDATE";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(283, 49);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(81, 13);
            this.label17.TabIndex = 44;
            this.label17.Text = "Manager name:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(509, 360);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(152, 17);
            this.label10.TabIndex = 43;
            this.label10.Text = "Managers not working";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(121, 360);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 17);
            this.label9.TabIndex = 41;
            this.label9.Text = "Current team manager";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 143);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(367, 214);
            this.dataGridView1.TabIndex = 40;
            // 
            // label_mName
            // 
            this.label_mName.AutoSize = true;
            this.label_mName.Location = new System.Drawing.Point(380, 49);
            this.label_mName.Name = "label_mName";
            this.label_mName.Size = new System.Drawing.Size(10, 13);
            this.label_mName.TabIndex = 48;
            this.label_mName.Text = "-";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(405, 143);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(362, 214);
            this.dataGridView2.TabIndex = 49;
            this.dataGridView2.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView2_CellMouseClick);
            // 
            // UPDATE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 385);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label_mName);
            this.Controls.Add(this.comboBox_tName);
            this.Controls.Add(this.label_tName);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UPDATE";
            this.Text = "UPDATE";
            this.Load += new System.EventHandler(this.UPDATE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox_tName;
        private System.Windows.Forms.Label label_tName;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label_mName;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}