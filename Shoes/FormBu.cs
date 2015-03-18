namespace Shoes
{
    using MySql.Data.MySqlClient;
    using System;
    using System.Data;
    using System.Windows.Forms;
    public partial class FormBu : Form
    {
        public FormBu()
        {
            InitializeComponent();
        }
        //Read connection string from application settings = App.config.xml
        private string ConnectionString = Connection.MyConnectionString;
        private MySqlConnection connection;
        private MySqlDataAdapter adapterBu;
        private DataTable DTBu;

        DataTable GetAllItems()
        {
            try
            {
                //prepare query to get all records from Bu table
                //prepare adapter to run query
                this.adapterBu = new MySqlDataAdapter(Connection.TableBu, this.connection);
                DataSet DSBu = new DataSet();
                //get query results in dataset
                this.adapterBu.Fill(DSBu);

                // Set the UPDATE command and parameters.
                this.adapterBu.UpdateCommand = new MySqlCommand("UPDATE bu SET ID=@ID, Date=@Date, Updated_Dt=NOW() WHERE ID=@ID;", this.connection);
                this.adapterBu.UpdateCommand.Parameters.Add("@ID", MySqlDbType.Int32, 11, "ID");
                this.adapterBu.UpdateCommand.Parameters.Add("@Date", MySqlDbType.Date, 6, "Date");
                this.adapterBu.UpdateCommand.UpdatedRowSource = UpdateRowSource.None;

                // Set the INSERT command and parameter.
                this.adapterBu.InsertCommand = new MySqlCommand("INSERT INTO bu VALUES (@ID, @Date, NOW());", this.connection);
                this.adapterBu.InsertCommand.Parameters.Add("@ID", MySqlDbType.Int32, 11, "ID");
                this.adapterBu.InsertCommand.Parameters.Add("@Date", MySqlDbType.Date, 6, "Date");
                this.adapterBu.InsertCommand.UpdatedRowSource = UpdateRowSource.None;

                // Set the DELETE command and parameter.
                this.adapterBu.DeleteCommand = new MySqlCommand("DELETE FROM bu WHERE ID=@ID;", this.connection);
                this.adapterBu.DeleteCommand.Parameters.Add("@ID", MySqlDbType.Int32, 11, "ID");

                //return datatable with all records
                return DSBu.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        private void FormBu_Load(object sender, EventArgs e)
        {
            //Initialize mysql connection
            this.connection = new MySqlConnection(this.ConnectionString);
            //Get all items in datatable
            this.DTBu = this.GetAllItems();
            //Fill grid with items
            this.dataGridViewBu.DataSource = this.DTBu;
        }

        private void cmb_Save_Bu_Click(object sender, EventArgs e)
        {
            try
            {
                //Save records in database using DTBu which is datasource for Grid
                this.adapterBu.Update(this.DTBu);
                //Refresh grid
                this.DTBu = this.GetAllItems();
                this.dataGridViewBu.DataSource = this.DTBu;
                MessageBox.Show("Items saved successfully...");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmb_Delete_Bu_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewBu.SelectedRows.Count > 0)
            {
                //Delete a row from grid first.
                this.dataGridViewBu.Rows.Remove(this.dataGridViewBu.SelectedRows[0]);
                //Save records again. This will delete record from database.
                this.adapterBu.Update(this.DTBu);
                //Refresh grid. Get items Bu again from database and show it in grid.
                this.DTBu = this.GetAllItems();
                this.dataGridViewBu.DataSource = this.DTBu;
                MessageBox.Show("Selected item deleted successfully...");
            }
            else
            {
                MessageBox.Show("You must select entire row in order to delete it.");
            }
        }

        private void cmb_Bu_Exit_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void dataGridViewBu_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            base.Close();
        }

        public int ReturnValueBu 
        { 
            get 
            {
                int result;
                try
                {
                    result = int.Parse(this.dataGridViewBu.SelectedCells[0].Value.ToString());
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Must be select First Column\n" + ex.Message);
                    result = 0;
                }
                catch (NullReferenceException)
                {
                    //MessageBox.Show("Test" + ex.Message);
                    result = 0;
                }
                return result;
            }
        }  
    }
}
