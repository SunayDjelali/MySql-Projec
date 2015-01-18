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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMySql));
            this.dataGridViewWorck = new System.Windows.Forms.DataGridView();
            this.cmb_Save = new System.Windows.Forms.Button();
            this.cmb_Delete = new System.Windows.Forms.Button();
            this.cmb_Main_Exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWorck)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewWorck
            // 
            resources.ApplyResources(this.dataGridViewWorck, "dataGridViewWorck");
            this.dataGridViewWorck.AllowUserToOrderColumns = true;
            this.dataGridViewWorck.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewWorck.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWorck.Name = "dataGridViewWorck";
            this.dataGridViewWorck.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridViewWorck_CellBeginEdit);
            //this.dataGridViewWorck.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewWorck_CellValueChanged);
            // 
            // cmb_Save
            // 
            resources.ApplyResources(this.cmb_Save, "cmb_Save");
            this.cmb_Save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cmb_Save.Name = "cmb_Save";
            this.cmb_Save.UseVisualStyleBackColor = true;
            this.cmb_Save.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmb_Delete
            // 
            resources.ApplyResources(this.cmb_Delete, "cmb_Delete");
            this.cmb_Delete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cmb_Delete.Name = "cmb_Delete";
            this.cmb_Delete.UseVisualStyleBackColor = true;
            this.cmb_Delete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cmb_Main_Exit
            // 
            resources.ApplyResources(this.cmb_Main_Exit, "cmb_Main_Exit");
            this.cmb_Main_Exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cmb_Main_Exit.Name = "cmb_Main_Exit";
            this.cmb_Main_Exit.UseVisualStyleBackColor = true;
            this.cmb_Main_Exit.Click += new System.EventHandler(this.cmb_Main_Exit_Click);
            // 
            // FormMySql
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmb_Main_Exit);
            this.Controls.Add(this.cmb_Delete);
            this.Controls.Add(this.cmb_Save);
            this.Controls.Add(this.dataGridViewWorck);
            this.Name = "FormMySql";
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

