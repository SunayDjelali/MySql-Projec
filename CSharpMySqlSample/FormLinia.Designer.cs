namespace CSharpMySqlSample
{
    partial class FormLinia
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
            this.cmb_Delete_Lin = new System.Windows.Forms.Button();
            this.cmb_Save_Lin = new System.Windows.Forms.Button();
            this.dataGridViewLin = new System.Windows.Forms.DataGridView();
            this.cmb_Linia_Exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLin)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_Delete_Lin
            // 
            this.cmb_Delete_Lin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Delete_Lin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cmb_Delete_Lin.Location = new System.Drawing.Point(228, 332);
            this.cmb_Delete_Lin.Name = "cmb_Delete_Lin";
            this.cmb_Delete_Lin.Size = new System.Drawing.Size(138, 32);
            this.cmb_Delete_Lin.TabIndex = 11;
            this.cmb_Delete_Lin.Text = "&Delete Selected";
            this.cmb_Delete_Lin.UseVisualStyleBackColor = true;
            this.cmb_Delete_Lin.Click += new System.EventHandler(this.cmb_Delete_Lin_Click);
            // 
            // cmb_Save_Lin
            // 
            this.cmb_Save_Lin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmb_Save_Lin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cmb_Save_Lin.Location = new System.Drawing.Point(12, 332);
            this.cmb_Save_Lin.Name = "cmb_Save_Lin";
            this.cmb_Save_Lin.Size = new System.Drawing.Size(87, 32);
            this.cmb_Save_Lin.TabIndex = 10;
            this.cmb_Save_Lin.Text = "&Save";
            this.cmb_Save_Lin.UseVisualStyleBackColor = true;
            this.cmb_Save_Lin.Click += new System.EventHandler(this.cmb_Save_Lin_Click);
            // 
            // dataGridViewLin
            // 
            this.dataGridViewLin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewLin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLin.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewLin.Name = "dataGridViewLin";
            this.dataGridViewLin.Size = new System.Drawing.Size(354, 314);
            this.dataGridViewLin.TabIndex = 9;
            this.dataGridViewLin.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewLin_CellMouseDoubleClick);
            // 
            // cmb_Linia_Exit
            // 
            this.cmb_Linia_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmb_Linia_Exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cmb_Linia_Exit.Location = new System.Drawing.Point(118, 332);
            this.cmb_Linia_Exit.Name = "cmb_Linia_Exit";
            this.cmb_Linia_Exit.Size = new System.Drawing.Size(87, 32);
            this.cmb_Linia_Exit.TabIndex = 14;
            this.cmb_Linia_Exit.Text = "&Exit";
            this.cmb_Linia_Exit.UseVisualStyleBackColor = true;
            this.cmb_Linia_Exit.Click += new System.EventHandler(this.cmb_Linia_Exit_Click);
            // 
            // FormLinia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 373);
            this.Controls.Add(this.cmb_Linia_Exit);
            this.Controls.Add(this.cmb_Delete_Lin);
            this.Controls.Add(this.cmb_Save_Lin);
            this.Controls.Add(this.dataGridViewLin);
            this.Name = "FormLinia";
            this.Text = "FormLinia";
            this.Load += new System.EventHandler(this.FormLinia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmb_Delete_Lin;
        private System.Windows.Forms.Button cmb_Save_Lin;
        private System.Windows.Forms.DataGridView dataGridViewLin;
        private System.Windows.Forms.Button cmb_Linia_Exit;

    }
}