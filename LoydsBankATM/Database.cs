using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;

namespace LoydsBankATM
{
    public class Database
    {
        
        protected string connstring = ConfigurationManager.ConnectionStrings["LoydsBankDB"].ConnectionString;
        

        public SqlConnection connection()
        {


            //we need the database address as an string
            string str = connstring;
            SqlConnection con;
            

            try
            {


                //creating connection with the database address
                con = new SqlConnection(str);

                //open connection
                con.Open();
                //writing a massage that databas is connected

                return con;

            } //catch for any error from sql
            catch (SqlException x)
            {
                con = new SqlConnection("");
                MessageBox.Show(x.Message);
                return con;
            }

        }
        
    }
}
