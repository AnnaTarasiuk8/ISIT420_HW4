using ISIT420_HW4_Tarasiuk_Gurskaia.Models;
using ISIT420_HW4_Tarasiuk_Gurskaia.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ISIT420_HW4_Tarasiuk_Gurskaia.Services
{
    public class DataService : ICDDataService, ISalesPersonDataService, IStoreDataService
    {
        private string ConnectionPath = "Data Source=.\\SQLExpress;Initial Catalog=NodeOrders500;User Id=taras;Password=1991;Trusted_Connection=True;";
        private SqlConnection connection;
        public DataService()
        {
            CreateConnection();
        }

        public List<CD> GetAllCD()
        {
            CreateConnection();
            List<CD> allCD = null;

            DataTable table = new DataTable();
            FillTable(ref table, "get_all_cd");
            Console.WriteLine("HELLO!");
            if (table.Rows.Count > 0)
            {
                allCD = new List<CD>();
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    allCD.Add(new CD(
                        int.Parse(table.Rows[i].ItemArray[0].ToString().TrimEnd()),
                        table.Rows[i].ItemArray[1].ToString().TrimEnd(),
                        table.Rows[i].ItemArray[2].ToString().TrimEnd(),
                        table.Rows[i].ItemArray[3].ToString().TrimEnd(),
                        int.Parse(table.Rows[i].ItemArray[4].ToString().TrimEnd()),
                        double.Parse(table.Rows[i].ItemArray[5].ToString().TrimEnd())));
                }
            }
            return allCD;
        }

        public List<SalesPerson> GetAllSalesPerson()
        {
            CreateConnection();
            List<SalesPerson> allSalesPerson = null;
            DataTable table = new DataTable();
            FillTable(ref table, "get_all_sales_person");
            if (table.Rows.Count > 0)
            {
                allSalesPerson = new List<SalesPerson>();
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    allSalesPerson.Add(new SalesPerson(
                        int.Parse(table.Rows[i].ItemArray[0].ToString().TrimEnd()),
                        table.Rows[i].ItemArray[1].ToString().TrimEnd(),
                        table.Rows[i].ItemArray[2].ToString().TrimEnd(),
                        int.Parse(table.Rows[i].ItemArray[3].ToString().TrimEnd()),
                        int.Parse(table.Rows[i].ItemArray[4].ToString().TrimEnd())));
                }
            }
            return allSalesPerson;
        }

        public List<Store> GetAllStores()
        {
            CreateConnection();
            List<Store> allStores = null;
            DataTable table = new DataTable();
            FillTable(ref table, "get_all_store");
            if (table.Rows.Count > 0)
            {
                allStores = new List<Store>();
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    allStores.Add(new Store(
                        int.Parse(table.Rows[i].ItemArray[0].ToString().TrimEnd()),
                        table.Rows[i].ItemArray[1].ToString().TrimEnd(),
                        table.Rows[i].ItemArray[2].ToString().TrimEnd(),
                        int.Parse(table.Rows[i].ItemArray[3].ToString().TrimEnd())));
                }
            }
            return allStores;
        }

        private void CreateConnection()
        {
            if (connection != null) return;
            connection = new SqlConnection(ConnectionPath);
            connection.Open();
        }
        private void FillTable(ref DataTable table, string procedure, string[] parameters = null, object[] values = null)
        {
            using (SqlCommand sqlCommand = new SqlCommand(procedure, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand))
            {
                sqlCommand.CommandType = CommandType.StoredProcedure;
                if (parameters != null && values != null)
                {
                    for (int i = 0; i < parameters.Length; i++)
                    {
                        sqlCommand.Parameters.AddWithValue(parameters[i], values[i]);
                    }
                }

                adapter.Fill(table);
            }
        }
    }
}