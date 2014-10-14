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
    public partial class FormFoundo : Form
    {
        public FormFoundo()
        {
            InitializeComponent();
        }

        //Read connection string from application settings = App.config.xml
        string ConnectionString = Connection.MyConnectionString;
        MySqlConnection connection;
        MySqlDataAdapter adapterFoundo;
        DataTable DTFoundo;

        DataTable GetAllItems()
        {
            try
            {
                //prepare query to get all records from foundo table
                //prepare adapter to run query
                adapterFoundo = new MySqlDataAdapter(Connection.TableFoundo, connection);
                DataSet DSFoundo = new DataSet();
                //get query results in dataset
                adapterFoundo.Fill(DSFoundo);

                // Set the UPDATE command and parameters.
                adapterFoundo.UpdateCommand = new MySqlCommand("UPDATE foundo SET ID=@ID, F_Name=@F_Name, Updated_Dt=NOW() WHERE ID=@ID;", connection);
                adapterFoundo.UpdateCommand.Parameters.Add("@ID", MySqlDbType.Int32, 11, "ID");
                adapterFoundo.UpdateCommand.Parameters.Add("@F_Name", MySqlDbType.VarChar, 15, "F_Name");
                adapterFoundo.UpdateCommand.UpdatedRowSource = UpdateRowSource.None;

                // Set the INSERT command and parameter.
                adapterFoundo.InsertCommand = new MySqlCommand("INSERT INTO foundo VALUES (@ID, @F_Name, NOW());", connection);
                adapterFoundo.InsertCommand.Parameters.Add("@ID", MySqlDbType.Int32, 11, "ID");
                adapterFoundo.InsertCommand.Parameters.Add("@F_Name", MySqlDbType.VarChar, 15, "F_Name");
                adapterFoundo.InsertCommand.UpdatedRowSource = UpdateRowSource.None;

                // Set the DELETE command and parameter.
                adapterFoundo.DeleteCommand = new MySqlCommand("DELETE FROM foundo WHERE ID=@ID;", connection);
                adapterFoundo.DeleteCommand.Parameters.Add("@ID", MySqlDbType.Int32, 11, "ID");
                adapterFoundo.DeleteCommand.UpdatedRowSource = UpdateRowSource.None;

                //return datatable with all records
                return DSFoundo.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        private void FormFoundo_Load(object sender, EventArgs e)
        {
            //Initialize mysql connection
            connection = new MySqlConnection(ConnectionString);
            //Get all items in datatable
            DTFoundo = GetAllItems();
            //Fill grid with items
            dataGridViewFon.DataSource = DTFoundo;
            
        }
        private void cmb_Foundo_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmb_Save_Fou_Click(object sender, EventArgs e)
        {
            try
            {
                //Save records in database using DTArticle which is datasource for Grid
                adapterFoundo.Update(DTFoundo);
                //Refresh grid
                DTFoundo = GetAllItems();
                dataGridViewFon.DataSource = DTFoundo;
                MessageBox.Show("Items saved successfully...");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void cmb_Delete_Fou_Click(object sender, EventArgs e)
        {
            if (dataGridViewFon.SelectedRows.Count > 0)
            {
                //Delete a row from grid first.
                dataGridViewFon.Rows.Remove(dataGridViewFon.SelectedRows[0]);
                //Save records again. This will delete record from database.
                adapterFoundo.Update(DTFoundo);
                //Refresh grid. Get items Bu again from database and show it in grid.
                DTFoundo = GetAllItems();
                dataGridViewFon.DataSource = DTFoundo;
                MessageBox.Show("Selected item deleted successfully...");
            }
            else
            {
                MessageBox.Show("You must select entire row in order to delete it.");
            }
        }

        private void dataGridViewFon_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.Close();
        }
        public int ReturnValueFon 
        { 
            get 
            {
                try
                {
                    return int.Parse(dataGridViewFon.SelectedCells[0].Value.ToString()); 
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
                ReturnValueFon = 0;
            }
            
        }
    }
}
