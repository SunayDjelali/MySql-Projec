namespace Diviator
{
    partial class DiviatorLightSystem
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
            this.diviator = new System.Windows.Forms.TrackBar();
            this.diviator2 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.diviator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diviator2)).BeginInit();
            this.SuspendLayout();
            // 
            // diviator
            // 
            this.diviator.Location = new System.Drawing.Point(28, 125);
            this.diviator.Maximum = 1;
            this.diviator.Name = "diviator";
            this.diviator.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.diviator.Size = new System.Drawing.Size(45, 61);
            this.diviator.TabIndex = 0;
            this.diviator.TabStop = false;
            this.diviator.ValueChanged += new System.EventHandler(this.diviator_ValueChanged);
            // 
            // diviator2
            // 
            this.diviator2.Location = new System.Drawing.Point(126, 125);
            this.diviator2.Maximum = 1;
            this.diviator2.Name = "diviator2";
            this.diviator2.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.diviator2.Size = new System.Drawing.Size(45, 61);
            this.diviator2.TabIndex = 1;
            this.diviator2.TabStop = false;
            this.diviator2.Value = 1;
            this.diviator2.ValueChanged += new System.EventHandler(this.diviator2_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // DiviatorLightSystem
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.diviator2);
            this.Controls.Add(this.diviator);
            this.Name = "DiviatorLightSystem";
            this.Text = "Diviator how work";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.diviator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diviator2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.TrackBar diviator;
        private System.Windows.Forms.TrackBar diviator2;
        private System.Windows.Forms.Label label1;
    }
}

