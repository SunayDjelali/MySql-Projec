namespace Shoes
{
    partial class FormLave
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
            this.cmb_Save = new System.Windows.Forms.Button();
            this.cmb_Delete = new System.Windows.Forms.Button();
            this.cmb_Exit = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_Save
            // 
            this.cmb_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmb_Save.Location = new System.Drawing.Point(12, 618);
            this.cmb_Save.Name = "cmb_Save";
            this.cmb_Save.Size = new System.Drawing.Size(75, 23);
            this.cmb_Save.TabIndex = 9;
            this.cmb_Save.Text = "Save";
            this.cmb_Save.UseVisualStyleBackColor = true;
            this.cmb_Save.Click += new System.EventHandler(this.cmb_Save_Click);
            // 
            // cmb_Delete
            // 
            this.cmb_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Delete.Location = new System.Drawing.Point(1069, 618);
            this.cmb_Delete.Name = "cmb_Delete";
            this.cmb_Delete.Size = new System.Drawing.Size(82, 23);
            this.cmb_Delete.TabIndex = 8;
            this.cmb_Delete.Text = "Delete Select";
            this.cmb_Delete.UseVisualStyleBackColor = true;
            this.cmb_Delete.Click += new System.EventHandler(this.cmb_Delete_Click);
            // 
            // cmb_Exit
            // 
            this.cmb_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Exit.Location = new System.Drawing.Point(1157, 618);
            this.cmb_Exit.Name = "cmb_Exit";
            this.cmb_Exit.Size = new System.Drawing.Size(75, 23);
            this.cmb_Exit.TabIndex = 7;
            this.cmb_Exit.Text = "Exit";
            this.cmb_Exit.UseVisualStyleBackColor = true;
            this.cmb_Exit.Click += new System.EventHandler(this.cmb_Exit_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(3, 3);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(1267, 611);
            this.dataGridView.TabIndex = 10;
            this.dataGridView.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridView_CellBeginEdit);
            this.dataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellEndEdit);
            // 
            // FormLave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 653);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.cmb_Save);
            this.Controls.Add(this.cmb_Delete);
            this.Controls.Add(this.cmb_Exit);
            this.Location = new System.Drawing.Point(0, 80);
            this.Name = "FormLave";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormLave";
            this.Load += new System.EventHandler(this.FormLave_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmb_Save;
        private System.Windows.Forms.Button cmb_Delete;
        private System.Windows.Forms.Button cmb_Exit;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}