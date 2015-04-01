namespace Shoes
{
    using MySql.Data.MySqlClient;
    using System;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Windows.Forms;

    public partial class FormCheck : Form
    {
        private string ConnectionString = Connection.MyConnectionString;
        private MySqlConnection connection;
        private MySqlDataAdapter adapterManufactured;
        private MySqlDataAdapter adapterLave;
        private DataTable DataTableManufactured;
        private DataTable DataTableLave;
        int[] result = new int[9];
        private string mesageNegative = "Check Manufetured Production smething is a Wrong.\nLaves canot be Negative";

        public FormCheck()
        {
            this.InitializeComponent();
        }

        private void FormCheck_Load(object sender, EventArgs e)
        {
            try
            {
                //Initialize mysql connection
                connection = new MySqlConnection(ConnectionString);
                //Get all items in datatable
                DataTableManufactured = GetAllItemsManufactoring();
                //DataTableLave.Clear();
                Connection.TableLeave = "SELECT * FROM `leave`";
                DataTableLave = GetAllItemsLave();
                //Fill grid with items
                dataGridViewDown.DataSource = DataTableManufactured;
                dataGridViewDown.Columns["ID"].Visible = false;
                dataGridViewDown.Columns["Updated_Dt"].Visible = false;
                dataGridViewUp.DataSource = DataTableLave;
                dataGridViewUp.Columns["ID"].Visible = true;
                dataGridViewUp.Columns["Updated_Dt"].Visible = false;
                dataGridViewDown.AllowUserToAddRows = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Concat(ex));
            }
        }

        public void SetZeroVlaue()
        {
            int lastRecortIndex = dataGridViewDown.NewRowIndex;
            if (this.dataGridViewDown.SelectedCells[0].Value == DBNull.Value)
            {
                for (int numbers = 7; numbers < 16; numbers++)
                {
                    this.dataGridViewDown.Rows[lastRecortIndex].Cells[numbers].Value = 0;
                }
            }
        }

        public void StringCalculation() 
        {
            //begin Update
            string query = "UPDATE `leave` SET ID='" + this.dataGridViewUp.Rows[0].Cells["ID"].Value +
                "', Bu_ID='" + this.dataGridViewUp.Rows[0].Cells["Bu_ID"].Value +
                "', Article_ID='" + this.dataGridViewUp.Rows[0].Cells["Article_ID"].Value +
                "', Lavoratione_ID='" + this.dataGridViewUp.Rows[0].Cells["Lavoratione_ID"].Value +
                "', Versions_ID='" + this.dataGridViewUp.Rows[0].Cells["Versions_ID"].Value +
                "', Foundo_ID='" + this.dataGridViewUp.Rows[0].Cells["Foundo_ID"].Value +
                "', Linia_ID='" + this.dataGridViewUp.Rows[0].Cells["Linia_ID"].Value +
                "', No_39='" + result[0].ToString() +
                "', No_40='" + result[1].ToString() +
                "', No_41='" + result[2].ToString() +
                "', No_42='" + result[3].ToString() +
                "', No_43='" + result[4].ToString() +
                "', No_44='" + result[5].ToString() +
                "', No_45='" + result[6].ToString() +
                "', No_46='" + result[7].ToString() +
                "', Total='" + result[8].ToString() +
                "', Updated_Dt=NOW() WHERE ID='" + this.dataGridViewUp.Rows[0].Cells["ID"].Value + "';";
            MySqlConnection myConn = new MySqlConnection(Connection.MyConnectionString);
            MySqlCommand cmdDataBase = new MySqlCommand(query, myConn);
            MySqlDataReader myReader;
            myConn.Open();
            myReader = cmdDataBase.ExecuteReader();
            MessageBox.Show("Items saved successfully...");
            myConn.Close();
            //Refresh grid
            Connection.TableLeave = "SELECT * FROM `leave`";
            DataTableLave = GetAllItemsLave();
            this.dataGridViewUp.DataSource = this.DataTableLave;
            this.txt_Lavor.Clear();

        }

        public void CalculationLavesTotal()
        {
            //7 do 14
            int newSum = Int32.Parse(dataGridViewUp.Rows[0].Cells["No_39"].Value.ToString())
                       + Int32.Parse(dataGridViewUp.Rows[0].Cells["No_40"].Value.ToString())
                       + Int32.Parse(dataGridViewUp.Rows[0].Cells["No_41"].Value.ToString())
                       + Int32.Parse(dataGridViewUp.Rows[0].Cells["No_42"].Value.ToString())
                       + Int32.Parse(dataGridViewUp.Rows[0].Cells["No_43"].Value.ToString())
                       + Int32.Parse(dataGridViewUp.Rows[0].Cells["No_44"].Value.ToString())
                       + Int32.Parse(dataGridViewUp.Rows[0].Cells["No_45"].Value.ToString())
                       + Int32.Parse(dataGridViewUp.Rows[0].Cells["No_46"].Value.ToString());
            this.dataGridViewUp.Rows[0].Cells["Total"].Value = newSum;
        }

        public DataTable GetAllItemsManufactoring()
        {
            try
            {
                //prepare query to get all records from items table
                //prepare adapter to run query
                this.adapterManufactured = new MySqlDataAdapter(Connection.TableManufactured, this.connection);
                DataSet DataSetManufactoring = new DataSet();
                //get query results in dataset
                this.adapterManufactured.Fill(DataSetManufactoring);
                //AutoGenerateColumns = false;
                // Set the UPDATE command and parameters.
                this.adapterManufactured.UpdateCommand = new MySqlCommand(
                    "UPDATE manufactured SET ID=@ID, Date=@Date, Bu_ID=@Bu_ID, Article_ID=@Article_ID, Lavoratione_ID=@Lavoratione_ID, Foundo_ID=@Foundo_ID, Linia_ID=@Linia_ID, No_39=@No_39, No_40=@No_40, No_41=@No_41, No_42=@No_42, No_43=@No_43, No_44=@No_44, No_45=@No_45, No_46=@No_46, Total=@Total, Updated_Dt=NOW() WHERE ID=@ID;",
                    connection);
                this.adapterManufactured.UpdateCommand.Parameters.Add("@ID", MySqlDbType.Int32, 11, "ID");
                this.adapterManufactured.UpdateCommand.Parameters.Add("@Date", MySqlDbType.Date, 0, "Date");//?????????
                this.adapterManufactured.UpdateCommand.Parameters.Add("@Bu_ID", MySqlDbType.Int32, 11, "Bu_ID");
                this.adapterManufactured.UpdateCommand.Parameters.Add("@Article_ID", MySqlDbType.Int32, 11, "Article_ID");
                this.adapterManufactured.UpdateCommand.Parameters.Add("@Lavoratione_ID", MySqlDbType.Int32, 11, "Lavoratione_ID");
                this.adapterManufactured.UpdateCommand.Parameters.Add("@Foundo_ID", MySqlDbType.Int32, 11, "Foundo_ID");
                this.adapterManufactured.UpdateCommand.Parameters.Add("@Linia_ID", MySqlDbType.Int32, 11, "Linia_ID");
                this.adapterManufactured.UpdateCommand.Parameters.Add("@No_39", MySqlDbType.Int32, 11, "No_39");
                this.adapterManufactured.UpdateCommand.Parameters.Add("@No_40", MySqlDbType.Int32, 11, "No_40");
                this.adapterManufactured.UpdateCommand.Parameters.Add("@No_41", MySqlDbType.Int32, 11, "No_41");
                this.adapterManufactured.UpdateCommand.Parameters.Add("@No_42", MySqlDbType.Int32, 11, "No_42");
                this.adapterManufactured.UpdateCommand.Parameters.Add("@No_43", MySqlDbType.Int32, 11, "No_43");
                this.adapterManufactured.UpdateCommand.Parameters.Add("@No_44", MySqlDbType.Int32, 11, "No_44");
                this.adapterManufactured.UpdateCommand.Parameters.Add("@No_45", MySqlDbType.Int32, 11, "No_45");
                this.adapterManufactured.UpdateCommand.Parameters.Add("@No_46", MySqlDbType.Int32, 11, "No_46");
                this.adapterManufactured.UpdateCommand.Parameters.Add("@Total", MySqlDbType.Int32, 11, "Total");
                this.adapterManufactured.UpdateCommand.UpdatedRowSource = UpdateRowSource.None;

                // Set the INSERT command and parameter.
                this.adapterManufactured.InsertCommand = new MySqlCommand(
                    "INSERT INTO manufactured VALUES (@ID, @Date, @Bu_ID, @Article_ID, @Lavoratione_ID, @Foundo_ID, @Linia_ID, @No_39, @No_40, @No_41, @No_42, @No_43, @No_44, @No_45, @No_46, @Total, NOW());",
                    connection);
                this.adapterManufactured.InsertCommand.Parameters.Add("@ID", MySqlDbType.Int32, 11, "ID");
                this.adapterManufactured.InsertCommand.Parameters.Add("@Date", MySqlDbType.Date, 0, "Date");
                this.adapterManufactured.InsertCommand.Parameters.Add("@Bu_ID", MySqlDbType.Int32, 11, "Bu_ID");
                this.adapterManufactured.InsertCommand.Parameters.Add("@Article_ID", MySqlDbType.Int32, 11, "Article_ID");
                this.adapterManufactured.InsertCommand.Parameters.Add("@Lavoratione_ID", MySqlDbType.Int32, 11, "Lavoratione_ID");
                this.adapterManufactured.InsertCommand.Parameters.Add("@Foundo_ID", MySqlDbType.Int32, 11, "Foundo_ID");
                this.adapterManufactured.InsertCommand.Parameters.Add("@Linia_ID", MySqlDbType.Int32, 11, "Linia_ID");
                this.adapterManufactured.InsertCommand.Parameters.Add("@No_39", MySqlDbType.Int32, 11, "No_39");
                this.adapterManufactured.InsertCommand.Parameters.Add("@No_40", MySqlDbType.Int32, 11, "No_40");
                this.adapterManufactured.InsertCommand.Parameters.Add("@No_41", MySqlDbType.Int32, 11, "No_41");
                this.adapterManufactured.InsertCommand.Parameters.Add("@No_42", MySqlDbType.Int32, 11, "No_42");
                this.adapterManufactured.InsertCommand.Parameters.Add("@No_43", MySqlDbType.Int32, 11, "No_43");
                this.adapterManufactured.InsertCommand.Parameters.Add("@No_44", MySqlDbType.Int32, 11, "No_44");
                this.adapterManufactured.InsertCommand.Parameters.Add("@No_45", MySqlDbType.Int32, 11, "No_45");
                this.adapterManufactured.InsertCommand.Parameters.Add("@No_46", MySqlDbType.Int32, 11, "No_46");
                this.adapterManufactured.InsertCommand.Parameters.Add("@Total", MySqlDbType.Int32, 11, "Total");
                this.adapterManufactured.InsertCommand.UpdatedRowSource = UpdateRowSource.None;

                // Set the DELETE command and parameter.
                this.adapterManufactured.DeleteCommand = new MySqlCommand("DELETE FROM manufactured " + "WHERE ID=@ID;", connection);
                this.adapterManufactured.DeleteCommand.Parameters.Add("@ID", MySqlDbType.Int32, 4, "ID");

                //return datatable with all records
                return DataSetManufactoring.Tables[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Concat(ex));
            }
            return null;

        }

        public DataTable GetAllItemsLave()
        {
            try
            {
                //prepare query to get all records from items table
                //prepare adapter to run query
                this.adapterLave = new MySqlDataAdapter(Connection.TableLeave, this.connection);
                DataSet DataSetLave = new DataSet();
                //get query results in dataset
                this.adapterLave.Fill(DataSetLave);
                //AutoGenerateColumns = false;
                // Set the UPDATE command and parameters.
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
                this.adapterLave.DeleteCommand = new MySqlCommand("DELETE FROM `leave` " + "WHERE ID=@ID;", connection);
                this.adapterLave.DeleteCommand.Parameters.Add("@ID", MySqlDbType.Int32, 4, "ID");

                //return datatable with all records
                return DataSetLave.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Concat(ex));
            }
            return null;
        }

        private void cmb_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmb_Save_Click(object sender, EventArgs e)
        {
            try
            {
                //get last record row where to work User
                int newRecord = this.dataGridViewDown.NewRowIndex-1;

                int chek = int.Parse(this.dataGridViewDown.Rows[newRecord].Cells["Total"].Value.ToString());
                
                bool[] negativ = {false, false, false, false, false, false, false, false, false};
                
                for (int shoeNumber = 0; shoeNumber < result.Length; shoeNumber++)
                {
                    if (result[shoeNumber] >= 0)
                    {
                        negativ[shoeNumber] = true;
                    }
                    else
                    {
                        //MessageBox.Show(mesageNegative);
                    }
                }

                if (negativ[0] && negativ[1] && negativ[2] && negativ[3] && negativ[4] && negativ[5] && negativ[6] && negativ[7] && negativ[8]==true)
                {
                    //save ne record
                    this.adapterManufactured.Update(this.DataTableManufactured);
                    //Refresh grid
                    this.dataGridViewDown.DataSource = this.DataTableManufactured;
                    //Update record in Lave Table
                    StringCalculation();
                }
                else
                {
                    MessageBox.Show(mesageNegative);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Concat(ex));
            }
        }

        private void cmb_Delete_Click(object sender, EventArgs e)
        {
            if (dataGridViewDown.SelectedRows.Count > 0)
            {
                //Delete a row from grid first.
                dataGridViewDown.Rows.Remove(dataGridViewDown.SelectedRows[0]);

                //Save records again. This will delete record from database.
                adapterManufactured.Update(DataTableManufactured);

                //Refresh grid. Get items again from database and show it in grid.
                DataTableManufactured = GetAllItemsManufactoring();
                dataGridViewDown.DataSource = DataTableManufactured;
                MessageBox.Show("Selected item deleted successfully...");
            }
            else
            {
                MessageBox.Show("You must select entire row in order to delete it.");
            }
        }

        private void dataGridViewDown_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            SetZeroVlaue();
            if (e.ColumnIndex == 1)
            {
                FormDate FDate = new FormDate();
                FDate.ShowDialog();
                this.dataGridViewDown.SelectedCells[0].Value = FDate.ReturnValueDate;
            }
        }

        private void dataGridViewDown_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int enteredValue = this.dataGridViewDown.NewRowIndex - 1;
            if (e.ColumnIndex >= 7 && e.ColumnIndex <= 14)
            {
                try
                {
                    int SelectedRowIndex = e.RowIndex;
                    bool ttry = int.Parse(this.dataGridViewDown.Rows[SelectedRowIndex].Cells[e.ColumnIndex].Value.ToString()) < 0;
                    if (ttry)
                    {
                        MessageBox.Show("Entered value cannot be Negative\nNow Value will be reset to the ZERO");
                        this.dataGridViewDown.Rows[SelectedRowIndex].Cells[e.ColumnIndex].Value = 0;
                    }
                    //Save records in database using DTItems which is datasource for Grid
                    //Calculate Values columns by rows in total column
                    if (this.dataGridViewDown.Rows[SelectedRowIndex].Cells["Total"].Value == DBNull.Value)
                    {
                        this.dataGridViewDown.Rows[SelectedRowIndex].Cells["Total"].Value = 0;
                    }
                    //7 do 14
                    int newSum = Int32.Parse(dataGridViewDown.Rows[SelectedRowIndex].Cells["No_39"].Value.ToString())
                           + Int32.Parse(dataGridViewDown.Rows[SelectedRowIndex].Cells["No_40"].Value.ToString())
                           + Int32.Parse(dataGridViewDown.Rows[SelectedRowIndex].Cells["No_41"].Value.ToString())
                           + Int32.Parse(dataGridViewDown.Rows[SelectedRowIndex].Cells["No_42"].Value.ToString())
                           + Int32.Parse(dataGridViewDown.Rows[SelectedRowIndex].Cells["No_43"].Value.ToString())
                           + Int32.Parse(dataGridViewDown.Rows[SelectedRowIndex].Cells["No_44"].Value.ToString())
                           + Int32.Parse(dataGridViewDown.Rows[SelectedRowIndex].Cells["No_45"].Value.ToString())
                           + Int32.Parse(dataGridViewDown.Rows[SelectedRowIndex].Cells["No_46"].Value.ToString());
                    int curentSum = Int32.Parse(dataGridViewDown.Rows[SelectedRowIndex].Cells["Total"].Value.ToString());
                    if (newSum != curentSum)
                    {
                        this.dataGridViewDown.Rows[SelectedRowIndex].Cells["Total"].Value = newSum;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(string.Concat(ex));
                }
            }
            if (e.ColumnIndex >= 7 && e.ColumnIndex <=14)
            {
                try
                {
                    //int upValueForMinuend = Int32.Parse(this.dataGridViewUp.Rows[0].Cells[e.ColumnIndex].Value.ToString());
                    //int downValueSubtrahend = Int32.Parse(this.dataGridViewDown.Rows[enteredValue].Cells[e.ColumnIndex].Value.ToString());
                    //int resultValue = upValueForMinuend - downValueSubtrahend;

                    int[] ostatik = { Int32.Parse(this.dataGridViewUp.Rows[0].Cells[7].Value.ToString()),
                                      Int32.Parse(this.dataGridViewUp.Rows[0].Cells[8].Value.ToString()),
                                      Int32.Parse(this.dataGridViewUp.Rows[0].Cells[9].Value.ToString()),
                                      Int32.Parse(this.dataGridViewUp.Rows[0].Cells[10].Value.ToString()),
                                      Int32.Parse(this.dataGridViewUp.Rows[0].Cells[11].Value.ToString()),
                                      Int32.Parse(this.dataGridViewUp.Rows[0].Cells[12].Value.ToString()),
                                      Int32.Parse(this.dataGridViewUp.Rows[0].Cells[13].Value.ToString()),
                                      Int32.Parse(this.dataGridViewUp.Rows[0].Cells[14].Value.ToString()),
                                      Int32.Parse(this.dataGridViewUp.Rows[0].Cells[15].Value.ToString())};

                    int[] minued = { Int32.Parse(this.dataGridViewDown.Rows[enteredValue].Cells[7].Value.ToString()),
                                     Int32.Parse(this.dataGridViewDown.Rows[enteredValue].Cells[8].Value.ToString()),
                                     Int32.Parse(this.dataGridViewDown.Rows[enteredValue].Cells[9].Value.ToString()),
                                     Int32.Parse(this.dataGridViewDown.Rows[enteredValue].Cells[10].Value.ToString()),
                                     Int32.Parse(this.dataGridViewDown.Rows[enteredValue].Cells[11].Value.ToString()),
                                     Int32.Parse(this.dataGridViewDown.Rows[enteredValue].Cells[12].Value.ToString()),
                                     Int32.Parse(this.dataGridViewDown.Rows[enteredValue].Cells[13].Value.ToString()),
                                     Int32.Parse(this.dataGridViewDown.Rows[enteredValue].Cells[14].Value.ToString()),
                                     Int32.Parse(this.dataGridViewDown.Rows[enteredValue].Cells[15].Value.ToString())};

                    
                    for (int i = 0; i < 9; i++)
                    {
                        result[i] = ostatik[i] - minued[i];
                    }
                    lbl_39.Text = result[0].ToString();
                    lbl_40.Text = result[1].ToString();
                    lbl_41.Text = result[2].ToString();
                    lbl_42.Text = result[3].ToString();
                    lbl_43.Text = result[4].ToString();
                    lbl_44.Text = result[5].ToString();
                    lbl_45.Text = result[6].ToString();
                    lbl_46.Text = result[7].ToString();
                    lbl_Total.Text = result[8].ToString();
                    

                    //if (resultValue < 0)
                    //{
                    //    MessageBox.Show(mesageNegative);
                    //    this.dataGridViewUp.Rows[0].Cells[e.ColumnIndex].Value = upValueForMinuend;
                    //    this.dataGridViewDown.Rows[0].Cells[e.ColumnIndex].Value = 0;
                    //}
                    //else
                    //{
                    //    this.dataGridViewUp.Rows[0].Cells[e.ColumnIndex].Value = resultValue;
                    //}
                    CalculationLavesTotal();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(string.Concat(ex));
                }
            }
        }

        private void cmb_Run_Click(object sender, EventArgs e)
        {
            try
            {
                DataTableManufactured.Clear();
                DataTableManufactured = GetAllItemsManufactoring();
                dataGridViewDown.DataSource = DataTableManufactured;

                int newRecord = this.dataGridViewDown.NewRowIndex;
                DataGridViewRow R = dataGridViewDown.Rows[newRecord];
                DataGridViewCell cell = R.Cells[1];
                this.dataGridViewDown.CurrentCell = cell;
                this.dataGridViewDown.BeginEdit(true);
                this.dataGridViewDown.EndEdit();
                Connection.TableLeave = "SELECT * FROM `leave` WHERE Lavoratione_ID=" + txt_Lavor.Text+ " AND Linia_ID=" + txt_Linia.Text;
                //Refresh grid
                DataTableLave.Clear();

                DataTableLave = GetAllItemsLave();
                this.dataGridViewUp.DataSource = DataTableLave;

                uint buvalaue = Convert.ToUInt32(this.dataGridViewUp.Rows[0].Cells["Bu_ID"].Value.ToString());
                this.dataGridViewDown.Rows[newRecord].Cells["Bu_ID"].Value = buvalaue;

                uint articlevalaue = Convert.ToUInt32(this.dataGridViewUp.Rows[0].Cells["Article_ID"].Value.ToString());
                this.dataGridViewDown.Rows[newRecord].Cells["Article_ID"].Value = articlevalaue;

                uint lavevalue = Convert.ToUInt32(this.dataGridViewUp.Rows[0].Cells["Lavoratione_ID"].Value.ToString());
                this.dataGridViewDown.Rows[newRecord].Cells["Lavoratione_ID"].Value = lavevalue;

                byte foundovalaue = Convert.ToByte(this.dataGridViewUp.Rows[0].Cells["Foundo_ID"].Value.ToString());
                this.dataGridViewDown.Rows[newRecord].Cells["Foundo_ID"].Value = foundovalaue;

                byte liniavalaue = Convert.ToByte(this.dataGridViewUp.Rows[0].Cells["Linia_ID"].Value.ToString());
                this.dataGridViewDown.Rows[newRecord].Cells["Linia_ID"].Value = liniavalaue;

                SendKeys.Send("{TAB}");
                SendKeys.Send("{TAB}");
                SendKeys.Send("{TAB}");
                SendKeys.Send("{TAB}");
                SendKeys.Send("{TAB}");
                SendKeys.Send("{TAB}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Concat(ex));
            }
        }

        private void txt_Lavor_TextChanged(object sender, EventArgs e)
        {
            if (txt_Lavor.Text.Length >= 6 && txt_Lavor.Text != "")
            {
                try
                {
                    int newRecord = this.dataGridViewDown.NewRowIndex;
                    DataGridViewRow R = dataGridViewDown.Rows[newRecord];
                    DataGridViewCell cell = R.Cells[1];
                    this.dataGridViewDown.CurrentCell = cell;
                    this.dataGridViewDown.BeginEdit(true);
                    this.dataGridViewDown.EndEdit();

                    Connection.TableLeave = "SELECT * FROM `leave` WHERE Lavoratione_ID=" + txt_Lavor.Text;

                    //Refresh grid
                    DataTableLave.Clear();
                    DataTableLave = GetAllItemsLave();
                    this.dataGridViewUp.DataSource = DataTableLave;

                    uint buvalaue = Convert.ToUInt32(this.dataGridViewUp.Rows[0].Cells["Bu_ID"].Value.ToString());
                    this.dataGridViewDown.Rows[newRecord].Cells["Bu_ID"].Value = buvalaue;

                    uint articlevalaue = Convert.ToUInt32(this.dataGridViewUp.Rows[0].Cells["Article_ID"].Value.ToString());
                    this.dataGridViewDown.Rows[newRecord].Cells["Article_ID"].Value = articlevalaue;

                    uint lavevalue = Convert.ToUInt32(this.dataGridViewUp.Rows[0].Cells["Lavoratione_ID"].Value.ToString());
                    this.dataGridViewDown.Rows[newRecord].Cells["Lavoratione_ID"].Value = lavevalue;

                    byte foundovalaue = Convert.ToByte(this.dataGridViewUp.Rows[0].Cells["Foundo_ID"].Value.ToString());
                    this.dataGridViewDown.Rows[newRecord].Cells["Foundo_ID"].Value = foundovalaue;

                    byte liniavalaue = Convert.ToByte(this.dataGridViewUp.Rows[0].Cells["Linia_ID"].Value.ToString());
                    this.dataGridViewDown.Rows[newRecord].Cells["Linia_ID"].Value = liniavalaue;
                    bool moreLiniaBuldRhisLavoratione = dataGridViewUp.RowCount > 1;
                    if (moreLiniaBuldRhisLavoratione)
                    {
                        this.dataGridViewUp.Columns["Linia_ID"].DefaultCellStyle.BackColor = Color.Red;
                    }
                    SendKeys.Send("{TAB}");
                    SendKeys.Send("{TAB}");
                    SendKeys.Send("{TAB}");
                    SendKeys.Send("{TAB}");
                    SendKeys.Send("{TAB}");
                    SendKeys.Send("{TAB}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(string.Concat(ex));
                }
            }
        }
    }
}
