namespace Shoes
{
    partial class FormLogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogIn));
            this.cmb_Work = new System.Windows.Forms.Button();
            this.cmb_Lave = new System.Windows.Forms.Button();
            this.cmb_Manufacturing = new System.Windows.Forms.Button();
            this.cmb_Invoiced = new System.Windows.Forms.Button();
            this.cmb_Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmb_Work
            // 
            resources.ApplyResources(this.cmb_Work, "cmb_Work");
            this.cmb_Work.Name = "cmb_Work";
            this.cmb_Work.UseVisualStyleBackColor = true;
            this.cmb_Work.Click += new System.EventHandler(this.cmb_Work_Click);
            // 
            // cmb_Lave
            // 
            resources.ApplyResources(this.cmb_Lave, "cmb_Lave");
            this.cmb_Lave.Name = "cmb_Lave";
            this.cmb_Lave.UseVisualStyleBackColor = true;
            this.cmb_Lave.Click += new System.EventHandler(this.cmb_Lave_Click);
            // 
            // cmb_Manufacturing
            // 
            resources.ApplyResources(this.cmb_Manufacturing, "cmb_Manufacturing");
            this.cmb_Manufacturing.Name = "cmb_Manufacturing";
            this.cmb_Manufacturing.UseVisualStyleBackColor = true;
            this.cmb_Manufacturing.Click += new System.EventHandler(this.cmb_Manufacturing_Click);
            // 
            // cmb_Invoiced
            // 
            resources.ApplyResources(this.cmb_Invoiced, "cmb_Invoiced");
            this.cmb_Invoiced.Name = "cmb_Invoiced";
            this.cmb_Invoiced.UseVisualStyleBackColor = true;
            this.cmb_Invoiced.Click += new System.EventHandler(this.cmb_Invoiced_Click);
            // 
            // cmb_Close
            // 
            resources.ApplyResources(this.cmb_Close, "cmb_Close");
            this.cmb_Close.Name = "cmb_Close";
            this.cmb_Close.UseVisualStyleBackColor = true;
            this.cmb_Close.Click += new System.EventHandler(this.cmb_Close_Click);
            // 
            // FormLogIn
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmb_Close);
            this.Controls.Add(this.cmb_Invoiced);
            this.Controls.Add(this.cmb_Manufacturing);
            this.Controls.Add(this.cmb_Lave);
            this.Controls.Add(this.cmb_Work);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormLogIn";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmb_Work;
        private System.Windows.Forms.Button cmb_Lave;
        private System.Windows.Forms.Button cmb_Manufacturing;
        private System.Windows.Forms.Button cmb_Invoiced;
        private System.Windows.Forms.Button cmb_Close;
    }
}

