namespace Shoes
{
    using System.Windows.Forms;
    public partial class FormDate : Form
    {
        public FormDate()
        {
            InitializeComponent();
        }
        public string ReturnValueDate
        {
            get
            {
                string theDate = monthCalendar.SelectionRange.Start.ToString("yyyy-MM-dd");
                return theDate;
            }
            set { value = monthCalendar.SelectionRange.Start.ToString("yyyy-MM-dd"); }
        }

        private void monthCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            this.Close();
        }  

    }
}
