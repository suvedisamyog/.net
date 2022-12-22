using System;
using MySql.Data.MySqlClient;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace database
{
    public partial class Display : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           

        }

        protected void Update_Click(object sender, EventArgs e)
        {    
           String MyConnection = "server=localhost;Uid=root;Pwd=;database=dotnet";
            MySqlConnection MyConn = new MySqlConnection(MyConnection);
            MyConn.Open();
            string Query = "UPDATE `products` SET `UnitPrice`='10000' WHERE ProductId=11";
            MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn);
            MyCommand2.ExecuteReader();
            MyConn.Close();

        }
    }
}