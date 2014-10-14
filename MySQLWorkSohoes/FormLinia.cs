using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CSharpMySqlSample
{
    public partial class FormLinia : Form
    {
        public FormLinia()
        {
            InitializeComponent();
            
        }

        //Read connection string from application settings = App.config.xml
        string ConnectionString = Connection.MyConnectionString;
        MySqlConnection connection;
        MySqlDataAdapter adapterLinia;
        DataTable DTLinia;

        DataTable GetAllItems()
        {
            try
            {
                
                //prepare query to get all records from Linia table
                //prepare adapter to run query
                adapterLinia = new MySqlDataAdapter(Connection.TableLinia, connection);
                DataSet DSLinia = new DataSet();
                //get query results in dataset
                adapterLinia.Fill(DSLinia);

                // Set the UPDATE command and parameters.
                adapterLinia.UpdateCommand = new MySqlCommand("UPDATE linia SET ID=@ID, Linia=@Linia, Updated_Dt=NOW() WHERE ID=@ID;", connection);
                adapterLinia.UpdateCommand.Parameters.Add("@ID", MySqlDbType.Int32, 11, "ID");
                adapterLinia.UpdateCommand.Parameters.Add("@Linia", MySqlDbType.VarChar, 15, "Linia");
                adapterLinia.UpdateCommand.UpdatedRowSource = UpdateRowSource.None;

                // Set the INSERT command and parameter.
                adapterLinia.InsertCommand = new MySqlCommand("INSERT INTO linia VALUES (@ID, @Linia, NOW());", connection);
                adapterLinia.InsertCommand.Parameters.Add("@ID", MySqlDbType.Int32, 11, "ID");
                adapterLinia.InsertCommand.Parameters.Add("@Linia", MySqlDbType.VarChar, 15, "Linia");
                adapterLinia.InsertCommand.UpdatedRowSource = UpdateRowSource.None;

                // Set the DELETE command and parameter.
                adapterLinia.DeleteCommand = new MySqlCommand("DELETE FROM linia WHERE ID=@ID;", connection);
                adapterLinia.DeleteCommand.Parameters.Add("@ID", MySqlDbType.Int32, 11, "ID");
                adapterLinia.DeleteCommand.UpdatedRowSource = UpdateRowSource.None;

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
            connection = new MySqlConnection(ConnectionString);
            //Get all items in datatable
            DTLinia = GetAllItems();
            //Fill grid with items
            dataGridViewLin.DataSource = DTLinia;
        }

        private void cmb_Linia_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmb_Save_Lin_Click(object sender, EventArgs e)
        {
            try
            {
                //Save records in database using DTArticle which is datasource for Grid
                adapterLinia.Update(DTLinia);
                //Refresh grid
                DTLinia = GetAllItems();
                dataGridViewLin.DataSource = DTLinia;
                MessageBox.Show("Items saved successfully...");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void cmb_Delete_Lin_Click(object sender, EventArgs e)
        {
            if (dataGridViewLin.SelectedRows.Count > 0)
            {
                //Delete a row from grid first.
                dataGridViewLin.Rows.Remove(dataGridViewLin.SelectedRows[0]);
                //Save records again. This will delete record from database.
                adapterLinia.Update(DTLinia);
                //Refresh grid. Get items Bu again from database and show it in grid.
                DTLinia = GetAllItems();
                dataGridViewLin.DataSource = DTLinia;
                MessageBox.Show("Selected item deleted successfully...");
            }
            else
            {
                MessageBox.Show("You must select entire row in order to delete it.");
            }

        }

        private void dataGridViewLin_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.Close();
        }
        public int ReturnValueLin 
        { 
            get 
            {
                try
                {
                    return int.Parse(dataGridViewLin.SelectedCells[0].Value.ToString());
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Must be select First Column\n" + ex.Message);
                    return 0;
                }
                catch (NullReferenceException)
                {
                    return 0;
                }
            }
            set
            {
                ReturnValueLin = 0;
            }
        }
    }
}
