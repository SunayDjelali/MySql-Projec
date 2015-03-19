namespace Shoes
{
    partial class FormFoundo
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
            this.cmb_Delete_Fou = new System.Windows.Forms.Button();
            this.cmb_Save_Fou = new System.Windows.Forms.Button();
            this.dataGridViewFon = new System.Windows.Forms.DataGridView();
            this.cmb_Foundo_Exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFon)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_Delete_Fou
            // 
            this.cmb_Delete_Fou.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Delete_Fou.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cmb_Delete_Fou.Location = new System.Drawing.Point(227, 330);
            this.cmb_Delete_Fou.Name = "cmb_Delete_Fou";
            this.cmb_Delete_Fou.Size = new System.Drawing.Size(138, 32);
            this.cmb_Delete_Fou.TabIndex = 15;
            this.cmb_Delete_Fou.Text = "&Delete Selected";
            this.cmb_Delete_Fou.UseVisualStyleBackColor = true;
            this.cmb_Delete_Fou.Click += new System.EventHandler(this.cmb_Delete_Fou_Click);
            // 
            // cmb_Save_Fou
            // 
            this.cmb_Save_Fou.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmb_Save_Fou.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cmb_Save_Fou.Location = new System.Drawing.Point(12, 330);
            this.cmb_Save_Fou.Name = "cmb_Save_Fou";
            this.cmb_Save_Fou.Size = new System.Drawing.Size(87, 32);
            this.cmb_Save_Fou.TabIndex = 14;
            this.cmb_Save_Fou.Text = "&Save";
            this.cmb_Save_Fou.UseVisualStyleBackColor = true;
            this.cmb_Save_Fou.Click += new System.EventHandler(this.cmb_Save_Fou_Click);
            // 
            // dataGridViewFon
            // 
            this.dataGridViewFon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewFon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFon.Location = new System.Drawing.Point(12, 10);
            this.dataGridViewFon.Name = "dataGridViewFon";
            this.dataGridViewFon.Size = new System.Drawing.Size(353, 314);
            this.dataGridViewFon.TabIndex = 13;
            this.dataGridViewFon.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewFon_CellMouseDoubleClick);
            // 
            // cmb_Foundo_Exit
            // 
            this.cmb_Foundo_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmb_Foundo_Exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cmb_Foundo_Exit.Location = new System.Drawing.Point(116, 330);
            this.cmb_Foundo_Exit.Name = "cmb_Foundo_Exit";
            this.cmb_Foundo_Exit.Size = new System.Drawing.Size(87, 32);
            this.cmb_Foundo_Exit.TabIndex = 16;
            this.cmb_Foundo_Exit.Text = "&Exit";
            this.cmb_Foundo_Exit.UseVisualStyleBackColor = true;
            this.cmb_Foundo_Exit.Click += new System.EventHandler(this.cmb_Foundo_Exit_Click);
            // 
            // FormFoundo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 373);
            this.Controls.Add(this.cmb_Foundo_Exit);
            this.Controls.Add(this.cmb_Delete_Fou);
            this.Controls.Add(this.cmb_Save_Fou);
            this.Controls.Add(this.dataGridViewFon);
            this.Location = new System.Drawing.Point(0, 100);
            this.Name = "FormFoundo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormFoundo";
            this.Load += new System.EventHandler(this.FormFoundo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmb_Delete_Fou;
        private System.Windows.Forms.Button cmb_Save_Fou;
        private System.Windows.Forms.DataGridView dataGridViewFon;
        private System.Windows.Forms.Button cmb_Foundo_Exit;
    }
}