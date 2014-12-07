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
    public partial class FormLavor : Form
    {
        public FormLavor()
        {
            InitializeComponent();
        }
        //Read connection string from application settings 
        string ConnectionString = Connection.MyConnectionString;
        MySqlConnection connection;
        MySqlDataAdapter adapterLavoratione;
        DataTable DTLavoratione;

        DataTable GetAllItems()
        {
            try
            {
                //prepare query to get all records from Lavoratione table
                //prepare adapter to run query
                adapterLavoratione = new MySqlDataAdapter(Connection.TableLavoratione, connection);
                DataSet DSLavoratione = new DataSet();
                //get query results in dataset
                adapterLavoratione.Fill(DSLavoratione);

                // Set the UPDATE command and parameters.
                adapterLavoratione.UpdateCommand = new MySqlCommand("UPDATE lavoratione SET Lavoratoine=@Lavoratoine, Updated_Dt=NOW() WHERE Lavoratoine=@Lavoratoine;", connection);
                adapterLavoratione.UpdateCommand.Parameters.Add("@Lavoratoine", MySqlDbType.Int32, 11, "Lavoratoine");
                adapterLavoratione.UpdateCommand.UpdatedRowSource = UpdateRowSource.None;

                // Set the INSERT command and parameter.
                adapterLavoratione.InsertCommand = new MySqlCommand("INSERT INTO lavoratione VALUES (@Lavoratoine, NOW());", connection);
                adapterLavoratione.InsertCommand.Parameters.Add("@Lavoratoine", MySqlDbType.Int32, 11, "Lavoratoine");
                adapterLavoratione.InsertCommand.UpdatedRowSource = UpdateRowSource.None;

                // Set the DELETE command and parameter.
                adapterLavoratione.DeleteCommand = new MySqlCommand("DELETE FROM lavoratione WHERE Lavoratoine=@Lavoratoine;", connection);
                adapterLavoratione.DeleteCommand.UpdatedRowSource = UpdateRowSource.None;

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
            connection = new MySqlConnection(ConnectionString);
            //Get all items in datatable
            DTLavoratione = GetAllItems();
            //Fill grid with items from Lavoratione
            dataGridViewLav.DataSource = DTLavoratione;
        }

        private void cmb_Save_Lav_Click(object sender, EventArgs e)
        {
            try
            {
                //Save records in database using DTLavoratione which is datasource for Grid
                adapterLavoratione.Update(DTLavoratione);
                //Refresh grid 
                DTLavoratione = GetAllItems();
                dataGridViewLav.DataSource = DTLavoratione;
                MessageBox.Show("Items saved successfully...");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmb_Delete_Lav_Click(object sender, EventArgs e)
        {
            if (dataGridViewLav.SelectedRows.Count > 0)
            {
                //Delete a row from grid first.
                dataGridViewLav.Rows.Remove(dataGridViewLav.SelectedRows[0]);
                //Save records again. This will delete record from database.
                adapterLavoratione.Update(DTLavoratione);
                //Refresh grid. Get items again from database and show it in grid.
                DTLavoratione = GetAllItems();
                dataGridViewLav.DataSource = DTLavoratione;
                MessageBox.Show("Selected item deleted successfully...");
            }
            else
            {
                MessageBox.Show("You must select entire row in order to delete it.");
            }

        }
        private void cmb_Lavor_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewLav_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.Close();
        }
        public int ReturnValueLav 
        { 
            get 
            {
                try
                {
                    return int.Parse(dataGridViewLav.SelectedCells[0].Value.ToString()); 
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
                ReturnValueLav = 0;
            }
           
        }
    }
}
