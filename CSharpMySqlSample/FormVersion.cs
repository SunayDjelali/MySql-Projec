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
    public partial class FormVersion : Form
    {
        public FormVersion()
        {
            InitializeComponent();
        }

        //Read connection string from application settings = App.config.xml
        string ConnectionString = Connection.MyConnectionString;
        MySqlConnection connection;
        MySqlDataAdapter adapterVersion;
        DataTable DTVersion;

        DataTable GetAllItems()
        {
            try
            {
                //prepare query to get all records from versions table
                //prepare adapter to run query
                adapterVersion = new MySqlDataAdapter(Connection.TableVersions, connection);
                DataSet DSVersion = new DataSet();

                //get query results in dataset
                adapterVersion.Fill(DSVersion);

                // Set the UPDATE command and parameters.
                adapterVersion.UpdateCommand = new MySqlCommand("UPDATE versions SET ID=@ID, Version=@Version, Updated_Dt=NOW() WHERE ID=@ID;", connection);
                adapterVersion.UpdateCommand.Parameters.Add("@ID", MySqlDbType.Int32, 11, "ID");
                adapterVersion.UpdateCommand.Parameters.Add("@Version", MySqlDbType.VarChar, 10, "Version");
                adapterVersion.UpdateCommand.UpdatedRowSource = UpdateRowSource.None;

                // Set the INSERT command and parameter.
                adapterVersion.InsertCommand = new MySqlCommand("INSERT INTO versions VALUES (@ID, @Version, NOW());", connection);
                adapterVersion.InsertCommand.Parameters.Add("@ID", MySqlDbType.Int32, 11, "ID");
                adapterVersion.InsertCommand.Parameters.Add("@Version", MySqlDbType.VarChar, 10, "Version");
                adapterVersion.InsertCommand.UpdatedRowSource = UpdateRowSource.None;

                // Set the DELETE command and parameter.
                adapterVersion.DeleteCommand = new MySqlCommand("DELETE FROM versions WHERE ID=@ID;", connection);
                adapterVersion.DeleteCommand.Parameters.Add("@ID", MySqlDbType.Int32, 11, "ID");
                adapterVersion.DeleteCommand.UpdatedRowSource = UpdateRowSource.None;

                //return datatable with all records
                return DSVersion.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        private void cmb_Version_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormVersion_Load(object sender, EventArgs e)
        {
            //Initialize mysql connection
            connection = new MySqlConnection(ConnectionString);

            //Get all items in datatable
            DTVersion = GetAllItems();

            //Fill grid with items
            dataGridViewVer.DataSource = DTVersion;
        }

        private void cmb_Save_Ver_Click(object sender, EventArgs e)
        {
            try
            {
                //Save records in database using DTArticle which is datasource for Grid
                adapterVersion.Update(DTVersion);

                //Refresh grid
                DTVersion = GetAllItems();

                dataGridViewVer.DataSource = DTVersion;

                MessageBox.Show("Items saved successfully...");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void cmb_Delete_Ver_Click(object sender, EventArgs e)
        {
            if (dataGridViewVer.SelectedRows.Count > 0)
            {
                //Delete a row from grid first.
                dataGridViewVer.Rows.Remove(dataGridViewVer.SelectedRows[0]);

                //Save records again. This will delete record from database.
                adapterVersion.Update(DTVersion);

                //Refresh grid. Get items Bu again from database and show it in grid.
                DTVersion = GetAllItems();

                dataGridViewVer.DataSource = DTVersion;

                MessageBox.Show("Selected item deleted successfully...");
            }
            else
            {
                MessageBox.Show("You must select entire row in order to delete it.");
            }

        }

        private void dataGridViewVer_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.Close();
        }
        public int ReturnValueVer { get { return int.Parse(dataGridViewVer.SelectedCells[0].Value.ToString()); } }

    }
}
