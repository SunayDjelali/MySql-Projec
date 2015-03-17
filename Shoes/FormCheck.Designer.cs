namespace Shoes
{
    partial class FormCheck
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
            this.dataGridViewUp = new System.Windows.Forms.DataGridView();
            this.dataGridViewDown = new System.Windows.Forms.DataGridView();
            this.cmb_Save = new System.Windows.Forms.Button();
            this.cmb_Delete = new System.Windows.Forms.Button();
            this.cmb_Exit = new System.Windows.Forms.Button();
            this.txt_Lavor = new System.Windows.Forms.TextBox();
            this.lbl_Lavoration = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDown)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewUp
            // 
            this.dataGridViewUp.AllowUserToAddRows = false;
            this.dataGridViewUp.AllowUserToDeleteRows = false;
            this.dataGridViewUp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewUp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewUp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUp.Location = new System.Drawing.Point(5, 0);
            this.dataGridViewUp.Name = "dataGridViewUp";
            this.dataGridViewUp.ReadOnly = true;
            this.dataGridViewUp.Size = new System.Drawing.Size(1267, 244);
            this.dataGridViewUp.TabIndex = 1;
            // 
            // dataGridViewDown
            // 
            this.dataGridViewDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewDown.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDown.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDown.Location = new System.Drawing.Point(5, 282);
            this.dataGridViewDown.Name = "dataGridViewDown";
            this.dataGridViewDown.Size = new System.Drawing.Size(1267, 244);
            this.dataGridViewDown.TabIndex = 2;
            this.dataGridViewDown.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridViewDown_CellBeginEdit);
            this.dataGridViewDown.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDown_CellEndEdit);
            // 
            // cmb_Save
            // 
            this.cmb_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmb_Save.Location = new System.Drawing.Point(5, 575);
            this.cmb_Save.Name = "cmb_Save";
            this.cmb_Save.Size = new System.Drawing.Size(75, 23);
            this.cmb_Save.TabIndex = 13;
            this.cmb_Save.Text = "Save";
            this.cmb_Save.UseVisualStyleBackColor = true;
            this.cmb_Save.Click += new System.EventHandler(this.cmb_Save_Click);
            // 
            // cmb_Delete
            // 
            this.cmb_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Delete.Location = new System.Drawing.Point(1062, 575);
            this.cmb_Delete.Name = "cmb_Delete";
            this.cmb_Delete.Size = new System.Drawing.Size(82, 23);
            this.cmb_Delete.TabIndex = 14;
            this.cmb_Delete.Text = "Delete Select";
            this.cmb_Delete.UseVisualStyleBackColor = true;
            this.cmb_Delete.Click += new System.EventHandler(this.cmb_Delete_Click);
            // 
            // cmb_Exit
            // 
            this.cmb_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Exit.Location = new System.Drawing.Point(1150, 575);
            this.cmb_Exit.Name = "cmb_Exit";
            this.cmb_Exit.Size = new System.Drawing.Size(75, 23);
            this.cmb_Exit.TabIndex = 15;
            this.cmb_Exit.Text = "Exit";
            this.cmb_Exit.UseVisualStyleBackColor = true;
            this.cmb_Exit.Click += new System.EventHandler(this.cmb_Exit_Click);
            // 
            // txt_Lavor
            // 
            this.txt_Lavor.Location = new System.Drawing.Point(328, 560);
            this.txt_Lavor.Name = "txt_Lavor";
            this.txt_Lavor.Size = new System.Drawing.Size(53, 20);
            this.txt_Lavor.TabIndex = 3;
            this.txt_Lavor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_Lavor.TextChanged += new System.EventHandler(this.txt_Lavor_TextChanged);
            // 
            // lbl_Lavoration
            // 
            this.lbl_Lavoration.AutoSize = true;
            this.lbl_Lavoration.Location = new System.Drawing.Point(325, 539);
            this.lbl_Lavoration.Name = "lbl_Lavoration";
            this.lbl_Lavoration.Size = new System.Drawing.Size(57, 13);
            this.lbl_Lavoration.TabIndex = 10;
            this.lbl_Lavoration.Text = "Lavoration";
            // 
            // FormCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 610);
            this.Controls.Add(this.lbl_Lavoration);
            this.Controls.Add(this.txt_Lavor);
            this.Controls.Add(this.cmb_Save);
            this.Controls.Add(this.cmb_Delete);
            this.Controls.Add(this.cmb_Exit);
            this.Controls.Add(this.dataGridViewDown);
            this.Controls.Add(this.dataGridViewUp);
            this.Location = new System.Drawing.Point(0, 80);
            this.Name = "FormCheck";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormCheck";
            this.Load += new System.EventHandler(this.FormCheck_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewUp;
        private System.Windows.Forms.DataGridView dataGridViewDown;
        private System.Windows.Forms.Button cmb_Save;
        private System.Windows.Forms.Button cmb_Delete;
        private System.Windows.Forms.Button cmb_Exit;
        private System.Windows.Forms.TextBox txt_Lavor;
        private System.Windows.Forms.Label lbl_Lavoration;
    }
}