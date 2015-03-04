namespace Shoes
{
    using MySql.Data.MySqlClient;
    using System;
    using System.Data;
    using System.Windows.Forms;
    public partial class FormLave : Form
    {
        public FormLave()
        {
            InitializeComponent();
        }

        private void cmb_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
