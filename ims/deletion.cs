using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace ims
{
    class deletion
    {
        public void delete(object id,string proc, string param)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(proc, MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue(param,id);
   
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
                MainClass.showMG("Data Deleted Successfully", "Success....", "success");

            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.showMG(ex.Message, "Error", "Error");
            }
        }


    }
}
