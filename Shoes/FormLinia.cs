namespace Shoes
{
    using MySql.Data.MySqlClient;
    using System;
    using System.Data;
    using System.Windows.Forms;
    public partial class FormLinia : Form
    {
        //Read connection string from application settings = App.config.xml
        private string ConnectionString = Connection.MyConnectionString;
        private MySqlConnection connection;
        private MySqlDataAdapter adapterLinia;
        private DataTable DTLinia;

        public FormLinia()
        {
            InitializeComponent();
        }

        private DataTable GetAllItems()
        {
            try
            {
                //prepare query to get all records from Linia table
                //prepare adapter to run query
                this.adapterLinia = new MySqlDataAdapter(Connection.TableLinia, this.connection);
                DataSet DSLinia = new DataSet();
                //get query results in dataset
                this.adapterLinia.Fill(DSLinia);

                // Set the UPDATE command and parameters.
                this.adapterLinia.UpdateCommand = new MySqlCommand("UPDATE linia SET ID=@ID, Linia=@Linia, Updated_Dt=NOW() WHERE ID=@ID;", this.connection);
                this.adapterLinia.UpdateCommand.Parameters.Add("@ID", MySqlDbType.Int32, 11, "ID");
                this.adapterLinia.UpdateCommand.Parameters.Add("@Linia", MySqlDbType.VarChar, 15, "Linia");
                this.adapterLinia.UpdateCommand.UpdatedRowSource = UpdateRowSource.None;

                // Set the INSERT command and parameter.
                this.adapterLinia.InsertCommand = new MySqlCommand("INSERT INTO linia VALUES (@ID, @Linia, NOW());", this.connection);
                this.adapterLinia.InsertCommand.Parameters.Add("@ID", MySqlDbType.Int32, 11, "ID");
                this.adapterLinia.InsertCommand.Parameters.Add("@Linia", MySqlDbType.VarChar, 15, "Linia");
                this.adapterLinia.InsertCommand.UpdatedRowSource = UpdateRowSource.None;

                // Set the DELETE command and parameter.
                this.adapterLinia.DeleteCommand = new MySqlCommand("DELETE FROM linia WHERE ID=@ID;", this.connection);
                this.adapterLinia.DeleteCommand.Parameters.Add("@ID", MySqlDbType.Int32, 11, "ID");
                this.adapterLinia.DeleteCommand.UpdatedRowSource = UpdateRowSource.None;

                //return datatable with all records
                return DSLinia.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        private void FormLinia_Load(object sender, EventArgs e)
        {
            //Initialize mysql connection
            this.connection = new MySqlConnection(this.ConnectionString);
            //Get all items in datatable
            this.DTLinia = this.GetAllItems();
            //Fill grid with items
            this.dataGridViewLin.DataSource = this.DTLinia;
            this.dataGridViewLin.Columns["Updated_Dt"].ReadOnly = true;
        }

        private void cmb_Linia_Exit_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void cmb_Save_Lin_Click(object sender, EventArgs e)
        {
            try
            {
                //Save records in database using DTArticle which is datasource for Grid
                this.adapterLinia.Update(DTLinia);
                //Refresh grid
                this.DTLinia = this.GetAllItems();
                this.dataGridViewLin.DataSource = this.DTLinia;
                MessageBox.Show("Items saved successfully...");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmb_Delete_Lin_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewLin.SelectedRows.Count > 0)
            {
                //Delete a row from grid first.
                this.dataGridViewLin.Rows.Remove(this.dataGridViewLin.SelectedRows[0]);
                //Save records again. This will delete record from database.
                this.adapterLinia.Update(this.DTLinia);
                //Refresh grid. Get items Bu again from database and show it in grid.
                this.DTLinia = this.GetAllItems();
                this.dataGridViewLin.DataSource = this.DTLinia;
                MessageBox.Show("Selected item deleted successfully...");
            }
            else
            {
                MessageBox.Show("You must select entire row in order to delete it.");
            }
        }

        private void dataGridViewLin_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            base.Close();
        }

        public int ReturnValueLin
        {
            get
            {
                int result;
                try
                {
                    result = int.Parse(this.dataGridViewLin.SelectedCells[0].Value.ToString());
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
