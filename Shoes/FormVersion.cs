namespace Shoes
{
    using MySql.Data.MySqlClient;
    using System;
    using System.Data;
    using System.Windows.Forms;
    public partial class FormVersion : Form
    {
        //Read connection string from application settings = App.config.xml
        private string ConnectionString = Connection.MyConnectionString;
        private MySqlConnection connection;
        private MySqlDataAdapter adapterVersion;
        private DataTable DTVersion;
        public void GoLastRow()
        {
            int lastRow = this.dataGridViewVer.RowCount - 1;
            this.dataGridViewVer.CurrentCell = dataGridViewVer.Rows[lastRow].Cells[0];
        }
        public FormVersion()
        {
            InitializeComponent();
        }

        private DataTable GetAllItems()
        {
            try
            {
                //prepare query to get all records from versions table
                //prepare adapter to run query
                this.adapterVersion = new MySqlDataAdapter(Connection.TableVersions, this.connection);
                DataSet DSVersion = new DataSet();

                //get query results in dataset
                this.adapterVersion.Fill(DSVersion);

                // Set the UPDATE command and parameters.
                this.adapterVersion.UpdateCommand = new MySqlCommand("UPDATE versions SET ID=@ID, Version=@Version, Updated_Dt=NOW() WHERE ID=@ID;", this.connection);
                this.adapterVersion.UpdateCommand.Parameters.Add("@ID", MySqlDbType.Int32, 11, "ID");
                this.adapterVersion.UpdateCommand.Parameters.Add("@Version", MySqlDbType.VarChar, 10, "Version");
                this.adapterVersion.UpdateCommand.UpdatedRowSource = UpdateRowSource.None;

                // Set the INSERT command and parameter.
                this.adapterVersion.InsertCommand = new MySqlCommand("INSERT INTO versions VALUES (@ID, @Version, NOW());", this.connection);
                this.adapterVersion.InsertCommand.Parameters.Add("@ID", MySqlDbType.Int32, 11, "ID");
                this.adapterVersion.InsertCommand.Parameters.Add("@Version", MySqlDbType.VarChar, 10, "Version");
                this.adapterVersion.InsertCommand.UpdatedRowSource = UpdateRowSource.None;

                // Set the DELETE command and parameter.
                this.adapterVersion.DeleteCommand = new MySqlCommand("DELETE FROM versions WHERE ID=@ID;", this.connection);
                this.adapterVersion.DeleteCommand.Parameters.Add("@ID", MySqlDbType.Int32, 11, "ID");

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
            base.Close();
        }

        private void FormVersion_Load(object sender, EventArgs e)
        {
            //Initialize mysql connection
            this.connection = new MySqlConnection(this.ConnectionString);

            //Get all items in datatable
            this.DTVersion = this.GetAllItems();

            //Fill grid with items
            this.dataGridViewVer.DataSource = this.DTVersion;
            this.dataGridViewVer.Columns["Updated_Dt"].ReadOnly = true;
            this.dataGridViewVer.Columns["ID"].ReadOnly = true;
            GoLastRow();
            lbl_Msg.Text = "";
        }

        private void cmb_Save_Ver_Click(object sender, EventArgs e)
        {
            try
            {
                //Save records in database using DTArticle which is datasource for Grid
                this.adapterVersion.Update(DTVersion);

                //Refresh grid
                this.DTVersion = this.GetAllItems();

                this.dataGridViewVer.DataSource = this.DTVersion;
                GoLastRow();
                lbl_Msg.Text = "Items saved successfully...";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmb_Delete_Ver_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewVer.SelectedRows.Count > 0)
            {
                //Delete a row from grid first.
                this.dataGridViewVer.Rows.Remove(this.dataGridViewVer.SelectedRows[0]);

                //Save records again. This will delete record from database.
                this.adapterVersion.Update(this.DTVersion);

                //Refresh grid. Get items Bu again from database and show it in grid.
                this.DTVersion = this.GetAllItems();

                this.dataGridViewVer.DataSource = this.DTVersion;
                GoLastRow();

                lbl_Msg.Text = "Selected item deleted successfully...";
            }
            else
            {
                MessageBox.Show("You must select entire row in order to delete it.");
            }
        }

        private void dataGridViewVer_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            base.Close();
        }

        public int ReturnValueVer
        {
            get
            {
                int result;
                try
                {
                    result = int.Parse(dataGridViewVer.SelectedCells[0].Value.ToString());
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
