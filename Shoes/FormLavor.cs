namespace Shoes
{
    using MySql.Data.MySqlClient;
    using System;
    using System.Data;
    using System.Windows.Forms;
    public partial class FormLavor : Form
    {
        //Read connection string from application settings 
        private string ConnectionString = Connection.MyConnectionString;
        private MySqlConnection connection;
        private MySqlDataAdapter adapterLavoratione;
        private DataTable DTLavoratione;

        public FormLavor()
        {
            InitializeComponent();
        }

        private DataTable GetAllItems()
        {
            try
            {
                //prepare query to get all records from Lavoratione table
                //prepare adapter to run query
                this.adapterLavoratione = new MySqlDataAdapter(Connection.TableLavoratione, this.connection);
                DataSet DSLavoratione = new DataSet();
                //get query results in dataset
                this.adapterLavoratione.Fill(DSLavoratione);

                // Set the UPDATE command and parameters.
                this.adapterLavoratione.UpdateCommand = new MySqlCommand("UPDATE lavoratione SET Lavoratoine=@Lavoratoine, Updated_Dt=NOW() WHERE Lavoratoine=@Lavoratoine;", connection);
                this.adapterLavoratione.UpdateCommand.Parameters.Add("@Lavoratoine", MySqlDbType.Int32, 11, "Lavoratoine");
                this.adapterLavoratione.UpdateCommand.UpdatedRowSource = UpdateRowSource.None;

                // Set the INSERT command and parameter.
                this.adapterLavoratione.InsertCommand = new MySqlCommand("INSERT INTO lavoratione VALUES (@Lavoratoine, NOW());", this.connection);
                this.adapterLavoratione.InsertCommand.Parameters.Add("@Lavoratoine", MySqlDbType.Int32, 11, "Lavoratoine");
                this.adapterLavoratione.InsertCommand.UpdatedRowSource = UpdateRowSource.None;

                // Set the DELETE command and parameter.
                this.adapterLavoratione.DeleteCommand = new MySqlCommand("DELETE FROM lavoratione WHERE Lavoratoine=@Lavoratoine;", this.connection);
                this.adapterLavoratione.DeleteCommand.UpdatedRowSource = UpdateRowSource.None;

                //return datatable with all records
                return DSLavoratione.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        private void FormLavor_Load(object sender, EventArgs e)
        {
            //Initialize mysql connection
            this.connection = new MySqlConnection(this.ConnectionString);
            //Get all items in datatable
            this.DTLavoratione = this.GetAllItems();
            //Fill grid with items from Lavoratione
            this.dataGridViewLav.DataSource = this.DTLavoratione;
        }

        private void cmb_Save_Lav_Click(object sender, EventArgs e)
        {
            try
            {
                //Save records in database using DTLavoratione which is datasource for Grid
                this.adapterLavoratione.Update(this.DTLavoratione);
                //Refresh grid 
                this.DTLavoratione = this.GetAllItems();
                this.dataGridViewLav.DataSource = this.DTLavoratione;
                MessageBox.Show("Items saved successfully...");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmb_Delete_Lav_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewLav.SelectedRows.Count > 0)
            {
                //Delete a row from grid first.
                this.dataGridViewLav.Rows.Remove(this.dataGridViewLav.SelectedRows[0]);
                //Save records again. This will delete record from database.
                this.adapterLavoratione.Update(this.DTLavoratione);
                //Refresh grid. Get items again from database and show it in grid.
                this.DTLavoratione = this.GetAllItems();
                this.dataGridViewLav.DataSource = this.DTLavoratione;
                MessageBox.Show("Selected item deleted successfully...");
            }
            else
            {
                MessageBox.Show("You must select entire row in order to delete it.");
            }

        }

        private void cmb_Lavor_Exit_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void dataGridViewLav_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            base.Close();
        }

        public int ReturnValueLav
        {
            get
            {
                int result;
                try
                {
                    result = int.Parse(this.dataGridViewLav.SelectedCells[0].Value.ToString());
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Must be select First Column\n" + ex.Message);
                    result = 0;
                }
                catch (NullReferenceException)
                {
                    result = 0;
                }
                return result;
            }
        }
    }
}
