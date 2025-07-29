using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;


namespace MinecraftBlockIndex
{
    static class AddBlockDB
    {
        private static SqlConnection GetDatabaseConnection()
        {
            // Establish a connection to the database
            return new SqlConnection("Data Source=localhost;Initial Catalog=MinecraftBlockIndex;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");

        }
    }
}
