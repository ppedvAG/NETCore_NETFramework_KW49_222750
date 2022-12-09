using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADONET_WithNET7
{
    static class  Program
    {
        public static void Main(string[] args) 
        {
            System_Data_SqlClient sqlClient = new System_Data_SqlClient();

            sqlClient.Sample();
            sqlClient.Sample_DataReader();
        }

    }
}
