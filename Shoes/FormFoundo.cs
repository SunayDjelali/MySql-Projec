namespace Shoes
{
    using MySql.Data.MySqlClient;
    using System;
    using System.Data;
    using System.Windows.Forms;

    public partial class FormFoundo : Form
    {
        //Read connection string from application settings = App.config.xml
        private string ConnectionString = Connection.MyConnectionString;
        private MySqlConnection connection;
        private MySqlDataAdapter adapterFoundo;
        private DataTable DTFoundo;

        public void GoLastRow()
        {
            int lastRow = this.dataGridViewFon.RowCount - 1;
            this.dataGridViewFon.CurrentCell = this.dataGridViewFon.Rows[lastRow].Cells[0];

        }
        public FormFoundo()
        {
            InitializeComponent();
        }

        private DataTable GetAllItems()
        {
            try
            {
                //prepare query to get all records from foundo table
                //prepare adapter to run query
                this.adapterFoundo = new MySqlDataAdapter(Connection.TableFoundo, this.connection);
                DataSet DSFoundo = new DataSet();
                //get query results in dataset
                this.adapterFoundo.Fill(DSFoundo);

                // Set the UPDATE command and parameters.
                this.adapterFoundo.UpdateCommand = new MySqlCommand("UPDATE foundo SET ID=@ID, F_Name=@F_Name, Updated_Dt=NOW() WHERE ID=@ID;", this.connection);
                this.adapterFoundo.UpdateCommand.Parameters.Add("@ID", MySqlDbType.Int32, 11, "ID");
                this.adapterFoundo.UpdateCommand.Parameters.Add("@F_Name", MySqlDbType.VarChar, 15, "F_Name");
                this.adapterFoundo.UpdateCommand.UpdatedRowSource = UpdateRowSource.None;

                // Set the INSERT command and parameter.
                this.adapterFoundo.InsertCommand = new MySqlCommand("INSERT INTO foundo VALUES (@ID, @F_Name, NOW());", this.connection);
                this.adapterFoundo.InsertCommand.Parameters.Add("@ID", MySqlDbType.Int32, 11, "ID");
                this.adapterFoundo.InsertCommand.Parameters.Add("@F_Name", MySqlDbType.VarChar, 15, "F_Name");
                this.adapterFoundo.InsertCommand.UpdatedRowSource = UpdateRowSource.None;

                // Set the DELETE command and parameter.
                this.adapterFoundo.DeleteCommand = new MySqlCommand("DELETE FROM foundo WHERE ID=@ID;", this.connection);
                this.adapterFoundo.DeleteCommand.Parameters.Add("@ID", MySqlDbType.Int32, 11, "ID");

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
            this.connection = new MySqlConnection(this.ConnectionString);
            //Get all items in datatable
            this.DTFoundo = this.GetAllItems();
            //Fill grid with items
            this.dataGridViewFon.DataSource = this.DTFoundo;
            dataGridViewFon.Columns["Updated_Dt"].ReadOnly = true;

            GoLastRow();
            lbl_Msg.Text = "";
        }

        private void cmb_Foundo_Exit_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void cmb_Save_Fou_Click(object sender, EventArgs e)
        {
            try
            {
                //Save records in database using DTArticle which is datasource for Grid
                this.adapterFoundo.Update(this.DTFoundo);
                //Refresh grid
                this.DTFoundo = this.GetAllItems();
                this.dataGridViewFon.DataSource = this.DTFoundo;
                GoLastRow();
                lbl_Msg.Text = "Items saved successfully...";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmb_Delete_Fou_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewFon.SelectedRows.Count > 0)
            {
                //Delete a row from grid first.
                this.dataGridViewFon.Rows.Remove(this.dataGridViewFon.SelectedRows[0]);
                //Save records again. This will delete record from database.
                this.adapterFoundo.Update(this.DTFoundo);
                //Refresh grid. Get items Bu again from database and show it in grid.
                this.DTFoundo = this.GetAllItems();
                this.dataGridViewFon.DataSource = this.DTFoundo;
                GoLastRow();
                lbl_Msg.Text = "Selected item deleted successfully...";
            }
            else
            {
                MessageBox.Show("You must select entire row in order to delete it.");
            }
        }

        private void dataGridViewFon_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            base.Close();
        }

        public int ReturnValueFon 
        { 
            get 
            {
                int result;
                try
                {
                    result = int.Parse(this.dataGridViewFon.SelectedCells[0].Value.ToString()); 
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
            set
            {
                this.ReturnValueFon = 0;
            }
            
        }
    }
}
