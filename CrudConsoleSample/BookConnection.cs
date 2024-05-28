using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;
using CrudConsoleSample;

namespace CrudConsoleSample1234
{
     public class BookConnection
    {
        
        string ConnectValues;

        public BookConnection()
        {
            ConnectValues = "Data source=DESKTOP-Q9V2K5P\\SQLEXPRESS;Initial Catalog=CONSOLE;User id=sa;password=Anaiyaan@123;";

        }
        public void SignUp1(BookShop Regis)
        {
            try

            {

                var InsertSql = $"Insert into  BookShop values('{Regis.BookName}','{Regis.Authour}','{Regis.ToatalNoPages}','{Regis.PublishedBy}',{Regis.ContactNo})";
              //  var ConnectValues = "Data source=DESKTOP-Q9V2K5P\\SQLEXPRESS;Initial Catalog=batch-8;User id=sa;password=Anaiyaan@123;";
                SqlConnection connection = new SqlConnection(ConnectValues);
                connection.Open();
                connection.Execute(InsertSql);
                connection.Close();

            }

            catch (SqlException ex)
            {
                throw;
            }
            catch (Exception ex)

            {
                throw;
            }

        }

        public IEnumerable<BookShop> SignUpUpdate(string a, string b)
        {
            try
            {


                {

                    var UpdateSql = $" UPdate  BookShop set ToatalNoPages= '{b}' where BookName ='{a}';";



                    SqlConnection connection = new SqlConnection(ConnectValues);
                    connection.Open();
                    var selectsall = connection.Query<BookShop>(UpdateSql);
                    connection.Close();
                    return selectsall;
                }
            }
            catch (SqlException ex)
           {
                throw;
           }
            catch (Exception ex)
            {
                throw;
            }
        }



        //public object SignUpUpdate(string b)
        //{
        //    throw new NotImplementedException();
        //}

        public IEnumerable<BookShop> DeleteTable(string BookName)

        {
            try
            {
                var DeleteSql = $"Delete from BookShop where BookName='{BookName}';";
                SqlConnection connection = new SqlConnection(ConnectValues);
                connection.Open();
                var selectsall = connection.Query<BookShop>(DeleteSql);
                connection.Close();
                return selectsall;
            }
            catch (SqlException ex)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public IEnumerable<BookShop> Select()

        {
            try
            {
                var selectquary = $"select * from BookShop ";
                SqlConnection connection = new SqlConnection(ConnectValues);
                connection.Open();
               var selectsall = connection.Query<BookShop>(selectquary);
                connection.Close();
                return selectsall;


            }
            catch (SqlException ex)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public IEnumerable<BookShop> valid(string BookName)
        {
            try
            {


                var validquary = $"select * from BookShop where BookName like '%{BookName}%'";

                SqlConnection connection = new SqlConnection(ConnectValues);
                connection.Open();
                var validsall = connection.Query<BookShop>(validquary);
                connection.Close();
                return validsall;
            }
            catch (SqlException ex)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw;
            }

        }
    }
}
