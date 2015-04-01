namespace Shoes
{
    using System.Windows.Forms;
    public partial class FormDate : Form
    {
        //private string curentSelectDate;
        public FormDate()
        {
            this.InitializeComponent();
        }
        public string ReturnValueDate
        {
            get
            {
                return this.monthCalendar.SelectionRange.Start.ToString("yyyy-MM-dd");
            }
        }

        private void monthCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            base.Close();
        }  

    }
}
