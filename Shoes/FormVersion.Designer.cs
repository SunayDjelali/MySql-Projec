namespace Shoes
{
    partial class FormVersion
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
            this.cmb_Delete_Ver = new System.Windows.Forms.Button();
            this.cmb_Save_Ver = new System.Windows.Forms.Button();
            this.dataGridViewVer = new System.Windows.Forms.DataGridView();
            this.cmb_Version_Exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVer)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_Delete_Ver
            // 
            this.cmb_Delete_Ver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Delete_Ver.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cmb_Delete_Ver.Location = new System.Drawing.Point(227, 330);
            this.cmb_Delete_Ver.Name = "cmb_Delete_Ver";
            this.cmb_Delete_Ver.Size = new System.Drawing.Size(138, 32);
            this.cmb_Delete_Ver.TabIndex = 15;
            this.cmb_Delete_Ver.Text = "&Delete Selected";
            this.cmb_Delete_Ver.UseVisualStyleBackColor = true;
            this.cmb_Delete_Ver.Click += new System.EventHandler(this.cmb_Delete_Ver_Click);
            // 
            // cmb_Save_Ver
            // 
            this.cmb_Save_Ver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmb_Save_Ver.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cmb_Save_Ver.Location = new System.Drawing.Point(12, 330);
            this.cmb_Save_Ver.Name = "cmb_Save_Ver";
            this.cmb_Save_Ver.Size = new System.Drawing.Size(87, 32);
            this.cmb_Save_Ver.TabIndex = 14;
            this.cmb_Save_Ver.Text = "&Save";
            this.cmb_Save_Ver.UseVisualStyleBackColor = true;
            this.cmb_Save_Ver.Click += new System.EventHandler(this.cmb_Save_Ver_Click);
            // 
            // dataGridViewVer
            // 
            this.dataGridViewVer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewVer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVer.Location = new System.Drawing.Point(12, 10);
            this.dataGridViewVer.Name = "dataGridViewVer";
            this.dataGridViewVer.Size = new System.Drawing.Size(353, 314);
            this.dataGridViewVer.TabIndex = 13;
            this.dataGridViewVer.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewVer_CellMouseDoubleClick);
            // 
            // cmb_Version_Exit
            // 
            this.cmb_Version_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmb_Version_Exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cmb_Version_Exit.Location = new System.Drawing.Point(123, 330);
            this.cmb_Version_Exit.Name = "cmb_Version_Exit";
            this.cmb_Version_Exit.Size = new System.Drawing.Size(87, 32);
            this.cmb_Version_Exit.TabIndex = 16;
            this.cmb_Version_Exit.Text = "&Exit";
            this.cmb_Version_Exit.UseVisualStyleBackColor = true;
            this.cmb_Version_Exit.Click += new System.EventHandler(this.cmb_Version_Exit_Click);
            // 
            // FormVersion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 373);
            this.Controls.Add(this.cmb_Version_Exit);
            this.Controls.Add(this.cmb_Delete_Ver);
            this.Controls.Add(this.cmb_Save_Ver);
            this.Controls.Add(this.dataGridViewVer);
            this.Location = new System.Drawing.Point(0, 100);
            this.Name = "FormVersion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormVersion";
            this.Load += new System.EventHandler(this.FormVersion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmb_Delete_Ver;
        private System.Windows.Forms.Button cmb_Save_Ver;
        private System.Windows.Forms.DataGridView dataGridViewVer;
        private System.Windows.Forms.Button cmb_Version_Exit;
    }
}