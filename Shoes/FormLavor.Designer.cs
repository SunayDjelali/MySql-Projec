namespace Shoes
{
    partial class FormLavor
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
            this.cmb_Delete_Lav = new System.Windows.Forms.Button();
            this.cmb_Save_Lav = new System.Windows.Forms.Button();
            this.dataGridViewLav = new System.Windows.Forms.DataGridView();
            this.cmb_Lavor_Exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLav)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_Delete_Lav
            // 
            this.cmb_Delete_Lav.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Delete_Lav.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cmb_Delete_Lav.Location = new System.Drawing.Point(227, 330);
            this.cmb_Delete_Lav.Name = "cmb_Delete_Lav";
            this.cmb_Delete_Lav.Size = new System.Drawing.Size(138, 32);
            this.cmb_Delete_Lav.TabIndex = 15;
            this.cmb_Delete_Lav.Text = "&Delete Selected";
            this.cmb_Delete_Lav.UseVisualStyleBackColor = true;
            this.cmb_Delete_Lav.Click += new System.EventHandler(this.cmb_Delete_Lav_Click);
            // 
            // cmb_Save_Lav
            // 
            this.cmb_Save_Lav.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmb_Save_Lav.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cmb_Save_Lav.Location = new System.Drawing.Point(12, 330);
            this.cmb_Save_Lav.Name = "cmb_Save_Lav";
            this.cmb_Save_Lav.Size = new System.Drawing.Size(87, 32);
            this.cmb_Save_Lav.TabIndex = 14;
            this.cmb_Save_Lav.Text = "&Save";
            this.cmb_Save_Lav.UseVisualStyleBackColor = true;
            this.cmb_Save_Lav.Click += new System.EventHandler(this.cmb_Save_Lav_Click);
            // 
            // dataGridViewLav
            // 
            this.dataGridViewLav.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewLav.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLav.Location = new System.Drawing.Point(12, 10);
            this.dataGridViewLav.Name = "dataGridViewLav";
            this.dataGridViewLav.Size = new System.Drawing.Size(353, 314);
            this.dataGridViewLav.TabIndex = 13;
            this.dataGridViewLav.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewLav_CellMouseDoubleClick);
            // 
            // cmb_Lavor_Exit
            // 
            this.cmb_Lavor_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmb_Lavor_Exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cmb_Lavor_Exit.Location = new System.Drawing.Point(122, 330);
            this.cmb_Lavor_Exit.Name = "cmb_Lavor_Exit";
            this.cmb_Lavor_Exit.Size = new System.Drawing.Size(87, 32);
            this.cmb_Lavor_Exit.TabIndex = 16;
            this.cmb_Lavor_Exit.Text = "&Exit";
            this.cmb_Lavor_Exit.UseVisualStyleBackColor = true;
            this.cmb_Lavor_Exit.Click += new System.EventHandler(this.cmb_Lavor_Exit_Click);
            // 
            // FormLavor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 373);
            this.Controls.Add(this.cmb_Lavor_Exit);
            this.Controls.Add(this.cmb_Delete_Lav);
            this.Controls.Add(this.cmb_Save_Lav);
            this.Controls.Add(this.dataGridViewLav);
            this.Name = "FormLavor";
            this.Text = "FormLavor";
            this.Load += new System.EventHandler(this.FormLavor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLav)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmb_Delete_Lav;
        private System.Windows.Forms.Button cmb_Save_Lav;
        private System.Windows.Forms.DataGridView dataGridViewLav;
        private System.Windows.Forms.Button cmb_Lavor_Exit;
    }
}