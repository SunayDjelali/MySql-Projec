namespace Shoes
{
    using MySql.Data.MySqlClient;
    using System;
    using System.Data;
    using System.Windows.Forms;
    public partial class FormLave : Form
    {   
        //Read connection string from application settings = App.config.xml
        private string ConnectionString = Connection.MyConnectionString;
        private MySqlConnection connection;
        private MySqlDataAdapter adapterLave;
        private DataTable DataTableLave;

        public DataTable GetAllItems()
        {
            try
            {
                this.adapterLave = new MySqlDataAdapter(Connection.TableLeave, connection);
                DataSet DataSetLave = new DataSet();
                this.adapterLave.Fill(DataSetLave);
                this.adapterLave.UpdateCommand = new MySqlCommand(
                    "UPDATE `leave` SET Bu_ID=@Bu_ID, Article_ID=@Article_ID, Lavoratione_ID=@Lavoratione_ID, Versions_ID=@Versions_ID, Foundo_ID=@Foundo_ID, Linia_ID=@Linia_ID, No_39=@No_39, No_40=@No_40, No_41=@No_41, No_42=@No_42, No_43=@No_43, No_44=@No_44, No_45=@No_45, No_46=@No_46, Total=@Total, Updated_Dt=NOW() WHERE ID=@ID;",
                    connection);
                this.adapterLave.UpdateCommand.Parameters.Add("@ID", MySqlDbType.Int32, 11, "ID");
                this.adapterLave.UpdateCommand.Parameters.Add("@Bu_ID", MySqlDbType.Int32, 11, "Bu_ID");
                this.adapterLave.UpdateCommand.Parameters.Add("@Article_ID", MySqlDbType.Int32, 11, "Article_ID");
                this.adapterLave.UpdateCommand.Parameters.Add("@Lavoratione_ID", MySqlDbType.Int32, 11, "Lavoratione_ID");
                this.adapterLave.UpdateCommand.Parameters.Add("@Versions_ID", MySqlDbType.Int32, 11, "Versions_ID");
                this.adapterLave.UpdateCommand.Parameters.Add("@Foundo_ID", MySqlDbType.Int32, 11, "Foundo_ID");
                this.adapterLave.UpdateCommand.Parameters.Add("@Linia_ID", MySqlDbType.Int32, 11, "Linia_ID");
                this.adapterLave.UpdateCommand.Parameters.Add("@No_39", MySqlDbType.Int32, 11, "No_39");
                this.adapterLave.UpdateCommand.Parameters.Add("@No_40", MySqlDbType.Int32, 11, "No_40");
                this.adapterLave.UpdateCommand.Parameters.Add("@No_41", MySqlDbType.Int32, 11, "No_41");
                this.adapterLave.UpdateCommand.Parameters.Add("@No_42", MySqlDbType.Int32, 11, "No_42");
                this.adapterLave.UpdateCommand.Parameters.Add("@No_43", MySqlDbType.Int32, 11, "No_43");
                this.adapterLave.UpdateCommand.Parameters.Add("@No_44", MySqlDbType.Int32, 11, "No_44");
                this.adapterLave.UpdateCommand.Parameters.Add("@No_45", MySqlDbType.Int32, 11, "No_45");
                this.adapterLave.UpdateCommand.Parameters.Add("@No_46", MySqlDbType.Int32, 11, "No_46");
                this.adapterLave.UpdateCommand.Parameters.Add("@Total", MySqlDbType.Int32, 11, "Total");
                this.adapterLave.UpdateCommand.UpdatedRowSource = UpdateRowSource.None;

                // Set the INSERT command and parameter.
                this.adapterLave.InsertCommand = new MySqlCommand(
                    "INSERT INTO `leave` VALUES (@ID, @Bu_ID, @Article_ID, @Lavoratione_ID, @Versions_ID, @Foundo_ID, @Linia_ID, @No_39, @No_40, @No_41, @No_42, @No_43, @No_44, @No_45, @No_46, @Total, NOW());",
                    connection);
                this.adapterLave.InsertCommand.Parameters.Add("@ID", MySqlDbType.Int32, 11, "ID");
                this.adapterLave.InsertCommand.Parameters.Add("@Bu_ID", MySqlDbType.Int32, 11, "Bu_ID");
                this.adapterLave.InsertCommand.Parameters.Add("@Article_ID", MySqlDbType.Int32, 11, "Article_ID");
                this.adapterLave.InsertCommand.Parameters.Add("@Lavoratione_ID", MySqlDbType.Int32, 11, "Lavoratione_ID");
                this.adapterLave.InsertCommand.Parameters.Add("@Versions_ID", MySqlDbType.Int32, 11, "Versions_ID");
                this.adapterLave.InsertCommand.Parameters.Add("@Foundo_ID", MySqlDbType.Int32, 11, "Foundo_ID");
                this.adapterLave.InsertCommand.Parameters.Add("@Linia_ID", MySqlDbType.Int32, 11, "Linia_ID");
                this.adapterLave.InsertCommand.Parameters.Add("@No_39", MySqlDbType.Int32, 11, "No_39");
                this.adapterLave.InsertCommand.Parameters.Add("@No_40", MySqlDbType.Int32, 11, "No_40");
                this.adapterLave.InsertCommand.Parameters.Add("@No_41", MySqlDbType.Int32, 11, "No_41");
                this.adapterLave.InsertCommand.Parameters.Add("@No_42", MySqlDbType.Int32, 11, "No_42");
                this.adapterLave.InsertCommand.Parameters.Add("@No_43", MySqlDbType.Int32, 11, "No_43");
                this.adapterLave.InsertCommand.Parameters.Add("@No_44", MySqlDbType.Int32, 11, "No_44");
                this.adapterLave.InsertCommand.Parameters.Add("@No_45", MySqlDbType.Int32, 11, "No_45");
                this.adapterLave.InsertCommand.Parameters.Add("@No_46", MySqlDbType.Int32, 11, "No_46");
                this.adapterLave.InsertCommand.Parameters.Add("@Total", MySqlDbType.Int32, 11, "Total");
                this.adapterLave.InsertCommand.UpdatedRowSource = UpdateRowSource.None;

                // Set the DELETE command and parameter.
                adapterLave.DeleteCommand = new MySqlCommand("DELETE FROM `leave` " + "WHERE ID=@ID;", connection);
                adapterLave.DeleteCommand.Parameters.Add("@ID", MySqlDbType.Int32, 4, "ID");

                //return datatable with all records
                return DataSetLave.Tables[0];

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

        public FormLave()
        {
            InitializeComponent();
        }

        private void FormLave_Load(object sender, EventArgs e)
        {
            try
            {
                this.connection = new MySqlConnection(this.ConnectionString);
                this.DataTableLave = this.GetAllItems();
                this.dataGridView.DataSource = this.DataTableLave;
                this.dataGridView.Columns["ID"].Visible = false;
                this.dataGridView.Columns["Updated_Dt"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmb_Exit_Click(object sender, EventArgs e)
        {
            base.Close();
        }
        
        private void cmb_Save_Click(object sender, EventArgs e)
        {
            try
            {
                this.adapterLave.Update(DataTableLave);
                //Refresh grid
                this.DataTableLave = this.GetAllItems();
                this.dataGridView.DataSource = this.DataTableLave;
                MessageBox.Show("Items saved successfully...");
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
                this.adapterLave.Update(this.DataTableLave);

                //Refresh grid. Get items again from database and show it in grid.
                this.DataTableLave = this.GetAllItems();
                this.dataGridView.DataSource = this.DataTableLave;
                MessageBox.Show("Selected item deleted successfully...");
            }
            else
            {
                MessageBox.Show("You must select entire row in order to delete it.");
            }
        }

        private void dataGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            this.SetZeroVlaue();
            if (e.ColumnIndex == 1)
            {
                FormBu FBu = new FormBu();
                FBu.ShowDialog();
                this.dataGridView.SelectedCells[0].Value = FBu.ReturnValueBu;
            }
            else if (e.ColumnIndex == 2)
            {
                FormArticle FArt = new FormArticle();
                FArt.ShowDialog();
                this.dataGridView.SelectedCells[0].Value = FArt.ReturnValueArt;
            }
            else if (e.ColumnIndex == 3)
            {
                FormLavor FLav = new FormLavor();
                FLav.ShowDialog();
                this.dataGridView.SelectedCells[0].Value = FLav.ReturnValueLav;
            }
            else if (e.ColumnIndex == 4)
            {
                FormVersion FVer = new FormVersion();
                FVer.ShowDialog();
                this.dataGridView.SelectedCells[0].Value = FVer.ReturnValueVer;
            }
            else if (e.ColumnIndex == 5)
            {
                FormFoundo FFon = new FormFoundo();
                FFon.ShowDialog();
                this.dataGridView.SelectedCells[0].Value = FFon.ReturnValueFon;
            }
            else if (e.ColumnIndex == 6)
            {
                FormLinia FLin = new FormLinia();
                FLin.ShowDialog();
                this.dataGridView.SelectedCells[0].Value = FLin.ReturnValueLin;
            }
        }

        private void dataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 7 && e.ColumnIndex <= 14)
            {
                try
                {
                    int SelectedRowIndex = e.RowIndex;
                    //Save records in database using DTItems which is datasource for Grid
                    //Calculate Values columns by rows in total column
                        if (this.dataGridView.Rows[SelectedRowIndex].Cells["Total"].Value == DBNull.Value)
                        {
                            this.dataGridView.Rows[SelectedRowIndex].Cells["Total"].Value = 0;
                        }
                    //sum values on the datagrid celss in row at columns 7 to 14
                            int newSum = Int32.Parse(this.dataGridView.Rows[SelectedRowIndex].Cells["No_39"].Value.ToString())
                                        + Int32.Parse(this.dataGridView.Rows[SelectedRowIndex].Cells["No_40"].Value.ToString())
                                        + Int32.Parse(this.dataGridView.Rows[SelectedRowIndex].Cells["No_41"].Value.ToString())
                                        + Int32.Parse(this.dataGridView.Rows[SelectedRowIndex].Cells["No_42"].Value.ToString())
                                        + Int32.Parse(this.dataGridView.Rows[SelectedRowIndex].Cells["No_43"].Value.ToString())
                                        + Int32.Parse(this.dataGridView.Rows[SelectedRowIndex].Cells["No_44"].Value.ToString())
                                        + Int32.Parse(this.dataGridView.Rows[SelectedRowIndex].Cells["No_45"].Value.ToString())
                                        + Int32.Parse(this.dataGridView.Rows[SelectedRowIndex].Cells["No_46"].Value.ToString());
                            int curentSum = Int32.Parse(this.dataGridView.Rows[SelectedRowIndex].Cells["Total"].Value.ToString());
                        if (newSum != curentSum)
                        {
                            this.dataGridView.Rows[SelectedRowIndex].Cells["Total"].Value = newSum;
                        }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(string.Concat(ex));
                    //throw;
                }
            }
        }
    }
}
