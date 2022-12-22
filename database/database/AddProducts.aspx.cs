using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using Org.BouncyCastle.Utilities.Collections;

namespace database
{
    public partial class AddProducts : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submit_Click(object sender, EventArgs e)
        {   
            String Name = PName.Text;
            String ID = PID.Text;
            String Price = PPrice.Text;
            String MyConnection = "server=localhost;Uid=root;Pwd=;database=dotnet";
            MySqlConnection MyConn = new MySqlConnection(MyConnection);
            MyConn.Open();
            string Query = $"insert into Products(ProductId,ProductName,UnitPrice) values('{ID}','{Name}','{Price}')";
            MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn);
            MyCommand2.ExecuteReader(); 
            MyConn.Close();

        }
    }
}