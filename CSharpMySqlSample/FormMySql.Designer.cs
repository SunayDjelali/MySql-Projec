namespace CSharpMySqlSample
{
    partial class FormMySql
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
            this.dataGridViewWorck = new System.Windows.Forms.DataGridView();
            this.cmb_Save = new System.Windows.Forms.Button();
            this.cmb_Delete = new System.Windows.Forms.Button();
            this.cmb_Main_Exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWorck)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewWorck
            // 
            this.dataGridViewWorck.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewWorck.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWorck.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewWorck.Name = "dataGridViewWorck";
            this.dataGridViewWorck.Size = new System.Drawing.Size(892, 314);
            this.dataGridViewWorck.TabIndex = 0;
            this.dataGridViewWorck.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewWorck_CellMouseDoubleClick);
            // 
            // cmb_Save
            // 
            this.cmb_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmb_Save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cmb_Save.Location = new System.Drawing.Point(12, 332);
            this.cmb_Save.Name = "cmb_Save";
            this.cmb_Save.Size = new System.Drawing.Size(87, 32);
            this.cmb_Save.TabIndex = 1;
            this.cmb_Save.Text = "&Save";
            this.cmb_Save.UseVisualStyleBackColor = true;
            this.cmb_Save.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmb_Delete
            // 
            this.cmb_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Delete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cmb_Delete.Location = new System.Drawing.Point(766, 332);
            this.cmb_Delete.Name = "cmb_Delete";
            this.cmb_Delete.Size = new System.Drawing.Size(138, 32);
            this.cmb_Delete.TabIndex = 2;
            this.cmb_Delete.Text = "&Delete Selected";
            this.cmb_Delete.UseVisualStyleBackColor = true;
            this.cmb_Delete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cmb_Main_Exit
            // 
            this.cmb_Main_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmb_Main_Exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cmb_Main_Exit.Location = new System.Drawing.Point(673, 332);
            this.cmb_Main_Exit.Name = "cmb_Main_Exit";
            this.cmb_Main_Exit.Size = new System.Drawing.Size(87, 32);
            this.cmb_Main_Exit.TabIndex = 14;
            this.cmb_Main_Exit.Text = "&Exit";
            this.cmb_Main_Exit.UseVisualStyleBackColor = true;
            this.cmb_Main_Exit.Click += new System.EventHandler(this.cmb_Main_Exit_Click);
            // 
            // FormMySql
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 413);
            this.Controls.Add(this.cmb_Main_Exit);
            this.Controls.Add(this.cmb_Delete);
            this.Controls.Add(this.cmb_Save);
            this.Controls.Add(this.dataGridViewWorck);
            this.Name = "FormMySql";
            this.Text = "Connecting to MySQL database using C#";
            this.Load += new System.EventHandler(this.frmMySql_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWorck)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewWorck;
        private System.Windows.Forms.Button cmb_Save;
        private System.Windows.Forms.Button cmb_Delete;
        private System.Windows.Forms.Button cmb_Main_Exit;
    }
}

