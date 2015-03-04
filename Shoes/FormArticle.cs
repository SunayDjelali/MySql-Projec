﻿namespace Shoes
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
                adapterArticle.UpdateCommand = new MySqlCommand("UPDATE article SET ArticleNo=@ArticleNo, Updated_Dt=NOW() WHERE ArticleNo=@ArticleNo;", connection);
                adapterArticle.UpdateCommand.Parameters.Add("@ArticleNo", MySqlDbType.Int32, 11, "ArticleNo");
                adapterArticle.UpdateCommand.UpdatedRowSource = UpdateRowSource.None;

                // Set the INSERT command and parameter.
                adapterArticle.InsertCommand = new MySqlCommand("INSERT INTO article VALUES (@ArticleNo, NOW());", connection);
                adapterArticle.InsertCommand.Parameters.Add("@ArticleNo", MySqlDbType.Int32, 11, "ArticleNo");
                adapterArticle.InsertCommand.UpdatedRowSource = UpdateRowSource.None;

                // Set the DELETE command and parameter.
                adapterArticle.DeleteCommand = new MySqlCommand("DELETE FROM article WHERE ArticleNo=@ArticleNo;", connection);
                adapterArticle.DeleteCommand.Parameters.Add("@ArticleNo", MySqlDbType.Int32, 11, "ArticleNo");

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
            //dataGridViewArt.ClearSelection(); 
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
        public int ReturnValueArt 
        {
            get
            {
                try
                {
                    //if (one)
                    //{
                    //    this.Close();
                    //}
                    return int.Parse(dataGridViewArt.SelectedCells[0].Value.ToString());
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
        }
    }
}