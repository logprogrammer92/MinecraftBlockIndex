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
            return new SqlConnection("Data Source=localdb;Initial Catalog=MinecraftBlockIndex;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");

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
        public static void Update(AddBlock block)
        {
            throw new NotImplementedException();
        }
        public static void Delete(AddBlock block) 
        {
            throw new NotImplementedException();
        }
        public static void GetBlock(int BlockID)
        {
            throw new NotImplementedException();
        }
    }
}
