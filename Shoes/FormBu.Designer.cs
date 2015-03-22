namespace Shoes
{
    partial class FormBu
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
            this.cmb_Delete_Bu = new System.Windows.Forms.Button();
            this.cmb_Save_Bu = new System.Windows.Forms.Button();
            this.dataGridViewBu = new System.Windows.Forms.DataGridView();
            this.cmb_Bu_Exit = new System.Windows.Forms.Button();
            this.lbl_Msg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBu)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_Delete_Bu
            // 
            this.cmb_Delete_Bu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Delete_Bu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cmb_Delete_Bu.Location = new System.Drawing.Point(172, 332);
            this.cmb_Delete_Bu.Name = "cmb_Delete_Bu";
            this.cmb_Delete_Bu.Size = new System.Drawing.Size(138, 32);
            this.cmb_Delete_Bu.TabIndex = 12;
            this.cmb_Delete_Bu.Text = "&Delete Selected";
            this.cmb_Delete_Bu.UseVisualStyleBackColor = true;
            this.cmb_Delete_Bu.Click += new System.EventHandler(this.cmb_Delete_Bu_Click);
            // 
            // cmb_Save_Bu
            // 
            this.cmb_Save_Bu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmb_Save_Bu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cmb_Save_Bu.Location = new System.Drawing.Point(3, 332);
            this.cmb_Save_Bu.Name = "cmb_Save_Bu";
            this.cmb_Save_Bu.Size = new System.Drawing.Size(76, 32);
            this.cmb_Save_Bu.TabIndex = 11;
            this.cmb_Save_Bu.Text = "&Save";
            this.cmb_Save_Bu.UseVisualStyleBackColor = true;
            this.cmb_Save_Bu.Click += new System.EventHandler(this.cmb_Save_Bu_Click);
            // 
            // dataGridViewBu
            // 
            this.dataGridViewBu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBu.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewBu.Name = "dataGridViewBu";
            this.dataGridViewBu.Size = new System.Drawing.Size(314, 323);
            this.dataGridViewBu.TabIndex = 10;
            this.dataGridViewBu.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridViewBu_CellBeginEdit);
            this.dataGridViewBu.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBu_CellDoubleClick);
            // 
            // cmb_Bu_Exit
            // 
            this.cmb_Bu_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmb_Bu_Exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cmb_Bu_Exit.Location = new System.Drawing.Point(85, 332);
            this.cmb_Bu_Exit.Name = "cmb_Bu_Exit";
            this.cmb_Bu_Exit.Size = new System.Drawing.Size(81, 32);
            this.cmb_Bu_Exit.TabIndex = 13;
            this.cmb_Bu_Exit.Text = "&Exit";
            this.cmb_Bu_Exit.UseVisualStyleBackColor = true;
            this.cmb_Bu_Exit.Click += new System.EventHandler(this.cmb_Bu_Exit_Click);
            // 
            // lbl_Msg
            // 
            this.lbl_Msg.AutoSize = true;
            this.lbl_Msg.Location = new System.Drawing.Point(85, 368);
            this.lbl_Msg.Name = "lbl_Msg";
            this.lbl_Msg.Size = new System.Drawing.Size(50, 13);
            this.lbl_Msg.TabIndex = 14;
            this.lbl_Msg.Text = "Message";
            // 
            // FormBu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 385);
            this.Controls.Add(this.lbl_Msg);
            this.Controls.Add(this.cmb_Bu_Exit);
            this.Controls.Add(this.cmb_Delete_Bu);
            this.Controls.Add(this.cmb_Save_Bu);
            this.Controls.Add(this.dataGridViewBu);
            this.Location = new System.Drawing.Point(100, 100);
            this.Name = "FormBu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Bu";
            this.Load += new System.EventHandler(this.FormBu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmb_Delete_Bu;
        private System.Windows.Forms.Button cmb_Save_Bu;
        private System.Windows.Forms.DataGridView dataGridViewBu;
        private System.Windows.Forms.Button cmb_Bu_Exit;
        private System.Windows.Forms.Label lbl_Msg;
    }
}