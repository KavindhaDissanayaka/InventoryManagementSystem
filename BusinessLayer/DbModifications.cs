using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Microsoft.Data.SqlClient;

namespace BusinessLayer
{
    public class DbModifications
    {
        public void CreateTable()
        {
            try
            {

                using (SqlConnection connection = new SqlConnection(SqlHelper.connectionstring()))
                {
                    connection.Open();

                    // Create tables if they don't exist
                    string[] createTableQueries = {
                    @"
                    IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Items')
                    BEGIN
                        CREATE TABLE Items (
                            ItemId INT IDENTITY(1,1) PRIMARY KEY,
                            Name VARCHAR(100) NOT NULL,
                            Quantity INT DEFAULT 0,
                            Supplier VARCHAR(100),
                            Category VARCHAR(50),
                            Price DECIMAL(10,2),
                            ReorderLevel INT DEFAULT 0,
                            CreatedAt DATETIME DEFAULT GETDATE()
                        )
                    END;
                    ",

                    @"
                    IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Warehouses')
                    BEGIN
                        CREATE TABLE Warehouses (
                            WarehouseId INT IDENTITY(1,1) PRIMARY KEY,
                            Name VARCHAR(100) NOT NULL,
                            Location VARCHAR(255),
                            Capacity INT DEFAULT 0,
                            CreatedAt DATETIME DEFAULT GETDATE()
                        )
                    END;
                    "
                };
                    foreach (var query in createTableQueries)
                    {
                        using (SqlCommand cmd = new SqlCommand(query, connection))
                        {
                            cmd.ExecuteNonQuery();
                        }
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
