namespace Shoes
{
    using System;
    using System.Windows.Forms;
    public partial class FormLogIn : Form
    {
        public FormLogIn()
        {
            InitializeComponent();
        }

        private void cmb_Work_Click(object sender, EventArgs e)
        {
            FormWork FWork = new FormWork();
            FWork.ShowDialog();
        }

        private void cmb_Lave_Click(object sender, EventArgs e)
        {
            FormLave FLave = new FormLave();
            FLave.ShowDialog();
        }

        private void cmb_Manufacturing_Click(object sender, EventArgs e)
        {
            FormManufactured FManufactured = new FormManufactured();
            FManufactured.ShowDialog();
        }

        private void cmb_Invoiced_Click(object sender, EventArgs e)
        {
            FormInvoiced FInvoiced = new FormInvoiced();
            FInvoiced.ShowDialog();
        }

        private void cmb_Close_Click(object sender, EventArgs e)
        {
            this.Close();
            //FormDate FDate = new FormDate();
            //FDate.ShowDialog();
        }

        private void cmb_Check_Click(object sender, EventArgs e)
        {
            FormCheck FCheck = new FormCheck();
            FCheck.ShowDialog();
        }
    }
}
