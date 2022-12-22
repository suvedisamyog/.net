using System;
namespace bookformproject{
    public partial class display : System.Web.UI.Page{
        protected void Page_Load(object sender, EventArgs e){
            Label1.Text = Session["name"].ToString();
            Label2.Text = Session["isbn"].ToString();
            Label3.Text = Session["writer"].ToString();
            Label4.Text = Session["publication"].ToString();

        }
    }
}