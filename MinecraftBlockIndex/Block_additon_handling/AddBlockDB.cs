using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using MinecraftBlockIndex.Block_additon_handling;


namespace MinecraftBlockIndex.Block_additon_handling
{
    static class AddBlockDB
    {
        /// <summary>
        /// This method establishes a connection to the database.
        /// </summary>
        /// <returns></returns>
        private static SqlConnection GetDatabaseConnection()
        {
            // Establish a connection to the database
            return new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=MinecraftBlockIndex;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }

        /// <summary>
        /// Adds a block to the database.
        /// </summary>
        /// <param name="block">The block to be added</param>
        public static void Add(AddBlock block)
        {
            // Establish connection to database
            SqlConnection con = GetDatabaseConnection();

            // Prepare insert statement
            SqlCommand insertCmd = new SqlCommand();
            insertCmd.Connection = con;
            insertCmd.CommandText = "INSERT INTO AddBlock(BlockName, IsBurnable, IsTransparent, IsFull, EmitsLight)" +
                "VALUES (@name, @isBurnable, @isTransparent, @isFull, @EmitsLight)";
            insertCmd.Parameters.AddWithValue("@name", block.BlockName);
            insertCmd.Parameters.AddWithValue("@isBurnable", block.IsBurnable);
            insertCmd.Parameters.AddWithValue("@isTransparent", block.IsTransparent);
            insertCmd.Parameters.AddWithValue("@isFull", block.IsFull);
            insertCmd.Parameters.AddWithValue("@EmitsLight", block.EmitsLight);

            // Open connection to database
            con.Open();

            // Execute insert query
            insertCmd.ExecuteNonQuery();

            // Close connection to database
            con.Close();
        }

        /// <summary>
        /// Updates a block in the database.
        /// </summary>
        /// <param name="block"></param>
        /// <returns>Number of rows affected</returns>
        public static int Update(AddBlock block)
        {
            // Establish connection to database
            SqlConnection con = GetDatabaseConnection();

            // Prepare insert statement
            SqlCommand updateCmd = new SqlCommand();
            updateCmd.Connection = con;

            updateCmd.CommandText = "UPDATE AddBlock SET BlockName = @name, IsBurnable = @isBurnable, " +
                "IsTransparent = @isTransparent, IsFull = @isFull, EmitsLight = @EmitsLight " +
                "WHERE BlockId = @BlockId;";
            updateCmd.Parameters.AddWithValue("@name", block.BlockName);
            updateCmd.Parameters.AddWithValue("@isBurnable", block.IsBurnable);
            updateCmd.Parameters.AddWithValue("@isTransparent", block.IsTransparent);
            updateCmd.Parameters.AddWithValue("@isFull", block.IsFull);
            updateCmd.Parameters.AddWithValue("@EmitsLight", block.EmitsLight);
            updateCmd.Parameters.AddWithValue("@BlockId", block.BlockId);


            // Open connection to database
            con.Open();

            // Execute insert query
            int numOfRows = updateCmd.ExecuteNonQuery();

            // Close connection to database
            con.Close();
            return numOfRows;
        }

        /// <summary>
        /// Deletes a block from the database.
        /// </summary>
        /// <param name="block"></param>
        public static void Delete(AddBlock block) 
        {
            // Establish connection to database
            SqlConnection con = GetDatabaseConnection();

            // Prepare insert statement
            SqlCommand deleteCommand = new SqlCommand();
            deleteCommand.Connection = con;

            deleteCommand.CommandText = "DELETE FROM AddBlock WHERE BlockId = @BlockId";

            deleteCommand.Parameters.AddWithValue("@BlockId", block.BlockId);


            // Open connection to database
            con.Open();

            // Execute insert query
            deleteCommand.ExecuteNonQuery();

            // Close connection to database
            con.Close();
        }

        /// <summary>
        /// Retrieves a block from the database by its ID.
        /// </summary>
        /// <param name="BlockID"></param>
        public static void GetBlock(int BlockID)
        {
            // Establish connection to database
            SqlConnection con = GetDatabaseConnection();

            // Prepare insert statement
            SqlCommand getCommand = new SqlCommand();
            getCommand.Connection = con;

            getCommand.CommandText = "SELECT BlockID, BlockName, IsBurnable, IsTransparent, IsFull, EmitsLight" + 
                "FROM AddBlock WHERE BlockId = @BlockId";

            getCommand.Parameters.AddWithValue("@BlockId", BlockID);

            // Open connection to database
            con.Open();

            // Execute insert query
            getCommand.ExecuteNonQuery();

            // Close connection to database
            con.Close();
        }

        /// <summary>
        /// Retrieves all blocks from the database.
        /// </summary>
        /// <returns></returns>
        public static List<AddBlock> GetAllBlocks()
        {
            // Get connection
            SqlConnection conn = GetDatabaseConnection();

            // Prepare the query
            SqlCommand selCmd = new SqlCommand();
            selCmd.Connection = conn;
            selCmd.CommandText = "SELECT BlockID, BlockName, IsBurnable, IsTransparent, IsFull, EmitsLight" +
                " FROM AddBlock";

            conn.Open();

            // Execute the query and use results
            SqlDataReader reader = selCmd.ExecuteReader();

            List<AddBlock> blocks = new();
            while (reader.Read())
            {
                int blockId = Convert.ToInt32(reader["BlockId"]);
                string blockName = reader["BlockName"].ToString();
                bool isBurnable = reader.GetBoolean(reader.GetOrdinal(name: "IsBurnable"));
                bool isTransparent = reader.GetBoolean(reader.GetOrdinal(name: "IsTransparent"));
                bool isFull = reader.GetBoolean(reader.GetOrdinal(name: "IsFull"));
                bool emitsLight = reader.GetBoolean(reader.GetOrdinal(name: "EmitsLight"));


                AddBlock tempBlock = new AddBlock(blockName, isBurnable, isTransparent, isFull, emitsLight);
                tempBlock.BlockId = blockId;

                blocks.Add(tempBlock);
            }

            // Close the connection
            conn.Close();

            // Return list of customers
            return blocks;
        }
    }
}
