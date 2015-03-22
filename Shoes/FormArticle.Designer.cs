namespace Shoes
{
    partial class FormArticle
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
            this.cmb_Delete_Art = new System.Windows.Forms.Button();
            this.cmb_Save_Art = new System.Windows.Forms.Button();
            this.dataGridViewArt = new System.Windows.Forms.DataGridView();
            this.cmb_Article_Exit = new System.Windows.Forms.Button();
            this.lbl_Msg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArt)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_Delete_Art
            // 
            this.cmb_Delete_Art.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Delete_Art.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cmb_Delete_Art.Location = new System.Drawing.Point(227, 332);
            this.cmb_Delete_Art.Name = "cmb_Delete_Art";
            this.cmb_Delete_Art.Size = new System.Drawing.Size(138, 32);
            this.cmb_Delete_Art.TabIndex = 15;
            this.cmb_Delete_Art.Text = "&Delete Selected";
            this.cmb_Delete_Art.UseVisualStyleBackColor = true;
            this.cmb_Delete_Art.Click += new System.EventHandler(this.cmb_Delete_Art_Click);
            // 
            // cmb_Save_Art
            // 
            this.cmb_Save_Art.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmb_Save_Art.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cmb_Save_Art.Location = new System.Drawing.Point(12, 332);
            this.cmb_Save_Art.Name = "cmb_Save_Art";
            this.cmb_Save_Art.Size = new System.Drawing.Size(87, 32);
            this.cmb_Save_Art.TabIndex = 14;
            this.cmb_Save_Art.Text = "&Save";
            this.cmb_Save_Art.UseVisualStyleBackColor = true;
            this.cmb_Save_Art.Click += new System.EventHandler(this.cmb_Save_Art_Click);
            // 
            // dataGridViewArt
            // 
            this.dataGridViewArt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewArt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewArt.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewArt.Name = "dataGridViewArt";
            this.dataGridViewArt.Size = new System.Drawing.Size(353, 314);
            this.dataGridViewArt.TabIndex = 13;
            this.dataGridViewArt.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridViewArt_CellBeginEdit);
            this.dataGridViewArt.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewArt_CellMouseDoubleClick);
            // 
            // cmb_Article_Exit
            // 
            this.cmb_Article_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmb_Article_Exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cmb_Article_Exit.Location = new System.Drawing.Point(122, 332);
            this.cmb_Article_Exit.Name = "cmb_Article_Exit";
            this.cmb_Article_Exit.Size = new System.Drawing.Size(87, 32);
            this.cmb_Article_Exit.TabIndex = 16;
            this.cmb_Article_Exit.Text = "&Exit";
            this.cmb_Article_Exit.UseVisualStyleBackColor = true;
            this.cmb_Article_Exit.Click += new System.EventHandler(this.cmb_Article_Exit_Click);
            // 
            // lbl_Msg
            // 
            this.lbl_Msg.AutoSize = true;
            this.lbl_Msg.Location = new System.Drawing.Point(149, 377);
            this.lbl_Msg.Name = "lbl_Msg";
            this.lbl_Msg.Size = new System.Drawing.Size(50, 13);
            this.lbl_Msg.TabIndex = 17;
            this.lbl_Msg.Text = "Message";
            // 
            // FormArticle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 399);
            this.Controls.Add(this.lbl_Msg);
            this.Controls.Add(this.cmb_Article_Exit);
            this.Controls.Add(this.cmb_Delete_Art);
            this.Controls.Add(this.cmb_Save_Art);
            this.Controls.Add(this.dataGridViewArt);
            this.Location = new System.Drawing.Point(250, 100);
            this.Name = "FormArticle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormArticle";
            this.Load += new System.EventHandler(this.FormArticle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmb_Delete_Art;
        private System.Windows.Forms.Button cmb_Save_Art;
        private System.Windows.Forms.DataGridView dataGridViewArt;
        private System.Windows.Forms.Button cmb_Article_Exit;
        private System.Windows.Forms.Label lbl_Msg;
    }
}