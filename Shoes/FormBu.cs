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
        string ConnectionString = Connection.MyConnectionString;
        MySqlConnection connection;
        MySqlDataAdapter adapterBu;
        DataTable DTBu;

        DataTable GetAllItems()
        {
            try
            {
                //prepare query to get all records from Bu table
                //prepare adapter to run query
                adapterBu = new MySqlDataAdapter(Connection.TableBu, connection);
                DataSet DSBu = new DataSet();
                //get query results in dataset
                adapterBu.Fill(DSBu);

                // Set the UPDATE command and parameters.
                adapterBu.UpdateCommand = new MySqlCommand("UPDATE bu SET ID=@ID, Date=@Date, Updated_Dt=NOW() WHERE ID=@ID;", connection);
                adapterBu.UpdateCommand.Parameters.Add("@ID", MySqlDbType.Int32, 11, "ID");
                adapterBu.UpdateCommand.Parameters.Add("@Date", MySqlDbType.Date, 6, "Date");
                adapterBu.UpdateCommand.UpdatedRowSource = UpdateRowSource.None;

                // Set the INSERT command and parameter.
                adapterBu.InsertCommand = new MySqlCommand("INSERT INTO bu VALUES (@ID, @Date, NOW());", connection);
                adapterBu.InsertCommand.Parameters.Add("@ID", MySqlDbType.Int32, 11, "ID");
                adapterBu.InsertCommand.Parameters.Add("@Date", MySqlDbType.Date, 6, "Date");
                adapterBu.InsertCommand.UpdatedRowSource = UpdateRowSource.None;

                // Set the DELETE command and parameter.
                adapterBu.DeleteCommand = new MySqlCommand("DELETE FROM bu WHERE ID=@ID;", connection);
                adapterBu.DeleteCommand.Parameters.Add("@ID", MySqlDbType.Int32, 11, "ID");

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
            connection = new MySqlConnection(ConnectionString);

            //Get all items in datatable
            DTBu = GetAllItems();

            //Fill grid with items
            dataGridViewBu.DataSource = DTBu;
        }

        private void cmb_Save_Bu_Click(object sender, EventArgs e)
        {
            try
            {
                //Save records in database using DTBu which is datasource for Grid
                adapterBu.Update(DTBu);
                //Refresh grid
                DTBu = GetAllItems();
                dataGridViewBu.DataSource = DTBu;
                MessageBox.Show("Items saved successfully...");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void cmb_Delete_Bu_Click(object sender, EventArgs e)
        {
            if (dataGridViewBu.SelectedRows.Count > 0)
            {
                //Delete a row from grid first.
                dataGridViewBu.Rows.Remove(dataGridViewBu.SelectedRows[0]);

                //Save records again. This will delete record from database.
                adapterBu.Update(DTBu);

                //Refresh grid. Get items Bu again from database and show it in grid.
                DTBu = GetAllItems();
                dataGridViewBu.DataSource = DTBu;
                MessageBox.Show("Selected item deleted successfully...");
            }
            else
            {
                MessageBox.Show("You must select entire row in order to delete it.");
            }
        }

        private void cmb_Bu_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void dataGridViewBu_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Close();
        }
        public int ReturnValueBu 
        { 
            get 
            {
                try
                {
                    return int.Parse(dataGridViewBu.SelectedCells[0].Value.ToString());
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Must be select First Column\n" + ex.Message);
                    return 0;
                }
                catch (NullReferenceException)
                {
                    //MessageBox.Show("Test" + ex.Message);
                    return 0;
                }
            }
            set
            {
                ReturnValueBu = 0;
            }
        }  
    }
}
