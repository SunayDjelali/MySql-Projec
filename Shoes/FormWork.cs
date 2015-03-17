namespace Shoes
{
    using MySql.Data.MySqlClient;
    using System;
    using System.Data;
    using System.Windows.Forms;
    public partial class FormWork : Form
    {
        //Read connection string from application settings = App.config.xml
        private string ConnectionString = Connection.MyConnectionString;
        private MySqlConnection connection;
        private MySqlDataAdapter adapterWorck;
        private DataTable DataTableWork;

        private DataTable GetAllItems()
        {
            try
            {
                //prepare query to get all records from items table
                //prepare adapter to run query
                this.adapterWorck = new MySqlDataAdapter(Connection.TableWorck, this.connection);
                DataSet DataSetWorck = new DataSet();
                //get query results in dataset
                this.adapterWorck.Fill(DataSetWorck);
                //AutoGenerateColumns = false;
                // Set the UPDATE command and parameters.
                this.adapterWorck.UpdateCommand = new MySqlCommand(
                    "UPDATE worck SET Bu_ID=@Bu_ID, Article_ID=@Article_ID, Lavoratione_ID=@Lavoratione_ID, Versions_ID=@Versions_ID, Foundo_ID=@Foundo_ID, Linia_ID=@Linia_ID, No_39=@No_39, No_40=@No_40, No_41=@No_41, No_42=@No_42, No_43=@No_43, No_44=@No_44, No_45=@No_45, No_46=@No_46, Total=@Total, Updated_Dt=NOW() WHERE ID=@ID;",
                    this.connection);
                this.adapterWorck.UpdateCommand.Parameters.Add("@ID", MySqlDbType.Int32, 11, "ID");
                this.adapterWorck.UpdateCommand.Parameters.Add("@Bu_ID", MySqlDbType.Int32, 11, "Bu_ID");
                this.adapterWorck.UpdateCommand.Parameters.Add("@Article_ID", MySqlDbType.Int32, 11, "Article_ID");
                this.adapterWorck.UpdateCommand.Parameters.Add("@Lavoratione_ID", MySqlDbType.Int32, 11, "Lavoratione_ID");
                this.adapterWorck.UpdateCommand.Parameters.Add("@Versions_ID", MySqlDbType.Int32, 11, "Versions_ID");
                this.adapterWorck.UpdateCommand.Parameters.Add("@Foundo_ID", MySqlDbType.Int32, 11, "Foundo_ID");
                this.adapterWorck.UpdateCommand.Parameters.Add("@Linia_ID", MySqlDbType.Int32, 11, "Linia_ID");
                this.adapterWorck.UpdateCommand.Parameters.Add("@No_39", MySqlDbType.Int32, 11, "No_39");
                this.adapterWorck.UpdateCommand.Parameters.Add("@No_40", MySqlDbType.Int32, 11, "No_40");
                this.adapterWorck.UpdateCommand.Parameters.Add("@No_41", MySqlDbType.Int32, 11, "No_41");
                this.adapterWorck.UpdateCommand.Parameters.Add("@No_42", MySqlDbType.Int32, 11, "No_42");
                this.adapterWorck.UpdateCommand.Parameters.Add("@No_43", MySqlDbType.Int32, 11, "No_43");
                this.adapterWorck.UpdateCommand.Parameters.Add("@No_44", MySqlDbType.Int32, 11, "No_44");
                this.adapterWorck.UpdateCommand.Parameters.Add("@No_45", MySqlDbType.Int32, 11, "No_45");
                this.adapterWorck.UpdateCommand.Parameters.Add("@No_46", MySqlDbType.Int32, 11, "No_46");
                this.adapterWorck.UpdateCommand.Parameters.Add("@Total", MySqlDbType.Int32, 11, "Total");
                this.adapterWorck.UpdateCommand.UpdatedRowSource = UpdateRowSource.None;

                // Set the INSERT command and parameter.
                this.adapterWorck.InsertCommand = new MySqlCommand(
                    "INSERT INTO worck VALUES (@ID, @Bu_ID, @Article_ID, @Lavoratione_ID, @Versions_ID, @Foundo_ID, @Linia_ID, @No_39, @No_40, @No_41, @No_42, @No_43, @No_44, @No_45, @No_46, @Total, NOW());",
                    this.connection);
                this.adapterWorck.InsertCommand.Parameters.Add("@ID", MySqlDbType.Int32, 11, "ID");
                this.adapterWorck.InsertCommand.Parameters.Add("@Bu_ID", MySqlDbType.Int32, 11, "Bu_ID");
                this.adapterWorck.InsertCommand.Parameters.Add("@Article_ID", MySqlDbType.Int32, 11, "Article_ID");
                this.adapterWorck.InsertCommand.Parameters.Add("@Lavoratione_ID", MySqlDbType.Int32, 11, "Lavoratione_ID");
                this.adapterWorck.InsertCommand.Parameters.Add("@Versions_ID", MySqlDbType.Int32, 11, "Versions_ID");
                this.adapterWorck.InsertCommand.Parameters.Add("@Foundo_ID", MySqlDbType.Int32, 11, "Foundo_ID");
                this.adapterWorck.InsertCommand.Parameters.Add("@Linia_ID", MySqlDbType.Int32, 11, "Linia_ID");
                this.adapterWorck.InsertCommand.Parameters.Add("@No_39", MySqlDbType.Int32, 11, "No_39");
                this.adapterWorck.InsertCommand.Parameters.Add("@No_40", MySqlDbType.Int32, 11, "No_40");
                this.adapterWorck.InsertCommand.Parameters.Add("@No_41", MySqlDbType.Int32, 11, "No_41");
                this.adapterWorck.InsertCommand.Parameters.Add("@No_42", MySqlDbType.Int32, 11, "No_42");
                this.adapterWorck.InsertCommand.Parameters.Add("@No_43", MySqlDbType.Int32, 11, "No_43");
                this.adapterWorck.InsertCommand.Parameters.Add("@No_44", MySqlDbType.Int32, 11, "No_44");
                this.adapterWorck.InsertCommand.Parameters.Add("@No_45", MySqlDbType.Int32, 11, "No_45");
                this.adapterWorck.InsertCommand.Parameters.Add("@No_46", MySqlDbType.Int32, 11, "No_46");
                this.adapterWorck.InsertCommand.Parameters.Add("@Total", MySqlDbType.Int32, 11, "Total");
                this.adapterWorck.InsertCommand.UpdatedRowSource = UpdateRowSource.None;

                // Set the DELETE command and parameter.
                this.adapterWorck.DeleteCommand = new MySqlCommand("DELETE FROM worck " + "WHERE ID=@ID;", this.connection);
                this.adapterWorck.DeleteCommand.Parameters.Add("@ID", MySqlDbType.Int32, 4, "ID");

                //return datatable with all records
                return DataSetWorck.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        public void SetZeroVlaue()
        {
            int lastRecortIndex = this.dataGridView.NewRowIndex;
            if (this.dataGridView.SelectedCells[0].Value == DBNull.Value)
            {
                for (int numbers = 7; numbers < 15; numbers++)
                {
                    this.dataGridView.Rows[lastRecortIndex].Cells[numbers].Value = 0;
                }
            }
        }

        public FormWork()
        {
            InitializeComponent();
        }

        private void cmb_Exit_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void FormWork_Load(object sender, EventArgs e)
        {
            try
            {
                //Initialize mysql connection
                this.connection = new MySqlConnection(this.ConnectionString);
                //Get all items in datatable
                this.DataTableWork = this.GetAllItems();
                //FormVersion FVer = new FormVersion();
                //Fill grid with items
                this.dataGridView.DataSource = this.DataTableWork;
                this.dataGridView.Columns["ID"].Visible = false;
                this.dataGridView.Columns["Updated_Dt"].Visible = false;
                //DataTableManufactoring.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void cmb_Delete_Click(object sender, EventArgs e)
        {
            if (this.dataGridView.SelectedRows.Count > 0)
            {
                //Delete a row from grid first.
                this.dataGridView.Rows.Remove(this.dataGridView.SelectedRows[0]);

                //Save records again. This will delete record from database.
                this.adapterWorck.Update(this.DataTableWork);

                //Refresh grid. Get items again from database and show it in grid.
                this.DataTableWork = this.GetAllItems();
                this.dataGridView.DataSource = this.DataTableWork;
                MessageBox.Show("Selected item deleted successfully...");
            }
            else
            {
                MessageBox.Show("You must select entire row in order to delete it.");
            }

        }

        private void cmb_Save_Click(object sender, EventArgs e)
        {
            try
            {
                this.adapterWorck.Update(this.DataTableWork);
                //Refresh grid
                this.DataTableWork = this.GetAllItems();
                this.dataGridView.DataSource = this.DataTableWork;
                MessageBox.Show("Items saved successfully...");
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
                    FormBu FBu = new FormBu();
                    FBu.ShowDialog();
                    dataGridView.SelectedCells[0].Value = FBu.ReturnValueBu;
                }
                else if (e.ColumnIndex == 2)
                {
                    FormArticle FArt = new FormArticle();
                    FArt.ShowDialog();
                    dataGridView.SelectedCells[0].Value = FArt.ReturnValueArt;
                }
                else if (e.ColumnIndex == 3)
                {
                    FormLavor FLav = new FormLavor();
                    FLav.ShowDialog();
                    dataGridView.SelectedCells[0].Value = FLav.ReturnValueLav;
                }
                else if (e.ColumnIndex == 4)
                {
                    FormVersion FVer = new FormVersion();
                    FVer.ShowDialog();
                    dataGridView.SelectedCells[0].Value = FVer.ReturnValueVer;
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
