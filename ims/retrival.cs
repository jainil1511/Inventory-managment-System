using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;



namespace ims
{
    class retrival
    {
        public void Showusers(DataGridView gv, DataGridViewColumn userIDGV, DataGridViewColumn nameGV, DataGridViewColumn usernameGV, DataGridViewColumn passGV, DataGridViewColumn emailGV, DataGridViewColumn phoneGV, DataGridViewColumn statusGV,string data= null)
        {
            try
            {

                SqlCommand cmd;
                if(data == null)
                {
                     cmd = new SqlCommand("st_getusersData", MainClass.con);
                }
                else
                {
                    cmd = new SqlCommand("st_getusersDataLike", MainClass.con);
                    cmd.Parameters.AddWithValue("@data", data);
                }
              
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                userIDGV.DataPropertyName = dt.Columns["ID"].ToString();
                nameGV.DataPropertyName = dt.Columns["Name"].ToString();
                usernameGV.DataPropertyName = dt.Columns["Username"].ToString();
                passGV.DataPropertyName = dt.Columns["Password"].ToString();
                emailGV.DataPropertyName = dt.Columns["Email"].ToString();
                phoneGV.DataPropertyName = dt.Columns["Phone"].ToString();
                statusGV.DataPropertyName = dt.Columns["Status"].ToString();
                gv.DataSource = dt;
            }
            catch(Exception)
            {

            }
        }

      
            public void ShowCategories(DataGridView gv, DataGridViewColumn catIDGV, DataGridViewColumn catnameGV, DataGridViewColumn statusGV)
            {
                try
                {

                    SqlCommand cmd = new SqlCommand("st_getCategoriesData", MainClass.con);
               
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    catIDGV.DataPropertyName = dt.Columns["ID"].ToString();
                    catnameGV.DataPropertyName = dt.Columns["Category"].ToString();              
                    statusGV.DataPropertyName = dt.Columns["Status"].ToString();
                    gv.DataSource = dt;
                }
                catch (Exception)
                {
                MainClass.showMG("unable to Load Categories Data","Error","Error");
                }
            }

        public void getList(string proc, ComboBox cb, string displayMember, string valueMember)
        {
            try
            {
                cb.Items.Clear();
                cb.DataSource = null;
                cb.Items.Insert(0, "Select...");             
                SqlCommand cmd = new SqlCommand(proc, MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataRow dr = dt.NewRow();
                dr.ItemArray = new object[] { 0, "Select..." };
                dt.Rows.InsertAt(dr,0);               
                cb.DisplayMember = displayMember;
                cb.ValueMember = valueMember;
                cb.DataSource = dt;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void getListWithTwoParameters(string proc, ComboBox cb, string displayMember, string valueMember,string param1,object val1,string param2,object val2)
        {
            try
            {
                //cb.Items.Clear();
                cb.DataSource = null;
         
                SqlCommand cmd = new SqlCommand(proc, MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue(param1, val1);
                cmd.Parameters.AddWithValue(param2, val2);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataRow dr = dt.NewRow();
                dr.ItemArray = new object[] { 0, "Select..." };
                dt.Rows.InsertAt(dr, 0);
                cb.DisplayMember = displayMember;
                cb.ValueMember = valueMember;
                cb.DataSource = dt;



            }
            catch (Exception )
            { 
                throw;
            }
        }



        private object productStockCount = 0;
        public  object getProductQuantity(Int64 proID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getProductQuantity", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@proID", proID);
                    
            
                MainClass.con.Open();
                productStockCount = cmd.ExecuteScalar();
         
                MainClass.con.Close();
            }
            catch (Exception) { }
            return productStockCount;
        }
        public object getProductQuantityWithoutConnection(Int64 proID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getProductQuantity", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@proID", proID);               
                productStockCount = cmd.ExecuteScalar();

             
            }
            catch (Exception) { }
            return productStockCount;
        }

        public void showProducts(DataGridView gv, DataGridViewColumn proIDGV, DataGridViewColumn pronameGV, DataGridViewColumn expiryGV,DataGridViewColumn catGV,DataGridViewColumn barGV,DataGridViewColumn catIDGV)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("st_getProductsData", MainClass.con);

                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                proIDGV.DataPropertyName = dt.Columns["Product ID"].ToString();
                pronameGV.DataPropertyName = dt.Columns["Product"].ToString();
                expiryGV.DataPropertyName = dt.Columns["Expiry"].ToString();
                barGV.DataPropertyName = dt.Columns["Barcode"].ToString();
                 
                catGV.DataPropertyName = dt.Columns["Category"].ToString();
                catIDGV.DataPropertyName = dt.Columns["Category ID"].ToString();

                gv.DataSource = dt;
            }
            catch (Exception)
            {
                MainClass.showMG("unable to Load Categories Data", "Error", "Error");
            }
        }
        public void showPurchaseInvoiceDetails(Int64 pid,DataGridView gv,DataGridViewColumn mPIDGV, DataGridViewColumn proIDGV, DataGridViewColumn pronameGV, DataGridViewColumn quantGV, DataGridViewColumn pupGV, DataGridViewColumn totGV)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("st_getPurchaseInvoiceDetails", MainClass.con);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pid ",pid);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                mPIDGV.DataPropertyName = dt.Columns["mPID"].ToString();
                proIDGV.DataPropertyName = dt.Columns["Product ID"].ToString();
                pronameGV.DataPropertyName = dt.Columns["Product"].ToString();
                pupGV.DataPropertyName = dt.Columns["Per Unit Price"].ToString();
                totGV.DataPropertyName = dt.Columns["Total Price"].ToString();
                quantGV.DataPropertyName = dt.Columns["Quantity"].ToString();
     

                gv.DataSource = dt;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static int USER_ID
        {
            get;
            private set;
        }
        public static string EMP_NAME
        {
            get;
            private set;

        }
        private static string user_name=null, pass_word=null;
        private static bool checkLogin;
        public static  bool  getUserDetails(string username,string password)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getUserDetail", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@user",username);
                cmd.Parameters.AddWithValue("@pass",password);
                MainClass.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    checkLogin = true;
                    while (dr.Read())
                    {
                        USER_ID = Convert.ToInt32(dr["ID"].ToString());
                        EMP_NAME = dr["Name"].ToString();
                        user_name = dr["Username"].ToString();
                        pass_word = dr["Password"].ToString();
                    }

                }
                else {
                    checkLogin = false;
                    if(username != null && password != null)
                    {
                        if(user_name != username && pass_word == password)
                        {
                            MainClass.showMG("Invalid UserName", "Error", "Error");
                        }
                       else if (user_name == username && pass_word != password)
                        {
                            MainClass.showMG("Invalid Password", "Error", "Error");
                        }
                        if (user_name != username && pass_word != password)
                        {
                            MainClass.showMG("Invalid UserName And Password", "Error", "Error");
                        }

                    }

                }
                
                MainClass.con.Close();
            }
            catch(Exception)
            {
                MainClass.con.Close();
                ///MainClass.showMG("Unable to Login","Error","Error");
                throw;
            }
            return checkLogin;
        }


        public void showSupplier(DataGridView gv, DataGridViewColumn suppIDGV, DataGridViewColumn comName, DataGridViewColumn personGV, 
            DataGridViewColumn phone1GV, DataGridViewColumn phone2GV, DataGridViewColumn addressGV, DataGridViewColumn ntnGV,DataGridViewColumn statusGV)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("st_getSupplierData", MainClass.con);

                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                suppIDGV.DataPropertyName = dt.Columns["ID"].ToString();
                comName.DataPropertyName  = dt.Columns["Company"].ToString();
                personGV.DataPropertyName = dt.Columns["Contact phone"].ToString();
                phone1GV.DataPropertyName = dt.Columns["Phone1"].ToString();
                phone2GV.DataPropertyName = dt.Columns["Phone2"].ToString();
                addressGV.DataPropertyName = dt.Columns["Address"].ToString();
                ntnGV.DataPropertyName = dt.Columns["NTN #"].ToString();
                statusGV.DataPropertyName = dt.Columns["Status"].ToString();

                gv.DataSource = dt;
            }
            catch (Exception)
            {
               // MainClass.showMG("unable to Load Supplier Data", "Error", "Error");
                throw;
            }
        }


        public void showStockDetails(DataGridView gv, DataGridViewColumn proIDGV, DataGridViewColumn proGV, DataGridViewColumn barcodeGV,
        DataGridViewColumn expiryGV, DataGridViewColumn bpGV, DataGridViewColumn spGV, DataGridViewColumn catGV, DataGridViewColumn avalStGV,
       DataGridViewColumn statusGV,DataGridViewColumn totGV)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("st_getAllStock", MainClass.con);

                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                proIDGV.DataPropertyName = dt.Columns["Product ID"].ToString();
                proGV.DataPropertyName = dt.Columns["Product"].ToString();
                barcodeGV.DataPropertyName = dt.Columns["Barcode"].ToString();
                expiryGV.DataPropertyName = dt.Columns["Expiry Date"].ToString();
                bpGV.DataPropertyName = dt.Columns["Buying Price"].ToString();
                spGV.DataPropertyName = dt.Columns["Selling price"].ToString();
                catGV.DataPropertyName = dt.Columns["Category"].ToString();
                avalStGV.DataPropertyName = dt.Columns["Available Stock"].ToString();               
                statusGV.DataPropertyName = dt.Columns["Status"].ToString();
                totGV.DataPropertyName = dt.Columns["Total Amount"].ToString();


                gv.DataSource = dt;
            }
            catch (Exception)
            {
                // MainClass.showMG("unable to Load Supplier Data", "Error", "Error");
                throw;
            }
        }
      
        private bool checkPPExistence;
        public bool checkproductPriceExistence(Int64 proID)
        {
            try {
                SqlCommand cmd = new SqlCommand("st_checkProductExist", MainClass.con);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@proID ", proID);
                MainClass.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    checkPPExistence = true;
                }
                else
                {
                    checkPPExistence = false;
                }
                MainClass.con.Close();

            }
            catch (Exception)
            {

            }
            return checkPPExistence;
        }
        private string[] productsData = new string[6];
        public string[] getProductsWRTBarcode(string barcode)
        {
            try
            {
                
                SqlCommand cmd = new SqlCommand("st_getProductByBarcode", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@barcode", barcode);
                MainClass.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        productsData[0] = dr[0].ToString();//proID
                        productsData[1] = dr[1].ToString();///product
                        productsData[2] = dr[2].ToString();//barcode
                        productsData[3] = dr[3].ToString();//Selling price
                        productsData[4] = dr[4].ToString();//Discount
                        productsData[5] = dr[5].ToString();// final Selling Price
                      
                    }

                }
                else
                {
                    Array.Clear(productsData, 0, productsData.Length);
                }
                MainClass.con.Close();
       
            }
            catch (Exception)
            {
                MainClass.con.Close();
              
            }
            return productsData;
        }

        public void showproductsWRTCategory(int catID,DataGridView gv, DataGridViewColumn proIDGV, DataGridViewColumn proNameIDGV, DataGridViewColumn bpGV
            , DataGridViewColumn spGV,DataGridViewColumn disGV, DataGridViewColumn profitperV)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("st_getProductsWRTCategory", MainClass.con);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@catID ", catID);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                proIDGV.DataPropertyName = dt.Columns["Product ID"].ToString();
                proNameIDGV.DataPropertyName = dt.Columns["Product"].ToString();
                bpGV.DataPropertyName = dt.Columns["Buying Price"].ToString();
                spGV.DataPropertyName = dt.Columns["Selling Price"].ToString();
                disGV.DataPropertyName = dt.Columns["Discount"].ToString();
                profitperV.DataPropertyName = dt.Columns["profit percentage"].ToString();

                gv.DataSource = dt;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }


    }

