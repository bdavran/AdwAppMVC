using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdwApp;
using AdwApp.Entity;
using System.Data.SqlClient;
using System.Data;

namespace AdwApp.DAL
{
    public class PersonDAL
    {
        private DBConnection dbConnection;

        public PersonDAL()
        {
            dbConnection = new DBConnection();
        }

        public List<Address> GetAllItems()
        {

            SqlCommand cmd = dbConnection.GetSqlCommand();
            cmd.CommandText = "SELECT * FROM Person.Address";

            List<Address> addresses = new List<Address>();
            SqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {

                Address address = new Address()
                {

                    AddressID = Convert.ToInt32(rdr.["AddressID"]),
                    AddressLine1 = rdr.["AddressLine1"].ToString(),
                    AddressLine2 = rdr.["AddressLine2"].ToString(),
                    City = rdr.["City"].ToString(),
                    StateProvinceID = Convert.ToInt32(rdr.["StateProvinenceID"]),
                    PostalCode = rdr.["PostalCode"].ToString(),
                    SpatialLocation = Convert.ToInt32(rdr["SpatialLocation"]),
                    rowguid = Convert.ToInt32(rdr.["rowduid"]),
                };


                addresses.Add(address);

            }
            return addresses;




        }

        public void AddNewItem(Address address)
        {

            string cmdText = "INSERT INTO [Person].[Address] ([AddressID] , [AddressLine1] , [AddressLine2] ,[City] , [StateProvinceID] , [PostalCode] , [SpatialLocation] , [rowguid]) ";
            cmdText += String.Format("VALUES({1}, '{2}', '{3}', '{4}' , {5} , '{6}', {7} , {8})",address.AddressID , address.AddressLine1 , address.AddressLine2 , address.City , address.StateProvinceID , address.PostalCode , address.SpatialLocation , address.rowguid);

            SqlCommand cmd = dbConnection.GetSqlCommand();
            cmd.CommandText = cmdText;

            cmd.ExecuteNonQuery();

        }
    }

    public void DeleteItemById()
    {

        string cmdText = "DELETE FROM 
    }
}
