using BusinessLayer.Models;
using DataAccess;
using Microsoft.Data.SqlClient;
using System.Data;

namespace BusinessLayer
{
    public class ItemCRUD
    {
        //Item myItem { get; set; }

        public DataSet GetAllItems()
        {
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection connection = new SqlConnection(SqlHelper.connectionstring()))
                {
                    connection.Open();

                    string sql = "Select * From [dbo].[Items]";

                    using (SqlCommand cmd = new SqlCommand(sql, connection))
                    {
                       SqlDataAdapter adapter = new SqlDataAdapter();
                        adapter.SelectCommand = cmd;
                        adapter.Fill(ds);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return ds;
        }
        public void CreateItem(Item myItem)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(SqlHelper.connectionstring()))
                {
                    connection.Open();

                    string sql = "INSERT INTO [dbo].[Items] ([Name] ,[Quantity] ,[Supplier] ,[Category] ,[Price] ,[ReorderLevel] ,[CreatedAt]) VALUES (@Name ,@Quantity ,@Supplier ,@Category ,@Price ,@ReorderLevel ,GETDATE())";

                    using (SqlCommand cmd = new SqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@Name", myItem.Name);
                        cmd.Parameters.AddWithValue("@Quantity", myItem.Quantity);
                        cmd.Parameters.AddWithValue("@Supplier", myItem.Supplier);
                        cmd.Parameters.AddWithValue("@Category", myItem.Category);
                        cmd.Parameters.AddWithValue("@Price", myItem.Price);
                        cmd.Parameters.AddWithValue("@ReorderLevel", myItem.ReorderLevel);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);    
            }
        }
        public void UpdateItem(Item myItem)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(SqlHelper.connectionstring()))
                {
                    connection.Open();

                    string sql = "UPDATE [dbo].[Items] SET [Name] = @Name ,[Quantity] = @Quantity ,[Supplier] = @Supplier ,[Category] = @Category ,[Price] = @Price ,[ReorderLevel] = @ReorderLevel ,[CreatedAt] = GETDATE() WHERE (ItemId = @ItemId)";

                    using (SqlCommand cmd = new SqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@ItemId", myItem.ItemId);
                        cmd.Parameters.AddWithValue("@Name", myItem.Name);
                        cmd.Parameters.AddWithValue("@Quantity", myItem.Quantity);
                        cmd.Parameters.AddWithValue("@Supplier", myItem.Supplier);
                        cmd.Parameters.AddWithValue("@Category", myItem.Category);
                        cmd.Parameters.AddWithValue("@Price", myItem.Price);
                        cmd.Parameters.AddWithValue("@ReorderLevel", myItem.ReorderLevel);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public void DeleteItem(Item myItem)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(SqlHelper.connectionstring()))
                {
                    connection.Open();

                    string sql = "DELETE FROM [dbo].[Items]  WHERE (ItemId = @ItemId)";

                    using (SqlCommand cmd = new SqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@ItemId", myItem.ItemId);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
