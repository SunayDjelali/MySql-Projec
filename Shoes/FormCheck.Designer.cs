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
            this.lbl_Total = new System.Windows.Forms.Label();
            this.lbl_46 = new System.Windows.Forms.Label();
            this.lbl_45 = new System.Windows.Forms.Label();
            this.lbl_44 = new System.Windows.Forms.Label();
            this.lbl_43 = new System.Windows.Forms.Label();
            this.lbl_42 = new System.Windows.Forms.Label();
            this.lbl_41 = new System.Windows.Forms.Label();
            this.lbl_40 = new System.Windows.Forms.Label();
            this.lbl_39 = new System.Windows.Forms.Label();
            this.txt_Linia = new System.Windows.Forms.TextBox();
            this.lal_Linia = new System.Windows.Forms.Label();
            this.cmb_Run = new System.Windows.Forms.Button();
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
            this.dataGridViewUp.Size = new System.Drawing.Size(1007, 145);
            this.dataGridViewUp.TabIndex = 1;
            // 
            // dataGridViewDown
            // 
            this.dataGridViewDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewDown.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDown.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDown.Location = new System.Drawing.Point(5, 170);
            this.dataGridViewDown.Name = "dataGridViewDown";
            this.dataGridViewDown.Size = new System.Drawing.Size(1007, 223);
            this.dataGridViewDown.TabIndex = 2;
            this.dataGridViewDown.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridViewDown_CellBeginEdit);
            this.dataGridViewDown.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDown_CellEndEdit);
            // 
            // cmb_Save
            // 
            this.cmb_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmb_Save.Location = new System.Drawing.Point(5, 415);
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
            this.cmb_Delete.Location = new System.Drawing.Point(797, 415);
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
            this.cmb_Exit.Location = new System.Drawing.Point(885, 415);
            this.cmb_Exit.Name = "cmb_Exit";
            this.cmb_Exit.Size = new System.Drawing.Size(75, 23);
            this.cmb_Exit.TabIndex = 15;
            this.cmb_Exit.Text = "Exit";
            this.cmb_Exit.UseVisualStyleBackColor = true;
            this.cmb_Exit.Click += new System.EventHandler(this.cmb_Exit_Click);
            // 
            // txt_Lavor
            // 
            this.txt_Lavor.Location = new System.Drawing.Point(328, 415);
            this.txt_Lavor.Name = "txt_Lavor";
            this.txt_Lavor.Size = new System.Drawing.Size(53, 20);
            this.txt_Lavor.TabIndex = 3;
            this.txt_Lavor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_Lavor.TextChanged += new System.EventHandler(this.txt_Lavor_TextChanged);
            // 
            // lbl_Lavoration
            // 
            this.lbl_Lavoration.AutoSize = true;
            this.lbl_Lavoration.Location = new System.Drawing.Point(325, 397);
            this.lbl_Lavoration.Name = "lbl_Lavoration";
            this.lbl_Lavoration.Size = new System.Drawing.Size(57, 13);
            this.lbl_Lavoration.TabIndex = 10;
            this.lbl_Lavoration.Text = "Lavoration";
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.Location = new System.Drawing.Point(939, 148);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(35, 13);
            this.lbl_Total.TabIndex = 16;
            this.lbl_Total.Text = "label1";
            // 
            // lbl_46
            // 
            this.lbl_46.AutoSize = true;
            this.lbl_46.Location = new System.Drawing.Point(880, 148);
            this.lbl_46.Name = "lbl_46";
            this.lbl_46.Size = new System.Drawing.Size(35, 13);
            this.lbl_46.TabIndex = 17;
            this.lbl_46.Text = "label1";
            // 
            // lbl_45
            // 
            this.lbl_45.AutoSize = true;
            this.lbl_45.Location = new System.Drawing.Point(820, 148);
            this.lbl_45.Name = "lbl_45";
            this.lbl_45.Size = new System.Drawing.Size(35, 13);
            this.lbl_45.TabIndex = 17;
            this.lbl_45.Text = "label1";
            // 
            // lbl_44
            // 
            this.lbl_44.AutoSize = true;
            this.lbl_44.Location = new System.Drawing.Point(760, 148);
            this.lbl_44.Name = "lbl_44";
            this.lbl_44.Size = new System.Drawing.Size(35, 13);
            this.lbl_44.TabIndex = 17;
            this.lbl_44.Text = "label1";
            // 
            // lbl_43
            // 
            this.lbl_43.AutoSize = true;
            this.lbl_43.Location = new System.Drawing.Point(702, 148);
            this.lbl_43.Name = "lbl_43";
            this.lbl_43.Size = new System.Drawing.Size(35, 13);
            this.lbl_43.TabIndex = 17;
            this.lbl_43.Text = "label1";
            // 
            // lbl_42
            // 
            this.lbl_42.AutoSize = true;
            this.lbl_42.Location = new System.Drawing.Point(642, 148);
            this.lbl_42.Name = "lbl_42";
            this.lbl_42.Size = new System.Drawing.Size(35, 13);
            this.lbl_42.TabIndex = 17;
            this.lbl_42.Text = "label1";
            // 
            // lbl_41
            // 
            this.lbl_41.AutoSize = true;
            this.lbl_41.Location = new System.Drawing.Point(582, 148);
            this.lbl_41.Name = "lbl_41";
            this.lbl_41.Size = new System.Drawing.Size(35, 13);
            this.lbl_41.TabIndex = 17;
            this.lbl_41.Text = "label1";
            // 
            // lbl_40
            // 
            this.lbl_40.AutoSize = true;
            this.lbl_40.Location = new System.Drawing.Point(523, 148);
            this.lbl_40.Name = "lbl_40";
            this.lbl_40.Size = new System.Drawing.Size(35, 13);
            this.lbl_40.TabIndex = 17;
            this.lbl_40.Text = "label1";
            // 
            // lbl_39
            // 
            this.lbl_39.AutoSize = true;
            this.lbl_39.Location = new System.Drawing.Point(464, 148);
            this.lbl_39.Name = "lbl_39";
            this.lbl_39.Size = new System.Drawing.Size(35, 13);
            this.lbl_39.TabIndex = 17;
            this.lbl_39.Text = "label1";
            // 
            // txt_Linia
            // 
            this.txt_Linia.Location = new System.Drawing.Point(387, 415);
            this.txt_Linia.Name = "txt_Linia";
            this.txt_Linia.Size = new System.Drawing.Size(53, 20);
            this.txt_Linia.TabIndex = 3;
            this.txt_Linia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lal_Linia
            // 
            this.lal_Linia.AutoSize = true;
            this.lal_Linia.Location = new System.Drawing.Point(388, 397);
            this.lal_Linia.Name = "lal_Linia";
            this.lal_Linia.Size = new System.Drawing.Size(29, 13);
            this.lal_Linia.TabIndex = 18;
            this.lal_Linia.Text = "Linia";
            // 
            // cmb_Run
            // 
            this.cmb_Run.Location = new System.Drawing.Point(452, 415);
            this.cmb_Run.Name = "cmb_Run";
            this.cmb_Run.Size = new System.Drawing.Size(75, 23);
            this.cmb_Run.TabIndex = 19;
            this.cmb_Run.Text = "Run";
            this.cmb_Run.UseVisualStyleBackColor = true;
            this.cmb_Run.Click += new System.EventHandler(this.cmb_Run_Click);
            // 
            // FormCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 453);
            this.Controls.Add(this.cmb_Run);
            this.Controls.Add(this.lal_Linia);
            this.Controls.Add(this.lbl_39);
            this.Controls.Add(this.lbl_40);
            this.Controls.Add(this.lbl_41);
            this.Controls.Add(this.lbl_42);
            this.Controls.Add(this.lbl_43);
            this.Controls.Add(this.lbl_44);
            this.Controls.Add(this.lbl_45);
            this.Controls.Add(this.lbl_46);
            this.Controls.Add(this.lbl_Total);
            this.Controls.Add(this.lbl_Lavoration);
            this.Controls.Add(this.txt_Linia);
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
        private System.Windows.Forms.Label lbl_Total;
        private System.Windows.Forms.Label lbl_46;
        private System.Windows.Forms.Label lbl_45;
        private System.Windows.Forms.Label lbl_44;
        private System.Windows.Forms.Label lbl_43;
        private System.Windows.Forms.Label lbl_42;
        private System.Windows.Forms.Label lbl_41;
        private System.Windows.Forms.Label lbl_40;
        private System.Windows.Forms.Label lbl_39;
        private System.Windows.Forms.TextBox txt_Linia;
        private System.Windows.Forms.Label lal_Linia;
        private System.Windows.Forms.Button cmb_Run;
    }
}