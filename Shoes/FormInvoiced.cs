namespace Shoes
{
    using MySql.Data.MySqlClient;
    using System;
    using System.Data;
    using System.Windows.Forms;
    public partial class FormInvoiced : Form
    {
        public FormInvoiced()
        {
            InitializeComponent();
        }

        private void cmb_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
