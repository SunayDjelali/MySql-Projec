namespace Shoes
{
    using MySql.Data.MySqlClient;
    using System;
    using System.Data;
    using System.Windows.Forms;
    public partial class FormManufactured : Form
    {   
        //Read connection string from application settings = App.config.xml
        string ConnectionString = Connection.MyConnectionString;
        MySqlConnection connection;
        MySqlDataAdapter adapterManufactured;
        DataTable DataTableManufactured;

        public DataTable GetAllItemsManufactoring()
        {
            try
            {
                //prepare query to get all records from items table
                //prepare adapter to run query
                adapterManufactured = new MySqlDataAdapter(Connection.TableManufactured, connection);
                DataSet DataSetManufactoring = new DataSet();
                //get query results in dataset
                adapterManufactured.Fill(DataSetManufactoring);
                //AutoGenerateColumns = false;
                // Set the UPDATE command and parameters.
                adapterManufactured.UpdateCommand = new MySqlCommand(
                    "UPDATE manufactured SET ID=@ID, Date=@Date, Bu_ID=@Bu_ID, Article_ID=@Article_ID, Lavoratione_ID=@Lavoratione_ID, Foundo_ID=@Foundo_ID, Linia_ID=@Linia_ID, No_39=@No_39, No_40=@No_40, No_41=@No_41, No_42=@No_42, No_43=@No_43, No_44=@No_44, No_45=@No_45, No_46=@No_46, Total=@Total, Updated_Dt=NOW() WHERE ID=@ID;",
                    connection);
                adapterManufactured.UpdateCommand.Parameters.Add("@ID", MySqlDbType.Int32, 11, "ID");
                adapterManufactured.UpdateCommand.Parameters.Add("@Date", MySqlDbType.Date, 0, "Date");//?????????
                adapterManufactured.UpdateCommand.Parameters.Add("@Bu_ID", MySqlDbType.Int32, 11, "Bu_ID");
                adapterManufactured.UpdateCommand.Parameters.Add("@Article_ID", MySqlDbType.Int32, 11, "Article_ID");
                adapterManufactured.UpdateCommand.Parameters.Add("@Lavoratione_ID", MySqlDbType.Int32, 11, "Lavoratione_ID");
                adapterManufactured.UpdateCommand.Parameters.Add("@Foundo_ID", MySqlDbType.Int32, 11, "Foundo_ID");
                adapterManufactured.UpdateCommand.Parameters.Add("@Linia_ID", MySqlDbType.Int32, 11, "Linia_ID");
                adapterManufactured.UpdateCommand.Parameters.Add("@No_39", MySqlDbType.Int32, 11, "No_39");
                adapterManufactured.UpdateCommand.Parameters.Add("@No_40", MySqlDbType.Int32, 11, "No_40");
                adapterManufactured.UpdateCommand.Parameters.Add("@No_41", MySqlDbType.Int32, 11, "No_41");
                adapterManufactured.UpdateCommand.Parameters.Add("@No_42", MySqlDbType.Int32, 11, "No_42");
                adapterManufactured.UpdateCommand.Parameters.Add("@No_43", MySqlDbType.Int32, 11, "No_43");
                adapterManufactured.UpdateCommand.Parameters.Add("@No_44", MySqlDbType.Int32, 11, "No_44");
                adapterManufactured.UpdateCommand.Parameters.Add("@No_45", MySqlDbType.Int32, 11, "No_45");
                adapterManufactured.UpdateCommand.Parameters.Add("@No_46", MySqlDbType.Int32, 11, "No_46");
                adapterManufactured.UpdateCommand.Parameters.Add("@Total", MySqlDbType.Int32, 11, "Total");
                adapterManufactured.UpdateCommand.UpdatedRowSource = UpdateRowSource.None;

                // Set the INSERT command and parameter.
                adapterManufactured.InsertCommand = new MySqlCommand(
                    "INSERT INTO manufactured VALUES (@ID, @Date, @Bu_ID, @Article_ID, @Lavoratione_ID, @Foundo_ID, @Linia_ID, @No_39, @No_40, @No_41, @No_42, @No_43, @No_44, @No_45, @No_46, @Total, NOW());",
                    connection);
                adapterManufactured.InsertCommand.Parameters.Add("@ID", MySqlDbType.Int32, 11, "ID");
                adapterManufactured.InsertCommand.Parameters.Add("@Date", MySqlDbType.Date, 0, "Date");
                adapterManufactured.InsertCommand.Parameters.Add("@Bu_ID", MySqlDbType.Int32, 11, "Bu_ID");
                adapterManufactured.InsertCommand.Parameters.Add("@Article_ID", MySqlDbType.Int32, 11, "Article_ID");
                adapterManufactured.InsertCommand.Parameters.Add("@Lavoratione_ID", MySqlDbType.Int32, 11, "Lavoratione_ID");
                adapterManufactured.InsertCommand.Parameters.Add("@Foundo_ID", MySqlDbType.Int32, 11, "Foundo_ID");
                adapterManufactured.InsertCommand.Parameters.Add("@Linia_ID", MySqlDbType.Int32, 11, "Linia_ID");
                adapterManufactured.InsertCommand.Parameters.Add("@No_39", MySqlDbType.Int32, 11, "No_39");
                adapterManufactured.InsertCommand.Parameters.Add("@No_40", MySqlDbType.Int32, 11, "No_40");
                adapterManufactured.InsertCommand.Parameters.Add("@No_41", MySqlDbType.Int32, 11, "No_41");
                adapterManufactured.InsertCommand.Parameters.Add("@No_42", MySqlDbType.Int32, 11, "No_42");
                adapterManufactured.InsertCommand.Parameters.Add("@No_43", MySqlDbType.Int32, 11, "No_43");
                adapterManufactured.InsertCommand.Parameters.Add("@No_44", MySqlDbType.Int32, 11, "No_44");
                adapterManufactured.InsertCommand.Parameters.Add("@No_45", MySqlDbType.Int32, 11, "No_45");
                adapterManufactured.InsertCommand.Parameters.Add("@No_46", MySqlDbType.Int32, 11, "No_46");
                adapterManufactured.InsertCommand.Parameters.Add("@Total", MySqlDbType.Int32, 11, "Total");
                adapterManufactured.InsertCommand.UpdatedRowSource = UpdateRowSource.None;

                // Set the DELETE command and parameter.
                adapterManufactured.DeleteCommand = new MySqlCommand("DELETE FROM manufactured " + "WHERE ID=@ID;", connection);
                adapterManufactured.DeleteCommand.Parameters.Add("@ID", MySqlDbType.Int32, 4, "ID");

                //return datatable with all records
                return DataSetManufactoring.Tables[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        public FormManufactured()
        {
            InitializeComponent();
        }

        private void cmb_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void SetZeroVlaue()
        {
            int lastRecortIndex = dataGridView.NewRowIndex;
            if (dataGridView.SelectedCells[0].Value == DBNull.Value)
            {
                for (int numbers = 7; numbers < 15; numbers++)
                {
                    dataGridView.Rows[lastRecortIndex].Cells[numbers].Value = 0;
                }
            }
        }

        private void cmb_Save_Click(object sender, EventArgs e)
        {
            try
            {
                adapterManufactured.Update(DataTableManufactured);
                //Refresh grid
                DataTableManufactured = GetAllItemsManufactoring();
                dataGridView.DataSource = DataTableManufactured;
                MessageBox.Show("Items saved successfully...");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void cmb_Delete_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                //Delete a row from grid first.
                dataGridView.Rows.Remove(dataGridView.SelectedRows[0]);

                //Save records again. This will delete record from database.
                adapterManufactured.Update(DataTableManufactured);

                //Refresh grid. Get items again from database and show it in grid.
                DataTableManufactured = GetAllItemsManufactoring();
                dataGridView.DataSource = DataTableManufactured;
                MessageBox.Show("Selected item deleted successfully...");
            }
            else
            {
                MessageBox.Show("You must select entire row in order to delete it.");
            }

        }

        private void FormManufactured_Load(object sender, EventArgs e)
        {
            try
            {
                //Initialize mysql connection
                connection = new MySqlConnection(ConnectionString);
                //Get all items in datatable
                DataTableManufactured = GetAllItemsManufactoring();
                //FormVersion FVer = new FormVersion();
                //Fill grid with items
                dataGridView.DataSource = DataTableManufactured;
                dataGridView.Columns["ID"].Visible = false;
                dataGridView.Columns["Updated_Dt"].Visible = false;
                //DataTableManufactoring.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            SetZeroVlaue();
            if (e.ColumnIndex == 1)
            {
                FormDate FDate = new FormDate();
                FDate.ShowDialog();
                dataGridView.SelectedCells[0].Value = FDate.ReturnValueDate;
            }
            else if (e.ColumnIndex == 2)
            {
                FormBu FBu = new FormBu();
                FBu.ShowDialog();
                dataGridView.SelectedCells[0].Value = FBu.ReturnValueBu;
            }
            else if (e.ColumnIndex == 3)
            {
                FormArticle FArt = new FormArticle();
                FArt.ShowDialog();
                dataGridView.SelectedCells[0].Value = FArt.ReturnValueArt;
            }
            else if (e.ColumnIndex == 4)
            {
                FormLavor FLav = new FormLavor();
                FLav.ShowDialog();
                dataGridView.SelectedCells[0].Value = FLav.ReturnValueLav;
            }
            else if (e.ColumnIndex == 5)
            {
                FormFoundo FFon = new FormFoundo();
                FFon.ShowDialog();
                dataGridView.SelectedCells[0].Value = FFon.ReturnValueFon;
            }
            else if (e.ColumnIndex == 6)
            {
                FormLinia FLin = new FormLinia();
                FLin.ShowDialog();
                dataGridView.SelectedCells[0].Value = FLin.ReturnValueLin;
            }
            try
            {
                int SelectedRowIndex = e.RowIndex;
                //Save records in database using DTItems which is datasource for Grid
                Int32 curentSum;
                Int32 newSum;
                //Calculate Values columns by rows in total column
                if (dataGridView.Rows[SelectedRowIndex].Cells["Total"].Value == DBNull.Value)
                {
                    dataGridView.Rows[SelectedRowIndex].Cells["Total"].Value = 0;
                }
                //7 do 14
                newSum = Int32.Parse(dataGridView.Rows[SelectedRowIndex].Cells["No_39"].Value.ToString())
                       + Int32.Parse(dataGridView.Rows[SelectedRowIndex].Cells["No_40"].Value.ToString())
                       + Int32.Parse(dataGridView.Rows[SelectedRowIndex].Cells["No_41"].Value.ToString())
                       + Int32.Parse(dataGridView.Rows[SelectedRowIndex].Cells["No_42"].Value.ToString())
                       + Int32.Parse(dataGridView.Rows[SelectedRowIndex].Cells["No_43"].Value.ToString())
                       + Int32.Parse(dataGridView.Rows[SelectedRowIndex].Cells["No_44"].Value.ToString())
                       + Int32.Parse(dataGridView.Rows[SelectedRowIndex].Cells["No_45"].Value.ToString())
                       + Int32.Parse(dataGridView.Rows[SelectedRowIndex].Cells["No_46"].Value.ToString());
                curentSum = Int32.Parse(dataGridView.Rows[SelectedRowIndex].Cells["Total"].Value.ToString());
                if (newSum != curentSum)
                {
                    dataGridView.Rows[SelectedRowIndex].Cells["Total"].Value = newSum;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
                //throw;
            }

        }

    }
}
