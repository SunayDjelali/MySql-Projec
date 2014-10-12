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
    public partial class FormArticle : Form
    {
        public FormArticle()
        {
            InitializeComponent();
        }

        //Read connection string from application settings = App.config.xml
        string ConnectionString = Connection.MyConnectionString;
        MySqlConnection connection;
        MySqlDataAdapter adapterArticle;
        DataTable DTArticle;

        DataTable GetAllItems()
        {
            try
            {
                //prepare query to get all records from Article table
                //prepare adapter to run query
                adapterArticle = new MySqlDataAdapter(Connection.TableArticle, connection);
                DataSet DSArticle = new DataSet();
                //get query results in dataset
                adapterArticle.Fill(DSArticle);

                // Set the UPDATE command and parameters.
                adapterArticle.UpdateCommand = new MySqlCommand("UPDATE article SET ID=@ID, ArticleNo=@ArticleNo, Updated_Dt=NOW() WHERE ID=@ID;", connection);
                adapterArticle.UpdateCommand.Parameters.Add("@ID", MySqlDbType.Int32, 11, "ID");
                adapterArticle.UpdateCommand.Parameters.Add("@ArticleNo", MySqlDbType.Int32, 11, "ArticleNo");
                adapterArticle.UpdateCommand.UpdatedRowSource = UpdateRowSource.None;

                // Set the INSERT command and parameter.
                adapterArticle.InsertCommand = new MySqlCommand("INSERT INTO article VALUES (@ID, @ArticleNo, NOW());", connection);
                adapterArticle.InsertCommand.Parameters.Add("@ID", MySqlDbType.Int32, 11, "ID");
                adapterArticle.InsertCommand.Parameters.Add("@ArticleNo", MySqlDbType.Int32, 11, "ArticleNo");
                adapterArticle.InsertCommand.UpdatedRowSource = UpdateRowSource.None;

                // Set the DELETE command and parameter.
                adapterArticle.DeleteCommand = new MySqlCommand("DELETE FROM article WHERE ID=@ID;", connection);
                adapterArticle.DeleteCommand.Parameters.Add("@ID", MySqlDbType.Int32, 11, "ID");
                adapterArticle.DeleteCommand.UpdatedRowSource = UpdateRowSource.None;

                //return datatable with all records
                return DSArticle.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        private void cmb_Article_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormArticle_Load(object sender, EventArgs e)
        {
            //Initialize mysql connection
            connection = new MySqlConnection(ConnectionString);

            //Get all items in datatable
            DTArticle = GetAllItems();

            //Fill grid with items
            dataGridViewArt.DataSource = DTArticle;
            dataGridViewArt.Columns["ID"].Visible = false;
        }

        private void cmb_Save_Art_Click(object sender, EventArgs e)
        {
            try
            {
                //Save records in database using DTArticle which is datasource for Grid
                adapterArticle.Update(DTArticle);

                //Refresh grid
                DTArticle = GetAllItems();

                dataGridViewArt.DataSource = DTArticle;

                MessageBox.Show("Items saved successfully...");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmb_Delete_Art_Click(object sender, EventArgs e)
        {
            if (dataGridViewArt.SelectedRows.Count > 0)
            {
                //Delete a row from grid first.
                dataGridViewArt.Rows.Remove(dataGridViewArt.SelectedRows[0]);

                //Save records again. This will delete record from database.
                adapterArticle.Update(DTArticle);

                //Refresh grid. Get items Bu again from database and show it in grid.
                DTArticle = GetAllItems();

                dataGridViewArt.DataSource = DTArticle;

                MessageBox.Show("Selected item deleted successfully...");
            }
            else
            {
                MessageBox.Show("You must select entire row in order to delete it.");
            }

        }

        private void dataGridViewArt_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.Close();
        }
        public int ReturnValueArt { get { return int.Parse(dataGridViewArt.SelectedCells[0].Value.ToString()); } }
    }
}
