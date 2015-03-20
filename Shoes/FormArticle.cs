namespace Shoes
{
    using MySql.Data.MySqlClient;
    using System;
    using System.Data;
    using System.Windows.Forms;
    public partial class FormArticle : Form
    {
        public FormArticle()
        {
            InitializeComponent();
        }

        //Read connection string from application settings = App.config.xml
        private string ConnectionString = Connection.MyConnectionString;
        private MySqlConnection connection;
        private MySqlDataAdapter adapterArticle;
        private DataTable DTArticle;

        private DataTable GetAllItems()
        {
            try
            {
                //prepare query to get all records from Article table
                //prepare adapter to run query
                this.adapterArticle = new MySqlDataAdapter(Connection.TableArticle, this.connection);
                DataSet DSArticle = new DataSet();
                //get query results in dataset
                this.adapterArticle.Fill(DSArticle);

                // Set the UPDATE command and parameters.
                this.adapterArticle.UpdateCommand = new MySqlCommand("UPDATE article SET ArticleNo=@ArticleNo, Updated_Dt=NOW() WHERE ArticleNo=@ArticleNo;", this.connection);
                this.adapterArticle.UpdateCommand.Parameters.Add("@ArticleNo", MySqlDbType.Int32, 11, "ArticleNo");
                this.adapterArticle.UpdateCommand.UpdatedRowSource = UpdateRowSource.None;

                // Set the INSERT command and parameter.
                this.adapterArticle.InsertCommand = new MySqlCommand("INSERT INTO article VALUES (@ArticleNo, NOW());", this.connection);
                this.adapterArticle.InsertCommand.Parameters.Add("@ArticleNo", MySqlDbType.Int32, 11, "ArticleNo");
                this.adapterArticle.InsertCommand.UpdatedRowSource = UpdateRowSource.None;

                // Set the DELETE command and parameter.
                this.adapterArticle.DeleteCommand = new MySqlCommand("DELETE FROM article WHERE ArticleNo=@ArticleNo;", this.connection);
                this.adapterArticle.DeleteCommand.Parameters.Add("@ArticleNo", MySqlDbType.Int32, 11, "ArticleNo");

                //return datatable with all records
                return DSArticle.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        public void GoLastCell()
        {
            int lastRow = dataGridViewArt.RowCount - 1;
            this.dataGridViewArt.CurrentCell = dataGridViewArt.Rows[lastRow].Cells[0];

        }

        private void cmb_Article_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormArticle_Load(object sender, EventArgs e)
        {
            //Initialize mysql connection
            this.connection = new MySqlConnection(this.ConnectionString);
            //Get all items in datatable
            this.DTArticle = this.GetAllItems();
            //Fill grid with items
            this.dataGridViewArt.DataSource = this.DTArticle;
            dataGridViewArt.Columns["Updated_Dt"].ReadOnly = true;
            GoLastCell();
            lbl_Msg.Text = "";
        }

        private void cmb_Save_Art_Click(object sender, EventArgs e)
        {
            try
            {
                //Save records in database using DTArticle which is datasource for Grid
                this.adapterArticle.Update(this.DTArticle);
                //Refresh grid
                this.DTArticle = this.GetAllItems();
                this.dataGridViewArt.DataSource = this.DTArticle;
                GoLastCell();
                lbl_Msg.Text = "Items saved successfully...";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmb_Delete_Art_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewArt.SelectedRows.Count > 0)
            {
                //Delete a row from grid first.
                this.dataGridViewArt.Rows.Remove(this.dataGridViewArt.SelectedRows[0]);
                //Save records again. This will delete record from database.
                this.adapterArticle.Update(this.DTArticle);
                //Refresh grid. Get items Bu again from database and show it in grid.
                this.DTArticle = this.GetAllItems();
                this.dataGridViewArt.DataSource = this.DTArticle;
                GoLastCell();
                lbl_Msg.Text = "Selected item deleted successfully...";
            }
            else
            {
                MessageBox.Show("You must select entire row in order to delete it.");
            }
        }

        private void dataGridViewArt_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            base.Close();
        }

        public int ReturnValueArt
        {
            get
            {
                int result;
                try
                {
                    result = int.Parse(this.dataGridViewArt.SelectedCells[0].Value.ToString());
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
